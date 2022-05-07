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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // vrste operacija
        private enum Operacije
        {
            Nista,
            Sabiranje,
            Oduzimanje,
            Mnozenje,
            Deljenje
        }

        // polja
        private double prviOperand;
        private double drugiOperand;
        private Operacije operacija;

        public MainWindow()
        {
            InitializeComponent();
        }

		// klik na neku od operacija
        private void Klik1(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            if (rezultat.Text.ToString() == "0")
                rezultat.Text = button.Content.ToString();
            else
                rezultat.Text += button.Content.ToString();
        }
		
		// klik na dugme AC
        private void Rst(object sender, RoutedEventArgs e)
        {
            prviOperand = 0;
            drugiOperand = 0;
            rezultat.Text = "0";
            operacija = Operacije.Nista;
        }

		// klik na dugme =
        private void Jednako(object sender, RoutedEventArgs e)
        {
            drugiOperand = double.Parse(rezultat.Text);
            rezultat.Text = Racunanje(prviOperand, operacija, drugiOperand);
            prviOperand = double.Parse(rezultat.Text);
            operacija = Operacije.Nista;
        }

		// dugme = poziva funkciju Racunanje
        private string Racunanje(double prviOperand, Operacije trenutniOperator, double drugiOperand)
        {
            if (trenutniOperator == Operacije.Sabiranje)
                return Math.Round((prviOperand + drugiOperand), 4).ToString();

            else if (trenutniOperator == Operacije.Oduzimanje)
                return Math.Round((prviOperand - drugiOperand), 4).ToString();

            else if (trenutniOperator == Operacije.Mnozenje)
                return Math.Round((prviOperand * drugiOperand), 4).ToString();

            else if (trenutniOperator == Operacije.Deljenje)
                return Math.Round((prviOperand / drugiOperand), 4).ToString();

            else if (trenutniOperator == Operacije.Nista)
                return Math.Round((prviOperand), 4).ToString();

            else
                return "0";
        }

		// ako je kliknuta operacija +
        private void Plus(object sender, RoutedEventArgs e)
        {
            operacija = Operacije.Sabiranje;
            prviOperand = double.Parse(rezultat.Text);
            rezultat.Text = "0";
        }

		// ako je kliknuta operacija -
        private void Minus(object sender, RoutedEventArgs e)
        {
            operacija = Operacije.Oduzimanje;
            prviOperand = double.Parse(rezultat.Text);
            rezultat.Text = "0";
        }

        // ako je kliknuta operacija *
		private void Zvezda(object sender, RoutedEventArgs e)
        {
            operacija = Operacije.Mnozenje;
            prviOperand = double.Parse(rezultat.Text);
            rezultat.Text = "0";
        }

        // ako je kliknuta operacija /
		private void Kosa(object sender, RoutedEventArgs e)
        {
            operacija = Operacije.Deljenje;
            prviOperand = double.Parse(rezultat.Text);
            rezultat.Text = "0";
        }

        // ako je kliknuta operacija za menjanje znaka
		private void Znak(object sender, RoutedEventArgs e)
        {
            if (rezultat.Text != "0")
                rezultat.Text = (double.Parse(rezultat.Text) * -1).ToString();
        }

        // ako je kliknuta operacija za racunanje procenata
		private void Procenat(object sender, RoutedEventArgs e)
        {
            if (rezultat.Text != "0")
                rezultat.Text = (double.Parse(rezultat.Text) / 100).ToString();
        }

        // ako je kliknuta tacka za razlomljene brojeve
		private void Tacka(object sender, RoutedEventArgs e)
        {
            if (rezultat.Text.IndexOf('.') < 0)
                rezultat.Text += ".";
        }

    }
}
