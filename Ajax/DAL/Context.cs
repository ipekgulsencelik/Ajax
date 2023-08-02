using Microsoft.EntityFrameworkCore;

namespace Ajax.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = MSI; database = AjaxDB; integrated security = true; trusted_connection = true; encrypt = false");
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
