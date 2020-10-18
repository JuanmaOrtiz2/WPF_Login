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

namespace Login
{
    /// <summary>
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private int total1 = 0;
        private int total2 = 0;
        private int op;
        private int acumulativo = 0;
        private bool operando2 = false;
        private bool operandoPulsado = false;
        

        public Window2()
        {
            InitializeComponent();
        }

        private void incrementarAcumulativo()
        {
            if (acumulativo == 0)
            {
                acumulativo = 10;
            }
        }

        //Botones numéricos

        private void Btn_1_Click(object sender, RoutedEventArgs e)
        {
            Resultado.Text += "1";
            if(operando2)
            {
                if (acumulativo == 0)
                {
                    total2 += 1;
                }
                else
                {
                    total2 *= acumulativo + 1;
                }

            }
            else
            {
                if (acumulativo == 0)
                {
                    total1 = total1+ 1;
                    
                }
                else
                {
                    
                    total1 = (total1*acumulativo) + 1;
                    
                }
            }
            
            incrementarAcumulativo();            

        }

        private void Btn_2_Click(object sender, RoutedEventArgs e)
        {
            Resultado.Text += "2";
            if (operando2)
            {
                if (acumulativo == 0)
                {
                    total2 += 2;
                }
                else
                {
                    total2 *= acumulativo + 2;
                }

            }
            else
            {
                if (acumulativo == 0)
                {
                    total1 = total1 + 2;

                }
                else
                {

                    total1 = (total1 * acumulativo) + 2;

                }
            }

            incrementarAcumulativo();
            
        }

        private void Btn_3_Click(object sender, RoutedEventArgs e)
        {
            Resultado.Text += "3";
            if (operando2)
            {
                if (acumulativo == 0)
                {
                    total2 += 3;
                }
                else
                {
                    total2 *= acumulativo + 3;
                }

            }
            else
            {
                if (acumulativo == 0)
                {
                    total1 = total1 + 3;

                }
                else
                {

                    total1 = (total1 * acumulativo) + 3;

                }
            }

            incrementarAcumulativo();
            

        }

        private void Btn_4_Click(object sender, RoutedEventArgs e)
        {
            Resultado.Text += "4";
            if (operando2)
            {
                if (acumulativo == 0)
                {
                    total2 += 4;
                }
                else
                {
                    total2 *= acumulativo + 4;
                }

            }
            else
            {
                if (acumulativo == 0)
                {
                    total1 = total1 + 4;

                }
                else
                {

                    total1 = (total1 * acumulativo) + 4;

                }
            }

            incrementarAcumulativo();
            
        }

        private void Btn_5_Click(object sender, RoutedEventArgs e)
        {
            Resultado.Text += "5";
            if (operando2)
            {
                if (acumulativo == 0)
                {
                    total2 += 5;
                }
                else
                {
                    total2 *= acumulativo + 5;
                }

            }
            else
            {
                if (acumulativo == 0)
                {
                    total1 = total1 + 5;

                }
                else
                {

                    total1 = (total1 * acumulativo) + 5;

                }
            }

            incrementarAcumulativo();
            
        }

        private void Btn_6_Click(object sender, RoutedEventArgs e)
        {
            Resultado.Text += "6";
            if (operando2)
            {
                if (acumulativo == 0)
                {
                    total2 += 6;
                }
                else
                {
                    total2 *= acumulativo + 6;
                }

            }
            else
            {
                if (acumulativo == 0)
                {
                    total1 = total1 + 6;

                }
                else
                {

                    total1 = (total1 * acumulativo) + 6;

                }
            }

            incrementarAcumulativo();
           
        }

        private void Btn_7_Click(object sender, RoutedEventArgs e)
        {
            Resultado.Text += "7";
            if (operando2)
            {
                if (acumulativo == 0)
                {
                    total2 += 7;
                }
                else
                {
                    total2 *= acumulativo + 7;
                }

            }
            else
            {
                if (acumulativo == 0)
                {
                    total1 = total1 + 7;

                }
                else
                {

                    total1 = (total1 * acumulativo) + 7;

                }
            }

            incrementarAcumulativo();
            
        }

        private void Btn_8_Click(object sender, RoutedEventArgs e)
        {
            Resultado.Text += "8";
            if (operando2)
            {
                if (acumulativo == 0)
                {
                    total2 += 8;
                }
                else
                {
                    total2 *= acumulativo + 8;
                }

            }
            else
            {
                if (acumulativo == 0)
                {
                    total1 = total1 + 8;

                }
                else
                {

                    total1 = (total1 * acumulativo) + 8;

                }
            }

            incrementarAcumulativo();
           
        }

        private void Btn_9_Click(object sender, RoutedEventArgs e)
        {
            Resultado.Text += "9";
            if (operando2)
            {
                if (acumulativo == 0)
                {
                    total2 += 9;
                }
                else
                {
                    total2 *= acumulativo + 9;
                }

            }
            else
            {
                if (acumulativo == 0)
                {
                    total1 = total1 + 9;

                }
                else
                {

                    total1 = (total1 * acumulativo) + 9;

                }
            }

            incrementarAcumulativo();
            
        }

        private void Btn_0_Click(object sender, RoutedEventArgs e)
        {
            Resultado.Text += "0";
            if (operando2)
            {
                total2 *= 10;
            }
            else
            {
                total1 *= 10;
            }

            incrementarAcumulativo();
            
        }

        //Botones de operaciones

        private void Btn_mas_Click(object sender, RoutedEventArgs e)
        {
            if(operandoPulsado)
            {
                MessageBox.Show("Esta calculadora solo admite 2 operandos. Estamos trabajando en ello");
            }
            else
            {
                Resultado.Text += "+";
                operando2 = true;
                op = 1;
                acumulativo = 0;
                operandoPulsado = true;
            }
            
        }

        private void Btn_menos_Click(object sender, RoutedEventArgs e)
        {
            if (operandoPulsado)
            {
                MessageBox.Show("Esta calculadora solo admite 2 operandos. Estamos trabajando en ello.");
            }
            else
            {
                Resultado.Text += "-";
                operando2 = true;
                op = 2;
                acumulativo = 0;
                operandoPulsado = true;
            }
        }

        private void Btn_por_Click(object sender, RoutedEventArgs e)
        {
            if (operandoPulsado)
            {
                MessageBox.Show("Esta calculadora solo admite 2 operandos. Estamos trabajando en ello");
            }
            else
            {
                Resultado.Text += "*";
                operando2 = true;
                op = 3;
                acumulativo = 0;
                operandoPulsado = true;
            }
        }

        private void Btn_div_Click(object sender, RoutedEventArgs e)
        {
            if (operandoPulsado)
            {
                MessageBox.Show("Esta calculadora solo admite 2 operandos. Estamos trabajando en ello");
            }
            else
            {
                Resultado.Text += "/";
                operando2 = true;
                op = 4;
                acumulativo = 0;
                operandoPulsado = true;
            }
        }

        private void Btn_igual_Click(object sender, RoutedEventArgs e)
        {
            switch(op)
            {
                case 1:
                    total1 += total2;
                    break;
                case 2:
                    total1 -= total2;
                    break;
                case 3:
                    total1 *= total2;
                    break;
                case 4:
                    total1 /= total2;
                    break;

            }
            Resultado.Text = "";
            Resultado.Text = total1.ToString();
        }

        private void Btn_borrar_Click(object sender, RoutedEventArgs e)
        {
            Resultado.Text = "";
            total1 = 0;
            total2 = 0;
            operando2 = false;
            acumulativo = 0;
            operandoPulsado = false;
        }
    }
}
