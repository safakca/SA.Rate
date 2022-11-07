using CRM.DataAccess.Abstract;
using CRM.DataAccess.Concrete;
using CRM.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CRM.DataAccess.Repository;

public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
{
    private readonly DatabaseContext _context;

    public GenericRepository(DatabaseContext context)
    {
        _context = context;
    }

    public T Add(T entity)
    {
        _context.Add(entity);
        _context.SaveChanges();
        return entity;
    }

    public void Update(T entity)
    {
        _context.Update(entity);
        _context.SaveChanges();
    }
    public void Delete(T entity)
    { 
        _context.Remove(entity);
        _context.SaveChanges();
    }

    public List<T> GetAll(Expression<Func<T, bool>> filter = null)
    {
        return filter == null ? _context.Set<T>().AsNoTracking().ToList() : _context.Set<T>().Where(filter).ToList();
    }

    public T GetByFilter(Expression<Func<T, bool>> filter)
    {
        return _context.Set<T>().SingleOrDefault(filter);
    }
}

