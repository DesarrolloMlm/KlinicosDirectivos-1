//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KlinicosDirectivos
{
    using System;
    using System.Collections.Generic;
    
    public partial class TurnosReserva
    {
        public int idTurno { get; set; }
        public Nullable<System.Guid> idPaciente { get; set; }
        public int idTipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
        public Nullable<int> idSexo { get; set; }
        public string primerApellido { get; set; }
        public string primerNombre { get; set; }
        public string otrosNombres { get; set; }
        public string email { get; set; }
        public string tipoTelefono { get; set; }
        public string telefono { get; set; }
        public string responsable { get; set; }
        public int idParentescoResponsable { get; set; }
        public string formaReserva { get; set; }
        public string usuarioCrea { get; set; }
        public System.DateTime fechaCrea { get; set; }
        public string usuarioModi { get; set; }
        public System.DateTime fechaModi { get; set; }
        public string motivo { get; set; }
        public int edadAparente { get; set; }
        public string edadAparenteUnidad { get; set; }
    
        public virtual Turno Turno { get; set; }
    }
}
