using LobosIguala.Data;
using LobosIguala.Domain.Entities;
using LobosIgualaApp.Interface;
using Microsoft.EntityFrameworkCore;

namespace LobosIgualaApp.Servicios
{
    public class PagoServicio : IPagoServicios
    {
        private readonly LobosIgualaDbContext _dbContext;
        public PagoServicio(LobosIgualaDbContext dbContext )
        {
            _dbContext = dbContext;
        }
        public async Task<List<Pago>> ObtenerPagosPorAlumno(int alumnoId)
        {
            var pagos = await _dbContext.Pagos

                .Where(p => p.AlumnoId == alumnoId)
                .Include(p => p.Alumno)
                .ToListAsync();
            return pagos;
        }


    }
}
