using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DeMinhHoa
{
    internal class KhachHang
    {
        private string maKH;
        private string hoTen;
        private int soLuongMua;
        private double donGia;
        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public int SoLuongMua
        {
            get { return soLuongMua; }
            set { soLuongMua = value; }
        }
        public double DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        /*public void nhap(string makh, string ten, string soluongmua, double dongia )
        {
            MaKH = makh;
            HoTen = hoTen;
            SoLuongMua = soluongmua;
            DonGia = dongia;
        }*/

        //phuong thuc constructor co tham so
        public KhachHang(string makh, string ten, int soluongmua, double dongia)
        {
            MaKH = makh;
            HoTen = hoTen;
            SoLuongMua = soluongmua;
            DonGia = dongia;
        }

        // phuong thuc constructor ko tham so
        public KhachHang() { }
        //phuong thuc tinh tong tien
        virtual public double TongTien() // cho phep lop con nap de
        {
            return soLuongMua * donGia;
        }
        public override bool Equals(object? obj)
        {
            KhachHang k = (KhachHang)obj;
            if (this.MaKH == k.MaKH) return true;
            else return false;
        }
        public override string ToString()
        {
            return string.Format("{0,10}{1,15}{2,15}{3,15}{4,15}", this.MaKH, this.HoTen, this.SoLuongMua, this.DonGia, this.TongTien());
        }
    }
}
