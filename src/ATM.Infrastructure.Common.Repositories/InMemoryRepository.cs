using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATM.Infrastructure.Framework.Domain;

namespace ATM.Infrastructure.Common.Repositories
{
    public class InMemoryRepository<TEntity>
        where TEntity : AggregateRoot
    {
        private List<TEntity> memList = new List<TEntity>();

        public void Add(TEntity entity)
        {
            memList.Add(entity);
        }

        public void Remove(TEntity entity)
        {
            memList.Remove(entity);
        }

        public IEnumerable<TEntity> List()
        {
            return memList;
        }
    }
}
