using JackShopV3.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JackShopV3.Data.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .HasKey(key => key.Id);

            builder
                .Property(p => p.Title)
                .HasMaxLength(100)
                .IsRequired();

            builder
               .Property(p => p.Description)
               .HasMaxLength(50)
               .IsRequired();

        }
    }
}
