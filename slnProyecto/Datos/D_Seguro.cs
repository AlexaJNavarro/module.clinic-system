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
    public class D_Seguro
    {
        Conexion cn = new Conexion();

        public DataTable ListarSeguro() 
        {

            DataTable tb = new DataTable();
            string sql = "select*from tb_health_insurance";

            using (SqlDataAdapter da = new SqlDataAdapter(sql, cn.Conectar)) 
            {
                da.Fill(tb);
            }
            return tb;
        }
    }
}
