
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
    
public partial class EvolucionesNOTA
{

    public System.Guid id { get; set; }

    public string texto { get; set; }

    public string notasPropias { get; set; }

    public string notasPropiasCompartirCon { get; set; }

    public Nullable<System.Guid> idEvolucionRelacionada { get; set; }



    public virtual Evoluciones Evoluciones { get; set; }

    public virtual Evoluciones Evoluciones1 { get; set; }

}

}
