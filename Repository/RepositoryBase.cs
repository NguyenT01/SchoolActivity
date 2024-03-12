using Microsoft.EntityFrameworkCore;
using Repository.Interface;
using System.Linq.Expressions;

namespace Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly RepositoryContext RepositoryContext;

        public RepositoryBase(RepositoryContext repositoryContext) { RepositoryContext = repositoryContext; }

        public void Add(T entity)
            => RepositoryContext.Set<T>().Add(entity);

        public void Delete(T entity)
            => RepositoryContext.Set<T>().Remove(entity);

        public IQueryable<T> FindAll(bool tracking)
            => tracking ? RepositoryContext.Set<T>() : RepositoryContext.Set<T>().AsNoTracking();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> condition, bool tracking)
            => tracking ? RepositoryContext.Set<T>().Where(condition) :
                        RepositoryContext.Set<T>().Where(condition).AsNoTracking();

        public void Update(T entity)
            => RepositoryContext.Set<T>().Update(entity);
    }
}
