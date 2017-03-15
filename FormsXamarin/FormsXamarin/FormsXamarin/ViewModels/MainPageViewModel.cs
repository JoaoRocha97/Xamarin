using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsXamarin.ViewModels
{
    class MainPageViewModel : BaseViewModel
    {
        private int primeiroNumero;
        private int segundoNumero;
        private int resultado;

        public int PrimeiroNumero
        {
            get
            {
                return primeiroNumero;
            }
            set
            {
                primeiroNumero = value;
                OnPropertyChanged();
            }
        }

        public int SegundoNumero
        {
            get
            {
                return segundoNumero;
            }

            set
            {
                segundoNumero = value;
                OnPropertyChanged();
            }
        }

        public int Resultado
        {
            get
            {
                return resultado;
            }

            set
            {
                resultado = value;
                OnPropertyChanged();
            }
        }

        public Command SomarCommand { get; set; }

    }
}
