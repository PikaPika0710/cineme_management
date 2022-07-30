using PBL3_GiaBao.BLL;
using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_GiaBao.View
{
    public partial class fLichChieu : Form
    {
        BindingSource showtimeList = new BindingSource();
        public fLichChieu()
        {
            InitializeComponent();
            LoadShowTime();
        }

        // Load dữ liệu
        #region Load
        void LoadShowTime()
        {
            dtgvShowTime.DataSource = showtimeList;
            LoadShowtimeList();
            LoadFormatMovieIntoComboBox();
            AddShowtimeBinding();

        } // Đỗ dữ liệu từ BindingSource showtimeList vào datagridview
        void LoadShowtimeList() // Load dữ liệu vào BindingSource showtimeList với các cột MaLichChieu, MaPhong, TenPhim, ManHinh, ThoiGianChieu
        {
            var data = from LichChieu in BLL_LichChieu.Instance.getAllLichChieuByBLL()
                       from Phim in BLL_Phim.Instance.getAllPhimByBLL()
                       from DinhDangPhim in BLL_DinhDangPhim.Instance.GetAllDinhDangPhimBLL()
                       from LoaiManHinh in BLL_LoaiManHinh.Instance.getAllLoaiManHinhByBLL()
                       where LichChieu.idDinhDang == DinhDangPhim.id
                       && DinhDangPhim.idPhim == Phim.id
                       && DinhDangPhim.idLoaiManHinh == LoaiManHinh.id
                       select new
                       {
                           MaLichChieu = LichChieu.id,
                           MaPhong = LichChieu.idPhong,
                           TenPhim = Phim.TenPhim,
                           ManHinh = LoaiManHinh.TenMH,
                           ThoiGianChieu = LichChieu.ThoiGianChieu
                       };
            showtimeList.DataSource = data.ToList();
        }
        void AddShowtimeBinding()
        {
            txtShowtimeID.DataBindings.Add("Text", dtgvShowTime.DataSource, "MaLichChieu", true, DataSourceUpdateMode.Never);
            dtmShowtimeDate.DataBindings.Add("Value", dtgvShowTime.DataSource, "ThoiGianChieu", true, DataSourceUpdateMode.Never);
            dtmShowtimeTime.DataBindings.Add("Value", dtgvShowTime.DataSource, "ThoiGianChieu", true, DataSourceUpdateMode.Never);
        } // Lấy dữ liệu từ BindingSource showtimeList, thêm vào textfied MaLichChieu, GroupBox ThoiGianChieu (Ngay, gio)
        void LoadFormatMovieIntoComboBox()
        {
            var data = BLL_DinhDangPhim.Instance.GetAllDinhDangPhimBLL();
            cboFormatID_Showtime.DataSource = data.ToList();
            cboFormatID_Showtime.DisplayMember = "ID"; // thuộc tính đươc combobox MaDinhDang hiển thị là DinhDangPhim.id 
        } // Load dữ liệu vào combobox MaDinhDang
        #endregion

        // Thêm , sửa , xóa, tìm kiếm, thoát
        #region Add, Update, Delete, Search, Exit
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maLichChieu = txtShowtimeID.Text;
            string maPhong = ((PhongChieu)cboCinemaID_Showtime.SelectedItem).id;
            string maDinhDang = ((DinhDangPhim)cboFormatID_Showtime.SelectedItem).id;
            DateTime time = new DateTime(dtmShowtimeDate.Value.Year, dtmShowtimeDate.Value.Month, dtmShowtimeDate.Value.Day, dtmShowtimeTime.Value.Hour, dtmShowtimeTime.Value.Minute, dtmShowtimeTime.Value.Second);
            //Bind dtmShowtimeDate to "time.date" and dtmShowtimeTime to "time.time" ... TODO : Look for a better way to do this
            //float ticketPrice = float.Parse(txtTicketPrice_Showtime.Text);
            if (BLL_LichChieu.Instance.addLichChieu(maLichChieu, maPhong, maDinhDang, time))
            {
                MessageBox.Show("Thêm lịch chiếu thành công");
            }
            else
            {
                MessageBox.Show("Thêm lịch chiếu thất bại");
            }
            LoadShowtimeList();
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string maLichChieu = txtShowtimeID.Text;
            string maPhong = ((PhongChieu)cboCinemaID_Showtime.SelectedItem).id;
            string maDinhDang = ((DinhDangPhim)cboFormatID_Showtime.SelectedItem).id;
            DateTime time = new DateTime(dtmShowtimeDate.Value.Year, dtmShowtimeDate.Value.Month, dtmShowtimeDate.Value.Day, dtmShowtimeTime.Value.Hour, dtmShowtimeTime.Value.Minute, dtmShowtimeTime.Value.Second);
            //Bind dtmShowtimeDate to "time.date" and dtmShowtimeTime to "time.time" ... TODO : Look for a better way to do this
            //float ticketPrice = float.Parse(txtTicketPrice_Showtime.Text);
            if (BLL_LichChieu.Instance.updateLichChieu(maLichChieu, maPhong, maDinhDang, time))
            {
                MessageBox.Show("Sửa lịch chiếu thành công");
            }
            else
            {
                MessageBox.Show("Sửa lịch chiếu thất bại");
            }
            LoadShowtimeList();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string maLichChieu = txtShowtimeID.Text;
            if (BLL_LichChieu.Instance.deleteLichChieu(maLichChieu))
            {
                MessageBox.Show("Xóa lịch chiếu thành công");
            }
            else
            {
                MessageBox.Show("Xóa lịch chiếu thất bại");
            }
            LoadShowtimeList();
        }
        private void btnSearchShowtime_Click(object sender, EventArgs e)
        {
            string tenPhim = txtSearchShowtime.Text;
            var data = from LichChieu in BLL_LichChieu.Instance.getAllLichChieuByBLL()
                       from Phim in BLL_Phim.Instance.getAllPhimByBLL()
                       from DinhDangPhim in BLL_DinhDangPhim.Instance.GetAllDinhDangPhimBLL()
                       from LoaiManHinh in BLL_LoaiManHinh.Instance.getAllLoaiManHinhByBLL()
                       where LichChieu.idDinhDang == DinhDangPhim.id
                       && DinhDangPhim.idPhim == Phim.id
                       && DinhDangPhim.idLoaiManHinh == LoaiManHinh.id
                       && convertToUnSign3(Phim.TenPhim).Contains(convertToUnSign3(tenPhim))
                       select new
                       {
                           MaLichChieu = LichChieu.id,
                           MaPhong = LichChieu.idPhong,
                           TenPhim = Phim.TenPhim,
                           ManHinh = LoaiManHinh.TenMH,
                           ThoiGianChieu = LichChieu.ThoiGianChieu
                       };
            showtimeList.DataSource = data.ToList();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        // Function
        #region Function
        public static string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        } // Hàm chuyển đổi chuỗi có dấu sang không dấu
        #endregion

        // Event
        #region Event
        private void cboFormatID_Showtime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFormatID_Showtime.SelectedIndex != -1)
            {
                DinhDangPhim formatMovieSelecting = (DinhDangPhim)cboFormatID_Showtime.SelectedItem;
                txtMovieName_Showtime.Text = BLL_Phim.Instance.getPhimByIdPhim(formatMovieSelecting.idPhim).TenPhim;
                txtScreenTypeName_Showtime.Text = BLL_LoaiManHinh.Instance.GetLoaiManHinhByIdMH(formatMovieSelecting.idLoaiManHinh).TenMH;
                cboCinemaID_Showtime.DataSource = null;
                LoaiManHinh screenType = BLL_LoaiManHinh.Instance.GetLoaiManHinhByIdMH(formatMovieSelecting.idLoaiManHinh);
                cboCinemaID_Showtime.DataSource = BLL_PhongChieu.Instance.GetPhongChieusByIdMH(screenType.id);
                cboCinemaID_Showtime.DisplayMember = "TenPhong"; // Thuộc tính combobox Phong Chieu hien thi la PhongChieu.TenPhong
            }
        } // Mỗi lần Mã định dạng thay đổi, load dữ liệu các textfield tương ứng
        private void txtShowtimeID_TextChanged(object sender, EventArgs e)
        {
            #region Change selected index of ComboBox FormatMovie
            // Thay đôi thuộc tính hiển thị trên combobox MaDinhDang tương ứng với record đang được chọn thông qua 2 thuộc tính TenPhim, TenMH
            string movieName = (string)dtgvShowTime.SelectedCells[0].OwningRow.Cells["TenPhim"].Value;
            string screenTypeName = (string)dtgvShowTime.SelectedCells[0].OwningRow.Cells["ManHinh"].Value;
            string idPhim = BLL_Phim.Instance.getPhimByTenPhim(movieName).id;
            string idMH = BLL_LoaiManHinh.Instance.GetLoaiManHinhByTenMH(screenTypeName).id;
            DinhDangPhim formatMovieSelecting = BLL_DinhDangPhim.Instance.GetDinhDangPhimById(idPhim, idMH);
            if (formatMovieSelecting == null)
                return;
            int indexFormatMovie = -1;
            for (int i = 0; i < cboFormatID_Showtime.Items.Count; i++)
            {
                DinhDangPhim item = cboFormatID_Showtime.Items[i] as DinhDangPhim;
                if (item.id == formatMovieSelecting.id)
                {
                    indexFormatMovie = i;
                    break;
                }
            }
            cboFormatID_Showtime.SelectedIndex = indexFormatMovie;
            #endregion  
            #region Change selected index of ComboBox Cinema
            // Thay đôi thuộc tính hiển thị trên combobox PhongChieu tương ứng với record đang được chọn thông qua thuộc tính MaPhong
            string maPhong = (string)dtgvShowTime.SelectedCells[0].OwningRow.Cells["MaPhong"].Value;
            PhongChieu cinemaSelecting = BLL_PhongChieu.Instance.GetPhongChieuByMaPhong(maPhong);
            //This is the Cinema that we're currently selecting in dtgv

            if (cinemaSelecting == null)
                return;

            int indexCinema = -1;
            int iCinema = 0;
            foreach (PhongChieu item in cboCinemaID_Showtime.Items)
            {
                if (item.id == cinemaSelecting.id)
                {
                    indexCinema = iCinema;
                    break;
                }
                iCinema++;
            }
            cboCinemaID_Showtime.SelectedIndex = indexCinema;
            #endregion   
            //toolTipCinema.SetToolTip(cboCinemaID_Showtime, "Danh sách phòng chiếu hỗ trợ loại màn hình trên");
        } // Mỗi lần chọn một record trên datagridview => Ma Lich Chieu thay đổi => load dữ liệu vào các textfied tương ứng với Ma lich chieu do
        private void txtSearchShowtime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchShowtime.PerformClick();
                e.SuppressKeyPress = true;//Tắt tiếng *ting của windows
            }
        } // Khi nhập tên phim cần tìm, có thể bấm Enter thay cho nút tìm kiếm
        #endregion
    }
}
