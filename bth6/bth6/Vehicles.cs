using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bth6
{
    class Vehicles : IVehicle
    {
        public string Id {  get; set; }
        public string marker {  get; set; }
        public string model {  get; set; }
        public int year {  get; set; }
        public double price {  get; set; }

        //phuong thuc khoi tao 0 tham so
        public Vehicles()
        {

        }

        //phuong thuc khoi tao 1 tham so
        public Vehicles(string Id)
        {
            this.Id = Id;
        }

        //phuong thuc khoi tao 5 tham so
        public Vehicles(string Id, string marker, string model, int year, double price)
        {
            this.Id = Id;
            this.marker = marker;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public virtual void Input()
        {
            Console.Write("id= "); Id = Console.ReadLine();
            Console.Write("marker= "); marker = Console.ReadLine();
            Console.Write("model= "); model = Console.ReadLine();
            Console.Write("year= "); year = int.Parse(Console.ReadLine());
            Console.Write("price= "); price = double.Parse(Console.ReadLine());

        }

        public virtual void Output()
        {
            Console.WriteLine("===output===");
            Console.WriteLine("Id: "+Id);
            Console.WriteLine("marker: " + marker);
            Console.WriteLine("model: " + model);
            Console.WriteLine("year: " + year);
            Console.WriteLine("price: " + price);

        }

        public override string ToString()
        {
            return string.Format("{0,-8}{1,-10}{2,-25}{3,10}{4,10}", Id, marker, model, year, price);
        }
    }
}
