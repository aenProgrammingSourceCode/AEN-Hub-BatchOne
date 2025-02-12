using Microsoft.EntityFrameworkCore;
using WebApplicationKarim.Feature.DataAccess.EntityConfigurations;

namespace WebApplicationKarim.Feature.DataAccess
{
    public class KarimDbContext:DbContext
    {
        public KarimDbContext()
        {
            
        }
        public KarimDbContext(DbContextOptions<KarimDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompanyConfigruation());
        }
        

    }
}
