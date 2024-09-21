namespace BaiTap
{
    internal class Course
    {
        public string courseID { get; set; }
        public string courseName { get; set; }
        public int fee { get; set; }
        public List<Student> listStd { get; set; }

        public Course()
        {
            listStd = new List<Student>();
            courseID = "";
            courseName = "";
            fee = 0;
        }

        public void InputCourse()
        {
            Console.Write("Nhập mã khoá học: ");
            courseID = Console.ReadLine();
            Console.Write("Nhập tên khoá học: ");
            courseName = Console.ReadLine();
            Console.Write("Nhập học phí: ");
            fee = int.Parse(Console.ReadLine());

            Console.Write("Nhập số lượng sinh viên: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Student student = new Student();
                Console.WriteLine("\tNhập sinh viên thứ {0}: ", (i+1));
                student.InputStudent();
                listStd.Add(student);
            }    
        }

        public void DisplayCourseAndStudents()
        {
            Console.WriteLine($"Mã Khoá học: {courseID}" +
                $"\nTên Khoá học: {courseName}" +
                $"\nHọc phí: {fee}");

            Console.WriteLine("----------Danh sách sinh viên-----------");
            Student.inTieuDe();
            foreach (Student student in listStd)
                Console.WriteLine(student);
        }

        public List<Student> GetAllStudents()
        {
            return listStd;
        }
    }
}
