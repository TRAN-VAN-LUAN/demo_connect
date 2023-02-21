using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace HinhHoc
{
    public class Compare
    {
        private static HinhHoc hh = new HinhHoc();
        string compare;
        public Compare() 
        {
        }
        public string MoiQuanHe(HinhVuong hv, HinhTron hr)  
        {
            double length_AB = hv.Length(hv.A, hv.B)/2;
            if(length_AB == hr.R)
            {
                compare = "Đường tròn nội tiếp hình vuông";
            }
            else
            {
                if (hv.Length_AC() == hr.R)
                {
                    compare = "Đường tròn ngoại tiếp hình Vuông";
                }
                else
                {
                    compare = "Đường tròn và hình vuông không có vị trí tương đối";
                }
            }
            return compare + "\n\tDiện tích hình tròn " + hr.DienTich() + "\n\tChu Vi hình tròn " + hr.ChuVi()
                + "\n\tDiện tích hình Vuông " + hv.DienTich() + "\n\tChu Vi hình vuông " + hv.ChuVi();
        }

        public string MoiQuanHe(HinhChuNhat hcn, HinhTron hr)
        {
            if (hcn.Length_AC() == hr.R)
            {
                compare = "Đường tròn ngoại tiếp hình chữ nhật";
            }
            else
            {
                compare = "Đường tròn và hình chữ nhật không có vị trí tương đối";
            }
            return compare + "\n\tDiện tích hình tròn " + hr.DienTich() + "\n\tChu Vi hình tròn " + hr.ChuVi()
                + "\n\tDiện tích hình Chữ Nhật " + hcn.DienTich() + "\n\tChu Vi hình Chữ Nhật " + hcn.ChuVi();
        }

        public string MoiQuanHe(ToaDo i, HinhTron hr)
        {
            double kc = hr.Length(hr.I, i);
            compare = (kc > hr.R ? "Nằm Ngoài" : kc == hr.R ? "Nằm Trên" :
                "Nằm Trong");
           return compare + "\n\tDiện tích hình tròn " + hr.DienTich() + "\n\tChu Vi hình tròn " + hr.ChuVi();
        }

        public string MoiQuanHe(TamGiac tg, HinhTron hr)
        {
            double length_a = hr.Length(hr.I, tg.A);
            double length_b = hr.Length(hr.I, tg.B);
            double length_c = hr.Length(hr.I, tg.C);
            double ab = tg.Length(tg.A, tg.B);
            double bc = tg.Length(tg.B, tg.C);
            double ac = tg.Length(tg.A, tg.C);
            double tong = ab + bc + ac;
            double x1 = (ab * tg.C.X + bc * tg.A.X + ac * tg.B.X) / tong;
            double y1 = (ab * tg.C.Y + bc * tg.A.Y + ac * tg.B.Y) / tong;
            compare = ((length_a == hr.R && length_b == hr.R && length_c == hr.R) ?
                "Đường tròn nội tiếp tam giác" : (length_a < hr.R || length_b < hr.R ||
                length_c < hr.R) ? "Tam giác cắt đường tròn" : (x1 == hr.I.X && y1 == hr.I.Y) ?
                "Đường tròn nội tiếp tam giác" : "Đường tròn nằm ngoài tam giác"
            );
            return compare + "\n\tDiện tích hình tròn " + hr.DienTich() + "\n\tChu Vi hình tròn " + hr.ChuVi() +
                 "\n\tDiện tích tam giác " + tg.DienTich() + "\n\tChu Vi hình tam giác " + tg.ChuVi();
        }

        public string MoiQuanHe(DuongThang dt, HinhTron hr)
        {
            double c = -(dt.A.X*dt.B.X+dt.A.Y*dt.B.Y);
            double length = Math.Abs(dt.A.X*hr.I.X + dt.A.Y* hr.I.Y + c)/(Math.Sqrt(dt.A.X*
                dt.A.X + dt.A.Y*dt.A.Y));
            compare = (length < hr.R ? "Đường Thẳng cắt đường tròn" : length == hr.R ? 
                "Đường thẳng là tiếp tuyến đường tròn" : "Đường thẳng và hình tròn không giao nhau");
            return compare + ("\n\tDiện tích hình tròn {0} \n\tChu Vi hinh tròn {1}", hr.DienTich(), hr.ChuVi());
        }

        public string MoiQuanHe(ToaDo D, TamGiac tg)
        {
            double length_AB = tg.Length(tg.A, tg.B);
            double length_BC = tg.Length(tg.B, tg.C);
            double length_AC = tg.Length(tg.C, tg.A);
            double S = tg.DienTich(length_AC, length_AB, length_BC);
            double length_AD = tg.Length(tg.A, D);
            double length_DB = tg.Length(D, tg.B);
            double length_DC = tg.Length(D, tg.C);
            double S_ADB = tg.DienTich(length_AD, length_DB, length_AB);
            double S_ADC = tg.DienTich(length_AD, length_DC, length_AC);
            double S_DCA = tg.DienTich(length_DC, length_AC, length_AD);
            compare = (S_ADB + S_ADC + S_DCA) == S && (S_ADB !=0 || 
                S_ADC !=0 || S_DCA !=0)? "Điểm nằm trong tam giác" : (S_ADB + S_ADC + S_DCA) == S && (S_ADB == 0 ||
                S_ADC == 0 || S_DCA == 0) ? "Điểm nằm trên tam giác" : "Điểm nằm ngoài tam giác";
            return compare + "\n\tDiện tích tam giác "+ tg.DienTich() + "\n\tChu Vi hình tam giác " + tg.ChuVi();
        }

        public string MoiQuanHe(ToaDo C, DuongThang dt)
        {
            double length_AC = dt.Length(dt.A, C);
            double length_CB = dt.Length(C, dt.B);
            double length_AB = dt.Length(dt.A, dt.B);
            compare = (length_AC + length_CB == length_AB) ? "Điểm nằm trên đường thẳng" :
                "Điểm và đường thẳng không giao nhau";
            return compare;
        }

        public string MoiQuanHe(ToaDo E, HinhVuong hv)
        {
            compare = (float)(hv.S_toanPhan(E)) == (float)(hv.DienTich()) ? "Điểm nằm trong hình vuông" : "Điểm nằm ngoài hình vuông";
            return compare + "\n\tDiện tích hình vuông " + hv.DienTich() + "\n\tChu Vi hình vuông " + hv.ChuVi();
        }

        public string MoiQuanHe(ToaDo E, HinhChuNhat hcn)
        {
            compare = (float)(hcn.S_toanPhan(E)) == (float)(hcn.DienTich()) ? "Điểm nằm ngoài hình chữ nhật" :
                "Điểm nằm ngoài hình chữ nhật";
            return compare + "\n\tDiện tích hình chữ nhật " + hcn.DienTich() + "\n\tChu Vi hình chữ nhật " + hcn.ChuVi();
        }

        public string MoiQuanHe(HinhTron hr, HinhTron hr2)
        {
            double length_iI = hr.Length(hr.I, hr2.I);
            double length_R = hr.R + hr2.R;
            compare = length_iI == length_R ? "2 đường tròn tiếp xúc nhau" : length_iI < length_R ? 
                "2 đường tròn cắt nhau" : "2 đường tròn không giao nhau";
            return compare + "\n\tDiện tích hình tròn 1 " + hr.DienTich() + "\n\tChu Vi hình tròn 1 " + hr.ChuVi() +
                "\n\tDiện tích hình tròn 2 " + hr2.DienTich() + "\n\tChu Vi hình tròn 2 " + hr2.ChuVi();
        }

        public string MoiQuanHe(HinhChuNhat hcn, HinhChuNhat hcn1)
        {
            return "Không có mối quan hệ " + "Diện tích và chu vi hình 1 : " + hcn.DienTich() + " " +
                hcn.ChuVi() + "\n\tDiện tích và chu vi hình 2 " + hcn1.DienTich() + " , " + hcn1.ChuVi();
        }

        public string MoiQuanHe(TamGiac tg, TamGiac tg2)
        {
            return "Không có mối quan hệ " + "Diện tích và chu vi hình 1 : " + tg.DienTich() + " " +
               tg.ChuVi() + "\n\tDiện tích và chu vi hình 2 " + tg2.DienTich() + " , " + tg2.ChuVi();
        }

        public string MoiQuanHe(HinhVuong hv, HinhVuong hv1)
        {
            return "Không có mối quan hệ " + "Diện tích và chu vi hình 1 : " + hv.DienTich() + " " +
               hv.ChuVi() + "\n\tDiện tích và chu vi hình 2 " + hv1.DienTich() + " , " + hv1.ChuVi();
        }

        public string MoiQuanHe(HinhVuong hv, TamGiac tg)
        {
            return "Không có mối quan hệ " + "Diện tích và chu vi hình 1 : " + hv.DienTich() + " " +
               hv.ChuVi() + "\n\tDiện tích và chu vi hình 2 " + tg.DienTich() + " , " + tg.ChuVi();
        }

        public string MoiQuanHe(HinhVuong hv, HinhChuNhat hcn)
        {
            return "Không có mối quan hệ " + "Diện tích và chu vi hình 1 : " + hv.DienTich() + " " +
               hv.ChuVi() + "\n\tDiện tích và chu vi hình 2 " + hcn.DienTich() + " , " + hcn.ChuVi();
        }

        public string MoiQuanHe(HinhVuong hv, DuongThang dt)
        {
            return "Không có mối quan hệ " + "Diện tích và chu vi hình Vuông : " + hv.DienTich() + " " +
               hv.ChuVi();
        }

        public string MoiQuanHe(HinhChuNhat hcn, DuongThang dt)
        {
            return "Không có mối quan hệ " + "Diện tích và chu vi hình Vuông : " + hcn.DienTich() + " " +
               hcn.ChuVi();
        }

        public string MoiQuanHe(DuongThang dt, DuongThang dt1)
        {
            bool soSanh = dt.A.X == dt1.A.X && dt.A.Y == dt1.A.Y && dt.B.X == dt1.B.X &&
                dt.B.Y == dt.B.Y;
            compare = soSanh == true ? "2 đường thẳng trùng nhau" : dt.A.X == dt1.A.X ? "2 đường thẳng" +
                "cắt nhau" : "2 đường thẳng song song với nhau";
            return compare;
        }

        public string MoiQuanHe(ToaDo A, ToaDo B)
        {
            return "Không có mối quan hệ";
        }
    }
}