using CRM.DataAccess.Abstract;
using CRM.DataAccess.Repository;
using CRM.Entity.Concrete;
using CRM.Entity.Dtos;
using Microsoft.EntityFrameworkCore;

namespace CRM.DataAccess.Concrete.EntityFramework;
public class EfRateDal : GenericRepository<Rate>, IRateDal
{
    private readonly DatabaseContext _context;
    public EfRateDal(DatabaseContext context) : base(context)
    {
        _context = context;
    }

    public Rate GetRatesByRateQuestion(int RateQuestionId)
    {
        return _context.Rates.Include(x => x.RateQNs) 
                             .Where(x => x.Id == RateQuestionId).SingleOrDefault();

    }
    public List<Rate> GetRatesByRateQuestionAll()
    {
        return _context.Rates.Include(x => x.RateQNs).ToList();
    } 
}

