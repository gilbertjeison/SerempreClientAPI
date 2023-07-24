using Microsoft.EntityFrameworkCore;
using SerempreClientAPI.Domain.Entities;
using SerempreClientAPI.Infrastructure.DataSource.Data;

namespace SerempreClientAPI.Infrastructure.DataSource
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions options) : base(options)
        {}

        public DataContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder is null)
            {
                return;
            }

            //Load all entity config from current assembly
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);

            modelBuilder.Entity<City>();
            modelBuilder.Entity<Client>();
            modelBuilder.Entity<User>();

            //Seed data
            modelBuilder.Entity<City>().HasData(SeedData.Cities);
            modelBuilder.Entity<Client>().HasData(SeedData.Clients);
            modelBuilder.Entity<User>().HasData(SeedData.Users);

            //Auditory properties
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var t = entityType.ClrType;
                if (typeof(DomainEntity).IsAssignableFrom(t))
                {
                    modelBuilder.Entity(entityType.Name).Property<DateTime>("CreatedOn").HasDefaultValue(DateTime.Now);
                    modelBuilder.Entity(entityType.Name).Property<DateTime>("UpdatedOn").HasDefaultValue(DateTime.Now);
                }
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
