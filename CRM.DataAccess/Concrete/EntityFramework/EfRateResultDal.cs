using AutoMapper;
using CRM.DataAccess.Abstract; 
using CRM.DataAccess.Repository;
using CRM.Entity.Concrete;
using CRM.Entity.Dtos;
using Microsoft.EntityFrameworkCore;

namespace CRM.DataAccess.Concrete.EntityFramework;

public class EfRateResultDal : GenericRepository<RateResult>, IRateResultDal
{
    private readonly DatabaseContext _context;
    private readonly IMapper _mapper;
    public EfRateResultDal(DatabaseContext context, IMapper mapper) : base(context)
    {
        _context = context;
        _mapper = mapper;
    }


    public List<RateResult> GetAllRateResultByDetail()
    {
        return _context.RateResults.Include(x=>x.RateResultDetails).ToList();
    }

    public RateResult GetRateResultByDetail(int id)
    {
        return _context.RateResults.Include(x => x.RateResultDetails).Where(x => x.Id == id).SingleOrDefault();
    }

    public RateResult insert(RateResultDto rateResultDto)
    {
       var result= _mapper.Map<RateResult>(rateResultDto);
       return result;
    }
}
