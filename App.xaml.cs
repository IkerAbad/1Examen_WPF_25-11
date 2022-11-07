using Examen_WPF.View;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Examen_WPF
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void Button_Click(Object sender, RoutedEventArgs e)
        {
            Informe MiVentana = new Informe();
            MiVentana.Owner = this;
            MiVentana.ShowDialog();
        }

        public static implicit operator Window(App v)
        {
            throw new NotImplementedException();
        }
    }


}
