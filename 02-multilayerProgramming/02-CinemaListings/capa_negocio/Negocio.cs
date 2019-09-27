using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_datos;
using capa_entidades;

namespace capa_negocio
{
    public class Negocio
    {
        // atributos
        private BD _bd;
        private List<Pelicula> _cartelera;
        

        // propiedades
        public List<Pelicula> cartelera
        {
            get
            {
                return _cartelera;
            }
        }

        public Negocio()
        {
            // Creo la Base de datos si no existia
            _bd = new BD();

            // Actualizo el objeto cartelera con los valores de la base de datos
            // El acceso a la BD se realizará desde el objeto _bd de la
            // capa de datos
            _cartelera=_bd.leer_cartelera();
        }

        // Guarda una nueva pelicula en la BD
        public int Añadir(string titulo,int edad,int duracion,string descripcion)
        {
            if (PeliculaNoExiste(titulo))
            {
                int filas_almacenadas;

                // Aquí procesaria los datos en según las necesidades de la empresa

                // Añado la película a la cartelera
                Pelicula p = new Pelicula(titulo, descripcion, duracion, edad);
                filas_almacenadas = _bd.añadir(p);

                // Actualizo el objeto cartelera con los valores de la base de datos
                // El acceso a la BD se realizará desde el objeto _bd de la
                // capa de datos
                _cartelera = _bd.leer_cartelera();

                return filas_almacenadas;
            }

            return -1;
        }

        public int Eliminar(string titulo)
        {
            if (!PeliculaNoExiste(titulo))
            {
                int filas_almacenadas;

                filas_almacenadas = _bd.eliminar(titulo);
                
                _cartelera = _bd.leer_cartelera();

                return filas_almacenadas;
            }

            return -1;
        }

        public bool PeliculaNoExiste(string titulo)
        {
            for(int i = 0; i < _cartelera.Count; i++)
            {
                if (_cartelera[i].Titulo == titulo)
                    return false;
            }

            return true;
        }
    }
}
