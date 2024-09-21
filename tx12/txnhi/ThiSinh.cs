using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txnhi
{
    class ThiSinh
    {
        public string sbd {  get; set; }
        public string hoten {  get; set; }
        public float diemvan {  get; set; }
        public float diemanh {  get; set; }

        public ThiSinh()
        {
            
        }

        public ThiSinh(string sbd, string hoten, float diemvan, float diemanh)
        {
            this.sbd = sbd;
            this.hoten = hoten;
            this.diemvan = diemvan;
            this.diemanh = diemanh;
        }

        public double TongDiem()
        {
            return diemvan+diemanh;
        }

        public virtual void nhap()
        {
            Console.Write("so bao danh: ");
            sbd=Console.ReadLine();
            Console.Write("ho ten: ");
            hoten=Console.ReadLine();
            Console.Write("diem van: ");
            diemvan=float.Parse(Console.ReadLine());
            Console.Write("diem anh: ");
            diemanh=float.Parse(Console.ReadLine());
        }

        public virtual void xuat()
        {
            Console.Write(" {0,-10} {1,-15} {2,-10} {3,-10}", sbd,hoten,diemvan,diemanh);
        }

    }
}
