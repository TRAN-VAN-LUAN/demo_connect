using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HinhHoc
{
    public class HinhVuong : TuGiac_DacBiet
    {
        public HinhVuong()
        {
            
        }
        public HinhVuong(ToaDo a, ToaDo b, ToaDo c, ToaDo d)
        {
            base.A = a;
            base.B = b;
            base.C = c;
            base.D = d;
        }
    }
}