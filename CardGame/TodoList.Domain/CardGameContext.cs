using Microsoft.EntityFrameworkCore;
using CardGame.Domain.Entities;


namespace CardGame.Domain
{
    public class CardGameContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Cards> Cards { get; set; }
        public DbSet<CardsInBox> CardsInBox { get; set; }

        public CardGameContext(DbContextOptions options) : base(options)
        {

        }
    }
}