using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Test
    {
        public static void Main(string[] args)
        {
            SERVICE sv = new SERVICE();

            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("---------------  MENU  ------------");
            Console.WriteLine("1. Nhap danh sach ");
            Console.WriteLine("2.Xuất danh sach");
            Console.WriteLine("3. Xuất danh sach giao vien trong khoảng giờ dạy được chọn");
            Console.WriteLine("4. Xóa đối tượng theo Id được chọn");
            Console.WriteLine("5. Kế thừa");
            Console.WriteLine("0. Thoát");

            do
            {
                int opt;
                Console.WriteLine();
                Console.WriteLine("------------------------------");
                Console.WriteLine("Nhập lựa chọn của bạn: ");
                opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        sv.inputList();
                        break;
                    case 2:
                        Console.WriteLine("---------- Danh sach ------------");
                        sv.outputList();
                        break;
                    case 3:
                        Console.WriteLine("---------- Danh sach ------------");
                        sv.outputByTime();
                        break;
                    case 4:
                        sv.deleteById();
                        break;
                    case 5:
                        sv.KeThua();
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Lựa chọn của bạn không phù hợp");
                        break;
                }

            } while (true);
        }
    }
}
