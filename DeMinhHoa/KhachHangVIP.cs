using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMinhHoa
{
    internal class KhachHangVIP:KhachHang
    {
        // nap de phuong thuc constructor cua KhachHang
        // bo sung bien thanh vien: Qua tang
        // thuoc tinh cho phep truy cap an toan
        private string gift;
        public string Gift
        {
            get { return gift; }
            set { gift = value; }
        }
        public KhachHangVIP(string makh, string ten, int soluongmua, double dongia, string quaTang) :base( makh,  ten, soluongmua, dongia)
        {
            Gift = quaTang;
        }
        // constructor khong tham so
        public KhachHangVIP() { }

        // nap de phuong thuc tong tien
        public virtual string QuaTang()
        {
            string gift = "";
            if(TongTien() < 1000)
            {
                gift = "Coupon 100";
            }
            else if (TongTien() < 5000)
            {
                gift = "Coupon 200";
            }
            else
            {
                gift = "Coupon 500";
            }
            return gift;
        }
        public override string ToString()
        {
            return string.Format("{0}{1, 15}", base.ToString(), this.QuaTang());
        }
    }
}
