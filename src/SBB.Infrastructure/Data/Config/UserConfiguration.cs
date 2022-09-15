using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SBB.Core.Entities;

namespace SBB.Infrastructure.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //    builder.ToTable("Users");

            //    builder.Property(u => u.Id)
            //           .UseHiLo("catalog_hilo")
            //           .IsRequired();

            //    builder.Property(ci => ci.Name)
            //        .IsRequired(true)
            //        .HasMaxLength(50);

            //public string? Email { get; set; }
            //public string? LastName { get; set; }
            //public DateTime CreatedDate { get; set; }
            //public DateTime LastModifiedDate { get; set; }
            //public int Age { get; set; }

            //builder.Property(ci => ci.Email)
            //        .IsRequired(true)
            //        .HasColumnType("decimal(18,2)");

            //    builder.Property(ci => ci.PictureUri)
            //        .IsRequired(false);

            //    builder.HasOne(ci => ci.CatalogBrand)
            //        .WithMany()
            //        .HasForeignKey(ci => ci.CatalogBrandId);

            //    builder.HasOne(ci => ci.CatalogType)
            //        .WithMany()
            //        .HasForeignKey(ci => ci.CatalogTypeId);
        }
    }
}
