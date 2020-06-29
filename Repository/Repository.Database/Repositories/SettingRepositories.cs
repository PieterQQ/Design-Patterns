using Microsoft.EntityFrameworkCore;
using Repository.Database.Entities;
using Repository.Database.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace Repository.Database
{
    public class SettingRepositories : BaseRepository<Settings>, ISettingRepositories
    {
        protected override DbSet<Settings> DbSet => _dbcontext.settings;

        public SettingRepositories(RepositoryDbContext dbContext) : base(dbContext)
        {
        }
      
        public void UpdateSetting(Settings setting)
        {
            var toUpdate = DbSet.Where(x => x.Name == setting.Name).FirstOrDefault();
            if (toUpdate == null)
            {
                DbSet.Add(setting);
            }
            else
            {
                toUpdate.Name = setting.Name;
                toUpdate.Value = setting.Value;
            }

            SaveChanges();
        }

        public void RemoveSetting(string name)
        {
            var toRemove = DbSet.Where(x => x.Name == name).First();
            if (toRemove != null)
            {
                DbSet.Remove(toRemove);
            }


            SaveChanges();
        }
            public Settings FindByName(string name)
            {
                var toFind = DbSet.Where(x => x.Name == name).First();
            return toFind;
            }
        }
}
