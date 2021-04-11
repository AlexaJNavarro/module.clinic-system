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
    public class N_Genero
    {
        private D_Genero d_g = new D_Genero();

        public DataTable ListarGenero() 
        {
            return d_g.ListarGenero();
        }
    }
}
