using FormsXamarin.ViewModels;

namespace FormsXamarin.Models
{
    class Livro : BaseViewModel
    {
        private int id;
        private string nome;
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

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
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
