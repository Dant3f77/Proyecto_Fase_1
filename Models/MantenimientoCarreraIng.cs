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
    public class MantenimientoCarreraIng
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
            SqlCommand comando = new SqlCommand("insert into Tablet_Ing(Carrera,Asignatura,Duracion,Descripcion) values(@Carrera, @Asignatura, @Duracion, @Descripcion)", con);
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

        public List<Carreras> RecuperarByEscuela(string escuela)
        {
            Conectar();
            List<Carreras> Table_Ing = new List<Carreras>();
            try
            {
                SqlCommand com = new SqlCommand("select * from Table_Carrera where Escuela ='"+escuela + "'", con);
                con.Open();
                SqlDataReader registros = com.ExecuteReader();
                while (registros.Read())
                {
                    Carreras carr = new Carreras()
                    {
                        Carrera = registros["Carrera"].ToString(),
                        escuela = registros["Escuela"].ToString(),
                        Asignaturas = int.Parse( registros["Asignatura"].ToString()),
                        Duracion = registros["Duracion"].ToString(),
                        Descripcion = registros["Descripcion"].ToString()
                    };
                    Table_Ing.Add(carr);

                }
                con.Close();
            }
            catch {Table_Ing = null; }
            return Table_Ing;
            

        }

        public List<Carreras> MostrarCarreras()
        {
            Conectar();
            List<Carreras> Table_Ing = new List<Carreras>();
            try
            {
                SqlCommand com = new SqlCommand("select * from Table_Carrera", con);
                con.Open();
                SqlDataReader registros = com.ExecuteReader();
                while (registros.Read())
                {
                    Carreras carr = new Carreras()
                    {
                        Id = int.Parse(registros["Id"].ToString()),
                        Carrera = registros["Carrera"].ToString(),
                        escuela = registros["Escuela"].ToString(),
                        Asignaturas = int.Parse(registros["Asignatura"].ToString()),
                        Duracion = registros["Duracion"].ToString(),
                        Descripcion = registros["Descripcion"].ToString()
                    };
                    Table_Ing.Add(carr);

                }
                con.Close();
            }
            catch { Table_Ing = null; }
            return Table_Ing;


        }
    }
}