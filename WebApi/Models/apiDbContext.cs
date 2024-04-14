using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions option) : base(option) 
        {

        }

        public DbSet<Users> user { get; set; }
    }
}
