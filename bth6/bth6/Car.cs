using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bth6
{
    class Car:Vehicles
    {
        public string color { get; set; }

        public Car() : base()
        {
        }

        public Car(string Id, string marker, string model, int year, double price, string color) : base(Id, marker, model, year, price)
        {
            this.color = color;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("color: ");color= Console.ReadLine();
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("color: "+color);
        }
    }
}
