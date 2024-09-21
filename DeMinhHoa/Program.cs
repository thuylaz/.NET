namespace DeMinhHoa
{
    internal class Program
    {
        static List<KhachHang> dsKH = new List<KhachHang>();
        static void Main(string[] args)
        {
            string luaChon;
            do
            {
                Console.WriteLine("==========NHAP MENU==========");
                Console.WriteLine("1. Nhap thong tin");
                Console.WriteLine("2. Hien thi danh sach");
                Console.WriteLine("3. Tim khach hang");
                Console.WriteLine("4. Thoat");
                Console.WriteLine("Nhap vao lua chon cua ban !");
                luaChon = Console.ReadLine();
                switch(luaChon)
                {
                    case "1":
                        NhapThongTin();
                        break;
                    case "2":
                        HienThi();
                        break;
                    case "3":
                        TimKiem();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Nhap sai lua chon !");
                        break;
                }
            } while (luaChon != "4");
        }
        static void NhapThongTin()
        {
            string luaChon;
            Console.WriteLine("----------Nhap thong tin cho khach hang----------");
            Console.WriteLine("1. Khach hang");
            Console.WriteLine("2. Khach hang vip");
            Console.WriteLine("3. Thoat");
            luaChon = Console.ReadLine();
            switch (luaChon)
            {
                case "1":
                    KhachHang kh = new KhachHang();
                    Console.WriteLine("Nhap ma kh: ");
                    kh.MaKH = Console.ReadLine();
                    if (dsKH.Contains(kh))
                    {
                        Console.WriteLine("Da ton tai khach hang nay!");
                        return;
                    }
                    Console.WriteLine("Nhap ho ten kh: ");
                    kh.HoTen = Console.ReadLine();
                    Console.WriteLine("Nhap so luong mua: ");
                    kh.SoLuongMua = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap don gia: ");
                    kh.DonGia = Convert.ToDouble(Console.ReadLine());
                    dsKH.Add(kh);
                    break;
                case "2":
                    KhachHangVIP vip = new KhachHangVIP();
                    Console.WriteLine("Nhap ma kh: ");
                    vip.MaKH = Console.ReadLine();
                    if (dsKH.Contains(vip))
                    {
                        Console.WriteLine("Da ton tai khach hang nay!");
                        return;
                    }
                    Console.WriteLine("Nhap ho ten kh: ");
                    vip.HoTen = Console.ReadLine();
                    Console.WriteLine("Nhap so luong mua: ");
                    vip.SoLuongMua = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap don gia: ");
                    vip.DonGia = Convert.ToDouble(Console.ReadLine());
                    dsKH.Add(vip);
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Nhap sai lua chon !");
                    break;
            }
        }

        static void HienThi()
        {
            Console.WriteLine("{0,10}{1,15}{2,15}{3,15}{4,15}{5, 15}", "Ma KH", "Ho Ten", "So luong mua", "Don Gia", "Tong Tien", "Qua Tang");
            foreach (KhachHang item in dsKH)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static int Max()
        {
            int max = dsKH[0].SoLuongMua;
            for(int i = 1; i < dsKH.Count; i++)
            {
                if (dsKH[i].SoLuongMua > max)
                {
                    max = dsKH[i].SoLuongMua;
                }
            }
            return max;
        }
        static void TimKiem()
        {
            foreach(KhachHang item in dsKH)
            {
                if (item.SoLuongMua == Max())
                {
                    Console.WriteLine("{0,10}{1,15}{2,15}{3,15}{4,15}{5, 15}", "Ma KH", "Ho Ten", "So luong mua", "Don Gia", "Tong Tien", "Qua Tang");
                    Console.WriteLine(item.ToString());
                }
            }

        }
    }
}
