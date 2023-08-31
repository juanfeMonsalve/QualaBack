using Microsoft.EntityFrameworkCore;
using QualaBack.Model;

namespace QualaBack.Configuration
{
    public class ApiContext : DbContext
    {
        protected override void OnConfiguring
               (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "AuthorDb");
        }
        public DbSet<Sucursal> sucursales { get; set; }




    }
}
