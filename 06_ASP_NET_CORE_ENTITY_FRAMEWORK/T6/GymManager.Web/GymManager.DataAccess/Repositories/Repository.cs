using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.DataAccess.Repositories
{
    public class Repository<TId, TEntity> : IRepository<TId, TEntity> where TEntity : class, new()
    {

        private readonly GymManagerContext _gymManagerContext;
        public Repository(GymManagerContext gymManagerContext) {
            _gymManagerContext= gymManagerContext;
        }

        public Task<TEntity> AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(TId id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> Get(TId id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
