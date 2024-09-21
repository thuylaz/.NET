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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace de1_tx2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void xoa()
        {
            txthoten.Text = "";
            txttien.Text = "";
            cboloai.Text = null;
            datengay.Text = null;
        }

        private void butnhap_Click(object sender, RoutedEventArgs e)
        {
            TimeSpan time = DateTime.Now - datengay.SelectedDate.Value;
            double tuoi = double.Parse((time.TotalDays / 365).ToString());

            double tienban = double.Parse(txttien.Text);
            double hoahong = 0;
            if (tienban >= 1000 && tienban <= 5000)
            {
                hoahong = tienban * 0.05;
            }
            else if (tienban > 5000)
            {
                hoahong = tienban * 0.1;
            }

            if (txthoten.Text != "" && txttien.Text != "" && cboloai.Text != "" && datengay.Text != "")
            {
                try
                {
                    double tien=double.Parse(txttien.Text);
                    if(tien <= 0)
                    {
                        MessageBox.Show("tien luong khong hop le");
                    }
                    else
                    {
                        listnv.Items.Add(txthoten.Text + "-" + datengay.Text + "-" + cboloai.Text + "-" + txttien.Text + "-" + hoahong);
                    }
                }
                catch(FormatException)
                {
                    MessageBox.Show("nhap sai du lieu");
                }
            }
            else
            {
                MessageBox.Show("nhap chua du thong tin");
            }

            
            



            //listnv.Items.Add(txthoten.Text + "-" + datengay.Text + "-" + cboloai.Text + "-" + txttien.Text + "-" + hoahong);
        }

        private void butxoa_Click(object sender, RoutedEventArgs e)
        {
            //if (listnv.SelectedItems.Count == 0) throw new Exception("Không có mục list box nào dc chọn"); ;
            xoa();
            txthoten.Focus();
            listnv.Items.Remove(listnv.SelectedItems);
        }

        private void butwindow2_Click(object sender, RoutedEventArgs e)
        {
            double tienban = double.Parse(txttien.Text);

            Window2 window2 =new Window2(txthoten.Text,cboloai.Text, datengay.SelectedDate.Value, tienban);
            //Employee employee = listnv.SelectedItem as Employee;
            this.Hide();
            window2.ShowDialog();
        }

    }
}
