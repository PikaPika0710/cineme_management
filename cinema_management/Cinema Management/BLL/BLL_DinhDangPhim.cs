using PBL3_GiaBao.DAL;
using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.BLL
{
    class BLL_DinhDangPhim
    {
        // Design Pattern
        #region Design Pattern
        private static BLL_DinhDangPhim _Instance = null;
        public static BLL_DinhDangPhim Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_DinhDangPhim();
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
        private BLL_DinhDangPhim()
        {

        }
        #endregion

        // Lấy dữ liệu
        #region Get Data
        public List<DinhDangPhim> GetAllDinhDangPhimBLL()
        {
            return DAL_DinhDangPhim.Instance.getAllDinhDangPhim();
        }
        public DinhDangPhim GetDinhDangPhimById(string idPhim, string idMH)
        {
            return DAL_DinhDangPhim.Instance.GetDinhDangPhimById(idPhim, idMH);
        }
        public bool xoaDinhDangPhim(List<string> maPhims)
        {
            return DAL.DAL_DinhDangPhim.Instance.xoaDinhDangPhim(maPhims);
        }
      
        
        #endregion
    }
}
