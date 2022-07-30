using PBL3_GiaBao.BLL;
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
    public partial class fPhongChieu : Form
    {
        BindingSource listPhim = new BindingSource();
        public fPhongChieu()
        {
            InitializeComponent();
            LoadCinema();

        }

        //Load dữ liệu
        #region Load 
        private void LoadCinema()
        {
            dtgvCinema.DataSource = listPhim;
            loadListPhim();
            AddCinemaBinding();
        } // Load dữ liệu lên datagridview
        void loadListPhim() // Load dữ liệu vào BindingSource listPhim gồm các cột MaPhong, TenPhong, TenMH, SoChoNgoi, TinhTrang, SoHangGhe, SoGheMotHang
        {
            var data = from PhongChieu in BLL_PhongChieu.Instance.getAllPhongChieuByBLL()
                       join LoaiManHinh in BLL_LoaiManHinh.Instance.getAllLoaiManHinhByBLL()
                       on PhongChieu.idManHinh equals LoaiManHinh.id
                       select new
                       {
                           MaPhong = PhongChieu.id,
                           TenPhong = PhongChieu.TenPhong,
                           TenMH = LoaiManHinh.TenMH,
                           SoChoNgoi = PhongChieu.SoChoNgoi,
                           TinhTrang = PhongChieu.TinhTrang,
                           SoHangGhe = PhongChieu.SoHangGhe,
                           SoGheMotHang = PhongChieu.SoGheMotHang,
                       };
            listPhim.DataSource = data.ToList();
        }
        void LoadScreenTypeIntoComboBox(ComboBox cbo)
        {
            cbo.DataSource = BLL_LoaiManHinh.Instance.getAllLoaiManHinhByBLL();
            cbo.DisplayMember = "TenMH";
            cbo.ValueMember = "id";
        } // Load dữ liệu vào combobox màn hình
        void AddCinemaBinding()
        {
            txtCinemaID.DataBindings.Add("Text", dtgvCinema.DataSource, "MaPhong", true, DataSourceUpdateMode.Never);
            txtCinemaName.DataBindings.Add("Text", dtgvCinema.DataSource, "TenPhong", true, DataSourceUpdateMode.Never);
            txtCinemaSeats.DataBindings.Add("Text", dtgvCinema.DataSource, "SoChoNgoi", true, DataSourceUpdateMode.Never);
            txtCinemaStatus.DataBindings.Add("Text", dtgvCinema.DataSource, "TinhTrang", true, DataSourceUpdateMode.Never);
            txtNumberOfRows.DataBindings.Add("Text", dtgvCinema.DataSource, "SoHangGhe", true, DataSourceUpdateMode.Never);
            txtSeatsPerRow.DataBindings.Add("Text", dtgvCinema.DataSource, "SoGheMotHang", true, DataSourceUpdateMode.Never);
            LoadScreenTypeIntoComboBox(cboCinemaScreenType);
        } // Lấy dữ liệu từ BindingSource listPhim, thêm vào các textfield MaPhong, TenPhong, SoChoNgoi, TinhTrang, SoHangGhe, SoGheMotHang
        #endregion

        // Thêm, sửa , xóa, thoát
        #region Add, Update, Delete, Exit 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maPhong = txtCinemaID.Text;
            string tenPhong = txtCinemaName.Text;
            string idMH = cboCinemaScreenType.SelectedValue.ToString();
            int soChoNgoi = int.Parse(txtCinemaSeats.Text);
            int tinhTrang = int.Parse(txtCinemaStatus.Text);
            int soHangGhe = int.Parse(txtNumberOfRows.Text);
            int soGheMoiHang = int.Parse(txtSeatsPerRow.Text);
            if (BLL_PhongChieu.Instance.addPhongChieu(maPhong, tenPhong, idMH, soChoNgoi, tinhTrang, soHangGhe, soGheMoiHang))
            {
                MessageBox.Show("Thêm phòng chiếu thành công");
            }
            else
            {
                MessageBox.Show("Thêm phòng chiếu thất bại");
            }
            loadListPhim();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string maPhong = txtCinemaID.Text;
            string tenPhong = txtCinemaName.Text;
            string idMH = cboCinemaScreenType.SelectedValue.ToString();
            int soChoNgoi = int.Parse(txtCinemaSeats.Text);
            int tinhTrang = int.Parse(txtCinemaStatus.Text);
            int soHangGhe = int.Parse(txtNumberOfRows.Text);
            int soGheMoiHang = int.Parse(txtSeatsPerRow.Text);
            if (BLL_PhongChieu.Instance.updatePhongChieu(maPhong, tenPhong, idMH, soChoNgoi, tinhTrang, soHangGhe, soGheMoiHang))
            {
                MessageBox.Show("Sửa phòng chiếu thành công");
            }
            else
            {
                MessageBox.Show("Sửa phòng chiếu thất bại");
            }
            loadListPhim();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maPhong = txtCinemaID.Text;
            if (BLL_PhongChieu.Instance.deletePhongChieuByMaPhong(maPhong))
            {
                MessageBox.Show("Xóa phòng chiếu thành công");
            }
            else
            {
                MessageBox.Show("Xóa phòng chiếu thất bại");
            }
            loadListPhim();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        // Event
        #region Event
        private void txtCinemaID_TextChanged(object sender, EventArgs e) // Mỗi khi Mã Phòng thay đổi, load dữ liệu vào các textfied tương ứng với Mã phòng đó
        {
            string screenName = (string)dtgvCinema.SelectedCells[0].OwningRow.Cells["TenMH"].Value;
            LoaiManHinh lmh = BLL_LoaiManHinh.Instance.GetLoaiManHinhByTenMH(screenName);
            //This is the ScreenType that we're currently selecting in dtgv

            cboCinemaScreenType.SelectedItem = lmh;

            int index = -1;
            int i = 0;
            foreach (LoaiManHinh item in cboCinemaScreenType.Items)
            {
                if (item.TenMH.Equals(lmh.TenMH))
                {
                    index = i;
                    break;
                }
                i++;
            }
            cboCinemaScreenType.SelectedIndex = index;
        }
        #endregion
    }
}
