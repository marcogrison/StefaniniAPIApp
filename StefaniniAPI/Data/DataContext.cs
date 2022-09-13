using Microsoft.EntityFrameworkCore;

namespace StefaniniAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Cidade> Cidades { get; set; }  

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
