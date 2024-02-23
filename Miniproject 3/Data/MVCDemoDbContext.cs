using Microsoft.EntityFrameworkCore;
using Miniproject_3.Models.Domain;

namespace Miniproject_3.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Customer> Customers {  get; set; }
    }
}
