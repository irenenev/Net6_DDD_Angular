using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Database;

public sealed class AuthConfiguration : IEntityTypeConfiguration<Domain.Auth>
{
    public void Configure(EntityTypeBuilder<Domain.Auth> builder)
    {
        builder.ToTable(nameof(Domain.Auth));

        builder.HasKey(entity => entity.Id);

        builder.Property(entity => entity.Id).ValueGeneratedOnAdd().IsRequired();

        builder.Property(entity => entity.Login).HasMaxLength(100).IsRequired();

        builder.Property(entity => entity.Password).HasMaxLength(1000).IsRequired();

        builder.Property(entity => entity.Salt).HasMaxLength(1000).IsRequired();

        builder.HasIndex(entity => entity.Login).IsUnique();

        builder.HasIndex(entity => entity.Salt).IsUnique();
    }
}
