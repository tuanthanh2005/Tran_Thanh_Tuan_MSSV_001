using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Chu_Nhat cn = new Chu_Nhat();
            cn.TinhChuVi();
            cn.TinhDienTich();
            cn.XuatThongTin();
            Hinh_Vuong hv = new Hinh_Vuong(5);
            hv.TinhChuVi();
            hv.TinhDienTich();
            hv.XuatThongTin();
            Console.ReadLine();
        }
    }
}
