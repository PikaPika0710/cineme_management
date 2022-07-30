using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.DAL
{
    class DAL_DinhDangPhim
    {
        private static QLRP1Entities db = new QLRP1Entities();

        // Design Pattern
        #region Design Pattern
        private static DAL_DinhDangPhim _Instance;
        public static DAL_DinhDangPhim Instance
        {
            get
            {
                if (_Instance == null) _Instance = new DAL_DinhDangPhim();
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
        private DAL_DinhDangPhim()
        {

        }
        #endregion

        // Function
        #region Function
        public List<DinhDangPhim> getAllDinhDangPhim()
        {
            return db.DinhDangPhim.Select(ddp => ddp).ToList();
        }
        public DinhDangPhim GetDinhDangPhimById(string idPhim, string idMH)
        {
            DinhDangPhim dinhDangPhim = null;
            var data = db.DinhDangPhim.Where(ddp => ddp.idPhim == idPhim && ddp.idLoaiManHinh == idMH);
            if (data.Count() > 0) dinhDangPhim = data.FirstOrDefault();
            return dinhDangPhim;
        }
        #endregion
        //check
        #region check
        public bool xoaDinhDangPhim(List<string> maPhims)
        {
            foreach(DinhDangPhim ddp in db.DinhDangPhim)
            {
                foreach(string mp in maPhims)
                {
                    if(ddp.idPhim.Trim().CompareTo(mp) == 0)
                    {
                        db.DinhDangPhim.Remove(ddp);
                        continue;
                    }
                }
            }
            return db.SaveChanges()>0;
        }
      
        #endregion
    }
}
