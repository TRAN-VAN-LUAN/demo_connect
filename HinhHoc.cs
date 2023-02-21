using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HinhHoc
{
    public class HinhHoc
    {
        private ToaDo a;
        private ToaDo b;
        private ToaDo c;
        private ToaDo d;
        private ToaDo i;
        private int r;
        public double pi = 3.14;
        public ToaDo A { get => a; set => a = value; }
        public ToaDo B { get => b; set => b = value; }
        public ToaDo C { get => c; set => c = value; }
        public ToaDo D { get => d; set => d = value; }
        public ToaDo I { get => i; set => i = value; }
        public int R { get => r; set => r = value; }
        public HinhHoc()
        {
        }
        public double Length(ToaDo x, ToaDo y)
        {
            double len = Math.Sqrt(Math.Pow((y.X - x.X), 2) + Math.Pow((y.Y - x.Y), 2));
            return len;
        }
        public ToaDo Vecto(ToaDo a, ToaDo b)
        {
            ToaDo c = new ToaDo();
            c.X=b.X-a.X;
            c.Y=b.Y-a.Y;
            return c;
        }
    }
}