using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Runtime;

namespace BuzdolabımData
{
    public class FrostItem
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public Guid FoodId { get; set; }
        public Guid ApplicationUserId { get; set; }

        public int Quantity { get; set; }

        public virtual Food? Food { get; set; }

        public virtual ApplicationUser? ApplicationUser { get; set; }


    }

    public class FrostItemEntityTypeConfiguration : IEntityTypeConfiguration<FrostItem>
    {
        public void Configure(EntityTypeBuilder<FrostItem> builder)
        {

        }
    }
}
