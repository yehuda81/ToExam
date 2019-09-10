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

namespace ToExam5
{
    /// <summary>
    /// Interaction logic for UserControlCustomize.xaml
    /// </summary>
    public partial class UserControlCustomize : UserControl
    {
        List<Order> orders = new List<Order>();
        public UserControlCustomize()
        {
            InitializeComponent();
            this.DataContext = this;
            orders.Add(new Order(1, "Yehuda", "Reisner", 38, "yudale81@gmail.com", true, 33.4f, Myenum.New));
            orders.Add(new Order(2, "Sivan", "Reisner", 35, "Sivanbo55@gmail.com", false, 22.1f, Myenum.Processing));
            orders.Add(new Order(3, "Lior", "Reisner", 1, "", true, 65.3f, Myenum.Shipped));
            DG.ItemsSource = orders;
        }
    }
}
