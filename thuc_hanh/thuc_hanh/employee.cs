using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuc_hanh
{
    class thisinh
    {
        public int sobaodanh {  get; set; }
        public string hoten {  get; set; }
        public string diachi {  get; set; }
        public double toan { get; set; }
        public double ly {  get; set; }
        public double hoa {  get; set; }
        public double diemuutien {  get; set; }

        //tên biến và phương thức 2 tên này đặt khác nhau
        
        public void nhapthisinh()
        {
            Console.Write("so bao danh: ");
            sobaodanh= Convert.ToInt32(Console.ReadLine());
            Console.Write("ho ten: ");
            hoten = Convert.ToString(Console.ReadLine());
            Console.Write("dia chi: ");
            diachi = Convert.ToString(Console.ReadLine());
            Console.Write("toan= ");
            toan = Convert.ToDouble(Console.ReadLine());
            Console.Write("ly= ");
            ly = Convert.ToDouble(Console.ReadLine());
            Console.Write("hoa= ");
            hoa = Convert.ToDouble(Console.ReadLine());
            Console.Write("diem uu tien= ");
            diemuutien = Convert.ToDouble(Console.ReadLine());

        }

        public void xuat()
        {
            Console.WriteLine($"{sobaodanh,5} {hoten,20} {diachi,15} {toan,15} {ly,15} {hoa,15} {diemuutien,15} {tongdiem(),15}");
        }

        public double tongdiem()
        {
            return Math.Round(toan + ly + hoa + diemuutien, 3);
        }
    }
}
