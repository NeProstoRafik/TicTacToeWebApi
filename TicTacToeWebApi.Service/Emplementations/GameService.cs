using Microsoft.Extensions.Logging;
using TicTacToeWebApi.DAL.Interfaces;
using TicTacToeWebApi.Domain.Entity;
using TicTacToeWebApi.Domain.ViewModel;
using TicTacToeWebApi.Service.Interfaces;

namespace TicTacToeWebApi.Service.Emplementations
{
    public class GameService : IGameService
    {
        private readonly IBaseRepository<Game> _baseRepository;
        private readonly ILogger<GameService> _logger;
        public GameService(IBaseRepository<Game> baseRepository, ILogger<GameService> logger)
        {
            _baseRepository = baseRepository;
            _logger = logger;
        }
        public async Task Create(ViewGameModel model)
        {
            try
            {
                _logger.LogInformation($"Запрос на создание- {model.Name}");

                var task = new Game
                {
                    Name = model.Name,
                    DateTime = model.DateTime,

                };
                _logger.LogInformation($"Создалась- {model.Name}");

                await _baseRepository.Create(task);

            }
            catch (Exception ex)
            {
                _logger.LogError($"[GameService].Create");
            }

        }

        public async Task<List<ViewGameModel>> GetAll()
        {
            List<ViewGameModel> result = new List<ViewGameModel>();

            var tabs = _baseRepository.GetAll().Select(x => new ViewGameModel()
            {
                Id = x.Id,
                Name = x.Name,
                DateTime = x.DateTime,
                Winner = x.Winner,
            });
            foreach (var tab in tabs)
            {
                result.Add(tab);
            }

            return result;
        }

        public async Task<IEnumerable<ViewGameModel>> GetTimeGame(DateTime dateTime)
        {
            // List<ViewGameModel> result = new List<ViewGameModel>();
            IEnumerable<ViewGameModel> task = null;
            try
            {

                task = (IEnumerable<ViewGameModel>)_baseRepository.GetAll()
                       .Where(x => x.DateTime == dateTime);

            }
            catch (Exception ex)
            {
                _logger.LogError($"[GameService].GetTimeGame");
            }
            return task;
        }

        public async Task Update(ViewGameModel model)
        {            
                var tabs = _baseRepository.GetAll()
               .FirstOrDefault(x => x.Id == model.Id);                            
                tabs.Winner = model.Winner;           
            
        }

    }
}
