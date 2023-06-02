using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Points.Domain.Entities;

namespace Points.DataAccess.Configurations
{
    public class PointConfiguration : IEntityTypeConfiguration<Point>
    {
        public void Configure(EntityTypeBuilder<Point> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.PositionX).IsRequired();
            builder.Property(x => x.PositionY).IsRequired();
            builder.Property(x => x.Color).IsRequired();

            builder.HasMany(x => x.Comments)
                .WithOne();
        }
    }
}