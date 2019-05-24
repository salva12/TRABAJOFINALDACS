using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaAccesoAntecedentes.Models
{
    public class AntContext : DbContext
    {
        public DbSet<TipoAntecedente> TipoAntecedentes { get; set; }
        public DbSet<EltoAntEvaluar> EltoAntEvaluars { get; set; }
        public DbSet<internac_paciente> internac_Pacientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=AntDB;Trusted_Connection=True;");
        }
    }
}
