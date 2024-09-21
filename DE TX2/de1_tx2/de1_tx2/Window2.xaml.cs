using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace de1_tx2
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private string hoten, loainv;
        private DateTime ngaysinh;
        private double tienban;
        public Window2()
        {
            InitializeComponent();
        }

        private void Window2_Load(object sender, EventArgs e)
        {
            txthoten2.Text = hoten;
            cboloai2.Text = loainv;
            datengay2.Text=ngaysinh.ToString();
            txttien2.Text = tienban.ToString();
            
        }

        public Window2(string hoten, string loainv, DateTime ngaysinh, double tienban)
        {
            InitializeComponent();
            this.hoten = hoten;
            this.loainv = loainv;
            this.tienban = tienban;
            this.ngaysinh = ngaysinh;
        }




    }
}
