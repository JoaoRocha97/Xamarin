using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace FormsXamarin.ViewModels
{
    class LivrosViewModel : ViewModels.BaseViewModel
    {
        private ObservableCollection<Models.Livro> livro;

        public Command CarregarCommand { get; set; }

        public ObservableCollection<Models.Livro> Livros
        {
            get
            {
                return livro;
            }

            set
            {
                livro = value;
                OnPropertyChanged();
            }
        }
        public LivrosViewModel()
        {
            Livros = new ObservableCollection<Models.Livro>();
            Livros.Add(new Models.Livro { Id = 1, Nome = "Teste"});
            CarregarCommand = new Command(async () =>
            {
                var livros = await ApiLivros.Api.GetAsync();
                
                Livros = new ObservableCollection<Models.Livro>(livros);
            });
        }
    }
}