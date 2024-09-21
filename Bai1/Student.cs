namespace BaiTap
{
    internal class Student : Person
    {
        public byte maths { get; set; }
        public byte physics { get; set; }

        public Student() : base()
        {
            maths = physics = 0;
        }
        public Student(string name, string address, byte maths, byte physics) : base(name, address)
        {
            this.maths = maths;
            this.physics = physics;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhập điểm Toán: ");
            maths = byte.Parse(Console.ReadLine());
            Console.Write("Nhập điểm Lý: ");
            physics = byte.Parse(Console.ReadLine());
        }

        public static void inTieuDe()
        {
            Person.inTieuDe();
            Console.WriteLine("{0,-15}{1,-15}{2,-15}", "Điểm Toán", "Điểm Lý", "Tổng điểm");
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("{0,-15}{1,-15}{2,-15}", maths, physics, Total());
        }

        public byte Total()
        {
            return (byte)(maths + physics);
        }
    }
}