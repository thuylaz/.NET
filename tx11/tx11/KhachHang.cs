using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tx11
{
    class KhachHang
    {
        private string hoten;
        public string Hoten
        {
            get { return hoten; }
            set { hoten  = value; }

        }    
        private bool gioitinh {  get; set; }
        private int slmua{ get; set; }
        private double dongia {  get; set; }

        public KhachHang()
        {
            
        }

        public KhachHang(string hoten)
        {
            hoten = hoten;
        }

        public KhachHang(string hoten, bool gioitinh, int slmua, double dongia)
        {
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.slmua = slmua;
            this.dongia = dongia;
        }

        public virtual double tongtien()
        {
            return slmua * dongia;
        }

        

        public virtual void nhap()
        {
            Console.Write("ho ten: ");
            hoten = Console.ReadLine();
            Console.Write("gioi tinh(true: Nam, false: Nu): ");
            gioitinh = Convert.ToBoolean(Console.ReadLine());
            Console.Write("sl mua: ");
            slmua = int.Parse(Console.ReadLine());
            Console.Write("don gia: ");
            dongia = double.Parse(Console.ReadLine());

        }

        public static void inTieuDe()
        {
            Console.Write("{0,-10}{1,-15}{2,-16}{3,-10}", "ho ten", "gioi tinh", "sl mua", "don gia");
        }
        public virtual void xuat()
        {
            Console.Write("{0,-10}{1,-15}{2,-16}{3,-10}", hoten, gioitinh ? "Nam" : "Nu", slmua, dongia);
        }
        public double ktra()
        {

        }


    }
}
