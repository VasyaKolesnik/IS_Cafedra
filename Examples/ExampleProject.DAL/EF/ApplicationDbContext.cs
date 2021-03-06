using ExampleProject.DAL.Entities;
using ExampleProject.DAL.Entities.Discipline;
using ExampleProject.DAL.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace ExampleProject.DAL.EF
{
    public sealed class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<ExampleEntity> Bases { get; set; } = null;
        public DbSet<Users> Users { get; set; } = null;
        public DbSet<Disciplines> Disciplines { get; set; } = null;
    }
}