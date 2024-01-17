using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    class Hinh_Vuong:Chu_Nhat
    {
        private double canh;


        public Hinh_Vuong(double canh )
        {
            this.canh = canh;
        }
        public double Canh
        {
            set { canh = value; }
            get { return canh; }
        }
        public override  double TinhChuVi()
        {
            return canh * 4;
        }
        public override double TinhDienTich()
        {
            return canh * canh;
        }
    }
}
