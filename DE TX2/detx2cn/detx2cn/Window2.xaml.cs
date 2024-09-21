using System;
using System.Collections.Generic;
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

namespace detx2cn
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        public string masv, hoten, solanxs, tenkhoa;

        private void win2_load(object sender, RoutedEventArgs e)
        {
            txtmasv2.Text=masv;
            txthoten2.Text = hoten;
            txtsolan2.Text = solanxs;
            cbkhoa2.Text= tenkhoa;
        }

        public Window2(string masv, string hoten, string solanxs, string tenkhoa)
        {
            InitializeComponent();
            this.masv = masv;
            this.hoten = hoten;
            this.solanxs = solanxs;
            this.tenkhoa = tenkhoa;
        }

        private void thoat(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
