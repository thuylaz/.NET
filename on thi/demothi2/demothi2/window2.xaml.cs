using demothi2.Models;
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

namespace demothi2
{
    /// <summary>
    /// Interaction logic for window2.xaml
    /// </summary>
    public partial class window2 : Window
    {
        public window2()
        {
            InitializeComponent();
        }

        private void win_loaded(object sender, RoutedEventArgs e)
        {
            QlsContext db = new QlsContext();
            var query = from p in db.Saches
                        join k in db.Nxbs
                        on p.Manxb equals k.Manxb
                        where p.Masach == "04"
                        select new
                        {
                            p.Masach,
                            p.Tensach,
                            p.Manxb,
                            p.Sotrang,
                            thanhtien = p.Sotrang * 8000
                        };
            dtg_win2.ItemsSource=query.ToList();

        }
    }
}
