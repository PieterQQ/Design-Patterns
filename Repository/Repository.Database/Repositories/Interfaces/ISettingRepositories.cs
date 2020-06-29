using Repository.Database.Entities;
using System.Collections.Generic;

namespace Repository.Database
{
    public interface ISettingRepositories
    {
        List<Settings> GetAll();
        void UpdateSetting(Settings setting);
        void SaveChanges();
        void RemoveSetting(string name);
    }
}
