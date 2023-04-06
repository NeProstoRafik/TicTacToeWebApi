using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeWebApi.Domain.Enum;

namespace TicTacToeWebApi.Domain.Entity
{
    public class Game
    {
        public int Id { get; set; }
        public Guid Name { get; set; }
        public Winner Winner { get; set; }
        public DateTime DateTime { get; set; }

    }
}
