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
 * Esta clase consiste en la busqueda de pokemon por su nombre que mostraremos en la pokedex
 */

namespace PokedexC_sharp
{
    public partial class Buscador : Form
    {
        public String texto = "";

        public Buscador()
        {
            InitializeComponent();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            VentanaPrincipal ventana = new VentanaPrincipal();

            texto = texto + textBox1.Text;//paso el texto escrito en el textBox a la String texto

            ventana.busqueda(texto);
            ventana.Show();//hago esto para que actualize la ventanaPrincipal

            this.Close();//cierro para que parezca que nunca se hubiese abierto
        }
    }
}
