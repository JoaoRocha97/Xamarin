using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsXamarin.ApiLivros
{
    class Api : ContentPage
    {
        public static async Task<List<Models.Livro>> GetAsync()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var json = await client.GetStringAsync("http://mvalivros.azurewebsites.net/api/livros");
                    var livros = JsonConvert.DeserializeObject<List<Models.Livro>>(json);
                    return livros;
                }
                catch
                {
                    
                }
                return null;
                
            }
        }
        public async void teste()
        {
            var teste = DisplayAlert("Alerta", "Verifique sua conexão com a internet.", "OK");
        }
    }
}