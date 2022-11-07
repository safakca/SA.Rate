using CRM.Entity.Concrete;
using CRM.Entity.Dtos;

namespace CRM.DataAccess.Abstract;
public interface IRateResultDal : IGenericRepository<RateResult>
{
    List<RateResult> GetAllRateResultByDetail();
    RateResult GetRateResultByDetail(int id);

    RateResult insert(RateResultDto rateResultDto);
}
