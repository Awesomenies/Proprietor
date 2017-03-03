namespace Proprietor.Models
{
    using System.Data.Entity;

    public class Entity : DbContext
    {
        public Entity()
            : base("name=Entity")
        {
        }

        public DbSet<UserAccount> UserAccount { get; set; }
        public DbSet<Accounting> Accountings { get; set; }
        public DbSet<GameAccount> GameAccounts { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Buildings> Buildings { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}