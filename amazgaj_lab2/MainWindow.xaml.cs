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

namespace amazgaj_lab2
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

        private void marka_Click (object sender, RoutedEventArgs e)
        {
            Window1 w_1 = new Window1();
            w_1.Show();
        }

        private void silnik_Click(object sender, RoutedEventArgs e)
        {
            Window2 w_2 = new Window2();
            w_2.Show();
        }

    }
}
