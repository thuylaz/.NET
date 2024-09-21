namespace BaiTap
{
    internal class Truck:Vehicles
    {
        public int truckload { get; set; }

        public Truck() : base()
        {
            truckload = 0;
        }
        public Truck(string id, string maker, string model, int year, double price, int truckload) : base(id, maker, model, year, price)
        {
            this.truckload = truckload;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhập tải trọng: ");
            truckload = int.Parse(Console.ReadLine());
        }

        public static void inTieuDe()
        {
            Vehicles.inTieuDe();
            Console.WriteLine("{0,15}", "Tải trọng");
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("{0,15}", truckload);
        }
    }
}
