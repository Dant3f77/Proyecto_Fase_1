using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Fase_1.Models
{
    public class MantenimientoAspirante
    {
        private SqlConnection con;

        private void Conectar()
        {
            string constr = ConfigurationManager.ConnectionStrings["Administracion"].ToString();
            con = new SqlConnection(constr);
        }

        public int Alta(Inscripcion Carr)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("insert into Table_Aspirante(Nombres,ApellidoP,ApellidoS,Dui,Nit,Correo,Telefono,idCarrera) values(@Nombres,@ApellidoP,@ApellidoS,@Dui,@Nit,@Correo,@Telefono,@IdCarrera)", con);
            comando.Parameters.Add("@Nombres", SqlDbType.VarChar);
            comando.Parameters.Add("@ApellidoP", SqlDbType.VarChar);
            comando.Parameters.Add("@ApellidoS", SqlDbType.VarChar);
            comando.Parameters.Add("@Dui", SqlDbType.VarChar);
            comando.Parameters.Add("@Nit", SqlDbType.VarChar);
            comando.Parameters.Add("@Correo", SqlDbType.VarChar);
            comando.Parameters.Add("@Telefono", SqlDbType.VarChar);
            comando.Parameters.Add("@IdCarrera", SqlDbType.Int);
            comando.Parameters["@Nombres"].Value = Carr.nombres;
            comando.Parameters["@ApellidoP"].Value = Carr.apellidoP;
            comando.Parameters["@ApellidoS"].Value = Carr.apellidoS;
            comando.Parameters["@Dui"].Value = Carr.dui;
            comando.Parameters["@Nit"].Value = Carr.nit;
            comando.Parameters["@Correo"].Value = Carr.correo;
            comando.Parameters["@Telefono"].Value = Carr.telefono;
            comando.Parameters["@IdCarrera"].Value = Carr.idCarrera;
            con.Open();
            int i = comando.ExecuteNonQuery();
            con.Close();
            return i;

        }

        public List<Inscripcion> RecuperarTodos()
        {
            Conectar();
            List<Inscripcion> Table_Aspirante = new List<Inscripcion>();
            try
            {
                SqlCommand com = new SqlCommand("SELECT Table_Aspirante.id, nombres, apellidop, apellidos,dui, nit, telefono,correo, idCarrera, Table_Carrera.Carrera as nameCarrera from Table_Aspirante inner join Table_Carrera on Table_Carrera.Id = Table_Aspirante.IdCarrera", con);
                con.Open();
                SqlDataReader registros = com.ExecuteReader();
                while (registros.Read())
                {
                    Inscripcion carr = new Inscripcion()
                    {
                        id = int.Parse(registros["Id"].ToString()),
                        nombres = registros["Nombres"].ToString(),
                        apellidoP = registros["ApellidoP"].ToString(),
                        apellidoS = registros["ApellidoS"].ToString(),
                        dui = registros["Dui"].ToString(),
                        nit = registros["Nit"].ToString(),
                        correo = registros["Correo"].ToString(),
                        telefono = registros["Telefono"].ToString(),
                        idCarrera = int.Parse(registros["idCarrera"].ToString()),
                        nameCarreras = registros["nameCarrera"].ToString()
                        
                    };
                    Table_Aspirante.Add(carr);

                }
                con.Close();
            }
            catch { Table_Aspirante = null; }
            return Table_Aspirante;


        }
        public Inscripcion Recuperar(int codigo)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("SELECT Table_Aspirante.id, nombres, apellidop, apellidos,dui, nit, telefono,correo, idCarrera, Table_Carrera.Carrera as nameCarrera from Table_Aspirante inner join Table_Carrera on Table_Carrera.Id = Table_Aspirante.IdCarrera where Table_Aspirante.id=" + codigo, con);
            comando.Parameters.Add("@Id", SqlDbType.Int);
            comando.Parameters["@Id"].Value = codigo;
            con.Open();
            SqlDataReader registros = comando.ExecuteReader();
            Inscripcion carr = new Inscripcion();
            if (registros.Read())
            {
                carr.id = int.Parse(registros["Id"].ToString());
                carr.nombres = registros["Nombres"].ToString();
                carr.apellidoP = registros["ApellidoP"].ToString();
                carr.apellidoS = registros["ApellidoS"].ToString();
                carr.dui = registros["Dui"].ToString();
                carr.nit = registros["Nit"].ToString();
                carr.correo = registros["Correo"].ToString();
                carr.telefono = registros["Telefono"].ToString();
                carr.idCarrera = int.Parse(registros["idCarrera"].ToString());
                carr.nameCarreras = registros["nameCarrera"].ToString();

            }
            con.Close();
            return carr;
        }

        public int Modificar(Inscripcion Carr)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("update Table_Aspirante set Nombres=@Nombres,ApellidoP=@ApellidoP,ApellidoS=@ApellidoS,Dui=@Dui,Nit=@Nit,Correo=@Correo,Telefono=@Telefono,IdCarrera=@IdCarrera where  Id = @Id", con);
            comando.Parameters.Add("@Id", SqlDbType.Int);
            comando.Parameters.Add("@Nombres", SqlDbType.VarChar);
            comando.Parameters.Add("@ApellidoP", SqlDbType.VarChar);
            comando.Parameters.Add("@ApellidoS", SqlDbType.VarChar);
            comando.Parameters.Add("@Dui", SqlDbType.VarChar);
            comando.Parameters.Add("@Nit", SqlDbType.VarChar);
            comando.Parameters.Add("@Correo", SqlDbType.VarChar);
            comando.Parameters.Add("@Telefono", SqlDbType.VarChar);
            comando.Parameters.Add("@IdCarrera", SqlDbType.Int);
            comando.Parameters["@Id"].Value = Carr.id;
            comando.Parameters["@Nombres"].Value = Carr.nombres;
            comando.Parameters["@ApellidoP"].Value = Carr.apellidoP;
            comando.Parameters["@ApellidoS"].Value = Carr.apellidoS;
            comando.Parameters["@Dui"].Value = Carr.dui;
            comando.Parameters["@Nit"].Value = Carr.nit;
            comando.Parameters["@Correo"].Value = Carr.correo;
            comando.Parameters["@Telefono"].Value = Carr.telefono;
            comando.Parameters["@IdCarrera"].Value = Carr.idCarrera;
            con.Open();
            int i = comando.ExecuteNonQuery();
            con.Close();
            return i;

        }
       
        public int Borrar(int codigo)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("delete from Table_Aspirante where id=@Id", con);
            comando.Parameters.Add("@Id", SqlDbType.Int);
            comando.Parameters["@Id"].Value = codigo;
            con.Open();
            int i = comando.ExecuteNonQuery();
            con.Close();
            return i;
        }


        



    }
}