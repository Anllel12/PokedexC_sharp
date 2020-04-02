using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexC_sharp
{
    public partial class VentanaPrincipal : Form
    {
        Conexion conexion= new Conexion();
        DataTable pokemons = new DataTable();

        int idActual = 1;//el pokemon que estamos viendo

        public VentanaPrincipal()
        {
            InitializeComponent();
            //es para que salga directamente Bulbasur al iniciar el programa
            pokemons = conexion.getPokemonId(idActual);//pasa el id a la clase Conexion
            label.Text = pokemons.Rows[0]["nombre"].ToString();//coge la columna nombre y la pasa a String
            imagen.Image = blobImagen((byte[])pokemons.Rows[0]["imagen"]);//pone la imagen del pokemon
        }

        public void busqueda(String texto)//al hacer la busqueda este se conecta con la base de datos
        {
            try
            {
                pokemons = conexion.getPokemonNombre(texto);//pasa el nombre a la clase Conexion

                label.Text = pokemons.Rows[0]["nombre"].ToString();//coge la columna nombre y la pasa a String
                imagen.Image = blobImagen((byte[])pokemons.Rows[0]["imagen"]);//pone la imagen del pokemon

                idActual = Convert.ToInt16(pokemons.Rows[0]["id"]);//hago que coincida el idActual con el pokemon de la busqueda
            }
            catch
            {
                Console.WriteLine("Pokemon no encontrado. Tal vez esta mal escrito");
            }
        }

        private Image blobImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);//lee el formato de la Base de Datos y lo transforma en imagen
            return (Image.FromStream(ms));
        }


        private void anterior_Click(object sender, EventArgs e)
        {
            idActual--;
            if (idActual <= 0) { idActual = 1; }

            pokemons = conexion.getPokemonId(idActual);//pasa el id a la clase Conexion

            label.Text = pokemons.Rows[0]["nombre"].ToString();//coge la columna nombre y la pasa a String
            imagen.Image = blobImagen((byte[])pokemons.Rows[0]["imagen"]);//pone la imagen del pokemon
        }

        private void siguiente_Click(object sender, EventArgs e)
        {
            idActual++;
            if (idActual >= 151) { idActual = 151; }

            pokemons = conexion.getPokemonId(idActual);//pasa el id a la clase Conexion

            label.Text = pokemons.Rows[0]["nombre"].ToString();//coge la columna nombre y la pasa a String
            imagen.Image = blobImagen((byte[])pokemons.Rows[0]["imagen"]);//pone la imagen del pokemon
        }

        private void especie_Click(object sender, EventArgs e)
        {
            label.Text = pokemons.Rows[0]["especie"].ToString();//coge la columna especie y la pasa a String
        }

        private void tipo_Click(object sender, EventArgs e)
        {
            label.Text = pokemons.Rows[0]["tipo1"].ToString();//coge la columna nombre y la pasa a String
            label.Text += " " + pokemons.Rows[0]["tipo2"].ToString();//coge la columna nombre y la pasa a String
        }

        private void habilidad_Click(object sender, EventArgs e)
        {
            label.Text = pokemons.Rows[0]["habilidad"].ToString();//coge la columna nombre y la pasa a String
        }

        private void habitat_Click(object sender, EventArgs e)
        {
            label.Text = pokemons.Rows[0]["habitat"].ToString();//coge la columna nombre y la pasa a String
        }

        private void altura_Click(object sender, EventArgs e)
        {
            label.Text = pokemons.Rows[0]["altura"].ToString() + "m";//coge la columna nombre y la pasa a String
        }

        private void peso_Click(object sender, EventArgs e)
        {
            label.Text = pokemons.Rows[0]["peso"].ToString() + "KG";//coge la columna nombre y la pasa a String
        }

        private void preEvolucion_Click(object sender, EventArgs e)
        {
            label.Text = pokemons.Rows[0]["preEvolucion"].ToString();//coge la columna nombre y la pasa a String
        }

        private void posEvolucion_Click(object sender, EventArgs e)
        {
            label.Text = pokemons.Rows[0]["posEvolucion"].ToString();//coge la columna nombre y la pasa a String
        }

        private void movimiento1_Click(object sender, EventArgs e)
        {
            label.Text = pokemons.Rows[0]["movimiento1"].ToString();//coge la columna nombre y la pasa a String
            label.Text += " " + pokemons.Rows[0]["movimiento2"].ToString();//coge la columna nombre y la pasa a String
        }

        private void movimiento2_Click(object sender, EventArgs e)
        {
            label.Text = pokemons.Rows[0]["movimiento3"].ToString();//coge la columna nombre y la pasa a String
            label.Text += " " + pokemons.Rows[0]["movimiento4"].ToString();//coge la columna nombre y la pasa a String
        }

        private void descripcion_Click(object sender, EventArgs e)
        {
            label.Text = pokemons.Rows[0]["descripcion"].ToString();//coge la columna nombre y la pasa a String
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            Buscador ventana = new Buscador();

            ventana.Show();//aparece el buscador

            this.Hide();//hago esto porque si no aparecen muchas pantallas de la pokedex
        }
    }
}
