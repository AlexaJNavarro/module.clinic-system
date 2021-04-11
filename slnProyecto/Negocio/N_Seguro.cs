using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Entidad;
using Datos;

namespace Negocio
{
    public class N_Seguro
    {
        private D_Seguro d_s = new D_Seguro();

        public DataTable ListarSeguro() 
        {
            return d_s.ListarSeguro();
        }
    }
}
