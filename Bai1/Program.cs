using BaiTap;


class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        List<Student> students = new List<Student>();

        int chon;
        do
        {
            Console.WriteLine("========QUẢN LÝ SINH VIÊN========");
            Console.WriteLine("1. Thêm một sinh viên");
            Console.WriteLine("2. Hiển thị danh sách sinh viên");
            Console.WriteLine("3. Tìm kiếm sinh viên theo id");
            Console.WriteLine("4. Tìm kiếm sinh viên theo address");
            Console.WriteLine("5. Xoá một sinh viên theo id");
            Console.WriteLine("6. Kết thúc chương trình");

            Console.Write("Nhập lựa chọn của bạn: ");
            chon = int.Parse(Console.ReadLine());
            switch (chon)
            {
                case 1:
                    NhapSV(students);
                    break;
                case 2:
                    Console.WriteLine("------------DANH SÁCH SINH VIÊN------------");
                    HienThiSV(students);
                    break;
                case 3:
                    TimKiemTheoID(students);
                    break;
                case 4:
                    TimKiemTheoAddress(students);
                    break;
                case 5:
                    Xoa(students);
                    break;
                default:
                    break;
            }
        } while (chon != 6);
    }

    //1. Thêm 1 sinh viên
    public static void NhapSV(List<Student> students)
    {
        Student sv = new Student();
        sv.Input();
        students.Add(sv);
    }

    //2. Hiển thị danh sách sinh viên
    public static void HienThiSV(List<Student> students)
    {
        Student.inTieuDe();
        foreach (Student sv in students)
            sv.Output();
    }

    //3. Tìm kiếm sinh viên theo id
    public static void TimKiemTheoID(List<Student> students)
    {
        Console.Write("Nhập id cần tìm: ");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("=>Sinh viên có id {0} là: ", id);
        Student.inTieuDe();
        foreach (Student sv in students)
            if (sv.id == id)
                sv.Output();
    }

    //4. Tìm kiếm sinh viên theo address
    public static void TimKiemTheoAddress(List<Student> students)
    {
        Console.Write("Nhập địa chỉ cần tìm: ");
        string diaChi = Console.ReadLine();
        Console.WriteLine("=>Sinh viên có địa chỉ {0} là: ", diaChi);
        Student.inTieuDe();
        foreach (Student sv in students)
            if (sv.address == diaChi)
                sv.Output();
    }

    //5. Xoá một sinh viên theo id
    public static void Xoa(List<Student> students)
    {
        Console.Write("Nhập id cần xoá: ");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("------------DANH SÁCH SINH VIÊN SAU KHI XOÁ------------");
        foreach (Student sv in students)
            if (sv.id == id)
            {
                students.Remove(sv);
                break;
            }
        HienThiSV(students);
    }
}