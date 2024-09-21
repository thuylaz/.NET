namespace BaiTap
{
    internal class Person
    {
        static private int _id = 0;
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public Person()
        {
            _id++;
            id = _id;
            name = "";
            address = "";
        }
        public Person(string name, string address)
        {
            _id++;
            id = _id;
            this.name = name;
            this.address = address;
        }
        public virtual void Input()
        {
            Console.Write("Nhập tên: ");
            name = Console.ReadLine();
            Console.Write("Nhập địa chỉ: ");
            address = Console.ReadLine();
        }
        public static void inTieuDe()
        {
            Console.Write("{0,-10}{1,-15}{2,-16}", "ID", "Tên", "Địa chỉ");
        }
        public virtual void Output()
        {
            Console.Write("{0,-10}{1,-15}{2,-16}", id, name, address);
        }
    }
}
