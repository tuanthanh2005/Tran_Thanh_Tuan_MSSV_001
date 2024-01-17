using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    class Chu_Nhat
    {
        private double rong;
        private double dai;

        public Chu_Nhat()
        {
            dai = 5;
            rong = 9;
        }  
        public double Rong 
        {
            set { rong = value; }
            get { return rong; }
        }
        public double Dai
        {
            set { dai = value; }
            get { return dai; }
        }
        public virtual double TinhChuVi()
        {
            return dai + rong * 2;
        }
        public virtual double TinhDienTich()
        {
            return dai * rong;
        }
        public virtual void XuatThongTin()
        {
            Console.WriteLine(" Tinh Chu Vi :{0} ",TinhChuVi());
            Console.WriteLine("Tinh Dien Tich :{0}",TinhDienTich());

        }
    } 
    }


