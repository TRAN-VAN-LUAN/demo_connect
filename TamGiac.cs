using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HinhHoc
{
    public class TamGiac : HinhHoc
    {
        public TamGiac() { }    
        public TamGiac(ToaDo a, ToaDo b, ToaDo c)
        {
            base.A= a;
            base.B = b;
            base.C = c;
        }
        public double ChuVi()
        {
            double a = this.Length(this.A, this.B);
            double b = this.Length(this.B, this.C);
            double c = this.Length(this.C, this.A);
            return a + b + c;
        }
        public double DienTich(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public double DienTich()
        {
            double a = this.Length(this.A, this.B);
            double b = this.Length(this.B, this.C);
            double c = this.Length(this.C, this.A);
            double p = (a + b + c) / 2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
    }
}