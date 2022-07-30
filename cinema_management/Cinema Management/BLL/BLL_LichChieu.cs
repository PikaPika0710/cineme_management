using PBL3_GiaBao.DAL;
using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.BLL
{
    class BLL_LichChieu
    {
        // Design Pattern
        #region Design Pattern
        private static BLL_LichChieu _Instance = null;
        public static BLL_LichChieu Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_LichChieu();
                return _Instance;
            }
            private set
            {
                _Instance = value;
            }
        }
        #endregion

        // Constructor
        #region Constructor
        private BLL_LichChieu()
        {

        }
        #endregion

        // Lấy dữ liệu
        #region Get Data
        public List<LichChieu> getAllLichChieuByBLL()
        {
            return DAL_LichChieu.Instance.getAllLichChieu();
        }
        #endregion

        // Thêm, sửa , xóa
        #region Add, Update, Delete
        public bool addLichChieu(string maLichChieu, string maPhong, string maDinhDang, DateTime time)
        {
            return DAL_LichChieu.Instance.addLichChieu(maLichChieu, maPhong, maDinhDang, time);
        }
        public bool updateLichChieu(string maLichChieu, string maPhong, string maDinhDang, DateTime time)
        {
            return DAL_LichChieu.Instance.updateLichChieu(maLichChieu, maPhong, maDinhDang, time);
        }
        public bool deleteLichChieu(string maLichChieu)
        {
            return DAL_LichChieu.Instance.deleteLichChieuByMaLichChieu(maLichChieu);
        }
        #endregion

    }
}
