using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.DAL
{
    class DAL_Phim
    {
        private QLRP1Entities db = new QLRP1Entities();

        // Design Pattern
        #region Design Pattern
        private static DAL_Phim _Instance;
        public static DAL_Phim Instance
        {
            get
            {
                if (_Instance == null) _Instance = new DAL_Phim();
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
        private DAL_Phim()
        {

        }
        #endregion

        // Function
        #region Function
        public List<Phim> getAllPhim()
        {
            return db.Phim.Select(phim => phim).ToList();
        }
        public Phim getPhimByIdPhim(string idPhim)
        {
            var data = db.Phim.Find(idPhim);
            return data;
        }
        public Phim getPhimByTenPhim(string tenPhim)
        {
            Phim phim = null;
            var data = db.Phim.Where(p => p.TenPhim == tenPhim);
            if (data.Count() > 0) phim = data.FirstOrDefault();
            return phim;
        }
        #endregion
        // check
        #region check

        public bool themPhim(Phim s, string idDinhDangPhim, string LoaiManHinh)
        {
            db.Phim.Add(s);

            DinhDangPhim ddp = new DinhDangPhim
            {
                id = idDinhDangPhim.Trim(),
                idPhim = s.id.Trim(),
                idLoaiManHinh = DAL.DAL_LoaiManHinh.Instance.getIdLMH(LoaiManHinh)
             };
            db.DinhDangPhim.Add(ddp);
            return db.SaveChanges() > 0;
        }
        public bool suaphim(Phim p)
        {
            foreach (Phim i in db.Phim)
            {
                if (i.id.Trim().CompareTo(p.id.Trim()) == 0)
                {
                    i.id = p.id.Trim();
                    i.TenPhim = p.TenPhim;
                    i.MoTa = p.MoTa;
                    i.idTheLoai = p.idTheLoai;
                    i.DaoDien = p.DaoDien;
                    i.SanXuat = p.SanXuat;
                    i.NamSX = p.NamSX;
                    i.ThoiLuong = p.ThoiLuong;
                    i.DinhDangPhim = p.DinhDangPhim;
                    i.NgayKhoiChieu = p.NgayKhoiChieu;
                    i.NgayKetThuc = p.NgayKetThuc;
                }
            }
            return db.SaveChanges() > 0;

        }
        public bool xoaphim(List<string> maphims)
        {
            foreach (Phim i in db.Phim)
            {
                foreach (string x in maphims)
                {
                    if (i.id.Trim().CompareTo(x.Trim()) == 0)
                    {
                        db.Phim.Remove(i);
                        continue;
                    }
                }
            }
            foreach (DinhDangPhim ddp in db.DinhDangPhim)
            {
                foreach (string mp in maphims)
                {
                    if (ddp.idPhim.Trim().CompareTo(mp) == 0)
                    {
                        db.DinhDangPhim.Remove(ddp);
                        continue;
                    }
                }
            }
            return db.SaveChanges() > 0;
        }
        #endregion 
    }

}
