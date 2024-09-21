using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class GiaoVien
    {
        private int ID;
        private string Ten;
        private double SoGioSay;

        public GiaoVien()
        {
            Ten1 = "NULL";
        }

        public int ID1 { get; set; }
        public string Ten1 { get; set; }
        public double SoGioSay1 { get; set; }

        public GiaoVien(int iD, string ten, double soGioSay)
        {
            ID = iD;
            Ten = ten;
            SoGioSay = soGioSay;
        }
       
        public virtual void inThongTin()
        {
            Console.Write("\n"+ID1+"\t"+Ten1+"\t"+SoGioSay1);
        }
    }
}
