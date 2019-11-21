using Microsoft.EntityFrameworkCore;
using apis.Models;
using apis.Data.Maps;

namespace APIS.Data
{
    public class StoreDataContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ClienteMap());
        }

    }
}