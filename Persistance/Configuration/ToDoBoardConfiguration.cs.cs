using MakeItOptimal.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MakeItOptimal.Persistance.Configuration
{
    public class ToDoBoardConfiguration : IEntityTypeConfiguration<ToDoBoard>
    {
        public void Configure(EntityTypeBuilder<ToDoBoard> builder)
        {
            builder.HasKey(k => k.Id);
            builder.HasMany(x => x.Lists)
                .WithOne(y => y.ToDoBoardRef);
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
