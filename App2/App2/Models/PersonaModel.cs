using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace App2.Models
{
    public class PersonaModel: System.ComponentModel.INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChange([CallerMemberName]string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }

        private bool isBusy = false;

        public bool Isbusy
        {
            get { return Isbusy=false; }
            set { isBusy = value;
                OnPropertyChange();
            }
        }



        private string id;
        public string  Id {
            get { return id; }
            set { id = value;
                OnPropertyChange();
            }
        }

        private string nombre;
        public string Nombre {
            get { return nombre; }
            set { nombre = value;
                OnPropertyChange();
                OnPropertyChange(nameof(NombreCompleto));
            }
        }

        private string apellido;
        public string  Apellido {
            get { return apellido; }
            set {apellido=value;

                OnPropertyChange();
                OnPropertyChange(nameof(NombreCompleto));
            }
        }

        private int edad; 
        public int Edad {
            get { return edad; }
            set {edad=value;

                OnPropertyChange();
                
            }
        }
        private string nombreCompleto;
        public string NombreCompleto {
            get { return $"{Nombre}{Apellido}";
            } set { nombreCompleto = value;

                OnPropertyChange();
                OnPropertyChange(nameof(Mesaje));
            }
        }
        private string mensaje;
        public string Mesaje {
            get { return $"Tu Nombre es {NombreCompleto}"; }
                 
        }

        
    }

}
