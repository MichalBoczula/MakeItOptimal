using MakeItOptimal.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MakeItOptimal.Persistance.Configuration
{
    public class ToDoListConfiguration : IEntityTypeConfiguration<ToDoList>
    {
        public void Configure(EntityTypeBuilder<ToDoList> builder)
        {
            builder.HasKey(k => k.Id);
            builder.HasMany(x => x.Tasks)
                .WithOne(y => y.ToDoListRef);
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}