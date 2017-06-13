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
using Cuentame.VistasModelos;

namespace Cuentame.Vistas
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        VistasModelos.Login vm = new VistasModelos.Login();
        public Login()
        {
            InitializeComponent();
        }

        private void label4_MouseEnter(object sender, MouseEventArgs e)
        {
            vm.Entra(label4);
        }

        private void label4_MouseLeave(object sender, MouseEventArgs e)
        {
            vm.Sale(label4);
        }

        private void btnInicia_Click(object sender, RoutedEventArgs e)
        {
            vm.Inicia_Sesion(RutoEmail.Text, Pass.Password.ToString(), this);
        }
    }
}
