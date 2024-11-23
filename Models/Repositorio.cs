using Microsoft.EntityFrameworkCore;

namespace Reservaciones.Models
{
    public class Repositorio : IRepositorio
    {
        private readonly BasedeDatosContexto _dbContexto;

        public Repositorio(BasedeDatosContexto dbContexto)
        {
            _dbContexto = dbContexto;
        }

        public async Task<Reserva> Add(Reserva reserva)
        {
            await _dbContexto.Reservaciones.AddAsync(reserva);
            await _dbContexto.SaveChangesAsync();
            return reserva;
        }

        public async Task Delete(Reserva entity)
        {
            _dbContexto.Reservaciones.Remove(entity);
            try
            {
                await _dbContexto.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new Exception($"Error al eliminar la persona:{ex.Message} ");
            }
        } 

        public async Task<Reserva?> Get(int id)
        {
            return await _dbContexto.Reservaciones.FindAsync(id);
        }

        public async Task<List<Reserva>> GetAll()
        {
            return await _dbContexto.Reservaciones.ToListAsync();
        }

        public async Task Update(Reserva entity)
        {
            _dbContexto.Reservaciones.Update(entity);
            await _dbContexto.SaveChangesAsync();
        }
    }
}
