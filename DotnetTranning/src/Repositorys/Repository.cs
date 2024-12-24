using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DotnetTranning.src.Repositorys
{
    public class Repository<Entity> : IRepository<Entity> where Entity : class
    {
        private  DbContext _Context;
        private  DbSet<Entity> _Set;
        public Repository(DbContext Context)
        {
            _Context = Context;
            _Set = Context.Set<Entity>();
        }

        public void AttachEntity(Entity Entity)
        {
            _Set.Add(Entity);
            SaveChanges();
        }

        public async Task DeleteById(int Id)
        {
            var Entity = await _Set.FindAsync(Id);
            _Set.Remove(Entity);
            SaveChanges();
        }

        public async Task<IEnumerable<Entity>> GetAll()
        {
            return await _Set.ToListAsync();
        }

        public Entity GetById(int Id)
        {
            return _Set.Find(Id);
        }
        public void SaveChanges()
        {
            _Context.SaveChanges();
        }
        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}