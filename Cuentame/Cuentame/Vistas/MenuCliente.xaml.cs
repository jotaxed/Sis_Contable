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

namespace Cuentame.Vistas
{
    /// <summary>
    /// Lógica de interacción para MenuCliente.xaml
    /// </summary>
    public partial class MenuCliente : Window
    {
        VistasModelos.MenuCliente MC = new VistasModelos.MenuCliente();

        public MenuCliente()
        {
            InitializeComponent();
        }

        private void Salir(object sender, RoutedEventArgs e)
        {
            MC.Salir();
        }

        private void Cierra_sesion(object sender, RoutedEventArgs e)
        {
            MC.CierraSesion(this);
        }
    }
}
