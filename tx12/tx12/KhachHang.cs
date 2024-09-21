using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tx12
{
    class KhachHang
    {
        private string hoten;
        public string Hoten
        {
            get { return hoten; } 
            set { hoten = value; }
        }

        private bool gioitinh {  get; set; }
        private int slmua {  get; set; }
        private double dongia {  get; set; }

        public KhachHang()
        {
            
        }

        public KhachHang(string hoten)
        {
            this.hoten = hoten;
        }

        public KhachHang(string hoten, bool gioitinh, int slmua, double dongia)
        {
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.slmua = slmua;
            this.dongia = dongia;
        }
        
        public virtual void input()
        {
            Console.Write("ho ten: ");
            hoten=Console.ReadLine();
            Console.Write("gioi tinh: ");
            gioitinh=Convert.ToBoolean(Console.ReadLine());
            Console.Write("so luong mua: ");
            slmua=int.Parse(Console.ReadLine());
            Console.Write("don gia: ");
            dongia=double.Parse(Console.ReadLine());
        }

        public double tongtien()
        {
            return slmua * dongia;
        }

        public virtual void output()
        {
            Console.Write("{0,-10} {1,-10} {2,-10} {3,-10}", hoten, gioitinh ? "nam" : "nu", slmua, dongia);

        }
    }
}
