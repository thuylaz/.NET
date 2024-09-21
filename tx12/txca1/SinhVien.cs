using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txca1
{
    class SinhVien
    {
        public string masv {  get; set; }
        public string hovaten { get; set; }
        public float python { get; set; }
        public float java { get; set; }

        public SinhVien()
        {
            
        }

        public SinhVien(string masv, string hovaten, float python, float java)
        {
            this.masv = masv;
            this.hovaten = hovaten;
            this.python = python;
            this.java = java;
        }
        
        public virtual void nhap()
        {
            Console.Write("ma sv: ");
            masv=Console.ReadLine();
            Console.Write("ho va ten: ");
            hovaten=Console.ReadLine();
            Console.Write("python: ");
            python=float.Parse(Console.ReadLine());
            Console.Write("java: ");
            java=float.Parse(Console.ReadLine());
        }

        public string xettuyen(int mark)
        {
            
            if (tongdiem() >= mark) return "duoc chon";
            else return "loai";
        }

        public double tongdiem()
        {
            return python + java;
        }
        public virtual void xuat()
        {
            Console.Write(" {0,-10} {1,-10} {2,-10} {3,-10}", masv,hovaten,python,java);
        }

    }
}
