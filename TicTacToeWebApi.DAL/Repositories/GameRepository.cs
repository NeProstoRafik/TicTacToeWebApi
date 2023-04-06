using TicTacToeWebApi.DAL.Interfaces;
using TicTacToeWebApi.Domain.Entity;

namespace TicTacToeWebApi.DAL.Repositories
{
    public class GameRepository : IBaseRepository<Game>
    {
        private readonly ApplicationDbContext _context;

        public GameRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create(Game entity)
        {
            await _context.DBGames.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public List<Game> GetAll()
        {
            return _context.DBGames.ToList();
        }


    }
}
