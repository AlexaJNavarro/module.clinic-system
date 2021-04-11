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
    
    public partial class tb_patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_patient()
        {
            this.tb_appointment = new HashSet<tb_appointment>();
            this.tb_contrareferencia = new HashSet<tb_contrareferencia>();
        }
    
        public string id { get; set; }
        public string name { get; set; }
        public string a_p { get; set; }
        public string a_m { get; set; }
        public string phone { get; set; }
        public System.DateTime birthdate { get; set; }
        public string address { get; set; }
        public bool seguro { get; set; }
        public string hopital_perteneciente { get; set; }
        public int id_type_identification { get; set; }
        public int id_gender { get; set; }
        public int id_marital_status { get; set; }
        public int id_clinic_history { get; set; }
        public int id_health_insurance { get; set; }
        public int id_district { get; set; }
        public Nullable<bool> state { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_appointment> tb_appointment { get; set; }
        public virtual tb_clinic_history tb_clinic_history { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_contrareferencia> tb_contrareferencia { get; set; }
        public virtual tb_district tb_district { get; set; }
        public virtual tb_gender tb_gender { get; set; }
        public virtual tb_health_insurance tb_health_insurance { get; set; }
        public virtual tb_marital_status tb_marital_status { get; set; }
        public virtual tb_type_identification tb_type_identification { get; set; }
    }
}