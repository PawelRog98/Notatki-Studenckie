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
using Microsoft.Win32;
using System.Xml.Linq;
using System.IO;
using System.Windows.Media.Animation;
namespace Notes
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        int Dodanie = 0;
        public MainWindow()
        {
            InitializeComponent();
            WyborPrzedmiotMain.IsEnabled = false;
            WyborSemestrMain.Items.Add("1");
            WyborSemestrMain.Items.Add("2");
            WyborSemestrMain.Items.Add("3");
            WyborSemestrMain.Items.Add("4");
            WyborSemestrMain.Items.Add("5");
            WyborSemestrMain.Items.Add("6");
            WyborSemestrMain.Items.Add("7");
            if (WpisanaNotatka.Text.Length == 0 && WyborSemestrMain.SelectedItem == null && WyborPrzedmiotMain.SelectedItem == null) { ZapisNotatkiMain.IsEnabled = false; }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Notatki().Show();
            this.Close();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (WyborSemestrMain.SelectedItem != null && WyborPrzedmiotMain.SelectedItem != null && WpisanaNotatka.Text.Length == 0) { ZapisNotatkiMain.IsEnabled = true; }
                WyborPrzedmiotMain.IsEnabled = true;
                WyborPrzedmiotMain.Items.Clear();
                int Semestr = WyborSemestrMain.SelectedIndex + 1;
                if (Semestr == 1)
                {
                    WyborPrzedmiotMain.Items.Add("Fizyka I");
                    WyborPrzedmiotMain.Items.Add("Analiza matematyczna I");
                    WyborPrzedmiotMain.Items.Add("Algebra");
                    WyborPrzedmiotMain.Items.Add("Technologia informacyjna");
                    WyborPrzedmiotMain.Items.Add("Informatyka I");
                    WyborPrzedmiotMain.Items.Add("Historia techniki");
                    WyborPrzedmiotMain.Items.Add("Bezpieczeństwo pracy i ergonomia");
                    WyborPrzedmiotMain.Items.Add("Prawo autorskie i gospodarcze");
                    WyborPrzedmiotMain.Items.Add("Podstawy metrologii");
                }
                if (Semestr == 2)
                {
                    WyborPrzedmiotMain.Items.Add("Analiza matematyczna II");
                    WyborPrzedmiotMain.Items.Add("Informatyka II");
                    WyborPrzedmiotMain.Items.Add("Metody statystyczne");
                    WyborPrzedmiotMain.Items.Add("Fizyka II");
                    WyborPrzedmiotMain.Items.Add("Wybrane zagadnienia");
                    WyborPrzedmiotMain.Items.Add("Elektrotechnika");
                    WyborPrzedmiotMain.Items.Add("Geometria i grafika inżynierska");
                    WyborPrzedmiotMain.Items.Add("Podstawy marketingu");
                }
                if (Semestr == 3)
                {
                    WyborPrzedmiotMain.Items.Add("Angielski");
                    WyborPrzedmiotMain.Items.Add("WF");
                    WyborPrzedmiotMain.Items.Add("Programowanie I");
                    WyborPrzedmiotMain.Items.Add("Algorytmy");
                    WyborPrzedmiotMain.Items.Add("Metody numeryczne");
                    WyborPrzedmiotMain.Items.Add("Systemy operacyjne I");
                    WyborPrzedmiotMain.Items.Add("Podstawy baz danych");
                    WyborPrzedmiotMain.Items.Add("Architektura komputerów");
                }
                if (Semestr == 4)
                {
                    WyborPrzedmiotMain.Items.Add("Angielski");
                    WyborPrzedmiotMain.Items.Add("Inżyniera oprogramowania");
                    WyborPrzedmiotMain.Items.Add("Programowanie II");
                    WyborPrzedmiotMain.Items.Add("Systemy operacyjne II");
                    WyborPrzedmiotMain.Items.Add("Grafika komputerowa");
                    WyborPrzedmiotMain.Items.Add("Sieci komputerowe I");
                    WyborPrzedmiotMain.Items.Add("Modelowanie baz danych");
                    WyborPrzedmiotMain.Items.Add("Technologie internetowe");
                }
                if (Semestr == 5)
                {
                    WyborPrzedmiotMain.Items.Add("Angielski");
                    WyborPrzedmiotMain.Items.Add("Metodyka badań naukowych");
                    WyborPrzedmiotMain.Items.Add("Sieci komputerowe II");
                    WyborPrzedmiotMain.Items.Add("Testowanie aplikacji");
                    WyborPrzedmiotMain.Items.Add("Ochrona danych w aplikacjach");
                    WyborPrzedmiotMain.Items.Add("Systemy wizyjne");
                    WyborPrzedmiotMain.Items.Add("Języki programowania");
                    WyborPrzedmiotMain.Items.Add("Podstawy teorii systemów");
                }
                if (Semestr == 6)
                {
                    WyborPrzedmiotMain.Items.Add("Angielski");
                    WyborPrzedmiotMain.Items.Add("Korporacyjne systemy informatyczne");
                    WyborPrzedmiotMain.Items.Add("Transmisja danych");
                    WyborPrzedmiotMain.Items.Add("Projekt systemu informatycznego");
                    WyborPrzedmiotMain.Items.Add("Aplikacje bazodanowe");
                    WyborPrzedmiotMain.Items.Add("Systemy wbudowane");
                    WyborPrzedmiotMain.Items.Add("Narzędzia sztucznej inteligencji");
                    WyborPrzedmiotMain.Items.Add("Praca przejściowa");
                }
                if (Semestr == 7)
                {
                    WyborPrzedmiotMain.Items.Add("Programowanie III");
                    WyborPrzedmiotMain.Items.Add("Sieci komputerowe CISCO");
                    WyborPrzedmiotMain.Items.Add("Programowanie IV");
                    WyborPrzedmiotMain.Items.Add("Analiza i przetwarzanie obrazu");
                    WyborPrzedmiotMain.Items.Add("Zastosowania informatyki");
                    WyborPrzedmiotMain.Items.Add("Seminarium dyplomowe");

                }
            }
            catch(Exception)
            {
                MessageBox.Show("Wystąpił błąd");
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        }

        

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                Dodanie++;
                XDocument Dokument = XDocument.Load("ZapisaneDane.xml");
                Dokument.Root.Add(new XElement("Notatka",
                new XElement("Numer_notatki", Dodanie),
                new XElement("Semestr", WyborSemestrMain.Text),
                new XElement("Przedmiot", WyborPrzedmiotMain.Text),
                new XElement("Tresc_notatki", WpisanaNotatka.Text)));
                Dokument.Save("ZapisaneDane.xml");
            }
            catch (Exception Wyjątek)
            {
                MessageBox.Show(Wyjątek.ToString(), "Wystąpił błąd");
            }
            WpisanaNotatka.Text = null;
            WyborSemestrMain.SelectedItem = null;
            WyborPrzedmiotMain.SelectedItem = null;
            Storyboard Animacja = Resources["AnimacjaLabela"] as Storyboard;
            Animacja.Begin(ZapisanoNotatke);
        }

        private void Notka1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {   if(WpisanaNotatka.Text==" ") { WpisanaNotatka.Clear(); }
                else
                if (WyborPrzedmiotMain.Items.Count != 0)
                {
                    if (WpisanaNotatka.Text.Length != 0 && WyborPrzedmiotMain.SelectedItem != null) { ZapisNotatkiMain.IsEnabled = true; }
                    else ZapisNotatkiMain.IsEnabled = false;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Wystąpił błąd");
            }
        }

        private void Otworzenie(object sender, EventArgs e)
        {
        }

        private void WyborPrzedmiotuLista(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (WpisanaNotatka.Text.Length != 0 && WyborPrzedmiotMain.SelectedItem != null) { ZapisNotatkiMain.IsEnabled = true; }
                else ZapisNotatkiMain.IsEnabled = false;
            }
            catch(Exception)
            {
                MessageBox.Show("Wystąpił błąd");
            }
        }
    }
}
