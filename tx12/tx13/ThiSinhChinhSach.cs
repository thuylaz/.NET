using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tx13
{
    class ThiSinhChinhSach:ThiSinh
    {
        private string dtut {  get; set; }
        public string Dtut
        {
            get { return dtut; }
            set { dtut = value; }
        }
        public ThiSinhChinhSach():base()
        {
            
        }

        public ThiSinhChinhSach(string dtut):base()
        {
            this.dtut = dtut;
        }
        public ThiSinhChinhSach(int sbd, DateTime ngaysinh, string dtut):base(sbd, ngaysinh)
        {
            this.dtut = dtut;
        }

        public override void input()
        {
            base.input();
            Console.Write("doi tuong uu tien: ");
            dtut=Console.ReadLine();
        }

        public double diemut()
        {
            if (dtut == "ut1") return 2;
            else if (dtut == "ut2") return 1.5;
            else if (dtut == "kv1") return 1;
            else if (dtut == "kv2") return 0.5;
            else return 0;
        }

        public override void output()
        {
            base.output();
            Console.WriteLine("{0,-10} {1,-10}", dtut, diemut());
        }


    }
}
