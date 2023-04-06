using TicTacToeWebApi.Domain.Enum;

namespace TicTacToeWebApi.Domain.Entity
{
    public class Point
    {
        public Player Player { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
