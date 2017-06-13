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
    /// Lógica de interacción para MenuContador.xaml
    /// </summary>
    public partial class MenuContador : Window
    {
        VistasModelos.MenuContador MC = new VistasModelos.MenuContador();

        public MenuContador()
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
