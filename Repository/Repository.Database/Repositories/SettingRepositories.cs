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

        public void RemoveSetting(int id)
        {
            var toRemove = DbSet.Where(x => x.Id == id).First();
            if (toRemove!=null)
            {
                DbSet.Remove(toRemove);
            }
          

            SaveChanges();
        }
    }
}
