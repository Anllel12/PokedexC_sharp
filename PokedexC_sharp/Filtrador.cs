using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Autor: Ángel Esquinas
 * 
 * Esta clase enseña los datos realizados en la query de los filtros
 */

namespace PokedexC_sharp
{
    public partial class Filtrador : Form
    {
        Conexion conexion = new Conexion();

        public Filtrador()
        {
            BusquedaFiltro ventana = new BusquedaFiltro();

            InitializeComponent();

            //dataGridView1.DataSource = conexion.getFiltroPokemon(ventana.query); No recibe bien la String 
        }
    }
}
