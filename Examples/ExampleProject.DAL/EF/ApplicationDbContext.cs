using ExampleProject.DAL.Entities;
using ExampleProject.DAL.Entities.Discipline;
using ExampleProject.DAL.Entities.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace ExampleProject.DAL.EF
{
    public sealed class ApplicationDbContext : IdentityDbContext<Users>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=127.0.0.1;Port=5432;Database=kazakhstan;Username=kazakhstan;Password=vGAHb9BS0oUTBW8gdIqw");
        }

        public DbSet<ExampleEntity> Bases { get; set; } = null;
        //public DbSet<Users> Users { get; set; } = null;
        public DbSet<Disciplines> Disciplines { get; set; } = null;
    }
}