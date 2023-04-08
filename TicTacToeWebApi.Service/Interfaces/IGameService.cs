using TicTacToeWebApi.Domain.ViewModel;

namespace TicTacToeWebApi.Service.Interfaces
{
    public interface IGameService
    {
        Task<List<ViewGameModel>> GetAll();
        Task Create(ViewGameModel model);
        Task<IEnumerable<ViewGameModel>> GetTimeGame(DateTime dateTime);
        Task Update(ViewGameModel model);

        //Task<List<ViewGameModel>> GetLastTen();

        //Game Get(int id);
    }
}
