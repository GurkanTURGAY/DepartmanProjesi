using Microsoft.EntityFrameworkCore;

namespace DepartmanProjesi.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-99SLPDA\\SQLEXPRESS; database=departmandb; integrated security=true; TrustServerCertificate=True;");
        }

        public DbSet<departmanlar> departmanlars { get; set; }
        public DbSet<personel> personels { get; set; }
    }
}
