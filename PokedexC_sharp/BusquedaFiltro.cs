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

        Boolean auxiliar = false;

        public BusquedaFiltro()
        {
            InitializeComponent();
        }

        private void queryEspecie()
        {
            if (listaEspecie != "")
            {
                query = query + "SELECT * FROM pokemon WHERE especie='" + listaEspecie + "'";

                if (listaTipo != "")
                {
                    query = query + " AND tipo1='" + listaTipo + "'";

                    if (listaHabilidad != "")
                    {
                        query = query + " AND habilidad='" + listaHabilidad + "'";

                        if (listaHabitat != "")
                        {
                            query = query + " AND habitat='" + listaHabitat + "'";

                            auxiliar = true;
                        }
                    }
                    else if (listaHabitat != "")
                    {
                        query = query + " AND habitat='" + listaHabitat + "'";

                        auxiliar = true;
                    }

                    auxiliar = true;
                }
                else if (listaHabilidad != "")
                {
                    query = query + " AND habilidad='" + listaHabilidad + "'";

                    if (listaHabitat != "")
                    {
                        query = query + " AND habitat='" + listaHabitat + "'";

                        auxiliar = true;
                    }

                    auxiliar = true;
                }
                else if (listaHabitat != "")
                {
                    query = query + " AND habitat='" + listaHabitat + "'";

                    auxiliar = true;
                }
                auxiliar = true;
            }
            
        }

        private void queryTipo()
        {
            if (listaTipo != "")
            {
                query = query + "SELECT * FROM pokemon WHERE tipo1='" + listaTipo + "'";

                if (listaHabilidad != "")
                {
                    query = query + " AND habilidad='" + listaHabilidad + "'";

                    if (listaHabitat != "")
                    {
                        query = query + " AND habitat='" + listaHabitat + "'";

                        auxiliar = true;
                    }
                    auxiliar = true;
                }
                else if (listaHabitat != "")
                {
                    query = query + " AND habitat='" + listaHabitat + "'";

                    auxiliar = true;
                }
                auxiliar = true;
            }
            
        }

        private void queryHabilidad()
        {
            if (listaHabilidad != "")
            {
                query = query + "SELECT * FROM pokemon WHERE habilidad='" + listaHabilidad + "'";

                if (listaHabitat != "")
                {
                    query = query + " AND habitat='" + listaHabitat + "'";

                    auxiliar = true;
                }
                auxiliar = true;
            }
        }
        private void queryHabitat()
        {        
            if (listaHabitat != "")
            {
                query = query + "SELECT * FROM pokemon WHERE habitat='" + listaHabitat + "'";
            }        
        }

        private void filtrar_Click(object sender, EventArgs e)
        {                            
            listaEspecie = listaEspecie + especie.Text;
            listaTipo = listaTipo + tipo.Text;
            listaHabilidad = listaHabilidad + habilidad.Text;
            listaHabitat = listaHabitat + habitat.Text;

            queryEspecie();
            if (!auxiliar)
            {
                queryTipo();
                if (!auxiliar)
                {
                    queryHabilidad();
                    if (!auxiliar)
                    {
                        queryHabitat();
                    }
                }
            }

            Filtrador ventana = new Filtrador();

            ventana.Show();

            this.Close();//cierro para que parezca que nunca se hubiese abierto

            Console.WriteLine(query);
        }
    }
}
