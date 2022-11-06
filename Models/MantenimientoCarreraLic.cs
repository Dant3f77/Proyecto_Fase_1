using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Fase_1.Models
{
    public class MantenimientoCarreraLic
    {
        private SqlConnection con;

        private void Conectar()
        {
            string constr = ConfigurationManager.ConnectionStrings["Administracion"].ToString();
            con = new SqlConnection(constr);
        }
        public int Alta(Carreras Carr)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("insert into Tablet_Lic(Carrera,Asignatura,Duracion,Descripcion) values(@Carrera, @Asignatura, @Duracion, @Descripcion)", con);
            comando.Parameters.Add("@Carrera", SqlDbType.VarChar);
            comando.Parameters.Add("@Asignatura", SqlDbType.VarChar);
            comando.Parameters.Add("@Duracion", SqlDbType.VarChar);
            comando.Parameters.Add("@Descripcion", SqlDbType.VarChar);
            comando.Parameters["@Carrera"].Value = Carr.Carrera;
            comando.Parameters["@Asignatura"].Value = Carr.Asignaturas;
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
            List<Carreras> Table_Lic = new List<Carreras>();

            SqlCommand com = new SqlCommand("select Carrera,Asignatura,Duracion,Descripcion from Table_Lic", con);
            con.Open();
            SqlDataReader registros = com.ExecuteReader();
            while (registros.Read())
            {
                Carreras carr = new Carreras()
                {
                    Carrera = registros["Carrera"].ToString(),
                   // Asignaturas = registros["Asignatura"].ToString(),
                    Duracion = registros["Duracion"].ToString(),
                    Descripcion = registros["Descripcion"].ToString()
                };
                Table_Lic.Add(carr);

            }
            con.Close();
            return Table_Lic;

        }



    }
}