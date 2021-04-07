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

namespace Encapsulation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Country C1 = new Country();
            C1.Name = "Poland";
            C1.Capital = "Warsaw";
            C1.Currency = "PLN";
            //C1.Population = 38000000;
            C1.Print();

           
        }
    }

    class Country
    {

        string name;   // accepted as private 

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string capital;

        public string Capital
        {
            get { return capital; }
            set { capital = value; }
        }
        int population = 1500;

        public int Population
        {
            get { return population; }
            set { population = value; }
        }
        string currency;

        public string Currency
        {
            get { return currency; } 
            set { currency = value; } 
        }

        public void Print()
        {
            MessageBox.Show(
                "Country Name   : " + name + "\n " +
                "Capital   : " + capital + "\n " +
                "Population  : " + population + "\n " +
                "Currency   : " + currency + "\n " +
                 "------------ "
                );           
        }
    }
}
