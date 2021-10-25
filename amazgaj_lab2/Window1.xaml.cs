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
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private string cena_val;
        private int polisa_;
        private int cena_;

        private string summary => (cena_ + polisa_).ToString();
        public Window1()
        {
            InitializeComponent();
        }

        private void Mustang_Checked(object sender, RoutedEventArgs e)
        {
                cena_ += 300000;
                cena.Content = summary;
        }
        private void Mustang_Unchecked(object sender, RoutedEventArgs e)
        {
            cena_ -= 300000;
            cena.Content = summary;
        }

        private void Ferrari_Checked(object sender, RoutedEventArgs e)
        {
            cena_ += 1000000;
            cena.Content = summary;
        }
        private void Ferrari_Unchecked(object sender, RoutedEventArgs e)
        {
            cena_ -= 1000000;
            cena.Content = summary;
        }

        private void Porche_Checked(object sender, RoutedEventArgs e)
        {
            cena_ += 800000;
            cena.Content = summary;
        }
        private void Porche_Unchecked(object sender, RoutedEventArgs e)
        {
            cena_ -= 800000;
            cena.Content = summary;
        }
 
        private void Polisa_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(polisa.Text))
            {
                polisa_ = 0;
            }
            else
            {
                int.TryParse(polisa.Text, out polisa_);
            }
            if (cena != null)
            {
                cena.Content = (cena_ + polisa_).ToString();
            }
        }

        private void Przyciemniane_szyby_Checked(object sender, RoutedEventArgs e)
        {

            cena_ = (cena_ + 3000);
            cena.Content = summary;

        }

        private void Przyciemniane_szyby_Unchecked(object sender, RoutedEventArgs e)
        {

            cena_ = (cena_ - 3000);
            cena.Content = summary;
        }

        private void Klimatyzacja_Checked(object sender, RoutedEventArgs e)
        {
            cena_ = (cena_ + 4000);
            cena.Content = summary;
        }
        private void Klimatyzacja_Unchecked(object sender, RoutedEventArgs e)
        {
            cena_ = (cena_ - 4000);
            cena.Content = summary;
        }

        private void Nawigacja_Checked(object sender, RoutedEventArgs e)
        {
            cena_ = (cena_ + 5000);
            cena.Content = summary;
        }
        private void Nawigacja_Unchecked(object sender, RoutedEventArgs e)
        {
            cena_ = (cena_ - 5000);
            cena.Content = summary;
        }

        private void Radio_Checked(object sender, RoutedEventArgs e)
        {
            cena_ = (cena_ + 3000);
            cena.Content = summary;
        }
        private void Radio_Unchecked(object sender, RoutedEventArgs e)
        {
            cena_ = (cena_ - 3000);
            cena.Content = summary;
        }

        private void Powrot_Click(object sender, RoutedEventArgs e)
        {
            cena_val = cena.Content.ToString();
            MainWindow mw = new MainWindow (cena_val);
            mw.Show();
            cena.Content = "0";
            this.Close();
        }
    }
}
