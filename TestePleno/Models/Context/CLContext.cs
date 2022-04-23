using Microsoft.EntityFrameworkCore;

namespace TestePleno.Models.Context
{
    public class ClContext : DbContext
    {
        public DbSet<Operator> operators { get; set; }

        public DbSet<Fare> fares { get; set; }

        public ClContext(DbContextOptions options) : base(options)
        {

        }
    }
}
