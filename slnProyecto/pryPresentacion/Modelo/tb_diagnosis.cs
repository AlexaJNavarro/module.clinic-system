//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pryPresentacion.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_diagnosis
    {
        public int id { get; set; }
        public string reasons_for_consultation { get; set; }
        public string current_illness { get; set; }
        public string pathological_history { get; set; }
        public int id_clinic_history { get; set; }
        public int id_doctor { get; set; }
    
        public virtual tb_clinic_history tb_clinic_history { get; set; }
        public virtual tb_doctor tb_doctor { get; set; }
    }
}