using PBL3_GiaBao.EF;
using PBL3_GiaBao.BLL;
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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            txtMK.PasswordChar = '*';
        }
        static TaiKhoan TaiKhoanlogin = new TaiKhoan();

        private void checkboxMk_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxMk.Checked == true)
            {
                txtMK.PasswordChar = '\0';
            }
            else
            {
                txtMK.PasswordChar = '*';
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDNhap_Click(object sender, EventArgs e)
        {
            string username = txtTentk.Text.Trim();
            string password = txtMK.Text.Trim();
            int result = Login(username, password);
            if(result==1)
            {
                TaiKhoanlogin = BLL.BLL_TaiKhoan.Instance.GetTaiKhoanByUserPass_BLL(username,password);
                if(TaiKhoanlogin.LoaiTK==1)
                {
                    fQuanly quanly = new fQuanly(TaiKhoanlogin);
                    quanly.Show();
                    quanly.FormClosed += Quanly_FormClosed;
                    this.Hide();
                }  
                else if (TaiKhoanlogin.LoaiTK == 2)
                {
                    fDatGhe banve = new fDatGhe();
                    banve.Show();
                    banve.FormClosed += Banve_FormClosed;
                    this.Hide();
                }   
                else if (TaiKhoanlogin.LoaiTK == 3)
                {
                    fQuanly quanly = new fQuanly(TaiKhoanlogin);
                    quanly.Show();
                    quanly.FormClosed += Quanly_FormClosed;
                    this.Hide();
                }
                else
                {
                    fQuanly quanly = new fQuanly(TaiKhoanlogin);
                    quanly.Show();
                    quanly.FormClosed += Quanly_FormClosed;
                    this.Hide();
                }
            }    
            else
            {
                MessageBox.Show("Dang nhap that bai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTentk.Text = "";
                txtMK.Text = "";
                txtTentk.Focus();
            }
        }

        private void Banve_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Quanly_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private int Login(string username, string password)
        {
            return BLL.BLL_TaiKhoan.Instance.Login(username, password);
            txtTentk.Text = "";
            txtMK.Text = "";
        }
    }
}
