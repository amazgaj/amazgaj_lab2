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

namespace amazgaj_lab2
{
    /// <summary>
    /// Logika interakcji dla klasy Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private string cena_val;
        private string cena_prev;
        private int power_;
        private int cena_;
        private string summary_ => (cena_ + 12*power_).ToString();

        public Window2(string previous)
        {
            InitializeComponent();
            cena_prev = previous;
        }

        private void ComboBox_SelectionChanged(object sender, EventArgs e)
        {
            power_ = Int32.Parse((sender as ComboBox).Text);
            cena.Content = summary_;
        }
        private void Hybryda_Checked(object sender, RoutedEventArgs e)
        {
            cena_ += 20000;
            cena.Content = summary_;
        }

        private void Hybryda_Unchecked(object sender, RoutedEventArgs e)
        {
            cena_ -= 20000;
            cena.Content = summary_;
        }

        private void Gaz_Checked(object sender, RoutedEventArgs e)
        {
            cena_ += 17000;
            cena.Content = summary_;
        }

        private void Gaz_Unchecked(object sender, RoutedEventArgs e)
        {
            cena_ -= 17000;
            cena.Content = summary_;
        }

        private void Benzyna_Checked(object sender, RoutedEventArgs e)
        {
            cena_ += 10000;
            cena.Content = summary_;
        }

        private void Benzyna_Unchecked(object sender, RoutedEventArgs e)
        {
            cena_ -= 10000;
            cena.Content = summary_;
        }

        private void Diesel_Checked(object sender, RoutedEventArgs e)
        {
            cena_ += 15000;
            cena.Content = summary_;
        }

        private void Diesel_Unchecked(object sender, RoutedEventArgs e)
        {
            cena_ -= 15000;
            cena.Content = summary_;
        }

        private void Powrot_Click(object sender, RoutedEventArgs e)
        {
            cena_val = cena.Content.ToString();
            MainWindow mw = new MainWindow(cena_val,cena_prev);
            mw.Show();
            cena.Content = "0";
            this.Close();
        }
    }
}