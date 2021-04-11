using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace Datos
{
    public class D_RPaciente
    {
        Conexion cn = new Conexion();

        public DataTable ListarPaciente() 
        {
            
            SqlDataAdapter da = new SqlDataAdapter("SP_ListarRegistro", cn.Conectar);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public string AgregarPaciente(E_RegistarPaciente e_regpac)
        {
            cn.Conectar.Open();
            string mensaje = "";

            using (SqlTransaction tr = cn.Conectar.BeginTransaction(IsolationLevel.Serializable)) 
            {
                SqlCommand cmd = new SqlCommand("SP_AgregarRegistro", cn.Conectar, tr);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", e_regpac.id_pac);
                cmd.Parameters.AddWithValue("@name", e_regpac.nombre);
                cmd.Parameters.AddWithValue("@a_p", e_regpac.app);
                cmd.Parameters.AddWithValue("@a_m", e_regpac.apm);
                cmd.Parameters.AddWithValue("@phone", e_regpac.telf);
                cmd.Parameters.AddWithValue("@birthdate", e_regpac.fecha_nac);
                cmd.Parameters.AddWithValue("@address", e_regpac.direccion);
                cmd.Parameters.AddWithValue("@seguro", e_regpac.seguro);
                cmd.Parameters.AddWithValue("@hopital_perteneciente", e_regpac.hosp_perteneciente);
                cmd.Parameters.AddWithValue("@id_type_identification", e_regpac.id_tipo_ident);
                cmd.Parameters.AddWithValue("@id_gender", e_regpac.id_genero);
                cmd.Parameters.AddWithValue("@id_marital_status", e_regpac.id_estado);
                cmd.Parameters.AddWithValue("@id_health_insurance", e_regpac.id_seguro);
                cmd.Parameters.AddWithValue("@id_district", e_regpac.id_distrito);

                try
                {
                    int nr = cmd.ExecuteNonQuery();
                    tr.Commit();
                    mensaje = nr.ToString() + " Registro Agregado. ";
                }
                catch (SqlException ex)
                {
                    tr.Rollback();
                    mensaje = ex.Message;
                }
                finally
                {
                    cn.Conectar.Close();
                }

            }

            return mensaje;
        }

        public string ActualizarPaciente(E_RegistarPaciente e_regpac)
        {
            cn.Conectar.Open();
            string mensaje = "";

            using (SqlTransaction tr = cn.Conectar.BeginTransaction(IsolationLevel.Serializable))
            {
                SqlCommand cmd = new SqlCommand("SP_ActualizarRegistro", cn.Conectar, tr);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", e_regpac.id_pac);
                cmd.Parameters.AddWithValue("@name", e_regpac.nombre);
                cmd.Parameters.AddWithValue("@a_p", e_regpac.app);
                cmd.Parameters.AddWithValue("@a_m", e_regpac.apm);
                cmd.Parameters.AddWithValue("@phone", e_regpac.telf);
                cmd.Parameters.AddWithValue("@birthdate", e_regpac.fecha_nac);
                cmd.Parameters.AddWithValue("@address", e_regpac.direccion);
                cmd.Parameters.AddWithValue("@seguro", e_regpac.seguro);
                cmd.Parameters.AddWithValue("@hopital_perteneciente", e_regpac.hosp_perteneciente);
                cmd.Parameters.AddWithValue("@id_type_identification", e_regpac.id_tipo_ident);
                cmd.Parameters.AddWithValue("@id_gender", e_regpac.id_genero);
                cmd.Parameters.AddWithValue("@id_marital_status", e_regpac.id_estado);
                cmd.Parameters.AddWithValue("@id_health_insurance", e_regpac.id_seguro);
                cmd.Parameters.AddWithValue("@id_district", e_regpac.id_distrito);

                try
                {
                    int nr = cmd.ExecuteNonQuery();
                    tr.Commit();
                    mensaje = nr.ToString() + " Registro Actualizado. ";
                }
                catch (SqlException ex)
                {
                    tr.Rollback();
                    mensaje = ex.Message;
                }
                finally
                {
                    cn.Conectar.Close();
                }

            }

            return mensaje;
        }

        public DataTable BuscarPaciente(E_RegistarPaciente e_regpac)
        {
            cn.Conectar.Open();

            using (SqlTransaction tr = cn.Conectar.BeginTransaction(IsolationLevel.Serializable))
            {
                SqlCommand cmd = new SqlCommand("SP_BuscarRegistro", cn.Conectar, tr);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", e_regpac.id_pac);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);

                cn.Conectar.Close();
                return dt;
            }
        }

    }
}
