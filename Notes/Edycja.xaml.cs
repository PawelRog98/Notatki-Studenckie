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
using System.Xml.Linq;

namespace Notes
{
    /// <summary>
    /// Logika interakcji dla klasy Edycja.xaml
    /// </summary>
    public partial class Edycja : Window
    {
        string Zapamietywanie;
        public Edycja(string TekstNotatki, string Semestr, string Przedmiot)
        {
            InitializeComponent();
            WpisanaNazwaEdycja.Text = TekstNotatki;
            WyswietlanieSemestr.Content = "Semestr: "+Semestr;
            WyswietlaniePrzedmiot.Content = "Przedmiot: "+Przedmiot;
            Zapamietywanie = TekstNotatki;
            Dane Przesłane = new Dane();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Notatki().Show();
            this.Close();
        }

        private void Notka2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (WpisanaNazwaEdycja.Text == " ") WpisanaNazwaEdycja.Clear();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (WpisanaNazwaEdycja.Text.Length == 0) { MessageBox.Show("Nie można zapisać pustej notatki"); }
            else
                try
                {
                string TekstNotatki = WpisanaNazwaEdycja.Text;
                XElement ZapisanyElement = XElement.Load("ZapisaneDane.xml");
                var ZapisanaNotatka = from Zapis in ZapisanyElement.Elements("Notatka")
                                      where Zapis.Element("Tresc_notatki") != null && Zapis.Element("Tresc_notatki").Value == Zapamietywanie
                                      select Zapis;
                foreach (XElement itemElement in ZapisanaNotatka)
                {
                    itemElement.SetElementValue("Tresc_notatki", TekstNotatki);
                }

                ZapisanyElement.Save("ZapisaneDane.xml");
                    new Notatki().Show();
                    this.Close();
                    MessageBox.Show("Zapisano notatkę","Zapis");
                }
            catch (Exception Wyjątek)
            {
                MessageBox.Show(Wyjątek.ToString(), "Wystąpił błąd");
            }
        }
    }
}
