using Microsoft.EntityFrameworkCore;
using AB12.Domain.Base.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AB12.Domain.Persistence.Configuration;
public class UserConfig : IEntityTypeConfiguration<User>
{
  public void Configure(EntityTypeBuilder<User> builder)
  {
    builder.ToTable("Users");

    builder.Property(u => u.ID).HasMaxLength(255);

    builder.Property(u => u.FirstName).HasMaxLength(100);

    builder.Property(u => u.LastName).HasMaxLength(100);

    builder.HasMany<Order>(u => u.Orders)
           .WithOne(o => o.User)
           .OnDelete(DeleteBehavior.Cascade);
  }
}