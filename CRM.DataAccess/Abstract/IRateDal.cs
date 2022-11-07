using CRM.Entity.Concrete;
using CRM.Entity.Dtos;

namespace CRM.DataAccess.Abstract;
public interface IRateDal : IGenericRepository<Rate>
{  
    Rate GetRatesByRateQuestion(int RateQuestionId);

    List<Rate> GetRatesByRateQuestionAll();
}
