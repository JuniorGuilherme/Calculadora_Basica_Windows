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

namespace Calculadora_Basica_Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double valor1=0, valor2=0, result, porcent;
        int operador;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void btn_Um(object sender, RoutedEventArgs e)
        {
            int num = 1;
            txtCaixa_Num.Text=txtCaixa_Num.Text + num.ToString();
        }

        private void btn_Dois(object sender, RoutedEventArgs e)
        {
            int num = 2;
            txtCaixa_Num.Text = txtCaixa_Num.Text + num.ToString();
        }

        private void btn_Tres(object sender, RoutedEventArgs e)
        {
            int num = 3;
            txtCaixa_Num.Text = txtCaixa_Num.Text + num.ToString();
        }

        private void btn_Quatro(object sender, RoutedEventArgs e)
        {
            int num = 4;
            txtCaixa_Num.Text = txtCaixa_Num.Text + num.ToString();
        }

        private void btn_Cinco(object sender, RoutedEventArgs e)
        {
            int num = 5;
            txtCaixa_Num.Text = txtCaixa_Num.Text + num.ToString();
        }

        private void btn_Seis(object sender, RoutedEventArgs e)
        {
            int num = 6;
            txtCaixa_Num.Text = txtCaixa_Num.Text + num.ToString();
        }

        private void btn_Sete(object sender, RoutedEventArgs e)
        {
            int num = 7;
            txtCaixa_Num.Text = txtCaixa_Num.Text + num.ToString();
        }

        private void btn_Oito(object sender, RoutedEventArgs e)
        {
            int num = 8;
            txtCaixa_Num.Text = txtCaixa_Num.Text + num.ToString();
        }

        private void btn_Nove(object sender, RoutedEventArgs e)
        {
            int num = 9;
            txtCaixa_Num.Text = txtCaixa_Num.Text + num.ToString();
        }

        private void btn_Zero(object sender, RoutedEventArgs e)
        {
            int num = 0;
            txtCaixa_Num.Text = txtCaixa_Num.Text + num.ToString();
        }

        private void btn_Virg(object sender, RoutedEventArgs e)
        {
            char virg = ',';
            txtCaixa_Num.Text = txtCaixa_Num.Text + virg.ToString();
        }

        private void btn_Apag(object sender, RoutedEventArgs e)
        {

        }

        private void btn_C(object sender, RoutedEventArgs e)
        {
            txtCaixa_Num.Clear();
        }

        private void btn_Multi(object sender, RoutedEventArgs e)
        {
            valor1 = double.Parse(txtCaixa_Num.Text);
            txtCaixa_Num.Clear();
            operador = 1;
        }

        private void btn_Div(object sender, RoutedEventArgs e)
        {
            valor1 = int.Parse(txtCaixa_Num.Text);
            txtCaixa_Num.Clear();
            operador = 2;
        }

        private void btn_Sub(object sender, RoutedEventArgs e)
        {
            valor1 = int.Parse(txtCaixa_Num.Text);
            txtCaixa_Num.Clear();
            operador = 3;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            valor1 = double.Parse(txtCaixa_Num.Text);
            result = Math.Sqrt(valor1);
            txtCaixa_Num.Clear();
            txtCaixa_Num.Text = result.ToString();
        }

        private void btn_Quad(object sender, RoutedEventArgs e)
        {
            valor1 = double.Parse(txtCaixa_Num.Text);
            txtCaixa_Num.Clear();
            result = valor1 * valor1;
            txtCaixa_Num.Text = result.ToString();
        }

        private void btn_Porcent(object sender, RoutedEventArgs e)
        {
            porcent = double.Parse(txtCaixa_Num.Text);
            porcent = porcent / 100;
            valor2 = valor1 * porcent;
            switch (operador)
            {
                case 3:
                    result = valor1 - valor2;
                    break;
                case 4:
                    result = valor1 + valor2;
                    break;
                case 1:
                    result = valor1 * valor2;
                    break;
                case 2:
                    result = valor1 / valor2;
                    break;
            }
            txtCaixa_Num.Text = result.ToString();
        }

        private void btn_Soma(object sender, RoutedEventArgs e)
        {
            valor1 = double.Parse(txtCaixa_Num.Text);
            txtCaixa_Num.Clear();
            operador = 4; 
        }

        private void btn_Result(object sender, RoutedEventArgs e)
        {
            valor2 = double.Parse(txtCaixa_Num.Text);
            txtCaixa_Num.Clear();
            switch (operador)
            {
                case 1:
                    result = valor1 * valor2;
                    break;
                case 2:
                    result = valor1 / valor2;
                    break;
                case 3:
                    result = valor1 - valor2;
                    break;
                case 4:
                    result = valor1 + valor2;
                    break;
                case 5:
                    result = valor1 - (valor2 / 100 *valor1);
                    break;
            }
            txtCaixa_Num.Text = result.ToString();
        }
    }
}
