using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class ThiSinhA
    {

        public int soBaoDanh { get; set; }
        public String hoTen { get; set; }
        public String diaChi { get; set; }
        public double toan { get; set; }
        public double ly { get; set; }
        public double hoa { get; set; }
        public double diemUuTien { get; set; }

        public static int SBD = 1;
        public ThiSinhA()
        {
            soBaoDanh = SBD++;
        }

        public void nhapThiSinh()
        {
            Console.Write("Nhập họ tên thí sinh: ");
            hoTen = Convert.ToString(Console.ReadLine());

            Console.Write("Nhập địa chỉ: ");
            diaChi = Convert.ToString(Console.ReadLine());

            Console.Write("Nhập điểm toán: ");
            toan = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập điểm lý: ");
            ly = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập điểm hóa: ");
            hoa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập điểm ưu tiên: ");
            diemUuTien = Convert.ToDouble(Console.ReadLine());
        }

        public void xuatThiSinh()
        {
            Console.WriteLine($"{soBaoDanh,5} {hoTen,25} {diaChi,15} {toan,13} {ly,13} {hoa,13} {diemUuTien,9} {tongDiem(),15}");
        }

        public double tongDiem()
        {
            return Math.Round(toan + ly + hoa + diemUuTien, 3);
        }
    }
}
