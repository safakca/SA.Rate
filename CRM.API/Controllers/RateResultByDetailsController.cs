using CRM.DataAccess.Abstract;
using CRM.Entity.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRM.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RateResultByDetailsController : ControllerBase
{
    private readonly IRateResultDal _rateResultDal;
   
    public RateResultByDetailsController(IRateResultDal rateResultDal)
    {
        _rateResultDal = rateResultDal;
    }

    [HttpGet("GetAllRateResultByDetail")]
    public IActionResult GetAllRateResultByDetail()
    {
        var result= _rateResultDal.GetAllRateResultByDetail();
        return Ok(result);
    }


    [HttpGet("GetRateResultByDetail")]
    public IActionResult GetRateResultByDetail(int id)
    {
        var result = _rateResultDal.GetRateResultByDetail(id);
        return Ok(result);
    }

    [HttpPost("InsertRateResultByDetail")]
    public IActionResult InsertRateResultByDetail(RateResultDto rateResultDto)
    {
        var result=_rateResultDal.insert(rateResultDto);
        return Ok(result);
    }

}
