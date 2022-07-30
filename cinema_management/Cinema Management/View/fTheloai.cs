using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_GiaBao.View
{
    public partial class fTheloai : Form
    {
        public delegate void load_del();
        public load_del d { get; set; }
        public fTheloai()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            LoaiPhimDataGridView.DataSource = BLL.BLL_TheLoai.Instance.getAllTheLoaiByBLL();
            LoaiPhimDataGridView.Columns["Phim"].Visible = false;
        }
        private void btThem_Click(object sender, EventArgs e)
        {

            if (theLoaitxt.Text.Trim() == "")
            {
                MessageBox.Show("Vui lien dien day du thong tin");
            }

            else
            {
                try
                {
                    TheLoai tl = new TheLoai
                    {
                        id = maLoaiPhimtxt.Text.Trim(),
                        TenTheLoai = theLoaitxt.Text.Trim()
                    };
                    if (!BLL.BLL_TheLoai.Instance.isExistTheLoai(tl))
                    {
                        BLL.BLL_TheLoai.Instance.themTheLoai(tl);
                        MessageBox.Show("Them Thanh Cong");
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Trung ma phim, hay thay doi!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Them that bai!");
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = LoaiPhimDataGridView.SelectedRows;

            if (rows.Count < 1)
            {
                MessageBox.Show("Vui long chon hon 1 loai phim de xoa");
            }
            else
            {
                List<string> maLoaiPhims = new List<string>();
                for (int i = 0; i < rows.Count; i++)
                {
                    string s = rows[i].Cells["id"].Value.ToString().Trim();
                    maLoaiPhims.Add(s);
                }
                try
                {
                    if (BLL.BLL_TheLoai.Instance.xoaTheLoai(maLoaiPhims))
                    {
                        MessageBox.Show("Xoa Thanh Cong!");
                        loadData();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Xoa That Bai!");
                }
            }
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Dispose();
            d();
        }
    }
}
