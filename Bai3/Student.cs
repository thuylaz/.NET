namespace BaiTap
{
    internal class Student
    {
        public int studentID { get; set; }
        public string name { get; set; }
        public string mark { get; set; }

        public void InputStudent()
        {
            Console.Write("Nhập id: ");
            studentID = int.Parse(Console.ReadLine());
            Console.Write("Nhập tên: ");
            name = Console.ReadLine();
            Console.Write("Nhập điểm thi: ");
            mark = Console.ReadLine();
        }

        public static void inTieuDe()
        {
            Console.WriteLine("{0,-10}{1,-15}{2,15}", "ID", "Tên", "Điểm");
        }

        public override string ToString()
        {
            return String.Format("{0,-10}{1,-15}{2,15}", studentID, name, mark);
        }
    }
}
