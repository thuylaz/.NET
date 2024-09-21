using BaiTap;
class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.OutputEncoding = System.Text.Encoding.Unicode;
            
        List<Vehicles> vehicles = new List<Vehicles>();

        int chon;
        do
        {
            Console.WriteLine("=========QUẢN LÝ PHƯƠNG TIỆN=========");
            Console.WriteLine("1. Nhập Dữ Liệu");
            Console.WriteLine("2. Hiển Thị Dữ Liệu");
            Console.WriteLine("3. Tìm Kiếm Theo ID");
            Console.WriteLine("4. Tìm Kiếm Theo Maker");
            Console.WriteLine("5. Sắp Xếp Theo Price");
            Console.WriteLine("6. Sắp Xếp Theo Year");
            Console.WriteLine("7. Kết Thúc");
            Console.Write("Mời bạn nhập lựa chọn: ");
            chon = int.Parse(Console.ReadLine());

            switch(chon)
            {
                case 1:
                    NhapDL(vehicles);
                    break;
                case 2:
                    Console.WriteLine("--------------------DANH SÁCH CÁC PHƯƠNG TIỆN--------------------");
                    HienThiDL(vehicles);
                    break;
                case 3: 
                    TimKiemTheoID(vehicles);
                    break;
                case 4:
                    TimKiemTheoMaker(vehicles);
                    break;
                case 5:
                    Console.WriteLine("----------DANH SÁCH CÁC PHƯƠNG TIỆN SAU KHI SẮP THEO GIÁ----------");
                    SapXepTheoPrice(vehicles);
                    break;
                case 6:
                    Console.WriteLine("----------DANH SÁCH CÁC PHƯƠNG TIỆN SAU KHI SẮP THEO NĂM----------");
                    SapXepTheoYear(vehicles);
                    break;
                default:
                    break;
            }    
        } while (chon != 7);
    }

    //1. Nhập Dữ Liệu
    public static void NhapDL(List<Vehicles> vehicles)
    {
        Console.WriteLine("\tNhập dữ liệu cho 3 Car: ");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("*Nhập dữ liệu cho car thứ {0}: ", (i + 1));
            Car car = new Car();
            car.Input();
            vehicles.Add(car);
        }

        Console.WriteLine("\tNhập dữ liệu cho 3 Truck: ");           
        for (int i = 0; i < 3; i++)
        {
            Truck truck = new Truck();
            Console.WriteLine("*Nhập dữ liệu cho truck thứ {0}: ", (i + 1));
            truck.Input();
            vehicles.Add(truck);
        }
    }

    //2. Hiển Thị Dữ Liệu
    public static void HienThiDL(List<Vehicles> vehicles)
    {
        Console.WriteLine("--Danh sách các Car: ");
        Car.inTieuDe();
        foreach(var pt in vehicles)
        {
            if (pt is Car)
                pt.Output();
        }

        Console.WriteLine("--Danh sách các Truck: ");
        Truck.inTieuDe();
        foreach (var pt in vehicles)
        {
            if (pt is Truck)
                pt.Output();
        }
    }

    //3. Tìm Kiếm Theo ID
    public static void TimKiemTheoID(List<Vehicles> vehicles)
    {
        Console.Write("Nhập ID cần tìm: ");
        string id = Console.ReadLine();
        Vehicles obj = new Vehicles(id);

        Console.WriteLine("\t=>Phương tiện có mã ID {0} là: ", id);
        foreach (var pt in vehicles)
            if (pt.Equals(obj))
            {
                if (pt is Car)
                    Car.inTieuDe();
                if (pt is Truck)
                    Truck.inTieuDe();
                pt.Output();
                break;
            }    
    }

    //4. Tìm Kiếm Theo Maker
    public static void TimKiemTheoMaker(List<Vehicles> vehicles)
    {
        Console.Write("Nhập hãng sản xuất cần tìm: ");
        string sx = Console.ReadLine();

        List<Car> cars = new List<Car>();
        List<Truck> trucks = new List<Truck>();

        Console.WriteLine("\t=>Phương tiện có hãng sản xuất {0} là: ", sx);
        foreach (var pt in vehicles)
        {
            if (pt.maker == sx)
            {
                if (pt is Car)
                    cars.Add((Car)pt);
                if (pt is Truck)
                    trucks.Add((Truck)pt);
            }
        }

        if (cars.Count > 0)
        {
            Car.inTieuDe();
            foreach (Car e1 in cars)
                e1.Output();
        }
        if (trucks.Count > 0)
        {
            Truck.inTieuDe();
            foreach (Truck e2 in trucks)
                e2.Output();
        }
    }

    //5. Sắp Xếp Theo Price
    public static void SapXepTheoPrice(List<Vehicles> vehicles)
    {
        vehicles.Sort();
        HienThiDL(vehicles);
    }

    //6. Sắp Xếp Theo Year
    public static void SapXepTheoYear(List<Vehicles> vehicles)
    {
        vehicles.Sort(new YearComparer());
        HienThiDL(vehicles);
    }
}
