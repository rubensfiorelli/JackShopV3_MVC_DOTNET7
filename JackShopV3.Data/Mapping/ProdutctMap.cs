using JackShopV3.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JackShopV3.Data.Mapping
{
    public class ProdutctMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .HasKey(key => key.Id);

            builder
                .Property(p => p.Title)
                .HasMaxLength(50)
                .IsRequired();

            builder
               .Property(p => p.Description)
               .HasMaxLength(300)
               .IsRequired();

            builder
               .Property(p => p.Price)
               .HasColumnType("decimal(10,2)");

            builder
                .HasOne(p => p.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.CategoryId);
        }
    }
}
