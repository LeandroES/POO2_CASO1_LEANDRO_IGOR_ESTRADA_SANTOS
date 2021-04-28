using POO2_CASO1_LEANDRO_IGOR_ESTRADA_SANTOS.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace POO2_CASO1_LEANDRO_IGOR_ESTRADA_SANTOS.Controllers
{
    public class Papeleta_DAO
    {

        string CAD_CN = ConfigurationManager.ConnectionStrings["cnx"].ConnectionString;

        public List<sp_ListarRegistro> Papeleta(DateTime PAPFECHA)
        {
            List<sp_ListarRegistro> lista = new List<sp_ListarRegistro>();

            SqlConnection conexion = new SqlConnection(CAD_CN);
            conexion.Open();

            SqlCommand comando = new SqlCommand("sp_ListarRegistro", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@PAPFECHA", SqlDbType.Decimal).Value = PAPFECHA;

            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {

                lista.Add(new sp_ListarRegistro()
                {

                    NROPAP = dr.GetInt32(0),
                    PAPFECHA = dr.GetDateTime(1)
                });
            }
            dr.Close();

            conexion.Close();

            return lista;
        }

        public List<sp_ListarRegistro> CursosPorCosto(DateTime PAPFECHA)
        {
            List<sp_ListarRegistro> lista = new List<sp_ListarRegistro>();


            SqlConnection conexion = new SqlConnection(CAD_CN);
            conexion.Open();

            SqlCommand comando = new SqlCommand("sp_ListarRegistro", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@PAPFECHA", SqlDbType.Decimal).Value = PAPFECHA;

            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {

                lista.Add(new sp_ListarRegistro()
                {

                    NROPAP = dr.GetInt32(0),
                    PAPFECHA = dr.GetDateTime(1)
                });
            }
            dr.Close();

            conexion.Close();

            return lista;
        }

    }
}