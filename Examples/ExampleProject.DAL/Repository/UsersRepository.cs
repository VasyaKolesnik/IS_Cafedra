using Core.DAL.Repository;
using ExampleProject.DAL.EF;
using ExampleProject.DAL.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleProject.DAL.Repository
{
    //public class UsersRepository : IRepository<Users>
    //{
    //    public UsersRepository(IDbContextFactory<ApplicationDbContext> context)
    //    { }

    //    public Task<Users> Create(Users item)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Task<bool> Delete(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public IEnumerable<Users> Find(Func<Users, bool> predicate)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public IQueryable<Users> Get(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public IQueryable<Users> GetAll()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Task<Users> Update(Users item)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
