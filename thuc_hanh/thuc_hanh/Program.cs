using System;
using System.Runtime.InteropServices;

namespace thuc_hanh
{
    class program
    {
        static List<thisinh> list = new List<thisinh>();
        public static void title()
        {
            Console.WriteLine($"{"sbd",5} {"ho ten", 15} {"dia chi", 10} {"toan", 10} {"ly", 10} {"hoa", 10} {"diem uu tien", 10} ");
        }

        public static void addthisinh()
        {
            thisinh ts = new thisinh();
            ts.nhapthisinh();
            list.Add(ts);
        }
    }
}