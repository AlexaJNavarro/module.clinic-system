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
    public class N_HC
    {
        private D_HC d_hc = new D_HC();

        public DataTable ListarHC() 
        {
            return d_hc.ListarHC();
        }
    }
}
