using DomainModel.Models;
using Microsoft.EntityFrameworkCore;

namespace NewsyWebAPI.DatabaseContext
{
    public class NewsyDBContext : DbContext
    {
        public NewsyDBContext(DbContextOptions<NewsyDBContext> dbContextOptions):
            base(dbContextOptions)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Article> Articles { get; set; } 
    }
}
