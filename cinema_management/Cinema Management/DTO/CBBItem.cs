using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.DTO
{
    class CBBItem
    {
        public object value { get; set; }
        public string text { get; set; }
        public override string ToString()
        {
            return text;
        }
    }
}
