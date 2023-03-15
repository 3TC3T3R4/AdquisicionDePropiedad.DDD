using Microsoft.EntityFrameworkCore;
using System.Reflection;
using AdquisicionDePropiedad.DDD.Domain.Genericos;

namespace AquisicionDePropiedad.DDD.Infraestructure
{
    public class DataBaseContext :  DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options)  :  base(options)
        {

        }
        public DbSet<StoredEvent> StoredEvents { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
