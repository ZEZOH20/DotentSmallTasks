using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetTranning.src.Repositorys
{
    public interface IRepository<Entity> where Entity : class
    {
        //CRUD
        Entity GetById(int Id);
        Task<IEnumerable<Entity>> GetAll();
        Task DeleteById(int Id);
        void AttachEntity(Entity Entity);
        public void SaveChanges();
        public void Dispose();

    }
}