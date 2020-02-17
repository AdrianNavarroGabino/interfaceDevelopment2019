// Adrián Navarro Gabino

using System;
using System.Collections.Generic;
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
                HttpResponseMessage response =
                    client.GetAsync("api/usuarios").Result;

                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    listaUsuarios =
                        JsonConvert.DeserializeObject<List<Usuario>>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return listaUsuarios;
        }

        public List<Provincia> ReadProvinces()
        {
            List<Provincia> provincesList = null;
            string aux;

            try
            {
                HttpResponseMessage response =
                    client.GetAsync("api/provincias").Result;

                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    provincesList =
                        JsonConvert.DeserializeObject<List<Provincia>>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return provincesList;
        }

        public Provincia ReadProvince(string provinceId)
        {
            Provincia province = null;
            string aux;

            try
            {
                HttpResponseMessage response =
                    client.GetAsync("api/Provincias/" + provinceId).Result;

                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    province = JsonConvert.DeserializeObject<Provincia>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return province;
        }

        public List<Localidad> ReadTowns()
        {
            List<Localidad> townsList = null;
            string aux;

            try
            {
                HttpResponseMessage response =
                    client.GetAsync("api/localidades").Result;

                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    townsList =
                        JsonConvert.DeserializeObject<List<Localidad>>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return townsList;
        }

        public bool InsertUser(Usuario user)
        {
            try
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("api/usuarios", user).Result;

                if (response.IsSuccessStatusCode)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return true;
        }

        public bool DeleteUser(string id)
        {
            try
            {
                HttpResponseMessage response =
                    client.DeleteAsync("api/usuarios/" + id).Result;

                if (response.IsSuccessStatusCode)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return true;
        }

        public bool ModifyUser(string id, Usuario user)
        {
            try
            {
                HttpResponseMessage response =
                    client.PutAsJsonAsync("api/usuarios/" + id, user).Result;

                if (response.IsSuccessStatusCode)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return true;
        }

        public List<Articulo> ReadProducts()
        {
            List<Articulo> productsList = null;
            string aux;

            try
            {
                HttpResponseMessage response =
                    client.GetAsync("api/Articulos").Result;

                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    productsList =
                        JsonConvert.DeserializeObject<List<Articulo>>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return productsList;
        }

        public List<TipoArticulo> ReadProductTypes()
        {
            List<TipoArticulo> productTypesList = null;
            string aux;

            try
            {
                HttpResponseMessage response =
                    client.GetAsync("api/tipoArticulos").Result;

                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    productTypesList =
                        JsonConvert.DeserializeObject<List<TipoArticulo>>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return productTypesList;
        }

        public Articulo ReadProduct(String idGet)
        {
            Articulo product = null;
            string aux;

            try
            {
                HttpResponseMessage response =
                    client.GetAsync("api/Articulos/" + idGet).Result;

                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    product = JsonConvert.DeserializeObject<Articulo>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return product;
        }
        
        public TipoArticulo ReadProductTypes(String type)
        {
            TipoArticulo productType = null;
            string aux;

            try
            {
                HttpResponseMessage response =
                    client.GetAsync("api/tipoArticulos/" + type).Result;

                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    productType =
                        JsonConvert.DeserializeObject<TipoArticulo>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return productType;
        }

        public Tv ReadTv(String id)
        {
            Tv tv = null;
            string aux;

            try
            {
                HttpResponseMessage response =
                    client.GetAsync("api/Tvs/" + id).Result;

                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    tv = JsonConvert.DeserializeObject<Tv>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return tv;
        }

        public Memoria ReadMemory(String id)
        {
            Memoria memory = null;
            string aux;

            try
            {
                HttpResponseMessage response =
                    client.GetAsync("api/Memorias/" + id).Result;

                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    memory = JsonConvert.DeserializeObject<Memoria>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return memory;
        }

        public Camara ReadCamera(String id)
        {
            Camara camera = null;
            string aux;

            try
            {
                HttpResponseMessage response =
                    client.GetAsync("api/Camaras/" + id).Result;

                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    camera = JsonConvert.DeserializeObject<Camara>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return camera;
        }

        public Objetivo ReadObjective(String id)
        {
            Objetivo objective = null;
            string aux;

            try
            {
                HttpResponseMessage response =
                    client.GetAsync("api/Objetivos/" + id).Result;

                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    objective = JsonConvert.DeserializeObject<Objetivo>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return objective;
        }

        public bool ModifyProduct(string id, Articulo product)
        {
            try
            {
                HttpResponseMessage response =
                    client.PutAsJsonAsync(
                        "api/Articulos/" + id, product).Result;

                if (response.IsSuccessStatusCode)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return true;
        }

        public Usuario ReadUser(String id)
        {
            Usuario user = null;
            string aux;

            try
            {
                HttpResponseMessage response =
                    client.GetAsync("api/Usuarios/" + id).Result;

                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    user = JsonConvert.DeserializeObject<Usuario>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return user;
        }

        public bool InsertOrderRow(Linped lp)
        {
            try
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("api/Linped", lp).Result;

                if (response.IsSuccessStatusCode)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return true;
        }

        public List<Pedido> ReadOrders()
        {
            List<Pedido> ordersList = null;
            string aux;

            try
            {
                HttpResponseMessage response =
                    client.GetAsync("api/Pedidos").Result;

                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    ordersList =
                        JsonConvert.DeserializeObject<List<Pedido>>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return ordersList;
        }

        public Pedido ReadOrder(string id)
        {
            Pedido order = null;
            string aux;

            try
            {
                HttpResponseMessage response =
                    client.GetAsync("api/Pedidos/" + id).Result;

                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    order = JsonConvert.DeserializeObject<Pedido>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return order;
        }

        public bool InsertOrder(Pedido order)
        {
            try
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("api/Pedidos", order).Result;

                if (response.IsSuccessStatusCode)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return true;
        }

        public List<Linped> ReadLinpeds()
        {
            List<Linped> orderRows = null;
            string aux;

            try
            {
                HttpResponseMessage response =
                    client.GetAsync("api/Linped").Result;

                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    orderRows =
                        JsonConvert.DeserializeObject<List<Linped>>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return orderRows;
        }

        public List<Stock> ReadStock()
        {
            List<Stock> stock = null;
            string aux;

            try
            {
                HttpResponseMessage response =
                    client.GetAsync("api/Stock").Result;

                if (response.IsSuccessStatusCode)
                {
                    aux = response.Content.ReadAsStringAsync().Result;

                    stock = JsonConvert.DeserializeObject<List<Stock>>(aux);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return stock;
        }

        public bool DeleteRow(string order, int row)
        {
            try
            {
                HttpResponseMessage response =
                    client.DeleteAsync(
                        "api/Linped/" + order + ":" + row).Result;

                if (response.IsSuccessStatusCode)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return true;
        }

        public bool DeleteOrder(string orderPK)
        {
            try
            {
                HttpResponseMessage response =
                    client.DeleteAsync("api/Pedidos/" + orderPK).Result;

                if (response.IsSuccessStatusCode)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return true;
        }
    }
}
