using FormsXamarin.ViewModels;

namespace FormsXamarin.Models
{
    class Livro : BaseViewModel
    {
        private int id;
        private string titulo;
        private Autor autor;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
                OnPropertyChanged();
            }
        }

        public string Titulo
        {
            get
            {
                return titulo;
            }

            set
            {
                titulo = value;
                OnPropertyChanged();
            }
        }

        public Autor Autor
        {
            get
            {
                return autor;
            }

            set
            {
                autor = value;
                OnPropertyChanged();
            }
        }
    }
}
