using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1
{
    public class myDbContext: DbContext
    {
        public myDbContext(DbContextOptions<myDbContext> options)
        {

        }
        public DbSet<Models.Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>().HasKey(x => x.ID);
            base.OnModelCreating(builder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mydb;Database=sampleDB; Persist Security Info=True;");
        }

    }

}