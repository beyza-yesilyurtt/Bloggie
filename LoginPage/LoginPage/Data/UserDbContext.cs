using LoginPage.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginPage.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

       
    }
}
