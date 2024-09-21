using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txnhi
{
    class sx : IComparer<ThiSinhUT>
    {
        public int Compare(ThiSinhUT x,ThiSinhUT y)
        {
            return x.gandiem().CompareTo(y.gandiem());
        }
    }

    
    class Program
    {
        static List<ThiSinhUT> list = new List<ThiSinhUT>();

        static void nhaptt()
        {
            ThiSinhUT ts=new ThiSinhUT();
            ts.nhap();
            list.Add(ts);
        }

        static void xuattt()
        {
            Console.WriteLine("danh sach sau khi nhap");
            Console.WriteLine("{0,-10}{1,-15}{2,-10}{3,-10}{4,-10}{5,-10}{6,-10}", "sbd", "ho ten", "diem van", "diem anh", "khu vuc","diem ut","tong diem");
            foreach (ThiSinh ts in list)
            {
                ts.xuat();
            }
        }

        static string truotdo()
        {
            Console.Write("nhap vao diem san: ");
            double diemsan = double.Parse(Console.ReadLine());
            foreach(ThiSinhUT ts in list)
            {
                ts.xettuyen(diemsan);
                ts.xuat();
            }
            
        }

        static void timkiem()
        {
            if (list.Count == 0) Console.WriteLine("danh sach rong");
            Console.Write("nhap sbd muon tim:");
            string sobd = Console.ReadLine();
            foreach (var ts in list)
            {
                if (ts.sbd.Equals(sobd))
                {

                     ts.xuat();
                    break;
                }
                
            }Console.WriteLine("khong ton tai hoc sinh");

        }

        static void sapxep()
        {
            Console.WriteLine("ham sau khi sap xep");
            list.Sort(new sx());
            foreach (ThiSinh ts in list)
            {
                ts.xuat();
            }
        }
        static void Main(string[] args)
        {
            int choose;
            do
            {
                Console.WriteLine("1. nhap thong tin 1 thi sinh");
                Console.WriteLine("2. hien thi thong tin");
                Console.WriteLine("3. tinh tong diem 3 mon");
                Console.WriteLine("4. xet tuyen");
                Console.Write("nhap lua chon: ");
                choose=int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        nhaptt();
                        break;
                    case 2:
                        xuattt();
                        break;
                    case 3:
                        truotdo();
                        break;
                    case 4:
                        timkiem();
                        break;
                    case 5:
                        sapxep();
                        break;
                }
            } while (choose != 6);
        }
    }
}

/*
1
sv1
thuy
3
4
2
0,5
1
sv2
nhung
3
7
2
0,5
2
4
sv2

 */