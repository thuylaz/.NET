using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tx11
{
    class Program
    {
        static List<KhachHang> list = new List<KhachHang>();

        static void nhapthongtin()
        {
            Console.WriteLine("nhap thong tin khach hang: ");
            KhachHangVIP khachHangVIP = new KhachHangVIP();
            khachHangVIP.nhap();
            list.Add(khachHangVIP);
        }

        static void xuatthongtin()
        {
            Console.Write("{0,-10}{1,-15}{2,-16}{3,-10}{4,-15}{5,-15}", "ho ten", "gioi tinh", "sl mua", "don gia", "loai kh", "tong tien");
            Console.WriteLine();
            foreach (KhachHang kh in  list)
            {
                kh.xuat();
            }
        }

        static void xoa()
        {
            Console.WriteLine("danh sach sinh vien ban dau");
            foreach(KhachHang kh in list)
            {
                kh.xuat();
            }
            Console.Write("nhap ten sv can xoa: ");
            string ten=Console.ReadLine();
            KhachHang h= new KhachHang(ten);
            foreach(KhachHang kh in list)
            {
                if (kh.Hoten==ten)
                {
                    list.Remove(kh);
                    break;
                } 
            }
            Console.WriteLine("danh sach sinh vien sau khi xoa");
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
                Console.Write("moi nhap lua chon: ");
                choose = int.Parse(Console.ReadLine());

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

            } while (choose != 4);
        }
    }
}


/*
 1
thuy
true
3
4
vip
1
nhung
true
3
4
vang
3

 */
