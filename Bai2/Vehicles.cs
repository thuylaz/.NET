namespace BaiTap
{
    internal class Vehicles : IVehicle, IComparable<Vehicles>
    {
        public string id { get; set; }
        public string maker { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public double price { get; set; }

        public Vehicles()
        {
            id = "";
            maker = "";
            model = "";
            year = 0;
            price = 0;
        }
        public Vehicles(string id)
        {
            this.id = id;
            maker = "";
            model = "";
            year = 0;
            price = 0;
        }
        public Vehicles(string id, string marker, string model, int year, double price)
        {
            this.id = id;
            this.maker = marker;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public virtual void Input()
        {
            Console.Write("Nhập id: ");
            id = Console.ReadLine();
            Console.Write("Nhập hãng sản xuất: ");
            maker = Console.ReadLine();
            Console.Write("Nhập tên xe(model): ");
            model = Console.ReadLine();
            Console.Write("Nhập năm sản xuất: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("Nhập giá tiền: ");
            price = double.Parse(Console.ReadLine());
        }

        public static void inTieuDe()
        {
            Console.Write("{0,-15}{1,-15}{2,-15}{3,15}{4,15}", "ID", "Hãng sản xuất", "Tên xe", "Năm sản xuất", "Giá tiền");
        }

        public virtual void Output()
        {
            Console.Write(this);
        }

        public override bool Equals(object obj)
        {
            Vehicles v = (Vehicles)obj;
            return (this.id.Equals(v.id));
        }

        public override string ToString()
        {
            return String.Format("{0,-15}{1,-15}{2,-15}{3,15}{4,15}", id, maker, model, year, price);
        }

        //Hàm so sánh theo giá
        public int CompareTo(Vehicles? other)
        {
            Vehicles v = (Vehicles)other;
            return this.price.CompareTo(v.price);
        }
    }

    class YearComparer : IComparer<Vehicles>
    {
        public int Compare(Vehicles x, Vehicles y)
        {
            return x.year - y.year;
        }
    }
}
