using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HinhHoc
{
    public class DuongThang : HinhHoc
    {
        public DuongThang()
        {
        }
        public DuongThang(ToaDo a, ToaDo b)
        {
            base.A = a;
            base.B = b;
        }
    }
}