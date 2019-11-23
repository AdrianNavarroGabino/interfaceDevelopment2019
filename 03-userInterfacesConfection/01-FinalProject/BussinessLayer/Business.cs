using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using EntityLayer;
using System.Security.Cryptography;

namespace BussinessLayer
{
    public class Business
    {
        private Data dat;

        public Business()
        {
            dat = new Data();
        }

        public string Codifica_MD5(string pas)
        {
            int i;
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(pas));

            pas = "";
            for (i = 0; i < data.Length; i++)
            {
                pas = pas + data[i];
            }

            return pas;
        }

        // Valido el login de un usuario
        public bool Validate(string usu, string pas)
        {
            List<Usuario> usersList = dat.ReadUsers();

            if (usersList != null)
            {
                for (int i = 0; i < usersList.Count; i++)
                {
                    if ((usersList[i].nombre == usu) &&
                        (usersList[i].password == Codifica_MD5(pas)))
                        return (true);
                }
            }

            return false;
        }

        public List<Provincia> GetProvinces()
        {
            return dat.ReadProvinces();
        }

        public Provincia GetProvince(string provinceId)
        {
            return dat.ReadProvince(provinceId);
        }

        public List<Localidad> GetTowns()
        {
            return dat.ReadTowns();
        }

        public List<Usuario> GetUsers()
        {
            return dat.ReadUsers();
        }

        public bool InsertUser(string id, string mail, string name,
            string surname, string password, string idCard, string phone,
            string address, string postalCode, string provinceId,
            string townId, string birthdate)
        {
            return dat.InsertUser(new Usuario(id, mail, Codifica_MD5(password), name,
                surname, idCard, phone, address, null, postalCode, townId,
                provinceId, birthdate));
        }

        public bool DeleteUser(string id)
        {
            return dat.DeleteUser(id);
        }

        public bool ModifyUser(string id, string mail, string name,
            string surname, string password, string idCard, string phone,
            string address, string postalCode, string provinceId,
            string townId, string birthdate)
        {
            return dat.ModifyUser(id, new Usuario(id, mail, Codifica_MD5(password), name,
                surname, idCard, phone, address, null, postalCode, townId,
                provinceId, birthdate));
        }

        public List<Articulo> GetProducts()
        {
            return dat.ReadProducts();
        }

        public List<TipoArticulo> GetProductTypes()
        {
            return dat.ReadProductTypes();
        }

        public Articulo GetProduct(String idGet)
        {
            return dat.ReadProduct(idGet);
        }

        public TipoArticulo GetType(String type)
        {
            return dat.ReadProductTypes(type);
        }

        public Tv GetTv(String id)
        {
            return dat.ReadTv(id);
        }

        public Memoria GetMemory(String id)
        {
            return dat.ReadMemory(id);
        }

        public Camara GetCamera(String id)
        {
            return dat.ReadCamera(id);
        }

        public Objetivo GetObjective(String id)
        {
            return dat.ReadObjective(id);
        }

        public bool ModifyProduct(string id, Articulo product)
        {
            return dat.ModifyProduct(id, product);
        }

        public Usuario GetUser(String id)
        {
            return dat.ReadUser(id);
        }

        public String CalculatePrice(double finalPrice)
        {
            return (finalPrice * 100 / 121).ToString("#.##");
        }

        public bool InsertOrderRow(Linped lp)
        {
            return dat.InsertOrderRow(lp);
        }

        public List<Pedido> GetOrders()
        {
            return dat.ReadOrders();
        }

        public bool InsertOrder(Pedido order)
        {
            return dat.InsertOrder(order);
        }

        public List<Linped> GetLinpeds()
        {
            return dat.ReadLinpeds();
        }

        public double GetTotalPrice(List<LinpedAux> rows)
        {
            double totalPrice = 0;
            foreach (LinpedAux lp in rows)
            {
                totalPrice += Convert.ToInt32(lp.cantidad) * Convert.ToDouble(lp.pvp);
            }

            return totalPrice;
        }

        public List<Stock> GetStock()
        {
            return dat.ReadStock();
        }
    }
}
