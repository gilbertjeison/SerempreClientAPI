using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SerempreClientAPI.Domain.Entities;

namespace SerempreClientAPI.Infrastructure.DataSource.ModelConfig;

public class UserConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(p => p.Id).IsRequired();
        builder.Property(p => p.Email).IsRequired();
        builder.Property(p => p.Password).IsRequired();
    }
}
