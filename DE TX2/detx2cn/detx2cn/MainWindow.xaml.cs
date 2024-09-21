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

namespace detx2cn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<sinhvien> dssv=new List<sinhvien>();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void them_Click(object sender, RoutedEventArgs e)
        {          
            if (txtmasv.Text != "" && txthoten.Text != "")
            {
                try
                {
                    int solan=int.Parse(txtsolan.Text);
                    if (solan < 1)
                    {
                        MessageBox.Show("so lan khong hop le");
                    }
                    
                }
                catch (FormatException)
                {
                    MessageBox.Show("nhap sai du lieu");
                }
            }
            else
            {
                MessageBox.Show("vui long nhap du thong tin");
            }


            string ttdanhap=txtmasv.Text;
            bool datontai = false;
            foreach(sinhvien sv in dssv)
            {
                string tthientai = sv.masv;
                if (ttdanhap == tthientai)
                {
                    datontai = true;
                    break;
                }
            }
            if (datontai)
            {
                MessageBox.Show("masv da ton tai, nhap lai");
            }
            else
            {
                sinhvien sv1 = new sinhvien();
                sv1.masv= txtmasv.Text;
                sv1.hoten=txthoten.Text;
                sv1.solanxs = int.Parse(txtsolan.Text);
                string tenk = "";
                if (cbkhoa.Text == "1")
                {
                    tenk= "khoa cntt";
                }
                else if (cbkhoa.Text == "2")
                {
                    tenk= "khoa ngoai ngu";
                }
                else tenk = "khoa dien";
                sv1.tenkhoa = tenk;

                int tien=0;
                int sl = int.Parse(txtsolan.Text);
                if (sl >= 3) tien= 300000;
                else if (sl > 1 && sl < 3) tien = 150000;
                else tien = 0;
                sv1.tienthuong = tien;
                dssv.Add(sv1); 
                dtg1.ItemsSource = null;
                dtg1.ItemsSource = dssv;             
            }  
            

        }
            //xoa
            //for(int i = 0; i < dssv.Count(); i++)
            //    if (dssv[i].masv.Equals(txtmasv.Text))
            //        dssv.RemoveAt(i);

            //dtg1.ItemsSource = dssv;

        private void tim_Click(object sender, RoutedEventArgs e)
        {

            dtg1.ItemsSource = null;
            List<sinhvien> dssvcn = dssv.Where(sv => sv.tenkhoa == "khoa cntt").ToList();
            dtg1.ItemsSource= dssvcn;

        }

        private void dtg1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            sinhvien items=(sinhvien) dtg1.SelectedItem;
            txtmasv.Text=items.masv;
            txthoten.Text=items.hoten;
            txtsolan.Text=items.solanxs.ToString();
            cbkhoa.Text= items.tenkhoa;
        }

        private void win2(object sender, RoutedEventArgs e)
        {
            
            if(cbkhoa.Text=="khoa cntt")
            {

            }
            Window2 window2 = new Window2(txtmasv.Text,txthoten.Text,txtsolan.Text,cbkhoa.Text);
            this.Hide();
            window2.Show();
        }
    }
}
