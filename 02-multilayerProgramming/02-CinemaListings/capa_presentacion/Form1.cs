using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_negocio;
using capa_entidades;


namespace capa_presentacion
{
    public partial class Form1 : Form
    {
        private Negocio negocio;
       
        public Form1()
        {
            InitializeComponent();

            negocio = new Negocio();
            leer_cartelera();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                int filas_almacenadas;

                // Aqui realizariamos las validaciones de los campos del formulario

                // Envío los datos a la capa de negocio
                filas_almacenadas = negocio.Añadir(box_titulo.Text,
                                  System.Convert.ToInt32(box_edad.Value),
                                  System.Convert.ToInt32(box_duracion.Value),
                                  box_descripcion.Text);

                if (filas_almacenadas == 1)
                {
                    label_resultado.ForeColor = Color.Black;
                    label_resultado.Text = "La pelicula se almacenó en la base de datos";

                    // relleno el datagrid de cartelera
                    leer_cartelera();
                }
                else if(filas_almacenadas == -1)
                {
                    label_resultado.ForeColor = Color.Red;
                    label_resultado.Text = "La película ya existe";
                }
                else
                {
                    label_resultado.ForeColor = Color.Red;
                    label_resultado.Text = "Error al almacenar la pelicula en la base de datos";
                }

                box_titulo.Text = "";
                box_duracion.Value = 0;
                box_descripcion.Text = "";
                box_edad.Value = 0;
            }
            else
            {
                label_resultado.ForeColor = Color.Red;
                label_resultado.Text = "Error al introducir película. Faltan datos";
            }
        }

        // Actualizo el valor del DataGrid de cartelera
        private void leer_cartelera()
        {
            int i = 0;
            List<Pelicula> aux;

            // Obtengo la lista de peliculas accediendo a la propiedad cartelera
            // del objeto negocio
            aux = negocio.cartelera;

            dataGridView1.Rows.Clear();
            while (i < aux.Count)
            {
                dataGridView1.Rows.Add();
                i++;
            }

            i = 0;
            while (i < aux.Count)
            {
                dataGridView1.Rows[i + 1].Cells[0].Value = aux[i].Titulo;
                dataGridView1.Rows[i + 1].Cells[1].Value = aux[i].Duracion.ToString();
                i++;
            }
        }

        private bool ValidateForm()
        {
            if (box_titulo.Text == "")
                return false;
            if (box_duracion.Value == 0)
                return false;

            return true;
        }

        private void EliminarPelicula(object sender, EventArgs e)
        {
            int filas_almacenadas;
            
            filas_almacenadas = negocio.Eliminar(box_titulo.Text);

            if (filas_almacenadas == 1)
            {
                label_resultado.ForeColor = Color.Black;
                label_resultado.Text = "La pelicula se eliminó de la base de datos";

                // relleno el datagrid de cartelera
                leer_cartelera();
            }
            else if (filas_almacenadas == -1)
            {
                label_resultado.ForeColor = Color.Red;
                label_resultado.Text = "La película no existe";
            }
            else
            {
                label_resultado.ForeColor = Color.Red;
                label_resultado.Text = "Error al eliminar la pelicula de la base de datos";
            }

            box_titulo.Text = "";
            box_duracion.Value = 0;
            box_descripcion.Text = "";
            box_edad.Value = 0;
        }

        private void getData(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                box_titulo.Text = dataGridView1.CurrentRow.Cells[0].
                    Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells[1].Value != null)
            {
                box_duracion.Text = dataGridView1.CurrentRow.Cells[1].
                    Value.ToString();
            }
        }
    }
}
