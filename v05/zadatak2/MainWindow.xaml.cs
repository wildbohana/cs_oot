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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int brojac = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Generisanje(object sender, RoutedEventArgs e)
        {
            if (this.Ime.Text == "" && this.Prezime.Text == "")
                MessageBox.Show("Unesite vrednosti za ime i prezime.", "Greška!", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                Random rand = new Random();
                this.KorisnickoIme.Text = this.Ime.Text + this.Prezime.Text + rand.Next();
            }
        }

        private void Brisanje(object sender, RoutedEventArgs e)
        {
            this.KorisnickoIme.Text = this.Ime.Text = this.Prezime.Text = "";

			/*
			ime.Clear();
            prezime.Clear();
            izgenerisano.Clear();
			*/
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            if (this.Ime.Text == "" && this.Prezime.Text == "")
			{
                MessageBox.Show("Unesite vrednosti za ime i prezime", "Greška!", MessageBoxButton.OK, MessageBoxImage.Error);
			}
            else
			{
				this.Sacuvano.Text = this.KorisnickoIme.Text;
				this.brojac++;
	            this.Broj.Text = this.brojac.ToString();
			}
        }

    }
}
