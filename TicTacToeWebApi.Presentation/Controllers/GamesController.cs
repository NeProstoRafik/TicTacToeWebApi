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

        public ActionResult GetAll()
        {
            var result = _gameService.GetAll().Result;
            return View(result);
        }
        public async Task Create(ViewGameModel model)
        {
            await _gameService.Create(model);
        }

        public async Task GamePlay(Point point)
        {
            _gameSession.Motion(point);
        }
        public IActionResult NewGame(ViewGameModel model)
        {
            _gameService.Update(model);
            return RedirectToAction("Create");
        }
    }
}
