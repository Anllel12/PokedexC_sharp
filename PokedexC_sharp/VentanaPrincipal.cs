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

            nombre.Text = pokemons.Rows[0]["nombre"].ToString();//coge la columna nombre y la pasa a String
            imagen.Image = blobImagen((byte[])pokemons.Rows[0]["imagen"]);//pone la imagen del pokemon
        }

        private void siguiente_Click(object sender, EventArgs e)
        {
            idActual++;
            if (idActual >= 151) { idActual = 151; }

            pokemons = conexion.getPokemonId(idActual);//pasa el id a la clase Conexion

            nombre.Text = pokemons.Rows[0]["nombre"].ToString();//coge la columna nombre y la pasa a String
            imagen.Image = blobImagen((byte[])pokemons.Rows[0]["imagen"]);//pone la imagen del pokemon
        }
    }
}
