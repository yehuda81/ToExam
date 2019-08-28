using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TaskProgramming2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                for (int i = 50; i >= 0; i--)
                {
                    Action action = new Action(()=> tBox.Text = i.ToString());
                    //Dispatcher.BeginInvoke(action);
                    SafeInvoke(action);
                    Thread.Sleep(250);
                }
            });
        }
        public void SafeInvoke(Action action)
        {
            if (Dispatcher.CheckAccess())
            {
                action.Invoke();
                return;
            }
            else
            {
                this.Dispatcher.BeginInvoke(action);
            }
        }
    }
}
