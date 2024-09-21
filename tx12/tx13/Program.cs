using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tx13
{
    class Program
    {
        static List<ThiSinh> list=new List<ThiSinh>();
        static ThiSinh FindByID(int sobd)
        {
            ThiSinh searchResult = null;
            if (list != null && list.Count > 0)
            {
                foreach (ThiSinh ts in list)
                {
                    if (ts.Sbd == sobd)
                    {
                        searchResult = ts;
                    }
                }
            }
            return searchResult;
        }
        static void nhapthongtin()
        {
            ThiSinhChinhSach ts = new ThiSinhChinhSach();
            ts.input();
            list.Add(ts);
        }

        static void hienthi()
        {
            Console.WriteLine("===============danh sach sau khi nhap=================");
            Console.WriteLine(" {0,-15}  {1,-30} {2,-10} {3,-10}", "sbd","ngay sinh","dtut","diem uu tien");
            foreach (ThiSinh ts in list)
            {
                ts.output();
            }
        }

        static void sua()
        {
            Console.Write("nhap sbd this sinh can sua: ");
            int sobd = int.Parse(Console.ReadLine());
            //ThiSinh ts = FindByID(sobd);
            //if(ts != null)
            //{
                foreach(ThiSinhChinhSach tss in list)
                {
                    if (tss.Sbd==sobd)
                    {
                        if (tss.Dtut != "ut1" && tss.Dtut != "ut2" && tss.Dtut != "kv1" && tss.Dtut != "kv2")
                        {
                            Console.Write("nhap ngay sinh can doi");
                            DateTime doingay = DateTime.Parse(Console.ReadLine());
                            tss.Ngaysinh = doingay.ToUniversalTime();
                            break;
                        }
                        else
                        {
                            Console.Write("nhap ten can doi");
                            string doiten = Console.ReadLine();
                            tss.Dtut = doiten;
                            break;
                        }
                    }
                }
            //}
            //else
            //{
            //    Console.WriteLine("sinh vien khong ton tai");
            //}

            Console.WriteLine("++++danh sach sau khi sua la++++++++");
            hienthi();
        }
        static void Main(string[] args)
        {
            int choose;
            do
            {
                Console.WriteLine("1. nhap thong tin");
                Console.WriteLine("2. hien thi dan sach");
                Console.WriteLine("3. sua thong tin");
                Console.WriteLine("4. thoat");
                Console.Write("nhap lua chon: ");
                choose=int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        nhapthongtin();
                        break;
                    case 2:
                        hienthi();
                        break;
                    case 3:
                        sua();
                        break;
                    case 4:
                        break;
                }
            } while (choose != 4);
        }
    }
}

/*
 1
1
22/09/2003
ut1
1
2
22/09/2004
ut1
2

 */