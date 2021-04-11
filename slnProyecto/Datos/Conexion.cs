using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        private SqlConnection cn = new SqlConnection("Data Source=.; Initial Catalog=db_clinic; User ID=sa; Password=123456;");

        public SqlConnection Conectar
        {
            get { return cn;  }
        }


    }
}
