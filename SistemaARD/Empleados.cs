//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaARD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleados
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleados()
        {
            this.Aguinaldos = new HashSet<Aguinaldos>();
            this.CargosEmpleados = new HashSet<CargosEmpleados>();
            this.CorreosEmpleados = new HashSet<CorreosEmpleados>();
            this.Indemnizaciones = new HashSet<Indemnizaciones>();
            this.PlanillasProduccion = new HashSet<PlanillasProduccion>();
            this.PlanillasVentas = new HashSet<PlanillasVentas>();
            this.TelefonosEmpleados = new HashSet<TelefonosEmpleados>();
            this.Planillas_Jefes = new HashSet<Planillas_Jefes>();
        }
    
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombreCompleto { get { return string.Format("{0} {1}", Nombres, Apellidos); } }
        public System.DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public int Genero_Id { get; set; }
        public string N_Dui { get; set; }
        public string N_Nit { get; set; }
        public int Afp_Id { get; set; }
        public string N_Afp { get; set; }
        public string N_Isss { get; set; }
        public System.DateTime FechaIngreso { get; set; }
        public int Estado_Id { get; set; }
    
        public virtual Afps Afps { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aguinaldos> Aguinaldos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CargosEmpleados> CargosEmpleados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CorreosEmpleados> CorreosEmpleados { get; set; }
        public virtual Estados Estados { get; set; }
        public virtual Generos Generos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Indemnizaciones> Indemnizaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanillasProduccion> PlanillasProduccion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanillasVentas> PlanillasVentas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TelefonosEmpleados> TelefonosEmpleados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Planillas_Jefes> Planillas_Jefes { get; set; }
    }
}
