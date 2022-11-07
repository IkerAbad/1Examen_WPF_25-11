using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen_WPF.Model;

namespace Examen_WPF.Model
{
    public class Trabajadores : INotifyPropertyChanged
    {
        private int idTrabajador;
        private string nombre;
        private string apellidos;
        private string nSS;
        private Equipos equipo;

        public int IdTrabajador
        {
            get
            {
                return idTrabajador;
            }
            set
            {
                idTrabajador = value;
                OnPropertyChanged("IdTrabajador");
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
                OnPropertyChanged("Nombre");
            }
        }
        public string Apellidos
        {
            get
            {
                return apellidos;
            }
            set
            {
                apellidos = value;
                OnPropertyChanged("Apellidos");
            }
        }
        public string NSS
        {
            get
            {
                return nSS;
            }
            set
            {
                nSS = value;
                OnPropertyChanged("NSS");
            }
        }
        public Equipos Equipo
        {
            get
            {
                return equipo;
            }
            set
            {
                equipo = value;
                OnPropertyChanged("Equipo");
            }
        }


        #region INotifyPropertyChanged Members  

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

    }
}

