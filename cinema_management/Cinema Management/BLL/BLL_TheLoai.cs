﻿using PBL3_GiaBao.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.BLL
{
    class BLL_TheLoai
    {
        private QLRP1Entities db = new QLRP1Entities();

        // Design Pattern
        #region Design Pattern
        private static BLL_TheLoai _Instance;
        public static BLL_TheLoai Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_TheLoai();
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
        private BLL_TheLoai()
        {

        }
        #endregion

        // Function
        #region Function
        public List<TheLoai> getAllTheLoaiByBLL()
        {
            return DAL.DAL_TheLoai.Instance.getAllTheLoai();
        }
        #endregion
        //Check
        #region check
        public bool isExistTheLoai(TheLoai tl)
        {
            return getAllTheLoaiByBLL().Exists(s => s.id.CompareTo(tl.id) == 0);
        }
        public bool themTheLoai(TheLoai tl)
        {
            return DAL.DAL_TheLoai.Instance.themTheLoai(tl);
        }
        public bool xoaTheLoai(List<string> maTheLoais)
        {
            return DAL.DAL_TheLoai.Instance.xoaTheLoai(maTheLoais);
        }
        #endregion
    }
}
