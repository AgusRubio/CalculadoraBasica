using System;
using System.Windows;
using System.Windows.Controls;

namespace CalculadoraBasica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string operador = OperadorTextBox.Text;
                int num1 = int.Parse(Operando1TextBox.Text);
                int num2 = int.Parse(Operando2TextBox.Text);
                int total = 0;

                switch (operador)
                {
                    case "+":
                        total = num1 + num2;
                        ResultadoTextBox.Text = total.ToString();
                        break;
                    case "-":
                        total = num1 - num2;
                        ResultadoTextBox.Text = total.ToString();
                        break;
                    case "*":
                        total = num1 * num2;
                        ResultadoTextBox.Text = total.ToString();
                        break;
                    case "/":
                        total = num1 / num2;
                        ResultadoTextBox.Text = total.ToString();
                        break;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Se ha producido un error. Revisa los operandos", "Calculadora básica", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                Operando1TextBox.Clear();
                Operando2TextBox.Clear();
                OperadorTextBox.Clear();
                ResultadoTextBox.Clear();
            }
            
        }

        private void ComprobarOperadorCorrecto(object sender, TextChangedEventArgs e)
        {
            string operando = OperadorTextBox.Text;

            switch (operando)
            {
                case "+":
                    CalcularBoton.IsEnabled = true;
                    break;
                case "-":
                    CalcularBoton.IsEnabled = true;
                    break;
                case "*":
                    CalcularBoton.IsEnabled = true;
                    break;
                case "/":
                    CalcularBoton.IsEnabled = true;
                    break;
                default:
                    CalcularBoton.IsEnabled = false;
                    break;
            }
        }

        private void Limpiar_Click(object sender, RoutedEventArgs e)
        {
            Operando1TextBox.Clear();
            Operando2TextBox.Clear();
            OperadorTextBox.Clear();
            ResultadoTextBox.Clear();
        }        
    }
}
