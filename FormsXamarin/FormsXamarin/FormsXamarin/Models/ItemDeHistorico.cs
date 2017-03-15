using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsXamarin.Models
{
    public class ItemDeHistorico
    {
        public int PrimeiroNumero{ get; }
        public int SegundoNumero{ get; }
        public int Resultado { get; }
        public DateTime Data { get; }

        public ItemDeHistorico(int primeiroNumero, int segundoNumero, int resultado)
        {
            Data = DateTime.Now;
            PrimeiroNumero = primeiroNumero;
            SegundoNumero = segundoNumero;
            Resultado = resultado;
        }
    }
}
