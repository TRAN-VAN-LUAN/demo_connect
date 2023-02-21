using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HinhHoc
{
    public class HinhTron : HinhHoc
    {
        public HinhTron()
        {
        }
        public HinhTron(ToaDo a, int r)
        {
            base.I = a;
            base.R = r;
        }
        public Double DienTich()
        {
            return this.R * this.R *pi;
        }
        public double ChuVi()
        {
            return 2* this.R *pi;
        }
    }
}