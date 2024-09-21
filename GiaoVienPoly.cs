using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class GiaoVienPoly:GiaoVien
    {
        private string NganhDay;

        public GiaoVienPoly() : base() 
        {
            NganhDay = "Null";
        }

        public GiaoVienPoly(int iD, string ten, double soGioSay,string Nganhday) : base(iD, ten, soGioSay)
        {
            this.NganhDay = Nganhday;
        }

        public string NganhDay1 { get; set; }

        public override void inThongTin()
        {
            base.inThongTin();
            Console.Write("\t\t"+NganhDay);
        }
    }
}
