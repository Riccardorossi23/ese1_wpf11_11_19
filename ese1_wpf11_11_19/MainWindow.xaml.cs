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

namespace ese1_wpf11_11_19
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

        private void Button_Click_Moltiplicazione1(object sender, RoutedEventArgs e)
        {
            double d = double.Parse(txtNumero.Text);
            double r = d * 0.1;
            txtNumero.Text = r.ToString();
        }

        private void Button_Click_Moltiplicazione2(object sender, RoutedEventArgs e)
        {
            double d = double.Parse(txtNumero.Text);
            double r = d * 0.01;
            txtNumero.Text = r.ToString();
        }

        private void Button_Click_Moltiplicazione3(object sender, RoutedEventArgs e)
        {
            double d = double.Parse(txtNumero.Text);
            double r = d * 0.001;
            txtNumero.Text = r.ToString();
        }

        private void Button_Click_Sottrazione1(object sender, RoutedEventArgs e)
        {
            double d = double.Parse(txtNumero.Text);
            double r = d - 1;
            txtNumero.Text = r.ToString();
        }

        private void Button_Click_Sottrazione2(object sender, RoutedEventArgs e)
        {
            double d = double.Parse(txtNumero.Text);
            double r = d - 0.1;
            txtNumero.Text = r.ToString();

        }

        private void Button_Click_Sottrazione3(object sender, RoutedEventArgs e)
        {
            double d = double.Parse(txtNumero.Text);
            double r = d - 0.01;
            txtNumero.Text = r.ToString();
        }

        private void Button_Click_Divisione1(object sender, RoutedEventArgs e)
        {
            double d = double.Parse(txtNumero.Text);
            double r = d / 0.1;
            txtNumero.Text = r.ToString();
        }

        private void Button_Click_Divisone2(object sender, RoutedEventArgs e)
        {
            double d = double.Parse(txtNumero.Text);
            double r = d / 0.01;
            txtNumero.Text = r.ToString();
        }

        private void Button_Click_Divisione3(object sender, RoutedEventArgs e)
        {
            double d = double.Parse(txtNumero.Text);
            double r = d / 0.001;
            txtNumero.Text = r.ToString();
        }

        private void Button_Click_somma1(object sender, RoutedEventArgs e)
        {
            double d = double.Parse(txtNumero.Text);
            double r = d +1;
            txtNumero.Text = r.ToString();
        }

        private void Button_Click_Somma2(object sender, RoutedEventArgs e)
        {
            double d = double.Parse(txtNumero.Text);
            double r = d + 0.1;
            txtNumero.Text = r.ToString();
        }

        private void Button_Click_Somma3(object sender, RoutedEventArgs e)
        {
            double d = double.Parse(txtNumero.Text);
            double r = d + 0.01;
            txtNumero.Text = r.ToString();
        }
    }
}
