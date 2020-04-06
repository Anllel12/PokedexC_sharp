﻿using System;
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
 * Esta clase consiste en la realizacion de una query por la cual filtrare los pokemon 
 */

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

        private void queryEspecie()//realizo la query si especie esta seleccionada
        {
            if (listaEspecie != "")
            {
                query = query + "WHERE especie='" + listaEspecie + "'";

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
                query = query + "WHERE tipo1='" + listaTipo + "'";

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
                query = query + "WHERE habilidad='" + listaHabilidad + "'";

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
                query = query + "WHERE habitat='" + listaHabitat + "'";
            }        
        }

        private void filtrar_Click(object sender, EventArgs e)
        {                            
            listaEspecie = listaEspecie + especie.Text;//paso el texto del Item sellecionado a una String
            listaTipo = listaTipo + tipo.Text;
            listaHabilidad = listaHabilidad + habilidad.Text;
            listaHabitat = listaHabitat + habitat.Text;

            queryEspecie();//realizo todas las posibilidades
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
