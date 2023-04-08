using TicTacToeWebApi.DAL.Interfaces;
using TicTacToeWebApi.Domain.Entity;
using TicTacToeWebApi.Domain.Response;

namespace TicTacToeWebApi.Service.Emplementations
{
    public class GameSessionService
    {
        private readonly IBaseRepository<Game> _baseRepository;
        private readonly GameSession _game;
        private bool _move =true;
        public BaseResponse MakeMove()
        {
        //    var response = new BaseResponse();
        //    if (_game.Board[point.X, point.Y] != 0)
        //    {
        //        response.Discription = "Сюда не ходи";
        //    }
        //    _game.isMove = false;
        //    return response;
            return new BaseResponse() { Discription = "Сюда не ходи" };
        }
        private bool CheckForWin()
        {
            for (int i = 0; i < 3; i++)
            {

                if (_game.Board[i, 0] != 0 && _game.Board[i, 0] == _game.Board[i, 1] && _game.Board[i, 1] == _game.Board[i, 2])
                {
                    return true;
                }

            }
            for (int i = 0; i < 3; i++)
            {

                if (_game.Board[0, i] != 0 && _game.Board[0, i] == _game.Board[1, i] && _game.Board[1, i] == _game.Board[2, i])
                {
                    return true;
                }

            }
            if (_game.Board[0, 0] != 0 && _game.Board[0, 0] == _game.Board[1, 1] && _game.Board[1, 1] == _game.Board[2, 2])
            {
                return true;
            }

            if (_game.Board[0, 2] != 0 && _game.Board[0, 2] == _game.Board[1, 1] && _game.Board[1, 1] == _game.Board[2, 0])
            {
                return true;
            }

            return false;
        }

        public void Motion(Point point)
        {
            if (_game.Board[point.X, point.Y] != 0)
            {
                MakeMove();
            }
            else
            {
                if (point.Player == Domain.Enum.Player.Player_X && _move==true)
                {
                    _game.Board[point.X, point.Y] = 1;
                    ChekForMotion();
                    CheckWinner(point);
                    _move = false;
                }
                else
                {
                    _game.Board[point.X, point.Y] = 2;
                    ChekForMotion();
                    CheckWinner(point);
                    _move = true;
                }
                // CheckForWin();
            }

        }
        private BaseResponse CheckWinner(Point point)
        {
            if (CheckForWin() == true)
            {
              
                return new BaseResponse { Discription = $"{point.Player} Выиграл" };
            }
            if (CheckForWin() != true && _game.isEnd == true)
            {
                return new BaseResponse { Discription = $"Ничья" };
            }
            return null;
        }
        //public void CreateWinner()
        //{
        //    //to do сохранить победителя
        //}
        private void ChekForMotion()
        {
            int N = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (_game.Board[i,j]!=0)
                    {
                        N++;
                    }
                    if (N==9)
                    {
                        _game.isEnd = true;
                    }
                }
            }
        }
    }
}
