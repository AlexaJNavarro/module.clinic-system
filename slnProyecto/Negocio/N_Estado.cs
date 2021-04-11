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
    public class N_Estado
    {
        private D_Estado d_e = new D_Estado();

        public DataTable ListarEstado() 
        {
            return d_e.ListarEstado();
        }
    }
}
