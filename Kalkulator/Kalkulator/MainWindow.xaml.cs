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
        string liczba1 = "";
        string liczba2 = "";
        double liczba1db = 0;
        double liczba2db = 0;
        string dzialanie = "";
        string ostatnieDzialanie = "";
        double tmp = 0;
        bool rownaOstatnioKlikniete = false;
        bool operatorKlikniety = false;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void przycisk1_Click(object sender, RoutedEventArgs e)
        {
            if (rownaOstatnioKlikniete == true)
                liczba1 = "";
            if (dzialanie == "")
            {
                if (liczba1 == "0")
                    liczba1 = "1";
                else
                    liczba1 = liczba1 + "1";
                wyswietlaczTextBox.Text = liczba1.ToString();
            }
            else if (operatorKlikniety && liczba2 != "")
            {
                rownajPrzycisk();
                liczba2 = liczba2 + "1";
                wyswietlaczTextBox.Text = liczba2;
            }
            else 
            {
                if (liczba2 == "0")
                    liczba2 = "1";
                else
                    liczba2 = liczba2 + "1";
                wyswietlaczTextBox.Text = liczba2.ToString();
            }
            operatorKlikniety = false;
            rownaOstatnioKlikniete = false;
        }

        private void przycisk2_Click(object sender, RoutedEventArgs e)
        {
            if (rownaOstatnioKlikniete == true)
                liczba1 = "";
            if (dzialanie == "")
            {
                if (liczba1 == "0")
                    liczba1 = "2";
                else
                    liczba1 = liczba1 + "2";
                wyswietlaczTextBox.Text = liczba1.ToString();
            }
            else if (operatorKlikniety && liczba2 != "")
            {
                rownajPrzycisk();
                liczba2 = liczba2 + "2";
                wyswietlaczTextBox.Text = liczba2;
            }
            else
            {
                if (liczba2 == "0")
                    liczba2 = "2";
                else
                    liczba2 = liczba2 + "2";
                wyswietlaczTextBox.Text = liczba2.ToString();
            }
            operatorKlikniety = false;
            rownaOstatnioKlikniete = false;
        }

        private void przycisk3_Click(object sender, RoutedEventArgs e)
        {
            if (rownaOstatnioKlikniete == true)
                liczba1 = "";
            if (dzialanie == "")
            {
                if (liczba1 == "0")
                    liczba1 = "3";
                else
                    liczba1 = liczba1 + "3";
                wyswietlaczTextBox.Text = liczba1.ToString();
            }
            else if (operatorKlikniety && liczba2 != "")
            {
                rownajPrzycisk();
                liczba2 = liczba2 + "3";
                wyswietlaczTextBox.Text = liczba2;
            }
            else
            {
                if (liczba2 == "0")
                    liczba2 = "3";
                else
                    liczba2 = liczba2 + "3";
                wyswietlaczTextBox.Text = liczba2.ToString();
            }
            operatorKlikniety = false;
            rownaOstatnioKlikniete = false;
        }

        private void przycisk4_Click(object sender, RoutedEventArgs e)
        {
            if (rownaOstatnioKlikniete == true)
                liczba1 = "";
            if (dzialanie == "")
            {
                if (liczba1 == "0")
                    liczba1 = "4";
                else
                    liczba1 = liczba1 + "4";
                wyswietlaczTextBox.Text = liczba1.ToString();
            }
            else if (operatorKlikniety && liczba2 != "")
            {
                rownajPrzycisk();
                liczba2 = liczba2 + "4";
                wyswietlaczTextBox.Text = liczba2;
            }
            else
            {
                if (liczba2 == "0")
                    liczba2 = "4";
                else
                    liczba2 = liczba2 + "4";
                wyswietlaczTextBox.Text = liczba2.ToString();
            }
            operatorKlikniety = false;
            rownaOstatnioKlikniete = false;
        }

        private void przycisk5_Click(object sender, RoutedEventArgs e)
        {
            if (rownaOstatnioKlikniete == true)
                liczba1 = "";
            if (dzialanie == "")
            {
                if (liczba1 == "0")
                    liczba1 = "5";
                else
                    liczba1 = liczba1 + "5";
                wyswietlaczTextBox.Text = liczba1.ToString();
            }
            else if (operatorKlikniety && liczba2 != "")
            {
                rownajPrzycisk();
                liczba2 = liczba2 + "5";
                wyswietlaczTextBox.Text = liczba2;
            }
            else
            {
                if (liczba2 == "0")
                    liczba2 = "5";
                else
                    liczba2 = liczba2 + "5";
                wyswietlaczTextBox.Text = liczba2.ToString();
            }
            operatorKlikniety = false;
            rownaOstatnioKlikniete = false;
        }

        private void przycisk6_Click(object sender, RoutedEventArgs e)
        {
            if (rownaOstatnioKlikniete == true)
                liczba1 = "";
            if (dzialanie == "")
            {
                if (liczba1 == "0")
                    liczba1 = "6";
                else
                    liczba1 = liczba1 + "6";
                wyswietlaczTextBox.Text = liczba1.ToString();
            }
            else if (operatorKlikniety && liczba2 != "")
            {
                rownajPrzycisk();
                liczba2 = liczba2 + "6";
                wyswietlaczTextBox.Text = liczba2;
            }
            else
            {
                if (liczba2 == "0")
                    liczba2 = "6";
                else
                    liczba2 = liczba2 + "6";
                wyswietlaczTextBox.Text = liczba2.ToString();
            }
            operatorKlikniety = false;
            rownaOstatnioKlikniete = false;
        }

        private void przycisk7_Click(object sender, RoutedEventArgs e)
        {
            if (rownaOstatnioKlikniete == true)
                liczba1 = "";
            if (dzialanie == "")
            {
                if (liczba1 == "0")
                    liczba1 = "7";
                else
                    liczba1 = liczba1 + "7";
                wyswietlaczTextBox.Text = liczba1.ToString();
            }
            else if (operatorKlikniety && liczba2 != "")
            {
                rownajPrzycisk();
                liczba2 = liczba2 + "7";
                wyswietlaczTextBox.Text = liczba2;
            }
            else
            {
                if (liczba2 == "0")
                    liczba2 = "7";
                else
                    liczba2 = liczba2 + "7";
                wyswietlaczTextBox.Text = liczba2.ToString();
            }
            operatorKlikniety = false;
            rownaOstatnioKlikniete = false;
        }

        private void przycisk8_Click(object sender, RoutedEventArgs e)
        {
            if (rownaOstatnioKlikniete == true)
                liczba1 = "";
            if (dzialanie == "")
            {
                if (liczba1 == "0")
                    liczba1 = "8";
                else
                    liczba1 = liczba1 + "8";
                wyswietlaczTextBox.Text = liczba1.ToString();
            }
            else if (operatorKlikniety && liczba2 != "")
            {
                rownajPrzycisk();
                liczba2 = liczba2 + "8";
                wyswietlaczTextBox.Text = liczba2;
            }
            else
            {
                if (liczba2 == "0")
                    liczba2 = "8";
                else
                    liczba2 = liczba2 + "8";
                wyswietlaczTextBox.Text = liczba2.ToString();
            }
            operatorKlikniety = false;
            rownaOstatnioKlikniete = false;
        }

        private void przycisk9_Click(object sender, RoutedEventArgs e)
        {
            if (rownaOstatnioKlikniete == true)
                liczba1 = "";
            if (dzialanie == "")
            {
                if (liczba1 == "0")
                    liczba1 = "9";
                else
                    liczba1 = liczba1 + "9";
                wyswietlaczTextBox.Text = liczba1;
            }
            else if (operatorKlikniety && liczba2 != "")
            {
                rownajPrzycisk();
                liczba2 = liczba2 + "9";
                wyswietlaczTextBox.Text = liczba2;
            }
            else
            {
                if (liczba2 == "0")
                    liczba2 = "9";
                else
                    liczba2 = liczba2 + "9";
                wyswietlaczTextBox.Text = liczba2;
            }
            operatorKlikniety = false;
            rownaOstatnioKlikniete = false;
        }

        private void przycisk0_Click(object sender, RoutedEventArgs e)
        {
            if (rownaOstatnioKlikniete == true)
                liczba1 = "0";
            if (dzialanie == "")
            {
                if (liczba1 != "0")
                    liczba1 = liczba1 + "0";
                wyswietlaczTextBox.Text = liczba1.ToString();
            }
            else if (operatorKlikniety && liczba2 != "")
            {
                rownajPrzycisk();
                liczba2 = liczba2 + "0";
                wyswietlaczTextBox.Text = liczba2;
            }
            else
            {
                if (liczba2 != "0")
                    liczba2 = liczba2 + "0";
                wyswietlaczTextBox.Text = liczba2.ToString();
            }
            
            operatorKlikniety = false;
            rownaOstatnioKlikniete = false;
        }

        private void przyciskPrzecinek_Click(object sender, RoutedEventArgs e)
        {
            if (rownaOstatnioKlikniete == true)
                liczba1 = "0";
            if (dzialanie == "")
            {
                if (liczba1 == "")
                    liczba1 = "0";
                if (!liczba1.Contains(","))
                    liczba1 = liczba1 + ",";
                wyswietlaczTextBox.Text = liczba1;
            }
            else if (operatorKlikniety && liczba2 != "")
            {
                rownajPrzycisk();
                liczba2 = liczba2 + "0";
                if (!liczba2.Contains(","))
                    liczba2 = liczba2 + ",";
                wyswietlaczTextBox.Text = liczba2;
            }
            else
            {
                if (liczba2 == "")
                    liczba2 = "0";
                if (!liczba2.Contains(","))
                    liczba2 = liczba2 + ",";
                wyswietlaczTextBox.Text = liczba2;
            }
            operatorKlikniety = false;
            rownaOstatnioKlikniete = false;
        }

        private void przyciskDzielenie_Click(object sender, RoutedEventArgs e)
        {
            if (ostatnieDzialanie == "/" && liczba2 == "0")
            {
                wyswietlaczTextBox.Text = "Nie można dzielić przez 0!";
                liczba1 = "";
                liczba2 = "";
                dzialanie = "";
            }
            else
            {
                if (dzialanie == "")
                {
                    dzialanie = "/";
                    ostatnieDzialanie = dzialanie;
                }
                else 
                {
                    ostatnieDzialanie = dzialanie;
                    dzialanie = "/";
                }
                operatorKlikniety = true;
                rownaOstatnioKlikniete = false;
            }
        }

        private void przyciskMnozenie_Click(object sender, RoutedEventArgs e)
        {
            if (ostatnieDzialanie == "/" && liczba2 == "0")
            {
                wyswietlaczTextBox.Text = "Nie można dzielić przez 0!";
                liczba1 = "";
                liczba2 = "";
                dzialanie = "";
            }
            else
            {
                if (dzialanie == "")
                {
                    dzialanie = "*";
                    ostatnieDzialanie = dzialanie;
                }
                else
                {
                    ostatnieDzialanie = dzialanie;
                    dzialanie = "*";
                }
                operatorKlikniety = true;
                rownaOstatnioKlikniete = false;
            }
        }

        private void przyciskOdejmowanie_Click(object sender, RoutedEventArgs e)
        {
            if (ostatnieDzialanie == "/" && liczba2 == "0")
            {
                wyswietlaczTextBox.Text = "Nie można dzielić przez 0!";
                liczba1 = "";
                liczba2 = "";
                dzialanie = "";
            }
            else
            {
                if (dzialanie == "")
                {
                    dzialanie = "-";
                    ostatnieDzialanie = dzialanie;
                }
                else
                {
                    ostatnieDzialanie = dzialanie;
                    dzialanie = "-";
                }
                operatorKlikniety = true;
                rownaOstatnioKlikniete = false;
            }
        }

        private void przyciskDodawanie_Click(object sender, RoutedEventArgs e)
        {
            if (ostatnieDzialanie == "/" && liczba2 == "0")
            {
                wyswietlaczTextBox.Text = "Nie można dzielić przez 0!";
                liczba1 = "";
                liczba2 = "";
                dzialanie = "";
            }
            else 
            {
                if (dzialanie == "")
                {
                    dzialanie = "+";
                    ostatnieDzialanie = dzialanie;
                }
                else
                {
                    ostatnieDzialanie = dzialanie;
                    dzialanie = "+";
                }
                operatorKlikniety = true;
                rownaOstatnioKlikniete = false;
            }
        }

        private void przyciskRownanie_Click(object sender, RoutedEventArgs e)
        {
            if (liczba1 == "")
                liczba1db = 0;
            else
                liczba1db = double.Parse(liczba1);

            if (liczba2 == "")
                liczba2db = 0;
            else
                liczba2db = double.Parse(liczba2);


            if ((dzialanie == "+" || dzialanie == "-" ) && liczba2db == 0)
            {
                dzialanie = "";
                wyswietlaczTextBox.Text = liczba1db.ToString();
            }
            if (dzialanie == "+")
            {
                liczba1db = (liczba1db + liczba2db);
                liczba1 = liczba1db.ToString();
                liczba2 = "";
                dzialanie = "";
                wyswietlaczTextBox.Text = liczba1db.ToString();
            }
            else if (dzialanie == "-")
            {
                liczba1db = (liczba1db - liczba2db);
                liczba1 = liczba1db.ToString();
                liczba2 = "";
                dzialanie = "";
                wyswietlaczTextBox.Text = liczba1db.ToString();
            }
            else if (dzialanie == "*")
            {
                liczba1db = (liczba1db * liczba2db);
                liczba1 = liczba1db.ToString();
                liczba2 = "";
                dzialanie = "";
                wyswietlaczTextBox.Text = liczba1db.ToString();
            }
            else if (dzialanie == "/")
            {
                if (liczba2db != 0)
                {
                    liczba1db = (liczba1db / liczba2db);
                    liczba1 = liczba1db.ToString();
                    liczba2 = "";
                    dzialanie = "";
                    wyswietlaczTextBox.Text = liczba1db.ToString();

                }
                else
                {
                    if (operatorKlikniety)
                        wyswietlaczTextBox.Text = liczba1db.ToString();
                    else
                        wyswietlaczTextBox.Text = "Nie można dzielić przez 0!";
                    liczba1 = "";
                    liczba2 = "";
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
                liczba1 = "";
                dzialanie = "";
            }
            else
                liczba2 = "";
            wyswietlaczTextBox.Text = "0";
            rownaOstatnioKlikniete = false;
            operatorKlikniety = false;
        }

        private void przyciskC_Click(object sender, RoutedEventArgs e)
        {
            liczba1 = "";
            liczba2 = "";
            dzialanie = "";
            wyswietlaczTextBox.Text = "0";
            rownaOstatnioKlikniete = false;
            operatorKlikniety = false;
        }

        private void przyciskDEL_Click(object sender, RoutedEventArgs e)
        {
            if (dzialanie == "")
            {
                if (liczba1.Length > 1)
                {
                    liczba1 = liczba1.Remove(liczba1.Length - 1);
                    wyswietlaczTextBox.Text = liczba1;
                }
                else if (liczba1.Length == 1)
                {
                    liczba1 = "";
                    wyswietlaczTextBox.Text = "0";
                }            
            }
            else
            {
                if (liczba2.Length > 1)
                {
                    liczba2 = liczba2.Remove(liczba2.Length - 1);
                    wyswietlaczTextBox.Text = liczba2;
                }
                else if (liczba2.Length == 1)
                {
                    liczba2 = "";
                    wyswietlaczTextBox.Text = "0";
                }
            }
            rownaOstatnioKlikniete = false;
            operatorKlikniety = false;
        }

        private void przyciskZmianaZnaku_Click(object sender, RoutedEventArgs e)
        {
            if (dzialanie == "")
            {
                tmp = double.Parse(liczba1);
                tmp *= -1;
                liczba1 = tmp.ToString();
                wyswietlaczTextBox.Text = liczba1;
            }
            else
            {
                tmp = double.Parse(liczba2);
                tmp *= -1;
                liczba2 = tmp.ToString();
                wyswietlaczTextBox.Text = liczba2;
            }
            rownaOstatnioKlikniete = false;
            operatorKlikniety = false;
        }

        private void rownajPrzycisk()
        {
            if (liczba1 == "")
                liczba1db = 0;
            else
                liczba1db = double.Parse(liczba1);

            liczba2db = double.Parse(liczba2);

            switch (ostatnieDzialanie)
            {
                case "+":
                    {
                        liczba1db = (liczba1db + liczba2db);
                        liczba1 = liczba1db.ToString();
                        liczba2 = "";
                        break;
                    }
                case "-":
                    { 
                        liczba1db = (liczba1db - liczba2db);
                        liczba1 = liczba1db.ToString();
                        liczba2 = "";
                        break;
                    }
                case "*":
                    {
                        liczba1db = (liczba1db * liczba2db);
                        liczba1 = liczba1db.ToString();
                        liczba2 = "";
                        break;
                    }
                case "/":
                    {
                        if (liczba2db != 0)
                        {
                            liczba1db = (liczba1db / liczba2db);
                            liczba1 = liczba1db.ToString();
                            liczba2 = "";
                        }
                        else
                        {
                            wyswietlaczTextBox.Text = "Nie można dzielić przez 0!";
                            liczba1 = "";
                            liczba2 = "";
                        }
                        break;
                    }
            }

        }

    }
}
