using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txca1
{
    class SinhVienDT:SinhVien
    {
        public float english { get; set; }
        public float uutien { get; set;}

        public SinhVienDT()
        {
            
        }

        public SinhVienDT(string masv, string hovaten, float python, float java, float english, float uutien):base(masv,hovaten,python,java)
        {
            this.english = english;
            this.uutien = uutien;
        }

        public override void nhap()
        {
            base.nhap();
            Console.Write("enlish: ");
            english=float.Parse(Console.ReadLine());
            Console.Write("uu tien: ");
            uutien=float.Parse(Console.ReadLine());
        }

        public double tong()
        {
            if (english > 8) return tongdiem()+english+ 1.0;
            else if (english >= 5 && english <= 8) return tongdiem() + english + 0.5;
            else if (english < 5) return tongdiem() + english + 0;
            else return tongdiem() + english + 0;
        }

        public override void xuat()
        {
            base.xuat();
            Console.WriteLine(" {0,-10} {1,-10} {2,-10}", english,uutien,tong());
        }
    }
}
