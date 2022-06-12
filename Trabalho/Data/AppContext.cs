using Microsoft.EntityFrameworkCore;
using Trabalho.Models;

namespace Trabalho.Data
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {

        }
     public DbSet<produto> Produtos { get; set; }

    }
}
