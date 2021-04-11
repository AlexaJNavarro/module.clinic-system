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
    public class D_Tipo_Ident
    {
        Conexion cn = new Conexion();

        public DataTable ListarTipo() 
        {
            DataTable tb = new DataTable();
            string sql = "select*from tb_type_identification";

            using (SqlDataAdapter da= new SqlDataAdapter(sql,cn.Conectar)) 
            {
                da.Fill(tb);
            }
            return tb;
        }
    }
}
