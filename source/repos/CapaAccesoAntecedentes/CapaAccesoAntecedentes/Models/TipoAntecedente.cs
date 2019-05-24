using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CapaAccesoAntecedentes.Models
{
    public class TipoAntecedente
    {
        //clave primaria

        [Key]
        public int IdTipoAnt { get; set; }

        //atributos

        public string NomTipoAnt { get; set; }

        //relacion "1 a muchos" con EltoAntEvaluar

        public ICollection<EltoAntEvaluar> EltoAntEvaluars { get; set; }





    }
}
