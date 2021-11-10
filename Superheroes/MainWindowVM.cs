using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private Superheroe superheroeActual;

        public Superheroe SuperheroeActual
        {
            get { return superheroeActual; }
            set { superheroeActual = value;
                NotifyPropertyChanged("SuperheroeActual");
            }
        }

        private int actual;

        public int Actual
        {
            get { return actual; }
            set { actual = value;
                NotifyPropertyChanged("Actual");
            }
        }

        private int total;

        public int Total
        {
            get { return total; }
            set { total = value;
                NotifyPropertyChanged("Total");
            }
        }

        public List<Superheroe> lista = Superheroe.GetSamples();     

        public MainWindowVM()
        {
            
            SuperheroeActual = lista[0];
            Actual = 1;
            Total = Superheroe.GetSamples().Count;
        }

        public void Avanzar()
        {
            if(Actual < Total)
            {
                Actual++;
                SuperheroeActual = lista[Actual - 1];
            }
        }
        public void Retroceder()
        {
            if (Actual > 1)
            {
                Actual--;
                SuperheroeActual = lista[Actual - 1];
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
