using Microsoft.AspNetCore.Mvc;
using TicTacToeWebApi.DAL;
using TicTacToeWebApi.Domain.Entity;
using TicTacToeWebApi.Domain.ViewModel;
using TicTacToeWebApi.Service.Emplementations;
using TicTacToeWebApi.Service.Interfaces;

namespace TicTacToeWebApi.Controllers
{
    public class GamesController : Controller
    {
        private readonly ApplicationDbContext applicationDb;
        private readonly IGameService _gameService;
        private readonly GameSessionService _gameSession;

        public GamesController(IGameService gameService)
        {
            _gameService = gameService;
        }
        [HttpGet("GetAllGames")]
        public IResult GetAll()
        {
            var result = _gameService.GetAll().Result;
            return Results.Json(result);
        }

        [HttpPost("StartNewGame")]
        public async Task Create(ViewGameModel model)
        {
            await _gameService.Create(model);
        }
        [HttpPut("Move")]
        public void GamePlay(Point point)
        {
            _gameSession.Motion(point);
        }


        [HttpGet("GetHasWinner")]
        public void HasWinner(ViewGameModel model)
        {
            _gameService.Update(model);
        }
    }
}
