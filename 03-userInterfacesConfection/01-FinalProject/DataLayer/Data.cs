using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace DataLayer
{
    public class Data
    {
        static HttpClient client = new HttpClient();

        public Data()
        {
            client.BaseAddress = new Uri("https://localhost:44384/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromMinutes(10);
        }

        public List<Usuario> ReadUsers()
        {
            List<Usuario> listaUsuarios = null;
            string aux;

            try
            {
                HttpResponseMessage response = client.GetAsync("api/usuarios").Result;

                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    listaUsuarios = JsonConvert.DeserializeObject<List<Usuario>>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return listaUsuarios;
        }

        /*public bool NewUser(string nom, string pas)
        {
            try
            {
                Usuario usu = new Usuario(nom, pas);

                HttpResponseMessage response = client.PostAsJsonAsync("api/articulos", usu).Result;

                if (response.IsSuccessStatusCode)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
                return false;
            }
        }*/
    }
}
