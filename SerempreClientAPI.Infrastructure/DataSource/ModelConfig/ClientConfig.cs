using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SerempreClientAPI.Domain.Entities;

namespace SerempreClientAPI.Infrastructure.DataSource.ModelConfig;

public class ClientConfig : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.Property(p => p.Id).IsRequired();

        builder.HasOne(p => p.City)
            .WithMany(c => c.Clients)
            .HasForeignKey(c => c.CityId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
