using FormsXamarin.Models;
using System.Collections.ObjectModel;
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
            Historico = new ObservableCollection<ItemDeHistorico>();
        }

        private bool CanExecuteSomarCommand() => PrimeiroNumero > 0 && SegundoNumero > 0;

        private void ExecuteSomarCommand()
        {
            Resultado = PrimeiroNumero + SegundoNumero;
            Historico.Add(new ItemDeHistorico(PrimeiroNumero, SegundoNumero, Resultado));
        }

        public ObservableCollection<ItemDeHistorico> Historico { get; set; }
    }
}
