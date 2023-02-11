using Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Database;

public sealed class FilmConfiguration : IEntityTypeConfiguration<Film>
{
    public void Configure(EntityTypeBuilder<Film> builder)
    {
        builder.ToTable(nameof(Film));

        builder.HasKey(entity => entity.Id);

        builder.Property(entity => entity.Id).ValueGeneratedOnAdd().IsRequired();

        builder.Property(entity => entity.Title).HasMaxLength(100).IsRequired();

        builder.Property(entity => entity.Year).HasMaxLength(4).IsRequired();

        builder.Property(entity => entity.Poster).HasMaxLength(200).IsRequired();

        builder.Property(entity => entity.Genre).HasMaxLength(50).IsRequired();

        builder.Property(entity => entity.Plot).HasMaxLength(1000);

        builder.Property(entity => entity.Actors).HasMaxLength(200);

        builder.Property(entity => entity.Language).HasMaxLength(50);

        builder.Property(entity => entity.Country).HasMaxLength(50);

        builder.HasIndex(entity => entity.Title).IsUnique();
    }
}
