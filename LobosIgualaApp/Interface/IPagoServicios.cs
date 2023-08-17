using LobosIguala.Domain.Entities;

namespace LobosIgualaApp.Interface
{
    public interface IPagoServicios 
    {
        Task<List<Pago>> ObtenerPagosPorAlumno(int alumnoId);
    }
}
