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

namespace WpfApp3
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

        private static int counter = 0;
		
		// public static int Counter { get => counter; set => counter = value; }
        
		// može se dodati i Property za ovo polje, ali nije neophodno
        // radi sve dok se ne koristi this.counter, onda se buni

		// iz nekog razloga ovo ne radi -> samo counter u definiciji inicijalizuj na 0 i tjt
        /*
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.counter = 0;
        }
        */

        private void Izgenerisi_Click(object sender, RoutedEventArgs e)
        {
            if (this.Ime.Text == "" && this.Prezime.Text == "")
            {
                // MessageBox.Show(šta hoćeš da piše u prozoru, naziv prozora, dugme, slika)
                MessageBox.Show("Unesite vrednosti za ime i prezime", "Unos", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Random rand = new Random();
                int broj = rand.Next(1, 500);

                // ako je neoznačen ComboBox, vratiće nam vrednost -1
                if (this.VrstaKorisnikaCB.SelectedIndex == -1)
                    this.KorisnickoIme.Text = this.Ime.Text + this.Prezime.Text + broj;
                // ako je označen prvi od ponuđenih iz opadajuće liste, vratiće nam 0
                else if (this.VrstaKorisnikaCB.SelectedIndex == 0)
                    this.KorisnickoIme.Text = this.Ime.Text + this.Prezime.Text + 'R' + broj;
                // ako nije nešto od ova dva, onda je sigurno selektovan drugi ponuđeni
                else
                    this.KorisnickoIme.Text = this.Ime.Text + this.Prezime.Text + 'S' + broj;

                // Koriscenje RadioButton-a i CheckBox-a //

                // RadioButton - istovremeno može biti samo jednan selektovanan (zato ide if - else if za proveru)
                if (this.RB1.IsChecked == true)
                    MessageBox.Show("Kategorija je A");
                else if (this.RB2.IsChecked == true)
                    MessageBox.Show("Kategorija je B");
                else if (this.RB3.IsChecked == true)
                    MessageBox.Show("Kategorija je B");

                // CheckBox - istovremeno može biti više selektovanih (zato ide if - if za proveru)
                string ispis = "Osobine su: ";
                if (this.CB1.IsChecked == true)
                    ispis += "D ";
                if (this.CB2.IsChecked == true)
                    ispis += "E ";
                if (this.CB3.IsChecked == true)
                    ispis += "F";

                MessageBox.Show(ispis, "Informacije o osobinama", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Osvezi_Click(object sender, RoutedEventArgs e)
        {
            this.KorisnickoIme.Text = this.Ime.Text = this.Prezime.Text = "";

            // dodato - ako se ne napiše, ostaće štiklirane vrednosti i posle osvežavanja
            this.RB1.IsChecked = this.RB2.IsChecked = this.RB3.IsChecked = false;
            this.CB1.IsChecked = this.CB2.IsChecked = this.CB3.IsChecked = false;
            this.VrstaKorisnikaCB.SelectedIndex = -1;
        }

        private void Sacuvaj_Click(object sender, RoutedEventArgs e)
        {
            if (this.Ime.Text == "" && this.Prezime.Text == "")
                MessageBox.Show("Unesite vrednosti za ime i prezime", "Unos", MessageBoxButton.OK, MessageBoxImage.Error);
            else
                this.Sacuvano.Text = this.KorisnickoIme.Text;
        }

        private void Sacuvano_TextChanged(object sender, TextChangedEventArgs e)
        {
            counter++;
            this.Broj.Text = counter.ToString();
        }

        private void Resetuj_Click(object sender, RoutedEventArgs e)
        {
            // samo counter, ne this.counter !!!
            counter = 0;

            // Može i Ime.Clear(); Prezime.Clear(); Lozinka.Clear(); Broj.Clear(); KorisnickoIme.Clear();
            this.Ime.Text = this.Prezime.Text = this.Sacuvano.Text = this.Lozinka.Password = "";
            this.Broj.Text = this.KorisnickoIme.Text = "";

			// Ponovno omogućavanje unosa lozinke
            this.Lozinka.IsEnabled = true;

            // Reset za CB i RB
            this.RB1.IsChecked = this.RB2.IsChecked = this.RB3.IsChecked = false;
            this.CB1.IsChecked = this.CB2.IsChecked = this.CB3.IsChecked = false;

			// Reset za ComboBox
            this.VrstaKorisnikaCB.SelectedIndex = -1;
        }

        private void SacuvajLoz_Click(object sender, RoutedEventArgs e)
        {
            // ako koristimo TextBox umesto PasswordBox, ide ovako:
            // if (this.Lozinka.Text.Contains(this.KorisnickoIme.Text))
               
            // PasswordBox je sličan TextBox-u, ali umesto Text propertija ima Password property
            if (this.Lozinka.Password.Contains(this.KorisnickoIme.Text))
            {
                MessageBox.Show("Lozinka ne sme da sadrzi korisnicko ime!", "Promenite lozinku", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Lozinka je uspesno kreirana!", "Dobra lozinka", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                this.Lozinka.IsEnabled = false;
            }
        }

        // event za ComboBox je SelectionChanged (izaberi naziv koji ti VS ponudi, ne filozofiraj bespotrebno)
        private void VrstaKorisnikaCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // ComboBox.SelectedIndex - vraća vrednost indeksa štiklirane kućice
            // kreće od indeksa 0, a ako ni jedan nije izabran, vraća -1

            var kucica = sender as ComboBox;
            int id = kucica.SelectedIndex;

            if (id == 0)
            {
                // regularni korisnik NE SME da bira kategoriju
                this.Kategorija.IsEnabled = false;
            }
            else
            {
                // specijalni korisnik SME da bira kategoriju
                this.Kategorija.IsEnabled = true;
            }

            // osim indeksa, možemo dobiti i tekst koji je izabran iz ComboBox-a
            // ComboBox.selectedItem.ToString() - tekst koji je izabran iz cb
        }

    }
}
