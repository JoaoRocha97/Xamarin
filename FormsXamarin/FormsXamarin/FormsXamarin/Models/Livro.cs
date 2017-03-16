using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsXamarin.Models
{
    class Livro : ViewModels.BaseViewModel
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
