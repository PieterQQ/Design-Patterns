using Microsoft.EntityFrameworkCore;
using Repository.Database.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace Repository.Database
{
    public class SettingRepositories
    {
        private  RepositoryDbContext _dbcontext;
        private DbSet<Settings> DbSet => _dbcontext.settings;
        public SettingRepositories(RepositoryDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        public List<Settings> GetAll()
        {
            var list = new List<Settings>();
            var settings = DbSet;
            foreach (var setting in settings)
            {
                list.Add(setting);
            }
            return list;
        }
        public void UpdateSetting(Settings setting)
        {
            var toUpdate = DbSet.Where(x => x.Id == setting.Id).FirstOrDefault();
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
        public void SaveChanges()
        {
            _dbcontext.SaveChanges();
        }
    }
}
