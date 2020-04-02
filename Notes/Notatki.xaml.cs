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
    /// Logika interakcji dla klasy Notatki.xaml
    /// </summary>
    public partial class Notatki : Window
    {
        public Notatki()
        {
            InitializeComponent();
            WyborPrzedmiotMojeNotatki.IsEnabled = false;
            WyborSemestrMojeNotatki.Items.Add("1");
            WyborSemestrMojeNotatki.Items.Add("2");
            WyborSemestrMojeNotatki.Items.Add("3");
            WyborSemestrMojeNotatki.Items.Add("4");
            WyborSemestrMojeNotatki.Items.Add("5");
            WyborSemestrMojeNotatki.Items.Add("6");
            WyborSemestrMojeNotatki.Items.Add("7");
            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            WyborPrzedmiotMojeNotatki.IsEnabled = true;
            WyborPrzedmiotMojeNotatki.Items.Clear();
            Text2.Visibility = Visibility.Visible;
            WyborPrzedmiotMojeNotatki.Visibility = Visibility.Visible;
            int Semestr = WyborSemestrMojeNotatki.SelectedIndex + 1;
            if (Semestr == 1)
            {
                WyborPrzedmiotMojeNotatki.Items.Add("Fizyka I");
                WyborPrzedmiotMojeNotatki.Items.Add("Analiza matematyczna I");
                WyborPrzedmiotMojeNotatki.Items.Add("Algebra");
                WyborPrzedmiotMojeNotatki.Items.Add("Technologia informacyjna");
                WyborPrzedmiotMojeNotatki.Items.Add("Informatyka I");
                WyborPrzedmiotMojeNotatki.Items.Add("Historia techniki");
                WyborPrzedmiotMojeNotatki.Items.Add("Bezpieczeństwo pracy i ergonomia");
                WyborPrzedmiotMojeNotatki.Items.Add("Prawo autorskie i gospodarcze");
                WyborPrzedmiotMojeNotatki.Items.Add("Podstawy metrologii");
            }
            if (Semestr == 2)
            {
                WyborPrzedmiotMojeNotatki.Items.Add("Analiza matematyczna II");
                WyborPrzedmiotMojeNotatki.Items.Add("Informatyka II");
                WyborPrzedmiotMojeNotatki.Items.Add("Metody statystyczne");
                WyborPrzedmiotMojeNotatki.Items.Add("Fizyka II");
                WyborPrzedmiotMojeNotatki.Items.Add("Wybrane zagadnienia");
                WyborPrzedmiotMojeNotatki.Items.Add("Elektrotechnika");
                WyborPrzedmiotMojeNotatki.Items.Add("Geometria i grafika inżynierska");
                WyborPrzedmiotMojeNotatki.Items.Add("Podstawy marketingu");
            }
            if (Semestr == 3)
            {
                WyborPrzedmiotMojeNotatki.Items.Add("Angielski");
                WyborPrzedmiotMojeNotatki.Items.Add("WF");
                WyborPrzedmiotMojeNotatki.Items.Add("Programowanie I");
                WyborPrzedmiotMojeNotatki.Items.Add("Algorytmy");
                WyborPrzedmiotMojeNotatki.Items.Add("Metody numeryczne");
                WyborPrzedmiotMojeNotatki.Items.Add("Systemy operacyjne I");
                WyborPrzedmiotMojeNotatki.Items.Add("Podstawy baz danych");
                WyborPrzedmiotMojeNotatki.Items.Add("Architektura komputerów");
            }
            if (Semestr == 4)
            {
                WyborPrzedmiotMojeNotatki.Items.Add("Angielski");
                WyborPrzedmiotMojeNotatki.Items.Add("Inżyniera oprogramowania");
                WyborPrzedmiotMojeNotatki.Items.Add("Programowanie II");
                WyborPrzedmiotMojeNotatki.Items.Add("Systemy operacyjne II");
                WyborPrzedmiotMojeNotatki.Items.Add("Grafika komputerowa");
                WyborPrzedmiotMojeNotatki.Items.Add("Sieci komputerowe I");
                WyborPrzedmiotMojeNotatki.Items.Add("Modelowanie baz danych");
                WyborPrzedmiotMojeNotatki.Items.Add("Technologie internetowe");
            }
            if (Semestr == 5)
            {
                WyborPrzedmiotMojeNotatki.Items.Add("Angielski");
                WyborPrzedmiotMojeNotatki.Items.Add("Metodyka badań naukowych");
                WyborPrzedmiotMojeNotatki.Items.Add("Sieci komputerowe II");
                WyborPrzedmiotMojeNotatki.Items.Add("Testowanie aplikacji");
                WyborPrzedmiotMojeNotatki.Items.Add("Ochrona danych w aplikacjach");
                WyborPrzedmiotMojeNotatki.Items.Add("Systemy wizyjne");
                WyborPrzedmiotMojeNotatki.Items.Add("Języki programowania");
                WyborPrzedmiotMojeNotatki.Items.Add("Podstawy teorii systemów");
            }
            if (Semestr == 6)
            {
                WyborPrzedmiotMojeNotatki.Items.Add("Angielski");
                WyborPrzedmiotMojeNotatki.Items.Add("Korporacyjne systemy informatyczne");
                WyborPrzedmiotMojeNotatki.Items.Add("Transmisja danych");
                WyborPrzedmiotMojeNotatki.Items.Add("Projekt systemu informatycznego");
                WyborPrzedmiotMojeNotatki.Items.Add("Aplikacje bazodanowe");
                WyborPrzedmiotMojeNotatki.Items.Add("Systemy wbudowane");
                WyborPrzedmiotMojeNotatki.Items.Add("Narzędzia sztucznej inteligencji");
                WyborPrzedmiotMojeNotatki.Items.Add("Praca przejściowa");
            }
            if (Semestr == 7)
            {
                WyborPrzedmiotMojeNotatki.Items.Add("Programowanie III");
                WyborPrzedmiotMojeNotatki.Items.Add("Sieci komputerowe CISCO");
                WyborPrzedmiotMojeNotatki.Items.Add("Programowanie IV");
                WyborPrzedmiotMojeNotatki.Items.Add("Analiza i przetwarzanie obrazu");
                WyborPrzedmiotMojeNotatki.Items.Add("Zastosowania informatyki");
                WyborPrzedmiotMojeNotatki.Items.Add("Seminarium dyplomowe");
            }
        }


        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }


        private void Wybor4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (WyborSemestrMojeNotatki.SelectedValue == null) { MessageBox.Show("Nie wprowadzono semstru","Brak filtru"); }
                else if (WyborPrzedmiotMojeNotatki.SelectedValue == null) { MessageBox.Show("Nie wprowadzono przedmiotu", "Brak filtru"); }
                else
                ListaNotatek.Items.Clear();
                string Semestr = WyborSemestrMojeNotatki.Text;
                string Przedmiot = WyborPrzedmiotMojeNotatki.Text;
                var Filtr = XElement.Load("ZapisaneDane.xml")
                .Descendants("Notatka")
                .Where(Nody => Nody.Element("Semestr").Value == Semestr && Nody.Element("Przedmiot").Value == Przedmiot)
                .OrderBy(Zmienna => (Zmienna.Element("Tresc_notatki").Value))
                .ToList<XElement>();
                foreach (var Tresc in Filtr)
                {
                    string NowaTresc = Tresc.Element("Tresc_notatki").Value;
                    ListaNotatek.Items.Add(NowaTresc);
                }
            }
            catch (Exception Wyjątek)
            {
                MessageBox.Show(Wyjątek.ToString(),"Wystąpił błąd");
            }
        }

        private void ListaNotatek_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (ListaNotatek.SelectedItem != null)
            {

                new Edycja(ListaNotatek.SelectedItem.ToString(),WyborSemestrMojeNotatki.SelectedItem.ToString(), WyborPrzedmiotMojeNotatki.SelectedItem.ToString()).Show();
                this.Close();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                string Notatka = ListaNotatek.SelectedValue.ToString();
                XDocument Dokument = XDocument.Load("ZapisaneDane.xml");
                Dokument.Descendants().Elements("Tresc_notatki")
                .Where(UsuwanieNotatki => UsuwanieNotatki.Value == Notatka)
                .Where(UsuwanieNotatki => UsuwanieNotatki.Parent.Name == "Notatka")
                .Select(UsuwanieNotatki => UsuwanieNotatki.Parent)
                .Remove();
                Dokument.Save("ZapisaneDane.xml");
                ListaNotatek.Items.Clear();
                string Semestr = WyborSemestrMojeNotatki.Text;
                string Przedmiot = WyborPrzedmiotMojeNotatki.Text;
                var Filtr = XElement.Load("ZapisaneDane.xml")
                .Descendants("Notatka")
                .Where(Nody => Nody.Element("Semestr").Value == Semestr && Nody.Element("Przedmiot").Value == Przedmiot)
                .OrderBy(Zmienna => (Zmienna.Element("Tresc_notatki").Value))
                .ToList<XElement>();
                foreach (var Tresc in Filtr)
                {
                    string NowaTresc = Tresc.Element("Tresc_notatki").Value;
                    ListaNotatek.Items.Add(NowaTresc);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Brak wybranej notatki do usuniecia","Wystąpił błąd");
            }
        }
    }
}
