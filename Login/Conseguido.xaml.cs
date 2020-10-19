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
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private int[,] ocupadas = new int[3,3];
        private int piezasTotales = 0;
        public Window1()
        {
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    ocupadas[i, j] = 0;
                }
            }
            InitializeComponent();
        }

        //Despues de cada ficha se evalua si esa ficha es un movimiento ganador
        private bool condicionVictoria(int a, int b, int jugador)
        {
            bool ganador = false;
            if (b == 0)
            {
                if (ocupadas[a, b + 1] == jugador && ocupadas[a, b + 2] == jugador)
                {
                    ganador = true;
                }
                if(a == 0)
                {
                    if(ocupadas[a+1,b+1]==jugador && ocupadas[a+2,b+2]==jugador)
                    {
                        ganador = true;
                    }
                }
            }
            if (a == 0)
            {
                if (ocupadas[a + 1, b] == jugador && ocupadas[a + 2, b] == jugador)
                {
                    ganador = true;
                    MessageBox.Show("Aqui 2");
                }

            }
            if (b == 2)
            {
                if (ocupadas[a, b - 1] == jugador && ocupadas[a, b - 2] == jugador)
                {
                    ganador = true;
                    MessageBox.Show("Aqui 3");
                }
                if (a == 0)
                {
                    if (ocupadas[a +1, b - 1] == jugador && ocupadas[a + 2, b - 2] == jugador)
                    {
                        ganador = true;
                    }
                }
                if (a == 2)
                {
                    if (ocupadas[a - 1, b - 1] == jugador && ocupadas[a - 2, b - 2] == jugador)
                    {
                        ganador = true;
                    }
                }
            }
            if (a == 2)
            {
                if (ocupadas[a - 1, b] == jugador && ocupadas[a - 2, b] == jugador)
                {
                    ganador = true;
                    MessageBox.Show("Aqui 4");
                }
                if(b==0)
                {
                    if(ocupadas[a-1,b+1]==jugador && ocupadas[a-2,b+2]==jugador)
                    {
                        ganador = true;
                    }
                }
            }
            if(a>0 && b>0 && a<2 && b<2)
            {
                if (ocupadas[a, b - 1] == jugador && ocupadas[a, b + 1] == jugador || ocupadas[a - 1, b] == jugador && ocupadas[a + 1, b] == jugador)
                {
                    ganador = true;
                    MessageBox.Show("Aqui 5");
                }
                if(ocupadas[a-1,b-1] == jugador && ocupadas[a+1,b+1] == jugador || ocupadas[a-1,b+1] == jugador && ocupadas[a+1,b-1]==jugador )
                {
                    ganador = true;
                }
            }
            return ganador;
        }


        // Movimiento del oponente
        private void Oponente()
        {
            int a = 0;
            int b = 0;
            bool colocada = false;
            int contador = 1;
            if (piezasTotales == 9) {
                colocada = true;
                BtnReset.Visibility = Visibility.Visible;
            } 
            while(!colocada)
            {
                if(ocupadas[a,b] == 0)
                {
                    colocada = true;
                    ocupadas[a, b] = 2;
                    switch(contador)
                    {
                        case 1:
                            circ1.Visibility = Visibility.Visible;
                            break;
                        case 2:
                            circ2.Visibility = Visibility.Visible;
                            break;
                        case 3:
                            circ3.Visibility = Visibility.Visible;
                            break;
                        case 4:
                            circ4.Visibility = Visibility.Visible;
                            break;
                        case 5:
                            circ5.Visibility = Visibility.Visible;
                            break;
                        case 6:
                            circ6.Visibility = Visibility.Visible;
                            break;
                        case 7:
                            circ7.Visibility = Visibility.Visible;
                            break;
                        case 8:
                            circ8.Visibility = Visibility.Visible;
                            break;
                        case 9:
                            circ9.Visibility = Visibility.Visible;
                            break;
                    }
                    piezasTotales++;
                    Console.WriteLine("Pieza Maquina: " + a + " " + b);
                    bool campeon = condicionVictoria(a, b,2);
                    if(campeon)
                    {
                        MessageBox.Show("La maquina ha ganado");
                        BtnReset.Visibility = Visibility.Visible;
                    }
                }
                contador++;
                    if(b == 2)
                    {
                        b = 0;
                        a++;
                    }
                    else
                    {
                        b++;
                    }
            }
        }

        

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            equis1.Visibility = Visibility.Visible;
            ocupadas[0, 0] = 1;
            piezasTotales++;
            Console.WriteLine("Pieza Jugador: " + 0 + " " + 0);
            bool campeon = condicionVictoria(0, 0, 1);
            if (campeon)
            {
                MessageBox.Show("Has ganado!");
                BtnReset.Visibility = Visibility.Visible;
            }
            Oponente();
            


        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            equis2.Visibility = Visibility.Visible;
            ocupadas[0, 1] = 1;
            piezasTotales++;
            Console.WriteLine("Pieza Jugador: " + 0 + " " + 1);
            bool campeon = condicionVictoria(0, 1, 1);
            if (campeon)
            {
                MessageBox.Show("Has ganado!");
                BtnReset.Visibility = Visibility.Visible;
            }
            Oponente();
            
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            equis3.Visibility = Visibility.Visible;
            ocupadas[0, 2] = 1;
            piezasTotales++;
            Console.WriteLine("Pieza Jugador: " + 0 + " " + 2);
            bool campeon = condicionVictoria(0, 2, 1);
            if (campeon)
            {
                MessageBox.Show("Has ganado!");
                BtnReset.Visibility = Visibility.Visible;
            }
            Oponente();
            
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            equis4.Visibility = Visibility.Visible;
            ocupadas[1, 0] = 1;
            piezasTotales++;
            Console.WriteLine("Pieza Jugador: " + 1 + " " + 0);
            bool campeon = condicionVictoria(1, 0, 1);
            if (campeon)
            {
                MessageBox.Show("Has ganado!");
                BtnReset.Visibility = Visibility.Visible;
            }
            Oponente();
           
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            equis5.Visibility = Visibility.Visible;
            ocupadas[1, 1] = 1;
            piezasTotales++;
            Console.WriteLine("Pieza Jugador: " + 1 + " " + 1);
            bool campeon = condicionVictoria(1, 1, 1);
            if (campeon)
            {
                MessageBox.Show("Has ganado!");
                BtnReset.Visibility = Visibility.Visible;
            }
            Oponente();
            
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            equis6.Visibility = Visibility.Visible;
            ocupadas[1, 2] = 1;
            piezasTotales++;
            Console.WriteLine("Pieza Jugador: " + 1 + " " + 2);
            bool campeon = condicionVictoria(1, 2, 1);
            if (campeon)
            {
                MessageBox.Show("Has ganado!");
                BtnReset.Visibility = Visibility.Visible;
            }
            Oponente();
            
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            equis7.Visibility = Visibility.Visible;
            ocupadas[2, 0] = 1;
            piezasTotales++;
            Console.WriteLine("Pieza Jugador: " + 2 + " " + 0);
            bool campeon = condicionVictoria(2, 0, 1);
            if (campeon)
            {
                MessageBox.Show("Has ganado!");
                BtnReset.Visibility = Visibility.Visible;
            }
            Oponente();
            
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            equis8.Visibility = Visibility.Visible;
            ocupadas[2, 1] = 1;
            piezasTotales++;
            Console.WriteLine("Pieza Jugador: " + 2 + " " + 1);
            bool campeon = condicionVictoria(2, 1, 1);
            if (campeon)
            {
                MessageBox.Show("Has ganado!");
                BtnReset.Visibility = Visibility.Visible;
            }
            Oponente();
            
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            equis9.Visibility = Visibility.Visible;
            ocupadas[2, 2] = 1;
            piezasTotales++;
            Console.WriteLine("Pieza Jugador: " + 2 + " " + 2);
            bool campeon = condicionVictoria(2, 2, 1);
            if (campeon)
            {
                MessageBox.Show("Has ganado!");
                BtnReset.Visibility = Visibility.Visible;
            }
            Oponente();
            
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            piezasTotales = 0;
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    ocupadas[i, j] = 0;
                }
            }
            equis1.Visibility = Visibility.Hidden;
            equis2.Visibility = Visibility.Hidden;
            equis3.Visibility = Visibility.Hidden;
            equis4.Visibility = Visibility.Hidden;
            equis5.Visibility = Visibility.Hidden;
            equis6.Visibility = Visibility.Hidden;
            equis7.Visibility = Visibility.Hidden;
            equis8.Visibility = Visibility.Hidden;
            equis9.Visibility = Visibility.Hidden;

            circ1.Visibility = Visibility.Hidden;
            circ2.Visibility = Visibility.Hidden;
            circ3.Visibility = Visibility.Hidden;
            circ4.Visibility = Visibility.Hidden;
            circ5.Visibility = Visibility.Hidden;
            circ6.Visibility = Visibility.Hidden;
            circ7.Visibility = Visibility.Hidden;
            circ8.Visibility = Visibility.Hidden;
            circ9.Visibility = Visibility.Hidden;

            BtnReset.Visibility = Visibility.Hidden;
        }
    }
}
