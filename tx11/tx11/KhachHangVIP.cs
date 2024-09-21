using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tx11
{
    class KhachHangVIP:KhachHang
    {
        public string loaikh {  get; set; }

        public KhachHangVIP() { }
        

        public KhachHangVIP(string hoten, bool gioitinh, int slmua, double dongia, string loaikh) : base(hoten, gioitinh, slmua, dongia)
        {
            this.loaikh = loaikh;
        }

        public override void nhap()
        {
            base.nhap();
            Console.Write("loai khach hang: ");
            loaikh=Console.ReadLine();
        }

        public static void inTieuDe()
        {
            KhachHang.inTieuDe();
            Console.WriteLine("{0,-15}{1,-15}", "loai khach hang", "tong tien");
        }


        public double lkh()
        {
            if (loaikh == "vip")
            {
                return tongtien() * 0.8;
            }
            else if (loaikh == "vang")
            {
                return tongtien() * 0.9;
            }
            else
            {
                return tongtien() * 0.95;
            }
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("{0,-15}{1,-15}", loaikh, lkh());
        }


    }
}
