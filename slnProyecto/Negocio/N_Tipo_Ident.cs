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
    public class N_Tipo_Ident
    {
        private D_Tipo_Ident d_ti = new D_Tipo_Ident();

        public DataTable ListarTipoI() 
        {
            return d_ti.ListarTipo();
        }
    }
}
