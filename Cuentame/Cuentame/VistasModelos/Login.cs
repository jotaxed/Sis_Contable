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
using Cuentame.Vistas;
using Cuentame.Modelos;

namespace Cuentame.VistasModelos
{
    class Login
    {
        CuentameEntities CE = new CuentameEntities();
        public void Entra(Label a)
        {
            SolidColorBrush brush = new SolidColorBrush(Color.FromRgb(0, 191, 255));
            a.Foreground = brush;
        }
        public void Sale(Label a)
        {
            SolidColorBrush brush = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            a.Foreground = brush;
        }
        public void Inicia_Sesion(string rutocorreo, string pass, Window win)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(rutocorreo))
                {
                    Usuario us = (from ce in CE.Usuarios join ce2 in CE.Tipo_de_Usuario on ce.Rut equals ce2.Rut where ce.Rut == rutocorreo || ce.Correo == rutocorreo select ce).First();
                    if (us.Password.Equals(pass))
                    {
                        Tipo_de_Usuario tu = (from tu1 in CE.Tipo_de_Usuario join tu2 in CE.Usuarios on tu1.Rut equals tu2.Rut where tu2.Rut == us.Rut select tu1).First();
                        if (tu.Descripcion.Equals("Administrador"))
                        {
                            MessageBoxResult result = MessageBox.Show("Bienvenido al sistema, " + us.Nombre + ", ha ingresado como Contador", "Bienvenido", MessageBoxButton.OK, MessageBoxImage.Information);
                            Vistas.MenuContador MC = new Vistas.MenuContador();
                            MC.Show();
                            win.Close();
                        }
                        else if (tu.Descripcion.Equals("Usuario"))
                        {
                            MessageBoxResult result = MessageBox.Show("Bienvenido al sistema, " + us.Nombre + ", ha ingresado como Cliente", "Bienvenido", MessageBoxButton.OK, MessageBoxImage.Information);
                            Vistas.MenuCliente MC = new Vistas.MenuCliente();
                            MC.Show();
                            win.Close();
                        }
                        else
                        {
                            MessageBoxResult result = MessageBox.Show("Ha ocurrido un problema interno, por favor, solicite al administrador que verifique la Base de Datos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    else
                    {
                        MessageBoxResult result = MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("Debe ingresar un usuario y una contraseña para poder ingresar", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            catch
            {
                MessageBoxResult result = MessageBox.Show("Usuario no encontrado", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
    }
}
