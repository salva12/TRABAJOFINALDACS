using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CapaAccesoAntecedentes.Models
{
    public class EltoAntEvaluar
    {
        //clave primaria

        [Key]
        public int IdEltoAntEvaluar { get; set; }

        //atributos

        public string NombreEltoEvaluar { get; set; }
        public bool EstadoEltoEvaluar { get; set; }
        public string Observacion { get; set; }
        public int IdInternacion { get; set; }

        //relacion "1 a 1" con TipoAntecedente
        
        public TipoAntecedente TipoAntecedente { get; set; }

       


    }
}
