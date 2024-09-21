using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bth6
{
    class Truck:Vehicles
    {
        public int trucload {  get; set; }
        public Truck():base() 
        { 

        }

        public Truck(string Id, string marker, string model, int year, double price, int trucload): base(Id, marker, model, year, price)
        {
            this.trucload = trucload;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("truckload: "); trucload=int.Parse(Console.ReadLine());

        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("truckload: " + trucload);
        }

        
    }
}
