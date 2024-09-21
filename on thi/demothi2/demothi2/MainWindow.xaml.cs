using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using demothi2.Models;
using System.Text.RegularExpressions;
using System.Reflection;
namespace demothi2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QlsContext db = new QlsContext();
        public MainWindow()
        {
            InitializeComponent();
        }

       //hien thi tu sql ra 
        private void hienthiCB() 
        {
            var query = from t in db.Nxbs
                        select t;
            cbnxb.ItemsSource = query.ToList();
            cbnxb.DisplayMemberPath = "Tennxb";
            cbnxb.SelectedValuePath = "Manxb";
            cbnxb.SelectedIndex = 0;
        }

        private void hienthiDL()
        {
            var query = from t in db.Saches
                        orderby t.Sotrang
                        select new
                        {
                            t.Masach,
                            t.Tensach,
                            t.Manxb,
                            t.Sotrang,
                            thanhtien = t.Sotrang * 8000
                        };
            dtg_sach.ItemsSource=query.ToList();
        }

        private void win_load(object sender, RoutedEventArgs e)
        {
            hienthiDL();
            hienthiCB();
        }

        //ham check du lieu
        private bool checkdl()
        {
            string tb = "";
            if (txtmasach.Text == "" || txttensach.Text == "" || txtsotrang.Text == "" || cbnxb.Text == "")
            {
                tb += "vui long nhap du du lieu";
            }
            if (!Regex.IsMatch(txtsotrang.Text, @"\d+"))
            {
                tb += "so trang nhap vao phai la so";
            }
            else
            {
                int sotrang = int.Parse(txtsotrang.Text);
                if(sotrang < 0)
                {
                    tb += "so trang nhap vaof phai la so duong";
                }
            }
            
            return true;
        }




        //them san pham
        private void btthem(object sender, RoutedEventArgs e)
        {
            var query = db.Saches.SingleOrDefault(t=>t.Masach.Equals(txtmasach.Text));
            if(query != null)
            {
                MessageBox.Show("ma sach nay ton tai", "thong bao");
                hienthiDL();
            }
            else
            {
                try
                {
                    if (checkdl())
                    {
                        Sach s = new Sach();
                        s.Masach = txtmasach.Text;
                        s.Tensach = txttensach.Text;
                        s.Sotrang = int.Parse(txtsotrang.Text);
                        Nxb itenmSelected = (Nxb)cbnxb.SelectedItem;
                        s.Manxb = itenmSelected.Manxb;
                        db.Saches.Add(s);
                        db.SaveChanges();
                        MessageBox.Show("them thanh cong", "thong bao");
                        hienthiDL();
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("co loi khi them");
                }
                
            }
        }


        //chon o bang de len giao dien
        private void dtg_select(object sender, SelectedCellsChangedEventArgs e)
        {
            if (dtg_sach.SelectedItem != null)
            {
                try
                {
                    Type t = dtg_sach.SelectedItem.GetType();
                    PropertyInfo[] p = t.GetProperties();
                    txtmasach.Text = p[0].GetValue(dtg_sach.SelectedValue).ToString();
                    txttensach.Text = p[1].GetValue(dtg_sach.SelectedValue).ToString();
                    cbnxb.SelectedValue = p[2].GetValue(dtg_sach.SelectedValue).ToString();
                    txtsotrang.Text = p[3].GetValue(dtg_sach.SelectedValue).ToString();
                    
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("co loi khi chon hang" + ex.Message, "thong bao");
                }
            }
        }

        //xoa san pham
        private void btxoa(object sender, RoutedEventArgs e)
        {
            var spxoa = db.Saches.SingleOrDefault(t => t.Masach.Equals(txtmasach.Text));
            if(spxoa != null)
            {
                db.Saches.Remove(spxoa);
                db.SaveChanges();
                hienthiDL();
            }
            else
            {
                MessageBox.Show("khong co san pham nay de xoa");
            }
        }


        //sua san pham
        private void btsua(object sender, RoutedEventArgs e)
        {
            var spsua = db.Saches.SingleOrDefault(t => t.Masach.Equals(txtmasach.Text));
            if(spsua != null)
            {
                spsua.Tensach = txttensach.Text;
                Nxb itemSelected=(Nxb)cbnxb.SelectedItem;
                spsua.Sotrang = int.Parse(txtsotrang.Text);
                db.SaveChanges();
                hienthiDL();

            }
            else
            {
                MessageBox.Show("khong tim thay san pham can sua");
            }
        }
        

        //tim san pham
        private void bttim(object sender, RoutedEventArgs e)
        {
            window2 w = new window2();
            w.Show();
        }





    }
}