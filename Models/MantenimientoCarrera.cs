using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Fase_1.Models
{
    public class MantenimientoCarrera
    {
        private SqlConnection con;

        private void Conectar()
        {
            string constr = ConfigurationManager.ConnectionStrings["Administracion"].ToString();
            con = new SqlConnection(constr);
        }
        // Inico Para Tabla Carrera Tecnica
        public int Alta(Carreras Carr)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("insert into Tablet_Tec(Carrera,Asignaturas,Duracion,Descripcion) values(@Carrera, @Asignaturas, @Duracion, @Descripcion)", con);
            comando.Parameters.Add("@Carrera", SqlDbType.VarChar);
            comando.Parameters.Add("@Asignaturas", SqlDbType.VarChar);
            comando.Parameters.Add("@Duracion", SqlDbType.VarChar);
            comando.Parameters.Add("@Descripcion", SqlDbType.VarChar);
            comando.Parameters["@Carrera"].Value = Carr.Carrera;
            comando.Parameters["@Asignaturas"].Value = Carr.Asignaturas;
            comando.Parameters["@Duracion"].Value = Carr.Duracion;
            comando.Parameters["@Descripcion"].Value = Carr.Descripcion;
            con.Open();
            int i = comando.ExecuteNonQuery();
            con.Close();
            return i;

        }

        public List<Carreras> RecuperarTodos()
        {
            Conectar();
            List<Carreras> Table_Tec = new List<Carreras>();

            SqlCommand com = new SqlCommand("select Carrera,Asignaturas,Duracion,Descripcion from Table_Tec", con);
            con.Open();
            SqlDataReader registros = com.ExecuteReader();
            while (registros.Read())
            {
                Carreras carr = new Carreras()
                {
                    Carrera = registros["Carrera"].ToString(),
                   // Asignaturas = registros["Asignaturas"].ToString(),
                    Duracion = registros["Duracion"].ToString(),
                    Descripcion = registros["Descripcion"].ToString()
                };
                Table_Tec.Add(carr);                

            }
            con.Close();
            return Table_Tec;

        }
        //Fin para Tabla Carrera Tecnica


    }
}