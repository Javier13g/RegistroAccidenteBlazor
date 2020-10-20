using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial.Data
{
    public class ReporteVehiculo
    {
        [Key]
        public int IdReporteVehiculo { get; set; }

        public string PlacaVehiculo { get; set; }

        public string MarcaVehiculo { get; set; }

        public string ModeloVehiculo { get; set; }

        public string ColorVehiculo { get; set; }

        public string Descripcion { get; set; }
    }

    public class PersonaVehiculo
    {
        [ForeignKey("ReporteVehiculo")]
        public int IdReporteVehiculo2 { get; set; }

        [Key]
        public int IdPersona { get; set; }

        public string NombrePersona { get; set; }

        public string ApellidoPersona { get; set; }

        public string  CedulaPersona { get; set; }

        public string LugarPersonaAtrapada { get; set; }
    }
}
