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

namespace Kalkulator
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long liczba1 = 0;
        long liczba2 = 0;
        string dzialanie = "";
        bool rownaOstatnioKlikniete = false;
        bool operatorKlikniety = false;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void przycisk1_Click(object sender, RoutedEventArgs e)
        {
            if (rownaOstatnioKlikniete == true)
                liczba1 = 0;
            if (dzialanie == "")
            {
                liczba1 = (liczba1 * 10) + 1;
                wyswietlaczTextBox.Text = liczba1.ToString();
            }
            else 
            {
                liczba2 = (liczba2 * 10) + 1;
                wyswietlaczTextBox.Text = liczba2.ToString();
            }
            operatorKlikniety = false;
            rownaOstatnioKlikniete = false;
        }

        private void przycisk2_Click(object sender, RoutedEventArgs e)
        {
            if (rownaOstatnioKlikniete == true)
                liczba1 = 0;
            if (dzialanie == "")
            {
                liczba1 = (liczba1 * 10) + 2;
                wyswietlaczTextBox.Text = liczba1.ToString();
            }
            else
            {
                liczba2 = (liczba2 * 10) + 2;
                wyswietlaczTextBox.Text = liczba2.ToString();
            }
            operatorKlikniety = false;
            rownaOstatnioKlikniete = false;
        }

        private void przycisk3_Click(object sender, RoutedEventArgs e)
        {
            if (rownaOstatnioKlikniete == true)
                liczba1 = 0;
            if (dzialanie == "")
            {
                liczba1 = (liczba1 * 10) + 3;
                wyswietlaczTextBox.Text = liczba1.ToString();
            }
            else
            {
                liczba2 = (liczba2 * 10) + 3;
                wyswietlaczTextBox.Text = liczba2.ToString();
            }
            operatorKlikniety = false;
            rownaOstatnioKlikniete = false;
        }

        private void przycisk4_Click(object sender, RoutedEventArgs e)
        {
            if (rownaOstatnioKlikniete == true)
                liczba1 = 0;
            if (dzialanie == "")
            {
                liczba1 = (liczba1 * 10) + 4;
                wyswietlaczTextBox.Text = liczba1.ToString();
            }
            else
            {
                liczba2 = (liczba2 * 10) + 4;
                wyswietlaczTextBox.Text = liczba2.ToString();
            }
            operatorKlikniety = false;
            rownaOstatnioKlikniete = false;
        }

        private void przycisk5_Click(object sender, RoutedEventArgs e)
        {
            if (rownaOstatnioKlikniete == true)
                liczba1 = 0;
            if (dzialanie == "")
            {
                liczba1 = (liczba1 * 10) + 5;
                wyswietlaczTextBox.Text = liczba1.ToString();
            }
            else
            {
                liczba2 = (liczba2 * 10) + 5;
                wyswietlaczTextBox.Text = liczba2.ToString();
            }
            operatorKlikniety = false;
            rownaOstatnioKlikniete = false;
        }

        private void przycisk6_Click(object sender, RoutedEventArgs e)
        {
            if (rownaOstatnioKlikniete == true)
                liczba1 = 0;
            if (dzialanie == "")
            {
                liczba1 = (liczba1 * 10) + 6;
                wyswietlaczTextBox.Text = liczba1.ToString();
            }
            else
            {
                liczba2 = (liczba2 * 10) + 6;
                wyswietlaczTextBox.Text = liczba2.ToString();
            }
            operatorKlikniety = false;
            rownaOstatnioKlikniete = false;
        }

        private void przycisk7_Click(object sender, RoutedEventArgs e)
        {
            if (rownaOstatnioKlikniete == true)
                liczba1 = 0;
            if (dzialanie == "")
            {
                liczba1 = (liczba1 * 10) + 7;
                wyswietlaczTextBox.Text = liczba1.ToString();
            }
            else
            {
                liczba2 = (liczba2 * 10) + 7;
                wyswietlaczTextBox.Text = liczba2.ToString();
            }
            operatorKlikniety = false;
            rownaOstatnioKlikniete = false;
        }

        private void przycisk8_Click(object sender, RoutedEventArgs e)
        {
            if (rownaOstatnioKlikniete == true)
                liczba1 = 0;
            if (dzialanie == "")
            {
                liczba1 = (liczba1 * 10) + 8;
                wyswietlaczTextBox.Text = liczba1.ToString();
            }
            else
            {
                liczba2 = (liczba2 * 10) + 8;
                wyswietlaczTextBox.Text = liczba2.ToString();
            }
            operatorKlikniety = false;
            rownaOstatnioKlikniete = false;
        }

        private void przycisk9_Click(object sender, RoutedEventArgs e)
        {
            if (rownaOstatnioKlikniete == true)
                liczba1 = 0;
            if (dzialanie == "")
            {
                liczba1 = (liczba1 * 10) + 9;
                wyswietlaczTextBox.Text = liczba1.ToString();
            }
            else
            {
                liczba2 = (liczba2 * 10) + 9;
                wyswietlaczTextBox.Text = liczba2.ToString();
            }
            operatorKlikniety = false;
            rownaOstatnioKlikniete = false;
        }

        private void przycisk0_Click(object sender, RoutedEventArgs e)
        {
            if (rownaOstatnioKlikniete == true)
                liczba1 = 0;
            if (dzialanie == "")
            {
                liczba1 = (liczba1 * 10);
                wyswietlaczTextBox.Text = liczba1.ToString();
            }
            else
            {
                liczba2 = (liczba2 * 10);
                wyswietlaczTextBox.Text = liczba2.ToString();
            }
            operatorKlikniety = false;
            rownaOstatnioKlikniete = false;
        }

        private void przyciskDzielenie_Click(object sender, RoutedEventArgs e)
        {
            dzialanie = "/";
            operatorKlikniety = true;
            rownaOstatnioKlikniete = false;
        }

        private void przyciskMnozenie_Click(object sender, RoutedEventArgs e)
        {
            dzialanie = "*";
            operatorKlikniety = true;
            rownaOstatnioKlikniete = false;
        }

        private void przyciskOdejmowanie_Click(object sender, RoutedEventArgs e)
        {
            dzialanie = "-";
            operatorKlikniety = true;
            rownaOstatnioKlikniete = false;
        }

        private void przyciskDodawanie_Click(object sender, RoutedEventArgs e)
        {
            dzialanie = "+";
            operatorKlikniety = true;
            rownaOstatnioKlikniete = false;
        }

        private void przyciskRownanie_Click(object sender, RoutedEventArgs e)
        {
            if ((dzialanie == "+" || dzialanie == "-" || dzialanie == "*") && liczba2 == 0)
            {
                dzialanie = "";
                wyswietlaczTextBox.Text = liczba1.ToString();
            }
            if (dzialanie == "+")
            {
                liczba1 = (liczba1 + liczba2);
                liczba2 = 0;
                dzialanie = "";
                wyswietlaczTextBox.Text = liczba1.ToString();
            }
            else if (dzialanie == "-")
            {
                liczba1 = (liczba1 - liczba2);
                liczba2 = 0;
                dzialanie = "";
                wyswietlaczTextBox.Text = liczba1.ToString();
            }
            else if (dzialanie == "*")
            {
                liczba1 = (liczba1 * liczba2);
                liczba2 = 0;
                dzialanie = "";
                wyswietlaczTextBox.Text = liczba1.ToString();
            }
            else if (dzialanie == "/")
            {
                if (liczba2 != 0)
                {
                    liczba1 = (liczba1 / liczba2);
                    liczba2 = 0;
                    dzialanie = "";
                    wyswietlaczTextBox.Text = liczba1.ToString();

                }
                else
                {
                    if (operatorKlikniety)
                        wyswietlaczTextBox.Text = liczba1.ToString();
                    else
                        wyswietlaczTextBox.Text = "Błąd!";
                    liczba1 = 0;
                    liczba2 = 0;
                    dzialanie = "";
                }
                    
            }
            rownaOstatnioKlikniete = true;
            operatorKlikniety = false;
        }

        private void przyciskCE_Click(object sender, RoutedEventArgs e)
        {
            if (dzialanie == "" || operatorKlikniety)
            {
                liczba1 = 0;
                dzialanie = "";
            }
            else
                liczba2 = 0;
            wyswietlaczTextBox.Text = "0";
            rownaOstatnioKlikniete = false;
            operatorKlikniety = false;
        }

        private void przyciskC_Click(object sender, RoutedEventArgs e)
        {
            liczba1 = 0;
            liczba2 = 0;
            dzialanie = "";
            wyswietlaczTextBox.Text = "0";
            rownaOstatnioKlikniete = false;
            operatorKlikniety = false;
        }

        private void przyciskDEL_Click(object sender, RoutedEventArgs e)
        {
            if (dzialanie == "")
            {
                liczba1 = (liczba1 / 10);
                wyswietlaczTextBox.Text = liczba1.ToString();
            }
            else
            {
                liczba2 = (liczba2 / 10);
                wyswietlaczTextBox.Text = liczba2.ToString();
            }
            rownaOstatnioKlikniete = false;
            operatorKlikniety = false;
        }

        private void przyciskZmianaZnaku_Click(object sender, RoutedEventArgs e)
        {
            if (dzialanie == "")
            {
                liczba1 *= -1;
                wyswietlaczTextBox.Text = liczba1.ToString();
            }
            else
            {
                liczba2 *= -1;
                wyswietlaczTextBox.Text = liczba2.ToString();
            }
            rownaOstatnioKlikniete = false;
            operatorKlikniety = false;
        }
    }
}
