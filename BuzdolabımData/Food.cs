using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BuzdolabımData
{
    public class Food
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid CategoryId { get; set; }

        public Category Category { get; set; }
    }


    public class FoodEntityTypeConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode()
                .IsFixedLength(false);

            builder
                .HasIndex(p => new { p.Name })
                .IsUnique();

           
        }
    }
}
