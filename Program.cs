using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhHoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
               //Tọa độ hình tròn (I, R)
            HinhTron ht= new HinhTron(new ToaDo(2, 1), 3);

            //Tọa độ hình Tam giác (A, B, C)
            TamGiac tg = new TamGiac(new ToaDo(2, 6), new ToaDo(-3, -4), new ToaDo(5, 0));
            
            // Tọa độ Hình chữ nhật (A, B, C ,D)
            HinhChuNhat hcn = new HinhChuNhat(new ToaDo(1, -3), new ToaDo(5, 4), new ToaDo(-2, 8),
                new ToaDo(-6, 1));

            //tọa độ hình vuông  (A, B, C ,D)
            HinhVuong hv = new HinhVuong(new ToaDo(1, -3), new ToaDo(5, 4), new ToaDo(-2, 8),
                new ToaDo(-6, 1));
           
            // Toa độ đường thẳng gồm VTPT n và điểm B  dt(n, B);  
            DuongThang dt = new DuongThang(new ToaDo(1, -3), new ToaDo(5, 4));
           
                  // Tọa độ điểm (diem)
            ToaDo diem = new ToaDo(1,1);
            //-------------------------------------------------------------------------------//
            //Những Đối tượng thứ 2 nếu chọn 2 hình giống nhau!

            HinhTron ht2 = new HinhTron(new ToaDo(2, 1), 3);
            TamGiac tg2 = new TamGiac(new ToaDo(2, 6), new ToaDo(-3, -4), new ToaDo(-3, -4));
            HinhChuNhat hcn2 = new HinhChuNhat(new ToaDo(1, -3), new ToaDo(5, 4), new ToaDo(-2, 8),
                new ToaDo(-6, 1));
            HinhVuong hv2 = new HinhVuong(new ToaDo(1, 1), new ToaDo(5, 4), new ToaDo(-2, 8),
                new ToaDo(-6, 1));
            DuongThang dt2 = new DuongThang(new ToaDo(1, -3), new ToaDo(5, 4));
            ToaDo diem2 = new ToaDo(0, 1);
            //--------------------------------------------------------------------------------//
            Compare cp = new Compare();

            //Nhập hình muốn tìm trong MoiQuanhe(hinh1, hinh2)
            //EX: Tam giác và Hình Tròn cp.MoiQuanHe(tg, ht));
            Console.WriteLine("\n\t"+ cp.MoiQuanHe(tg,ht)); 
            Console.WriteLine("\n\t" + cp.MoiQuanHe(diem, hv));
            Console.ReadLine();

        }
    }
}
