using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace FormsXamarin.ViewModels
{
    class LivrosViewModel : BaseViewModel
    {
        private ObservableCollection<Models.Livro> livros;
        public Command Carregar { get; set; }
        public ObservableCollection<Models.Livro> Livros
        {
            get
            {
                return livros;
            }
            set
            {
                Livros = value;
                OnPropertyChanged();
            }
        }
        public LivrosViewModel()
        {
            Livros = new ObservableCollection<Models.Livro>();
            Carregar = new Command(async () =>
            {
                var livros = await ApiLivros.Api.GetAsync();
                Livros = new ObservableCollection<Models.Livro>(livros);
            });
        }
    }
}
