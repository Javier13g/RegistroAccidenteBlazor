using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial.Data
{
    public class ReporteService
    {
        private DbReporte dbContext;

        public ReporteService(DbReporte dbCon)
        {
            this.dbContext = dbCon;
        }
         
        public async Task <List<ReporteVehiculo>> GetReporteVehiculosAsync()
        {
            return await dbContext.ReportesVe.ToListAsync();
        }

        public async Task<List<PersonaVehiculo>> GetPersonaVehiculosAsync()
        {
            return await dbContext.PersonaVe.ToListAsync();
        }

        public async Task<ReporteVehiculo> AddVehiculoAsync(ReporteVehiculo RV) // GUARDA VEHICULOS
        {
            try
            {
                dbContext.ReportesVe.Add(RV);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return RV;
        }

        public async Task<ReporteVehiculo> UpdateVehiculoAsync(ReporteVehiculo Rv) //ACTUALIZA
        {
            try
            {
                var VehiculoExiste = dbContext.ReportesVe.FirstOrDefaultAsync(
                    veh => veh.IdReporteVehiculo == Rv.IdReporteVehiculo);
                if (VehiculoExiste != null)
                {
                    dbContext.Update(Rv);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Rv;
        }

        public async Task DeleteVehiculoAsync(ReporteVehiculo RV) //BORRA VEHICULOS
        {
            try
            {
                dbContext.ReportesVe.Remove(RV);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<PersonaVehiculo> AddPersonaAsync(PersonaVehiculo PV) // GUARDA PERSONA
        {
            try
            {
                dbContext.PersonaVe.Add(PV);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return PV;
        }

        public async Task<PersonaVehiculo> UpdatePersonaAsync(PersonaVehiculo Pv) //ACTUALIZA PERSONA
        {
            try
            {
                var PersonaExiste = dbContext.PersonaVe.FirstOrDefaultAsync(
                    Per => Per.IdPersona == Pv.IdPersona);
                if (PersonaExiste != null)
                {
                    dbContext.Update(Pv);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Pv;
        }

        public async Task DeletePersonaAsync(PersonaVehiculo PV) //BORRA PERSONA
        {
            try
            {
                dbContext.PersonaVe.Remove(PV);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
