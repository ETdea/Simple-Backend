using System;
using System.Collections.Generic;

namespace SimpleBackend.Models
{
    public class DbInitializer : System.Data.Entity.DropCreateDatabaseAlways<MyDbContext>
    {
        static public List<Func<object>> seeds = new List<Func<object>>();

        protected override void Seed(MyDbContext context)
        {
            seeds.ForEach(seed => seed());
            
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