using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace detx2cn
{
    class sinhvien
    {
        public string masv { get; set; }
        public string hoten { get; set; }
        public int solanxs { get; set; }
        public string tenkhoa { get; set; }
        public double tienthuong { get; set; }

        public sinhvien()
        {

        }
        public sinhvien(string masv, string hoten, int solanxs, string tenkhoa, double tienthuong)
        {
            this.masv = masv;
            this.hoten = hoten;
            this.solanxs = solanxs;
            this.tenkhoa = tenkhoa;
            this.tienthuong = tienthuong;
        }
    }
}
