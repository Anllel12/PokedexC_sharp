using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexC_sharp
{
    public partial class BusquedaFiltro : Form
    {
        public String query = "";
        public String listaEspecie = "";
        public String listaHabilidad = "";
        public String listaHabitat = "";
        public String listaTipo = "";

        public BusquedaFiltro()
        {
            InitializeComponent();
        }

        private void filtrar_Click(object sender, EventArgs e)
        {
            //Filtrador ventana = new Filtrador();
            if (Convert.ToBoolean(especie.SelectedItem))
            {
                label4.Text = especie.Text;
            }
            if (Convert.ToBoolean(habilidad.SelectedItem))
            {
                label5.Text = habilidad.Text;
            }
            if (Convert.ToBoolean(habitat.SelectedItem))
            {
                label6.Text = habitat.Text;
            }
            if (Convert.ToBoolean(tipo.SelectedItem))
            {
                label7.Text = tipo.Text;
            }
            //listaEspecie = listaEspecie + especie.Text;
            //listaHabilidad = listaHabilidad + habilidad.Text;
            //listaHabitat = listaHabitat + habitat.Text;
            //listaTipo = listaTipo + tipo.Text;

            //ventana.Show();

            //this.Close();//cierro para que parezca que nunca se hubiese abierto
        }
    }
}
