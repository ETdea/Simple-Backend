using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace SimpleBackend.Models
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<MyDbContext>
    {
        static public List<Func<object>> seeds = new List<Func<object>>();

        protected override void Seed(MyDbContext context)
        {
            foreach(var seedFunc in seeds)
            {
                var seed = seedFunc();

                context.Set(seed.GetType()).Add(seed);
            }
            
            context.Configuration.ValidateOnSaveEnabled = false;
            base.Seed(context);

            seeds = null;
        }

        static public void AddSeed(Func<object> seed)
        {
            seeds.Add(seed);
        }
    }
}