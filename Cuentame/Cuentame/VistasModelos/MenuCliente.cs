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

namespace Cuentame.VistasModelos
{
    class MenuCliente
    {
        public void Salir()
        {
            Application.Current.Shutdown();
        }
        public void CierraSesion(Window MC)
        {
            Vistas.Login Login = new Vistas.Login();
            Login.Show();
            MC.Close();
        }
    }
}
