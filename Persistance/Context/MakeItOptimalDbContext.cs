using MakeItOptimal.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace MakeItOptimal.Persistance.Context
{
    public class MakeItOptimalDbContext : DbContext
    {
        public DbSet<ToDoBoard> Boards { get; set; }
        public DbSet<ToDoList> Lists { get; set; }
        public DbSet<ToDoTask> Tasks { get; set; }

        public MakeItOptimalDbContext([NotNull] DbContextOptions<MakeItOptimalDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}