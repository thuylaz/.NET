using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thisinha1
{
    class thisinh
    {
        public double Id { get; set; }
        public string Name { get; set; }
        public double diemtoan { get; set; }
        public double diemly { get; set; }
        public double diemhoa { get; set; }
        public void nhap()
        {
            Console.Write("id: ");
            Id = Convert.ToDouble(Console.ReadLine());
            Console.Write("name: ");
            Name = Convert.ToString(Console.ReadLine());
            Console.Write("deim toan: ");
            diemtoan = Convert.ToDouble(Console.ReadLine());
            Console.Write("diem ly: ");
            diemly = Convert.ToDouble(Console.ReadLine());
            Console.Write("diem hoa: ");
            diemhoa = Convert.ToDouble(Console.ReadLine());

        }

        public void xuat()
        {
            Console.WriteLine($"{Id,3} {Name,5} {diemtoan,7} {diemly,7} {diemhoa,7} {tongdiem(),7}");
        }

        public double tongdiem()
        {
            return Math.Round(diemhoa + diemly + diemtoan, 2);
        }

        

    }
}
