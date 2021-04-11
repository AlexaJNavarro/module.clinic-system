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
    public class D_Distrito
    {
        public DataTable ListarDistrito()
        {
            Conexion cn = new Conexion();

            DataTable tb = new DataTable();
            string sql = "select*from tb_district";

            using (SqlDataAdapter da = new SqlDataAdapter(sql, cn.Conectar))
            {
                da.Fill(tb);
            }
            return tb;
        }
    }
}
