using FormsXamarin.ViewModels;
using Xamarin.Forms;

namespace FormsXamarin
{
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
            BindingContext = new LivrosViewModel();
        }
    }
}
