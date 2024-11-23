namespace Reservaciones.Models
{
    public interface IRepositorio
    {
        Task<List<Reserva>> GetAll();
        Task<Reserva?> Get(int id);
        Task<Reserva> Add(Reserva entity);
        Task Update(Reserva entity);
        Task Delete(Reserva entity);
    }
}
