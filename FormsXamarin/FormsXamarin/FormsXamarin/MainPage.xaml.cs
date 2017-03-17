using FormsXamarin.ViewModels;
using Xamarin.Forms;

namespace FormsXamarin
{
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
            BindingContext = new LivrosViewModel();
            var teste = DisplayAlert("Alerta", "Verifique sua conexão com a internet.", "OK");
        }
    }
}
