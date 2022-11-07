using CRM.Entity.Concrete;
using System.Linq.Expressions;

namespace CRM.DataAccess.Abstract;
public interface IGenericRepository<T> where T : class, new()
{
    T Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    List<T> GetAll(Expression<Func<T,bool>> filter=null);
    T GetByFilter(Expression<Func<T, bool>> filter);
}

