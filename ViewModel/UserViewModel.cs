using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen_WPF.Model;
using Examen_WPF.View;
using System.Windows.Input;
using System.Windows;

namespace Examen_WPF.ViewModel
{
    class UserViewModel : MainPage
    {
        public void Button_Click(Object sender, RoutedEventArgs e)
        {
            Informe MiVentana = new Informe();
            MiVentana.Owner = this;
            MiVentana.ShowDialog();
        }


        private ICommand mUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new Updater();
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }

        private class Updater : ICommand
        {
            #region ICommand Members  

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {

            }

            #endregion
        }

        private IList<Trabajadores> listaTrabajadores;

        public UserViewModel()
        {
            listaTrabajadores = new List<Trabajadores>
            {
                new Trabajadores{IdTrabajador = 1,Nombre="Raj",Apellidos="Beniwal",NSS="13424414241S"},
                new Trabajadores{IdTrabajador=2,Nombre="Mark",Apellidos="henry", NSS="124134234A"},
                new Trabajadores{IdTrabajador=3,Nombre="Mahesh",Apellidos="Chand" ,NSS="1412413414A"},
                new Trabajadores{IdTrabajador=4,Nombre="Vikash",Apellidos="Nanda" ,NSS="123414123A"},
                new Trabajadores{IdTrabajador=5,Nombre="Harsh",Apellidos="Kumar" ,NSS="3123112V"},
                new Trabajadores{IdTrabajador=6,Nombre="Reetesh",Apellidos="Tomar", NSS="2131231122D"},
                new Trabajadores{IdTrabajador=7,Nombre="Deven",Apellidos="Verma", NSS="12312312312F"},
                new Trabajadores{IdTrabajador=8,Nombre="Ravi",Apellidos="Taneja", NSS="31231312H"}
            };

        }
    }
}
