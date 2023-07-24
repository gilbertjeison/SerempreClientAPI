using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SerempreClientAPI.Domain.Entities;

namespace SerempreClientAPI.Infrastructure.DataSource.ModelConfig
{
    public class CityConfig : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.Property(p => p.Id).IsRequired();
        }
    }
}
