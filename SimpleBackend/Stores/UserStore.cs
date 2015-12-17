using Microsoft.AspNet.Identity.EntityFramework;
using SimpleBackend.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBackend.Stores
{
    public class UserStore : UserStore<User, Role, int, UserLogin, UserRole, UserClaim>
    {
        private DbSet<User> table { get { return Context.Set<User>(); } }

        public UserStore(DbContext dbContext) : base(dbContext) { }

        public override Task CreateAsync(User user)
        {
            user.Id = Guid.NewGuid().ToInt32();
            user.Created = DateTime.UtcNow;
            user.Updated = user.Created;

            return base.CreateAsync(user);
        }

        public IEnumerable<User> Find()
        {
            return table;
        }

        public void DeleteAll(IEnumerable<int> ids)
        {
            table.RemoveRange(table.Where(p => ids.Contains(p.Id)));
            Context.SaveChanges();
        }

        public override Task UpdateAsync(User user)
        {
            if(user != null)
            {
                user.Updated = DateTime.UtcNow;
            }

            return base.UpdateAsync(user);
        }
    }
}