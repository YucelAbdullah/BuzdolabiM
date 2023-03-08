using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BuzdolabımData
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }

        public bool Enabled { get; set; }
        public string? Description { get; set; }
        public ICollection<Food> Foods { get; set; } = new HashSet<Food>();
    }

    public class CategoryEntityTypeConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .Property(p=>p.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode()
                .IsFixedLength(false);

            builder
                .HasIndex(p => new { p.Name })
                .IsUnique();

            builder
                .Property(c => c.Description)
                .IsRequired(false)
                .HasMaxLength(250)
                .IsUnicode()
                .IsFixedLength(false);

            builder
                .HasIndex(c => new { c.Description })
                .IsUnique();


            builder
                .HasMany(c => c.Foods)
                .WithOne(c=>c.Category)
                .HasForeignKey(c => c.CategoryId)  
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
