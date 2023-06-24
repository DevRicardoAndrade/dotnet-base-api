using System.Linq.Expressions;

namespace dotnet.Repositories
{
    public interface IRepository<T>
    {

        public IQueryable<T> Get();
        public Task<T> Get(Expression<Func<T, bool>> predicate);
        public void Create(T model);
        public void Update(T model);
        public void Delete(T model);

    }
}
