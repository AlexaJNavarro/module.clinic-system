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
   
    public class N_RPaciente
    {
        private D_RPaciente d_pac = new D_RPaciente();

        private static void ValidarRegistro(E_RegistarPaciente e_regpac) 
        {
            //Exceptiones
            if (String.IsNullOrEmpty(e_regpac.id_pac))
            {
                throw new ArgumentException("El N° de Identificación no puede estar vacío");
            }
        }

        public DataTable ListarPaciente() 
        {
            return d_pac.ListarPaciente();
        }

        public string RegistrarPaciente(E_RegistarPaciente e_regpac) 
        {
            try
            {
                ValidarRegistro(e_regpac);
                return d_pac.AgregarPaciente(e_regpac);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }

        public string ActualizarPaciente(E_RegistarPaciente e_regpac)
        {
            try
            {
                ValidarRegistro(e_regpac);
                return d_pac.ActualizarPaciente(e_regpac);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public DataTable BuscarPaciente(E_RegistarPaciente e_regpac)
        {
           return d_pac.BuscarPaciente(e_regpac);
        }
    }
}
