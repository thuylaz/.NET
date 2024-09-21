using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txnhi
{
    class ThiSinhUT:ThiSinh
    {
        public int khuvuc {  get; set; }
        public float diemut {  get; set; }

        public ThiSinhUT()
        {
            
        }

        public ThiSinhUT(string sbd, string hoten, float diemvan, float diemanh, int khuvuc, float diemut):base(sbd,hoten,diemvan,diemanh)
        {
            this.khuvuc = khuvuc;
            this.diemut = diemut;
        }

        public override void nhap()
        {
            base.nhap();
            Console.Write("khu vuc: ");
            khuvuc = int.Parse(Console.ReadLine());
            Console.Write("diem uu tien: ");
            diemut= float.Parse(Console.ReadLine());
        }

        public double gandiem()
        {
            if (khuvuc == 1) return TongDiem();
            else if (khuvuc == 2) return TongDiem() + 0.5;
            else if (khuvuc == 3) return TongDiem() + 1.0;
            else return TongDiem();
        }
        public string xettuyen(double diemsan)
        {
            
            if (gandiem() >= diemsan) return "thi do";
            else return "thi truot";
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("{0,-10}{1,-10}{2,-10}", khuvuc,diemut,gandiem());
        }
    }
}
