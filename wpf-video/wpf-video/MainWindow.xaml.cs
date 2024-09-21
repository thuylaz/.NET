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

namespace wpf_video
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

        private void butxem_Click(object sender, RoutedEventArgs e)
        {
            string strMessage, strHoTen, strTitle, strngoaingu="";
            strHoTen = txthodem.Text + " " + txtten.Text;
            if(radioNam.IsChecked== true )
            {
                strTitle = "Mr.";

            }
            else
            {
                strTitle = "Miss/Mrs.";
            }
            strMessage ="Xin Chào "+ strTitle + "" + strHoTen;
            if(chkAnh.IsChecked== true )
            {
                strngoaingu = "Tiếng anh";
            }
            if (chkTrung.IsChecked == true)
            {
                strngoaingu = (strngoaingu.Length == 0) ? "Tiếng Trung" : (strngoaingu + "Và tiếng trung");
            }
            strMessage += "\nNgoại ngữ: " + strngoaingu;
            if (cboque.SelectedIndex >= 0)
            {
                strMessage += "\nQuê quán: " + cboque.Text;
            }
            MessageBox.Show(strMessage);
        }

        private void butnhap_Click(object sender, RoutedEventArgs e)
        {
            txthodem.Text = "";
            txtten.Text = "";
            radioNam.IsChecked = true;
            radioNu.IsChecked = false;
            chkAnh.IsChecked= false;
            chkTrung.IsChecked= false;
            cboque.SelectedIndex = 0;
        }
    }
}
