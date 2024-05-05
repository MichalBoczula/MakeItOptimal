using MakeItOptimal.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace MakeItOptimal.Persistance.Configuration
{
    public class ToDoTaskConfiguration : IEntityTypeConfiguration<ToDoTask>
    {
        public void Configure(EntityTypeBuilder<ToDoTask> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(t => t.Status)
                .HasConversion<int>()
                .IsRequired();
            builder.Property(t => t.Name)
                .HasMaxLength(255)
                .IsRequired();
        }
    }
}
