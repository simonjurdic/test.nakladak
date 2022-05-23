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

namespace test.nakladak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Nakladak Mercedes;
        Nakladak Renault;
        public MainWindow()
        {
            InitializeComponent();
            Mercedes = new Nakladak();
            Mercedes.Jmeno = "Mercedes";
            Zobraz(Mercedes, txtBox1);

            Renault = new Nakladak();
            Renault.Jmeno = "Renault";
            Zobraz(Renault, txtBox2);
        }
        public void Zobraz(Nakladak nakladak, TextBox textBox)
        {
            textBox.Text = nakladak.Jmeno + " \n";
            textBox.Text += "Nosnost v kg: " + nakladak.Nosnost.ToString() + "\n";
            textBox.Text += "Palivo v nadrzi: " + nakladak.PalivoVNadrzi.ToString() + "\n";
            textBox.Text += "Spotreba Paliva l/km: " + nakladak.SpotrebaPaliva.ToString() + "\n";
            textBox.Text += "Celkova UjetaVzdalenost: " + nakladak.CelkovaUjetaVzdalenost.ToString() + "\n";
            textBox.Text += "Naklad: " + nakladak.Naklad.ToString() + "\n";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Mercedes.Nalozit();
            Zobraz(Mercedes, txtBox1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Renault.Nalozit();
            Zobraz(Renault, txtBox2);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Mercedes.Vylozit();
            Zobraz(Mercedes, txtBox1);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Renault.Vylozit();
            Zobraz(Renault, txtBox2);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Mercedes.Jet();
            Zobraz(Mercedes, txtBox1);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Mercedes.Natankovat();
            Zobraz(Mercedes, txtBox1);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Renault.Natankovat();
            Zobraz(Renault, txtBox2);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Renault.Jet();
            Zobraz(Renault, txtBox2);
        }
    }
}
