using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_WPF.Model
{
    public class Equipos : INotifyPropertyChanged
    {
        private int idEquipo;
        private string nombre;
        private int nTrabajadores;
        private List<Trabajadores> trabajadores;
        private String tipoEquipo;

        public int IdEquipo
        {
            get
            {
                return idEquipo;
            }
            set
            {
                idEquipo = value;
                OnPropertyChanged("IdEquipo");
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
        public int NTrabajadores
        {
            get
            {
                return nTrabajadores;
            }
            set
            {
                nTrabajadores = value;
                OnPropertyChanged("NTrabajadores");
            }
        }
        public List<Trabajadores> Trabajadores
        {
            get
            {
                return trabajadores;
            }
            set
            {
                trabajadores = value;
                OnPropertyChanged("Trabajadores");
            }
        }
        public String TipoEquipo
        {
            get
            {
                return tipoEquipo;
            }
            set
            {
                tipoEquipo = value;
                OnPropertyChanged("TipoEquipo");
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

