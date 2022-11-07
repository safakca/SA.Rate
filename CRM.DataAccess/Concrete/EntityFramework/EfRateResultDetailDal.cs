using CRM.DataAccess.Abstract; 
using CRM.DataAccess.Repository;
using CRM.Entity.Concrete;

namespace CRM.DataAccess.Concrete.EntityFramework;

public class EfRateResultDetailDal : GenericRepository<RateResultDetail>, IRateResultDetailDal
{
    public EfRateResultDetailDal(DatabaseContext context) : base(context)
    {
    }
}