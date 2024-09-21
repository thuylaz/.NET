using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txca1
{
    class sx : IComparer<SinhVienDT>
    {
        public int Compare(SinhVienDT x, SinhVienDT y)
        {
            return x.tong().CompareTo(y.tong());
        }

    }



   
    class Program
    {
        static List<SinhVienDT> list=new List<SinhVienDT>();

        static void nhapthongtin()
        {
            Console.WriteLine("danh sach thong tin sinh vien la");
            
            SinhVienDT sv=new SinhVienDT();
            sv.nhap();
            list.Add(sv);
        }

        static void hienthi()
        {
            Console.WriteLine("+++++++++danh sach sinh vien++++++++");
            Console.WriteLine(" {0,-10} {1,-10} {2,-10} {3,-10} {4,-10} {5,-10} {6,-10}", "ma sv", "ho va ten", "python", "java", "english", "uutien", "tong diem");
            foreach(SinhVienDT sv in list)
            {
                sv.xuat();
            }
        }

        static void truotdo()
        {
            Console.Write("nhap diem du tuyen: ");
            double diemdutuyen=double.Parse(Console.ReadLine());
            foreach (SinhVienDT sv in list)
            {
                if (sv.tong(diemdutuyen) > diemdutuyen)
                {
                    
                    sv.xuat();
                    
                }
            }
            
        }

        static void timkiem()
        {
            Console.Write("nhap masv muon tim");
            string msv=Console.ReadLine();
            foreach (SinhVienDT sv in list)
            {
                if(sv.masv.Equals(msv))
                {
                    sv.xuat();break;
                }
                Console.WriteLine("khong co sv");
            } 
        }

        static void ss()
        {
            list.Sort(new sx());
            foreach (SinhVienDT sv in list)
            {
                sv.xuat();
            }

        }

        static void xoa()
        {
            Console.Write("nhap ma can xoa: ");
            string msv=Console.ReadLine();
            //Console.Write("nhap ten can xoa");

            for(int i=0; i<list.Count; i++)
            {
                if (list[i].masv == msv)
                    list.Remove(list[i]);
            }

            
            //SinhVienDT svv=new SinhVienDT();
            //foreach (SinhVienDT sv in list)
            //{
            //    if (sv.masv != msv)
            //    {
            //        Console.WriteLine("khong ton tai ma");
            //        break;

            //    }
            //    else
            //    {
            //        list.Remove(sv);
                    
            //    }
            //}
            hienthi();
        }
        static void Main(string[] args)
        {
            int choose;
            do
            {
                Console.WriteLine("1. nhap thong tin 1 sinh vien");
                Console.WriteLine("2. hien thi thong tin sinh vien");
                Console.WriteLine("3. tra danh sach sv do");
                Console.WriteLine("4. tim kiem theo ma sv");
                Console.WriteLine("5. thoat");
                Console.Write("moi nhap lua chon: ");
                choose=int.Parse(Console.ReadLine());

                switch (choose){
                    case 1:
                        nhapthongtin();
                        break;
                    case 2:
                        hienthi();
                        break;
                    case 3:
                        truotdo();
                        break;
                    case 4:
                        timkiem();
                        break;
                    case 5:
                        ss();
                        break;
                    case 6:
                        xoa();
                        break;
                    case 7:
                        break;
                }


            } while (choose!=7);
        }
    }
}

/*
1
sv1
thuy
3
4
5
0,5
1
sv2
nhung
8
2
8,5
1
2
  
*/
