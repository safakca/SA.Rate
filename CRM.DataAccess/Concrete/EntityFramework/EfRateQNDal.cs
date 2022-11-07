using CRM.DataAccess.Abstract; 
using CRM.DataAccess.Repository;
using CRM.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CRM.DataAccess.Concrete.EntityFramework;

public class EfRateQNDal : GenericRepository<RateQN>, IRateQNDal
{
    private readonly DatabaseContext _context;    
    public EfRateQNDal(DatabaseContext context) : base(context)
    {
        _context = context;
    }


}
