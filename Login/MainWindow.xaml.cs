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


namespace Login
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string usuario;
        private string password;
        private string captcha;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void BtnEntrar_Click(object sender, RoutedEventArgs e)
        {
            usuario = UserText.Text;
            password = PassText.Password;
            captcha = Captcha.Text;
            if (usuario == "") MessageBox.Show("Falta el usuario");
            else if (password == "") MessageBox.Show("Falta la contraseña");
            else if (captcha == "") MessageBox.Show("Falta resolver la operación");
            else
            {
                if (usuario == "hola" && password == "1234" && captcha == "3555")
                {
                    Window1 ventana = new Window1();
                    ventana.Owner = this;
                    ventana.ShowDialog();
                }
                else
                {
                    MessageBox.Show("ERROR.Revise las credenciales");
                }
            } 

            

        }

        private void Ayuda_Click(object sender, RoutedEventArgs e)
        {
            Window2 ventana = new Window2();
            ventana.Owner = this;
            ventana.Show();
            

        }
    }
}
