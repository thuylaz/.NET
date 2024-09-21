namespace BaiTap
{
    internal class Car:Vehicles
    {
        public string color { get; set; }

        public Car():base()
        {
            color = "";
        }
        public Car(string id, string maker, string model, int year, double price, string color):base(id,maker,model, year,price)
        {
            this.color = color;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhập màu sắc: ");
            color = Console.ReadLine();
        }

        public static void inTieuDe()
        {
            Vehicles.inTieuDe();
            Console.WriteLine("{0,15}", "Màu sắc");
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("{0,15}", color);
        }
    }
}
