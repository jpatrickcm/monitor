using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using Monitor.Models;

namespace Monitor.Conexiones
{
    public class Conection
    {

        internal static List<COMPROBANTES_FRP> EjemploMetodo(string cadena1, string cadena2, string cadena3)

        {
            List<COMPROBANTES_FRP> listado = new List<COMPROBANTES_FRP>();

            COMPROBANTES_FRP objetoEjemplo = null;

            string connectionString = ConfigurationManager.ConnectionStrings["Contex_Monitor"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))

            {

                string cmdText = "VER_COMPROBANTES_FRP";

                using (SqlCommand cmd = new SqlCommand(cmdText, connection))

                {

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@empresa", cadena1);

                    cmd.Parameters.AddWithValue("@fechaInicio", cadena2);

                    cmd.Parameters.AddWithValue("@fechafinal", cadena3);

                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())

                    {

                        while (reader.Read())

                        {
                            objetoEjemplo = new COMPROBANTES_FRP();
                            objetoEjemplo.RUC = reader["RUC"].ToString();
                            objetoEjemplo.COMPROBANTE = reader["COMPROBANTE"].ToString();
                            objetoEjemplo.SERIE = reader["SERIE"].ToString();
                            objetoEjemplo.CORRELATIVO = Int32.Parse(reader["CORRELATIVO"].ToString());
                            objetoEjemplo.FECHA_EMISION = reader["FECHA_EMISION"].ToString();
                            objetoEjemplo.FECHA_CARGA = reader["FECHA_CARGA"].ToString();
                            objetoEjemplo.ESTADO = reader["ESTADO"].ToString();
                            objetoEjemplo.NUMERO_EMPRESA = Int32.Parse(reader["NUMERO_EMPRESA"].ToString());
                            objetoEjemplo.MENSAJE = reader["MENSAJE"].ToString();
                            //objetoEjemplo.campo = reader["RUC"].ToString();
                            listado.Add(objetoEjemplo);
                            //obj.Fecha = reader["fecha"].ToString();

                        }

                    }

                }

            }

            return listado;

        }


    }
}