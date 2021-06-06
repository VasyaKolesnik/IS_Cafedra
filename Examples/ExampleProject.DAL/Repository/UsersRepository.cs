using Core.DAL.Repository;
using ExampleProject.DAL.EF;
using ExampleProject.DAL.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace ExampleProject.DAL.Repository
{
    public class UsersRepository : AbstractRepository<Users>
    {
        public UsersRepository(IDbContextFactory<ApplicationDbContext> context) : base(context)
        { }
    }
}
