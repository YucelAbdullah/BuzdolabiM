using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuzdolabımData
{
    public class FoodImage
    {
        public Guid Id { get; set; }

        public Guid FoodId { get; set; }

        public byte[] Image { get; set; }

        public virtual Food? Food { get; set; }


    }

    public class FoodImagesEntityTypeConfiguration : IEntityTypeConfiguration<FoodImage>
    {
        public void Configure(EntityTypeBuilder<FoodImage> builder)
        {
            builder
                .Property(p => p.Image)
                .IsRequired();
        }
    }
}
