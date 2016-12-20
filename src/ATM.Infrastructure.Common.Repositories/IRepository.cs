using System.Collections.Generic;
using ATM.Infrastructure.Framework.Domain;

namespace ATM.Infrastructure.Common.Repositories
{
    public interface IRepository<TEntity> where TEntity : AggregateRoot
    {
        void Add(TEntity entity);
        IEnumerable<TEntity> List();
        void Remove(TEntity entity);
    }
}