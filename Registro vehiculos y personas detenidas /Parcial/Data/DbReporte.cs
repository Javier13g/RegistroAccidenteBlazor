using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial.Data
{
    public class DbReporte: DbContext
    {
        public DbReporte(DbContextOptions<DbReporte> options)
            : base(options)
        {

        }

        public DbSet<ReporteVehiculo> ReportesVe { get; set; }
        public DbSet<PersonaVehiculo> PersonaVe { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReporteVehiculo>().HasData(GetReporteVehiculos());
            modelBuilder.Entity<PersonaVehiculo>().HasData(GetPersonasVehiculos());
            base.OnModelCreating(modelBuilder);
        }

        private List<ReporteVehiculo> GetReporteVehiculos()
        {
            return new List<ReporteVehiculo>
            {
                new ReporteVehiculo
                {
                    IdReporteVehiculo = 1
                },
            };
        }

        private List<PersonaVehiculo> GetPersonasVehiculos()
        {
            return new List<PersonaVehiculo>
            {
                new PersonaVehiculo
                {
                    IdPersona = 1
                },
            };
        }
    }
}
