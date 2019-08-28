﻿using System;
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

namespace ToExam6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetValue(PassProperty, false);            
        }
        public bool Pass
        {
            get
            {
                return (bool)GetValue(PassProperty);
            }
            set
            {
                SetValue(PassProperty, value);
            }
        }


        public static readonly DependencyProperty PassProperty =
        DependencyProperty.Register("Pass", typeof(bool), typeof(MainWindow), new PropertyMetadata(false));

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (UserTXT.Text == "Admin" && PasswordTXT.Text == "1234")
            {
                SetValue(PassProperty, true);
            }  
            else
            {
                SetValue(PassProperty, false);
            }
           
        }
    }
}
