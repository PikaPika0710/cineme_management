using PBL3_GiaBao.DTO;
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
    public partial class fQuanlyphim : Form
    {
        static string extension = ".jpg";
        public fQuanlyphim()
        {
            InitializeComponent();
            loadData();
            setCBB();
            SaveBtn.Hide();
        }
        //Funtion
        #region Function
        private void loadData()
        {
            var innerJoinQuery = from Phim in BLL.BLL_Phim.Instance.getAllPhimByBLL()
                                 from TheLoai in BLL.BLL_TheLoai.Instance.getAllTheLoaiByBLL()
                                 from DinhDangPhim in BLL.BLL_DinhDangPhim.Instance.GetAllDinhDangPhimBLL()
                                 from LoaiManHinh in BLL.BLL_LoaiManHinh.Instance.getAllLoaiManHinhByBLL()
                                 where Phim.idTheLoai == TheLoai.id &&
                                 DinhDangPhim.idPhim == Phim.id &&
                                 DinhDangPhim.idLoaiManHinh == LoaiManHinh.id
                                 select new
                                 {
                                     id = Phim.id,
                                     TenPhim = Phim.TenPhim,
                                     MoTa = Phim.MoTa,
                                     ThoiLuong = Phim.ThoiLuong,
                                     NgayKhoiChieu = Phim.NgayKhoiChieu,
                                     NgayKetThuc = Phim.NgayKetThuc,
                                     SanXuat = Phim.SanXuat,
                                     DaoDien = Phim.DaoDien,
                                     NamSX = Phim.NamSX,
                                     TheLoai = TheLoai.TenTheLoai,
                                     LoaiManHinh = LoaiManHinh.TenMH,
                                     ApPhich = Phim.ApPhich,
                                     DinhDangPhim = DinhDangPhim.id
                                 };
            ListPhimDataGridView.DataSource = innerJoinQuery.ToList();
            ListPhimDataGridView.Columns["ApPhich"].Visible = false;
        }
        private void setCBB()
        {
            cbbTheLoai.Items.Clear();
            foreach (TheLoai i in BLL.BLL_TheLoai.Instance.getAllTheLoaiByBLL())
            {
                cbbTheLoai.Items.Add(new CBBItem
                {
                    value = i.id.Trim(),
                    text = i.TenTheLoai.Trim()
                });
            }
        }
        private void setImage()
        {
            phimImageBox.Visible = true;
            phimImageBox.Image = Image.FromFile("Image Source\\" + txtMaPhim.Text + extension);
            phimImageBox.SizeMode = PictureBoxSizeMode.AutoSize;
        }
        private void disableTools()
        {
            txtMaPhim.ReadOnly = true;
            txtTenPhim.ReadOnly = true;
            txtDaoDien.ReadOnly = true;
            txtMoTa.ReadOnly = true;
            txtQuocGia.ReadOnly = true;
            txtNSX.ReadOnly = true;
            txtThoiLuong.ReadOnly = true;
            txtDinhDang.ReadOnly = true;
            txtManHinh.ReadOnly = true;
            cbbTheLoai.Enabled = false;
            pickImageBtn.Enabled = false;
            endDatePicker.Enabled = false;
            startDatePicker.Enabled = false;
        }
        private void enableTools()
        {
            txtTenPhim.ReadOnly = false; //khong duoc sua ten phim dan den khong load anh duoc
            txtDaoDien.ReadOnly = false;
            txtMoTa.ReadOnly = false;
            txtQuocGia.ReadOnly = false;
            txtNSX.ReadOnly = false;
            txtThoiLuong.ReadOnly = false;
            txtDinhDang.ReadOnly = false;
            txtManHinh.ReadOnly = false;
            cbbTheLoai.Enabled = true;
            pickImageBtn.Enabled = true;
            endDatePicker.Enabled = true;
            startDatePicker.Enabled = true;
           // endDatePicker.Value = DateTime.Now;
           // startDatePicker.Value = DateTime.Now;
        }
        private bool enoughInfo()
        {
            if (
            txtMaPhim.Text == "" || txtMaPhim.Text == "" || txtTenPhim.Text == "" ||
            cbbTheLoai.SelectedIndex == -1 || txtDaoDien.Text == "" ||
            txtQuocGia.Text == "" || txtNSX.Text == "" || txtThoiLuong.Text == "" || txtDinhDang.Text == "" || txtManHinh.Text == ""
            || endDatePicker.Value == DateTime.Now || startDatePicker.Value == DateTime.Now
            )
            {
                return false;
            }
            else return true;
        }
        private Phim getPhimfromDataView()
        {
            return new Phim
            {
                id = txtMaPhim.Text.Trim(),
                TenPhim = txtTenPhim.Text.Trim(),
                MoTa = txtMoTa.Text.Trim(),
                ThoiLuong = Convert.ToInt32(txtThoiLuong.Text.Trim()),
                NgayKhoiChieu = Convert.ToDateTime(startDatePicker.Value.ToString()),
                NgayKetThuc = Convert.ToDateTime(endDatePicker.Value.ToString()),
                SanXuat = txtQuocGia.Text.Trim(),
                DaoDien = txtDaoDien.Text.Trim(),
                NamSX = Convert.ToInt32(txtNSX.Text.Trim()),
                // ap phich
                idTheLoai = Convert.ToString(((CBBItem)cbbTheLoai.SelectedItem).value).Trim()
            };
        }
        #endregion

        //BUTTON
        #region BUTTON ACTIVATE 
        private void btClear_Click(object sender, EventArgs e)
        {
            enableTools();
            txtMaPhim.ReadOnly = false;
            endDatePicker.Value = DateTime.Now;
            startDatePicker.Value = DateTime.Now;
            txtMaPhim.Text = txtMaPhim.Text = txtTenPhim.Text = txtDaoDien.Text = txtMoTa.Text =
            txtQuocGia.Text = txtNSX.Text = txtThoiLuong.Text = txtDinhDang.Text = txtManHinh.Text = "";
            cbbTheLoai.SelectedIndex = -1;
            phimImageBox.Visible = false;
        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion
        private void btQLLoaiPhim_Click(object sender, EventArgs e)
        {
            fTheloai f = new fTheloai();
            f.d += new fTheloai.load_del(setCBB);
            f.ShowDialog();
        }

        private void pickImageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string filePathIamge = null;
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
                openFile.FilterIndex = 1;
                openFile.RestoreDirectory = true;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    filePathIamge = openFile.FileName;
                    phimImageBox.Visible = true;
                    phimImageBox.Image = Image.FromFile(filePathIamge.ToString());
                    phimImageBox.SizeMode = PictureBoxSizeMode.AutoSize;
                    phimImageBox.Visible = true;
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        

        private void addPhim_Click(object sender, EventArgs e)
        {
            SaveBtn.Hide();
            if (!enoughInfo())
            {
                MessageBox.Show("Vui long dien day du thong tin!");
            }
            else
            {
                try
                {
                    Phim p = getPhimfromDataView();
                    if (BLL.BLL_Phim.Instance.isExistPhim(p))
                    {
                        MessageBox.Show("Trung ma phim, hay thay doi!");
                    }
                    else
                    {
                        if (BLL.BLL_Phim.Instance.themPhim(p, txtDinhDang.Text.Trim(), txtManHinh.Text.Trim()))
                        {
                            //BLL.BLL_DinhDangPhim.Instance.themDinhDangPhim(p, txtManHinh.Text);
                            MessageBox.Show("Them thanh cong!");
                            loadData();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Them that bai!");
                }
            }
        }

        private void ListPhimDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SaveBtn.Hide();
            txtMaPhim.Text = ListPhimDataGridView.Rows[e.RowIndex].Cells["id"].Value.ToString().Trim();
            txtTenPhim.Text = ListPhimDataGridView.Rows[e.RowIndex].Cells["TenPhim"].Value.ToString().Trim();
            txtDaoDien.Text = ListPhimDataGridView.Rows[e.RowIndex].Cells["DaoDien"].Value.ToString().Trim();
            txtMoTa.Text = ListPhimDataGridView.Rows[e.RowIndex].Cells["MoTa"].Value.ToString().Trim();
            txtQuocGia.Text = ListPhimDataGridView.Rows[e.RowIndex].Cells["SanXuat"].Value.ToString().Trim();
            txtNSX.Text = ListPhimDataGridView.Rows[e.RowIndex].Cells["NamSX"].Value.ToString().Trim();
            txtThoiLuong.Text = ListPhimDataGridView.Rows[e.RowIndex].Cells["ThoiLuong"].Value.ToString().Trim();
            txtDinhDang.Text = ListPhimDataGridView.Rows[e.RowIndex].Cells["DinhDangPhim"].Value.ToString().Trim();
            txtManHinh.Text = ListPhimDataGridView.Rows[e.RowIndex].Cells["LoaiManHinh"].Value.ToString().Trim();
            startDatePicker.Value = Convert.ToDateTime(ListPhimDataGridView.Rows[e.RowIndex].Cells["NgayKhoiChieu"].Value.ToString().Trim());
            endDatePicker.Value = Convert.ToDateTime(ListPhimDataGridView.Rows[e.RowIndex].Cells["NgayKetThuc"].Value.ToString().Trim());
            foreach (Object j in cbbTheLoai.Items)
            {
                if (((CBBItem)j).text.CompareTo(ListPhimDataGridView.Rows[e.RowIndex].Cells["TheLoai"].Value.ToString().Trim()) == 0)
                {
                    cbbTheLoai.SelectedIndex = cbbTheLoai.Items.IndexOf(j);
                }
            }
            setImage();
            disableTools();
        }
        
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (!enoughInfo())
            {
                MessageBox.Show("Vui long dien day du thong tin!");
            }
            else
            {
                try
                {
                    Phim p = getPhimfromDataView();
                    

                    if (BLL.BLL_Phim.Instance.suaphim(p))
                    {
                        MessageBox.Show("Sua thanh cong!");
                        loadData();
                        SaveBtn.Hide();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Sua that bai!");
                }
            }
        }

        private void EditPhim_Click(object sender, EventArgs e)
        {
            SaveBtn.Show();
            enableTools();
        }

        private void deletePhim_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = ListPhimDataGridView.SelectedRows;
            if (rows.Count < 1)
            {
                MessageBox.Show("Vui long chon hon 1 row de xoa!");
            }
            List<string> maPhims = new List<string>();
            for (int i = 0; i < rows.Count; i++)
            {
                string s = rows[i].Cells["id"].Value.ToString().Trim();
                maPhims.Add(s);
            }
            
            if (!(!BLL.BLL_Phim.Instance.xoaphim(maPhims)))
            {
                MessageBox.Show("Xoa thanh cong!");
                loadData();
            }
            else
            {
                MessageBox.Show("Xoa that bai!");
            }
        }
    }
}
