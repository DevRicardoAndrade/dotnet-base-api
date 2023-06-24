using dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
                
        }

        public DbSet<HomeModel> Homes { get; set; }  
    }
}
