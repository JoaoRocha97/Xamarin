using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsXamarin.Models
{
    public class Livro : INotifyPropertyChanged
    {
        private int id;
        private string nome;
        private Autor autor;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(id)));
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
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(nome)));
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
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(autor)));
            }
        }
    }
}
