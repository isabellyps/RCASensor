using Microsoft.EntityFrameworkCore;
using RCASensor.Model.EntityModel;

namespace RCASensor.Repository
{
    public class RCASensorContext : DbContext
    {
        public DbSet<Event> Event { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RCASensor;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var eventMap = modelBuilder.Entity<Event>();

            eventMap.HasKey(x => x.Id);

            eventMap.Property(x => x.Country)
                    .IsRequired()
                    .HasMaxLength(100);

            eventMap.Property(x => x.Region)
                    .IsRequired()
                    .HasMaxLength(100);

            eventMap.Property(x => x.Sensor)
                    .IsRequired()
                    .HasMaxLength(25);
        }
    }
}
