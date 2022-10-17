using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KlinicosDirectivos.ViewModels
{
    public class DetalleSemanalPartialVM
    {
        public List<Especialidades> especialidad;


        public int cantTurnosReservados;
        public int cantTurnosIngresados;
        public int cantEspontaneos;
        public int totalIngresos;
        public int totalAtendidos;


        public SemanalProfesional semanal ;
        public enum diasSemana { lunes, martes, miercoles, jueves, viernes, sabado, domigno }
        public Dictionary<diasSemana, SemanalProfesional> diasAtencion;

        public DateTime fechadesde;
        public DateTime fechaHasta;
        public string mes;
        public string anio;
        public string mesHasta;
        public string anioHasta;
        public int idSector;
        public int idEspecialidad;
        public int idProfesional;
        public string tipoEspecialidad;

    }

    //enum diasSemana { Domingo = 0, Lunes = 1, Martes = 2, Miercoles = 3, Jueves = 4, Viernes = 5, Sabado = 6 }

    //private Dictionary<diasSemana, bool> diasAtencion;

    //public ProfesionalDe        sempeño(Klinicos_BEntities entidades)
    //{
    //    this.diasAtencion = ObtenerDiasAtencion(entidades.Evoluciones.Where(x => x.idProfesional == 32).ToList());
    //}

    //private Dictionary<diasSemana, bool> ObtenerDiasAtencion(List<Evoluciones> evoluciones)
    //{
    //    Dictionary<diasSemana, bool> diccionario = new Dictionary<diasSemana, bool>();

    //    diccionario.Add(diasSemana.Domingo, ComprobarAtencionEnElDia(evoluciones, (int)diasSemana.Domingo));
    //    diccionario.Add(diasSemana.Lunes, ComprobarAtencionEnElDia(evoluciones, (int)diasSemana.Lunes));
    //    diccionario.Add(diasSemana.Martes, ComprobarAtencionEnElDia(evoluciones, (int)diasSemana.Martes));
    //    diccionario.Add(diasSemana.Miercoles, ComprobarAtencionEnElDia(evoluciones, (int)diasSemana.Miercoles));
    //    diccionario.Add(diasSemana.Jueves, ComprobarAtencionEnElDia(evoluciones, (int)diasSemana.Jueves));
    //    diccionario.Add(diasSemana.Viernes, ComprobarAtencionEnElDia(evoluciones, (int)diasSemana.Viernes));
    //    diccionario.Add(diasSemana.Sabado, ComprobarAtencionEnElDia(evoluciones, (int)diasSemana.Sabado));

    //    return diccionario;
    //}

    //public bool ComprobarAtencionEnElDia(List<Evoluciones> evoluciones, int miDia)
    //{

    //    if (evoluciones == null || evoluciones.Count == 0 || object.Equals(evoluciones, null))
    //        return false;

    //    foreach (Evoluciones evo in evoluciones)
    //    {
    //        //Comprobar datetime
    //        if (Object.Equals(evo.fechaCrea, null) || evo.fechaCrea == DateTime.MinValue)
    //            continue;

    //        if (miDia == (int)evo.fechaCrea.DayOfWeek)
    //            return true;
    //    }

    //    return false;
    //}
}