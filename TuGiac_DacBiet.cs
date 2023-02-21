using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HinhHoc
{
    public class TuGiac_DacBiet : HinhHoc
    {
        public TuGiac_DacBiet() { }
        public double ChuVi()
        {
            double a = this.Length(this.A, this.B);
            double b = this.Length(this.B, this.C);
            return 2 * (a + b);
        }

        public double DienTich()
        {
            double a = this.Length(this.A, this.B);
            double b = this.Length(this.B, this.C);
            return a * b;
        }
        public double Goc(ToaDo A, ToaDo B)
        {
            double cos = (A.X*B.X+ A.Y*B.Y)/(Math.Sqrt(A.X*A.X + A.Y*A.Y)*
                Math.Sqrt(B.X*B.X+B.Y*B.Y));
            return cos;
        }
        public double Length_AC()
        {
            double length_AC = this.Length(this.A, this.C)/2;
            return length_AC;
        }
        public double S_toanPhan(ToaDo E)
        {
            TamGiac tg = new TamGiac();
            double length_AB = this.Length(this.A, this.B);
            double length_BC = this.Length(this.B, this.C);
            double length_CD = this.Length(this.C, this.D);
            double length_DA = this.Length(this.D, this.A);
            double length_AE = this.Length(this.A, E);
            double length_EB = this.Length(E, this.B);  
            double length_EC = this.Length(E, this.C);
            double length_DE = this.Length(this.D, E);
            double S_ABE = tg.DienTich(length_AB, length_EB, length_AE);
            double S_BEC = tg.DienTich(length_EB, length_EC, length_BC);
            double S_ECD = tg.DienTich(length_EC, length_DE, length_CD);
            double S_AED = tg.DienTich(length_AE, length_DE, length_DA);
            double Total = S_ABE + S_AED + S_BEC +S_ECD;
            return Total;
        }
    }
}