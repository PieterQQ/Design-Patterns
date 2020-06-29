using Microsoft.EntityFrameworkCore;
using Repository.Database.Entities;
using System.Collections.Generic;

namespace Repository.Database.Repositories
{
    public abstract class BaseRepository<Entity>  where Entity : class
    {
        protected RepositoryDbContext _dbcontext;
        protected abstract DbSet<Entity> DbSet { get;}
        public BaseRepository(RepositoryDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        public List<Entity> GetAll()
        {
            var list = new List<Entity>();
            var entities = DbSet;
            foreach (var entity in entities)
            {
                list.Add(entity);
            }
            return list;
        }
        public void SaveChanges()
        {
            _dbcontext.SaveChanges();
        }
    }
}
