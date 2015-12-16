using Microsoft.AspNet.Identity.EntityFramework;
using SimpleBackend.Models;
using System.Data.Entity;

namespace SimpleBackend.Stores
{
    public class RoleStore : RoleStore<Role, int, UserRole>
    {
        public RoleStore(DbContext dbContext) : base(dbContext) { }
    }
}