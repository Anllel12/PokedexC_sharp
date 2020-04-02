using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PokedexC_sharp
{
    class Conexion
    {
        public MySqlConnection conexion;

        public Conexion()
        {
            try
            {
                conexion = new MySqlConnection("Server=127.0.0.1; Database=listapokemons; Uid=root; Pwd=; Port=3306");
            }
            catch (MySqlException e)
            {
                throw e;
            }

        }

        public DataTable getPokemonId(int id)
        {
            try
            {
                conexion.Open();//conectamos con la base de datos
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM pokemon WHERE id='" + id + "'", conexion);//hacemos la query
                MySqlDataReader resultado = consulta.ExecuteReader();//la ejecutamos
                DataTable pokemons = new DataTable();
                pokemons.Load(resultado);//cargamos los datos
                conexion.Close();//cerramos la conexion para dejar 
                return pokemons;
            }
            catch(MySqlException e)
            {
                throw e;
            }
        }

        public DataTable getPokemonNombre(String pokemon)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM pokemon WHERE nombre='" + pokemon + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable pokemons = new DataTable();
                pokemons.Load(resultado);
                conexion.Close();
                return pokemons;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
    }
}
