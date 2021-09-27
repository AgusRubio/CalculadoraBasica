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
                string operando = operador.Text;
                int num1 = int.Parse(operador1.Text);
                int num2 = int.Parse(operador2.Text);
                int total = 0;

                switch (operando)
                {
                    case "+":
                        total = num1 + num2;
                        resultado.Text = total.ToString();
                        break;
                    case "-":
                        total = num1 - num2;
                        resultado.Text = total.ToString();
                        break;
                    case "*":
                        total = num1 * num2;
                        resultado.Text = total.ToString();
                        break;
                    case "/":
                        total = num1 / num2;
                        resultado.Text = total.ToString();
                        break;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Se ha producido un error. Revisa los operandos");
            }
            
        }

        private void cambio(object sender, TextChangedEventArgs e)
        {
            string operando = operador.Text;

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
            operador1.Clear();
            operador2.Clear();
            operador.Clear();
            resultado.Clear();
        }        
    }
}
