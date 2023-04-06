using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeWebApi.Domain.Entity;

namespace TicTacToeWebApi.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //  Database.EnsureDeleted();
           // Database.EnsureCreated();
           //или добавить миграции
        }
      public  DbSet<Game> DBGames {get; set;}
    }
}
