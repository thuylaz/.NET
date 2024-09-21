using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class SERVICE
    {
        List<GiaoVien> listGv = new List<GiaoVien>();

        public void inputList()
        {
            string select;
            do
            {
                Console.WriteLine("-----------   Nhap thong tin cua Giao Vien   ------------------");
                GiaoVien gv = new GiaoVien();
                Console.WriteLine("Nhap id: ");
                gv.ID1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap Ten: ");
                gv.Ten1 = Console.ReadLine();
                Console.WriteLine("Nhap so gio day: ");
                gv.SoGioSay1 = double.Parse(Console.ReadLine());
                
                listGv.Add(gv);

                Console.WriteLine("Bạn có muốn tiếp tục không?(y/n)");
                select = Console.ReadLine();

            } while (select == "y");
        }

        public void outputList()
        {
            Console.WriteLine("Id\tTên\tSố Giờ Dạy");
            foreach (var item in listGv)
            {
                item.inThongTin();
            }
        }

        public void outputByTime()
        {
            Console.WriteLine("Nhap khoảng giờ dạy 1: ");
            double t1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap khoảng giờ dạy 2: ");
            double t2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Id\tTên\tSố Giờ Dạy");

            foreach (var item in listGv)
            {
                if(item.SoGioSay1 >t1 && item.SoGioSay1 < t2)
                {
                    item.inThongTin();
                }
            }
        }

        public void deleteById()
        {
            Console.WriteLine("Nhập id cần xóa: ");
            int id1= int.Parse(Console.ReadLine());

            foreach(var item in listGv)
            {
                if(item.ID1 == id1)
                {
                    listGv.Remove(item);
                    break;
                }
            }
            Console.WriteLine("--------- Danh sach sau khi xoa ---------");
            outputList();
        }

        public void KeThua()
        {
            GiaoVienPoly Gvpl = new GiaoVienPoly();

            Console.WriteLine("------------ Thong tin giao vien poly ---------");
            Console.WriteLine("Id\tTên\tSố Giờ Dạy\tKế thừa");

            Gvpl.inThongTin();

        }
    }
}
