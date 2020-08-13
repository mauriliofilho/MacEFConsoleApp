using Microsoft.EntityFrameworkCore;

namespace MacEFConsoleApp.Entities
{
    public class ActorDBContext: DbContext
    {
        public DbSet<Actor> Actors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./Teminal.db");
        }
    }
 
}