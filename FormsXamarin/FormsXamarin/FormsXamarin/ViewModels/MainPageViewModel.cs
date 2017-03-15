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
                SomarCommand.ChangeCanExecute();
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
                SomarCommand.ChangeCanExecute();
            }
        }

        public int Resultado
        {
            get
            {
                return resultado;
            }

            private set
            {
                resultado = value;
                OnPropertyChanged();
                SomarCommand.ChangeCanExecute();
            }
        }

        public Command SomarCommand { get; private set; }

        public MainPageViewModel()
        {
            SomarCommand = new Command(ExecuteSomarCommand, CanExecuteSomarCommand);
        }

        private bool CanExecuteSomarCommand() => PrimeiroNumero > 0 && SegundoNumero > 0;         

        private void ExecuteSomarCommand() => Resultado = PrimeiroNumero + SegundoNumero;
        
    }
}
