using Microsoft.EntityFrameworkCore;
using mypersonalwebsite.Models;

namespace mypersonalwebsite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ContactTuse> Contacts { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
            
        }
    }
}
