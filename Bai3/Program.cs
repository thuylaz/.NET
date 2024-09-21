using BaiTap;
class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        int chon;
        List<Course> courses = new List<Course>();
        do
        {
            Console.WriteLine("==================MENU===================");
            Console.WriteLine("1. Thêm 1 khoá học");
            Console.WriteLine("2. Hiển thị các khoá học");
            Console.WriteLine("3. Tìm kiếm khoá học");
            Console.WriteLine("4. Tìm kiếm sinh viên");
            Console.WriteLine("5. Xoá một khoá học");
            Console.WriteLine("6. Kết thúc chương trình");

            Console.Write("Nhập lựa chọn của bạn: ");
            chon = int.Parse(Console.ReadLine());
            switch (chon)
            {
                case 1:
                    ThemKhoaHoc(courses);
                    break;
                case 2:
                    Console.WriteLine("\t--------DANH SÁCH KHOÁ HỌC-------");
                    HienThiKhoaHoc(courses);
                    break;
                case 3:
                    TimKiemKhoaHoc(courses);
                    break;
                case 4:
                    TimKiemSinhVien(courses);
                    break;
                case 5:
                    XoaKhoaHoc(courses);
                    break;
                default:
                    break;
            }
        } while (chon != 6);
    }

    //1. Thêm 1 khoá học
    public static void ThemKhoaHoc(List<Course> courses)
    {
        Course kh = new Course();
        kh.InputCourse();
        courses.Add(kh);
    }

    //2. Hiển thị các khoá học
    public static void HienThiKhoaHoc(List<Course> courses)
    {
        foreach (Course c in courses)
            c.DisplayCourseAndStudents();
    }

    //3. Tìm kiếm khoá học
    public static void TimKiemKhoaHoc(List<Course> courses)
    {
        Console.Write("Nhập mã khoá học cần tìm: ");
        string id = Console.ReadLine();

        Console.WriteLine("=>Thông tin khoá học có mã {0} là: ", id);
        foreach (Course c in courses)
            if (c.courseID == id)
                c.DisplayCourseAndStudents();
    }

    //4. Tìm kiếm sinh viên
    public static void TimKiemSinhVien(List<Course> courses)
    {
        Console.Write("Nhập mã sinh viên cần tìm: ");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("=>Thông tin sinh viên có mã {0} là: ", id);
        Student.inTieuDe();
        foreach (Course c in courses)
            foreach (Student sv in c.GetAllStudents())
            {
                if (sv.studentID == id)
                {
                    Console.WriteLine(sv);break;
                }
                    
                else Console.WriteLine("khong tim thay");
            }


    }

    //5. Xoá một khoá học
    public static void XoaKhoaHoc(List<Course> courses)
    {
        Console.Write("Nhập mã khoá học cần xoá: ");
        string id = Console.ReadLine();
    
        for (int i=0; i<courses.Count; i++)
            if (courses[i].courseID == id)
                courses.Remove(courses[i]);

        Console.WriteLine("\t--------DANH SÁCH KHOÁ HỌC SAU KHI XOÁ-------");
        HienThiKhoaHoc(courses);
    }
}
