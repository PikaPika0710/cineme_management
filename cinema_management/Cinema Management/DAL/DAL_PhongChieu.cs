﻿using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.DAL
{
    class DAL_PhongChieu
    {
        private QLRP1Entities db = new QLRP1Entities();

        // Design Pattern
        #region Design Pattern
        private static DAL_PhongChieu _Instance;
        public static DAL_PhongChieu Instance
        {
            get
            {
                if (_Instance == null) _Instance = new DAL_PhongChieu();
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
        private DAL_PhongChieu()
        {

        }
        #endregion

        // Function
        #region Function
        public List<PhongChieu> getAllPhongChieu()
        {
            return db.PhongChieu.Select(pc => pc).ToList();
        }
        public List<PhongChieu> GetPhongChieusByIdMH(string IdMH)
        {
            var data = db.PhongChieu.Where(pc => pc.idManHinh == IdMH);
            return data.ToList();
        }
        public PhongChieu GetPhongChieuByMaPhong(string maPhong)
        {
            return db.PhongChieu.Find(maPhong);
        }
        public bool addPhongChieu(string maPhong, string tenPhong, string idMH, int soChoNgoi, int tinhTrang, int soHangGhe, int soGheMoiHang)
        {
            db.PhongChieu.Add(new PhongChieu
            {
                id = maPhong,
                TenPhong = tenPhong,
                idManHinh = idMH,
                SoChoNgoi = soChoNgoi,
                TinhTrang = tinhTrang,
                SoHangGhe = soHangGhe,
                SoGheMotHang = soGheMoiHang
            });
            return db.SaveChanges() > 0;
        }
        public bool updatePhongChieu(string maPhong, string tenPhong, string idMH, int soChoNgoi, int tinhTrang, int soHangGhe, int soGheMoiHang)
        {
            var s = db.PhongChieu.Find(maPhong);
            s.TenPhong = tenPhong;
            s.idManHinh = idMH;
            s.SoChoNgoi = soChoNgoi;
            s.TinhTrang = tinhTrang;
            s.SoHangGhe = soHangGhe;
            s.SoGheMotHang = soGheMoiHang;
            return db.SaveChanges() > 0;
        }
        public bool deletePhongChieuByMaPhong(string maPhong)
        {
            foreach (PhongChieu pc in getAllPhongChieu())
            {
                if (pc.id == maPhong)
                {
                    db.PhongChieu.Remove(pc);
                    break;
                }
            }
            return db.SaveChanges() > 0;
        }
        #endregion
    }
}
