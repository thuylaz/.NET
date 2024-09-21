using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tx12
{
    class KhachHangVIP:KhachHang
    {
        public string loaikh {  get; set; }
        public KhachHangVIP()
        {
            
        }

        public KhachHangVIP(string hoten, bool gioitinh, int slmua, double dongia, string loaikh) : base(hoten, gioitinh, slmua, dongia)
        {
            this.loaikh = loaikh;
        }

        public override void input()
        {
            base.input();
            Console.Write("loai khach hang: ");
            loaikh= Console.ReadLine();
        }

        public double tinhtong()
        {
            if (loaikh == "vip") return tongtien() * 0.8;
            else if (loaikh == "vang") return tongtien() * 0.9;
            else return tongtien() * 0.95;
        }
        public override void output()
        {
            base.output();
            Console.WriteLine("{0,-10}{1,-10}", loaikh, tinhtong());
        }

    }
}
