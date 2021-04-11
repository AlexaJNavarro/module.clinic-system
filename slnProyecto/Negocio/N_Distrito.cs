using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Datos;
using Entidad;


namespace Negocio
{
    public class N_Distrito
    {
        private D_Distrito d_dis = new D_Distrito();

        public DataTable ListarDistrito()
        {
            return d_dis.ListarDistrito();
        }
    }
}
