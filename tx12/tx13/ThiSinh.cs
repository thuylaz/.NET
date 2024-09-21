using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tx13
{
    class ThiSinh
    {
        private int sbd {  get; set; }
        private DateTime ngaysinh { get; set; }

        public int Sbd
        {
            get { return sbd; }
            set { sbd = value; }
        }

        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }

        
        public ThiSinh()
        {
            
        }

        public ThiSinh(int sbd, DateTime ngaysinh)
        {
            this.sbd = sbd;
            this.ngaysinh = ngaysinh;
        }

        public virtual void input()
        {
            Console.Write("so bao danh: ");
            sbd=int.Parse(Console.ReadLine());
            Console.Write("ngay sinh: ");
            ngaysinh=DateTime.Parse(Console.ReadLine());           
        }

        public virtual void output()
        {
            Console.Write("{0,-15} {1,-30}",sbd,ngaysinh);
        }


    }
}
