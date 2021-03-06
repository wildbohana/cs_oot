using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Biblioteka.Knjige
{
    public partial class ObrisiKnjigu : Page
    {
        public ObrisiKnjigu()
        {
            InitializeComponent();

            #region INICIJALIZACIJA DATACONTEXT
            DataContext = this;
            dataGridSveKnjige.ItemsSource = App.SveKnjige;
            #endregion
        }
		
        private void dataGridSveKnjige_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var row = ItemsControl.ContainerFromElement((DataGrid)sender, e.OriginalSource as DependencyObject) as DataGridRow;

            if (row == null)
                return;

            if (dataGridSveKnjige.SelectedItem == null)
                return;

            var knjiga = dataGridSveKnjige.SelectedItem as Knjiga;

            var daNe = MessageBox.Show("Brisanje knjige je NEPOVRATNA OPERACIJA!\n" +
                "Brisanjem knjige brišu se svi zapisi iz svih INVENTARA!\n\n" +
                "Da li ste sigurni?", "Upozorenje o brisanju!", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (daNe == MessageBoxResult.Yes)
            {
                // Uklanjanje knjige iz globalne kolekcije
                App.SveKnjige.Remove(knjiga);
                MessageBox.Show("Knjiga obrisana iz kolekcije!", "Informacija", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            // Ažuriranje prikaza liste posle brisanja
            dataGridSveKnjige.ItemsSource = App.SveKnjige;
        }

        private void pretraga_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<Knjiga> pretrazeno = new List<Knjiga>();
            string unos = (sender as TextBox).Text;
            unos = Regex.Replace(unos, @"\s+", " ");

            foreach (Knjiga k in App.SveKnjige)
            {
                string nazivautor = k.Naziv.ToLower() + " " + k.Autor.ToLower();
                string autornaziv = k.Autor.ToLower() + " " + k.Naziv.ToLower();

                if (nazivautor.Contains(unos.ToLower()) || autornaziv.Contains(unos.ToLower()))
                {
                    pretrazeno.Add(k);
                }
            }

            dataGridSveKnjige.ItemsSource = pretrazeno.ToList();
        }
    }
}
