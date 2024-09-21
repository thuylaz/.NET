using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tx12
{
    class Program
    {
        static List<KhachHang> list=new List<KhachHang>();

        static void nhapthongtin()
        {
            KhachHangVIP kh=new KhachHangVIP();
            kh.input();
            list.Add(kh);
        }

        static void xuatthongtin()
        {
            Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10}{4,-10}{5,-10}", "ho ten", "gioi tinh", "sl mua", "don gia","loai kh", "tong tien");

            foreach (KhachHang kh in list)
            {
                kh.output();
            }
        }

        static void xoa()
        {
            Console.Write("nhap ten can xoa: "); string ten=Console.ReadLine();
            KhachHang khach=new KhachHang();
            
            foreach (KhachHang kh in list)
            {
                if(kh.Hoten!=ten)
                {
                    Console.WriteLine("ten k ton tai"); break;
                    
                }
                else
                {
                    list.Remove(kh);
                    break;
                }
            }
            Console.WriteLine("===============danh sach sau khi thao tac================");
            xuatthongtin();
        }
        static void Main(string[] args)
        {
            int choose;
            do
            {
                Console.WriteLine("1. nhap thong tin");
                Console.WriteLine("2. hien thi danh sach");
                Console.WriteLine("3. xoa khach hang");
                Console.WriteLine("4. thoat");
                Console.Write("nhap lua chon: ");
                choose=int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        nhapthongtin();
                        break;
                    case 2:
                        xuatthongtin();
                        break;
                    case 3:
                        xoa();
                        break;
                    case 4:
                        break;
                }

            }while(choose!=4);
        }
    }
}

