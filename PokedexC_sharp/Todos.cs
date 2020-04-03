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
    public partial class Todos : Form
    {
        Conexion conexion = new Conexion();
        DataTable pokemons = new DataTable();

        int idActual = 1;//el pokemon que estamos viendo

        public Todos()
        {
            InitializeComponent();

            dataGridView2.DataSource = conexion.getTodosPokemon();

            pokemons = conexion.getPokemonId(idActual);//pasa el id a la clase Conexion           
            pictureBox1.Image = blobImagen((byte[])pokemons.Rows[0]["imagen"]);//pone la imagen del pokemon
            label1.Text = pokemons.Rows[0]["nombre"].ToString();//coge la columna nombre y la pasa a String
        }

        private Image blobImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);//lee el formato de la Base de Datos y lo transforma en imagen
            return (Image.FromStream(ms));
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = dataGridView2.Rows[e.RowIndex].Cells["nombre"].Value.ToString();//segun la columna donde pinche te pone el nombre del pokemon
            pictureBox1.Image = blobImagen((byte[])dataGridView2.Rows[e.RowIndex].Cells["imagen"].Value);//pone la imagen del pokemon segun la columna donde pinche
        }
    }
}
