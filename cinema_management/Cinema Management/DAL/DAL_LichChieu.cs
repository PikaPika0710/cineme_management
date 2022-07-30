using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.DAL
{
    class DAL_LichChieu
    {
        private static QLRP1Entities db = new QLRP1Entities();

        // Design Pattern
        #region Design Pattern
        private static DAL_LichChieu _Instance;
        public static DAL_LichChieu Instance
        {
            get
            {
                if (_Instance == null) _Instance = new DAL_LichChieu();
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
        private DAL_LichChieu()
        {

        }
        #endregion

        // Function
        #region Function
        public List<LichChieu> getAllLichChieu()
        {
            return db.LichChieu.Select(lc => lc).ToList();
        }
        public bool addLichChieu(string maLichChieu, string maPhong, string maDinhDang, DateTime time)
        {
            db.LichChieu.Add(new LichChieu
            {
                id = maLichChieu,
                idPhong = maPhong,
                idDinhDang = maDinhDang,
                ThoiGianChieu = time,
            });
            return db.SaveChanges() > 0;
        }
        public bool updateLichChieu(string maLichChieu, string maPhong, string maDinhDang, DateTime time)
        {
            var s = db.LichChieu.Find(maLichChieu);
            s.idPhong = maPhong;
            s.idDinhDang = maDinhDang;
            s.ThoiGianChieu = time;
            return db.SaveChanges() > 0;
        }
        public bool deleteLichChieuByMaPhong(string maPhong)
        {
            foreach (LichChieu lc in getAllLichChieu())
            {
                if (lc.idPhong == maPhong)
                {
                    db.LichChieu.Remove(lc);
                    break;
                }
            }
            return db.SaveChanges() > 0;
        }
        public bool deleteLichChieuByMaLichChieu(string maLicChieu)
        {
            foreach (LichChieu lc in getAllLichChieu())
            {
                if (lc.idPhong == maLicChieu)
                {
                    db.LichChieu.Remove(lc);
                    break;
                }
            }
            return db.SaveChanges() > 0;
        }
        #endregion
    }
}
