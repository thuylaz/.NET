using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bth6
{
    class ssprice : IComparer<Vehicles>
    {
        public int Compare(Vehicles x, Vehicles y)
        {
            return x.price.CompareTo(y.price);
        }
    }
    class Program
    {
        static List<Vehicles> list = new List<Vehicles>();

        static void nhapthongtin()
        {
            Console.WriteLine("nhap dl car");
            for (int i = 0; i < 1; i++)
            {
                Car car = new Car();
                car.Input();
                list.Add(car);
            }

            Console.WriteLine("nhap dl truck");
            for (int i = 0; i < 1; i++)
            {
                Truck truck = new Truck();
                truck.Input();
                list.Add(truck);
            }
        }

        static void hienthitt()
        {
            if(list.Count == 0) Console.WriteLine("danh sach trong");
            foreach (Vehicles vehicle in list)
            {
                vehicle.Output();
            }
        }

        static void timid()
        {
            if (list.Count == 0) Console.WriteLine("danh sach rong");
            Console.Write("nhap id can tim: "); string id = Console.ReadLine();
            foreach (var item in list)
            {
                if (item.Id.Equals(id))
                {
                    item.Output();
                    break;
                }
                else Console.WriteLine("khong tim thay");
            }          
        }

        static void timmarker()
        {
            if (list.Count == 0) Console.WriteLine("danh sach rong");
            Console.Write("nhap marker can tim: "); string marker = Console.ReadLine();
            foreach(var item in list)
            {
                if (item.Id.Equals(marker))
                {
                    item.Output();
                    break;
                }else Console.WriteLine("khong tim thay");
            }
        }

        

        static void ssvegia()
        {
            Console.WriteLine("ham truoc khi sap xep");
            foreach (Vehicles vehicle in list)
            {
                vehicle.Output();
            }
            Console.WriteLine("ham sau khi sap xep");
            list.Sort(new ssprice());
            foreach (Vehicles vehicle in list)
            {
                vehicle.Output();
            }
        }
        
        static void Main(string[] args)
        {
            int choose;
            do
            {
                Console.WriteLine("1.nhap dl");
                Console.WriteLine("2.hien thi du lieu");
                Console.WriteLine("3.tim kiem theo id");
                Console.WriteLine("4.tim kiem theo marker");
                Console.WriteLine("5.sap xep theo price");
                Console.WriteLine("6.sap xep theo year");
                Console.WriteLine("7.ket thuc");
                Console.WriteLine("chon 1 lua chon");
                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        nhapthongtin();
                        //list.Add(new Car("car1", "h1", "cc", 2020, 3000, "blue"));
                        //list.Add(new Car("car2", "h2", "bt", 2018, 36000, "red"));
                        //list.Add(new Car("car3", "h3", "x", 2017, 30070, "black"));

                        //list.Add(new Truck("Truck1", "h4", "bt", 2021, 2000, 30));
                        //list.Add(new Truck("Truck2", "h5", "cc", 2003, 5000, 50));
                        //list.Add(new Truck("Truck3", "h6", "x", 2004, 31000, 70));

                        //Console.WriteLine("nhap dl Car");
                        //for (int i = 0; i < 1; i++)
                        //{
                        //    Car car = new Car();
                        //    car.Input();
                        //    list.Add(car);
                        //}
                        //Console.WriteLine("nhap dl Truck");
                        //for (int i = 0; i < 1; i++)
                        //{
                        //    Truck truck = new Truck();
                        //    truck.Input();
                        //    list.Add(truck);
                        //}

                        break;

                    case 2:
                        foreach (var item in list)
                        {
                            item.Output();
                        }
                        break;
                    case 3:
                        timid();
                        //Console.WriteLine("\n=====Tim kiem theo id=====");

                        //Console.Write("\nNhap id can tim kiem:  ");
                        //string id = Console.ReadLine();

                        //foreach (var item in list)
                        //{
                        //    if (item.Id.Equals(id))
                        //        item.Output();
                        //}

                        //Console.WriteLine("\nNhan \"Enter\" den tiep tuc");
                        //Console.ReadLine();
                     
                        break;
                    case 4:
                        timmarker();
                        break;
                    case 5:
                        ssvegia();
                        break;
                    case 6:
                        break;
                    case 7:
                        break;

                }

            } while (choose != 7);
        }
    }
}


/*
1
id1
xedep
honda
30
40
green
id2
xehoi
toyo
20
10
5

 */