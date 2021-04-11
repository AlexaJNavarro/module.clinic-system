using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class E_RegistarPaciente
    {
       
        public string id_pac { get; set; }
        public string nombre { get; set; }
        public string app { get; set; }
        public string apm { get; set; }
        public string telf { get; set; }
        public DateTime fecha_nac { get; set; }
        public string direccion { get; set; }
        public byte seguro { get; set; }
        public string hosp_perteneciente { get; set; }
        public int id_tipo_ident { get; set; }
        public int id_genero { get; set; }
        public int id_estado { get; set; }
        public int id_seguro { get; set; }
        public int id_distrito { get; set; }

    }
}
