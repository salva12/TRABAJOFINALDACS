using System;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CapaAccesoAntecedentes.Models
{
    public class internac_paciente
    {
        [Key]
        public int Id_internacion { get; set; }


        public int Id_expediente { get; set; }

        public int Id_personal { get; set; }
        public DateTime Fecha_ingreso { get; set; }
        public string Imp_diagnostica { get; set; }
        public string Tratamiento { get; set; }

        public ICollection<internac_paciente> internac_pacientes { get; set; }
    }
}
