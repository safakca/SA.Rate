using CRM.DataAccess.Abstract; 
using Microsoft.AspNetCore.Mvc;

namespace CRM.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RatesByRateQNController : ControllerBase
{
    private readonly IRateDal _rateDal;

    public RatesByRateQNController(IRateDal rateDal)
    {
        _rateDal = rateDal;
    } 

    [HttpGet("GetRatesByRateQuestionAll")]
    public IActionResult GetAll()
    {
        var result = _rateDal.GetRatesByRateQuestionAll();
        return Ok(result);
    }

    [HttpGet("GetRateByRateQN")]
    public IActionResult GetRateByRateQN(int id)
    {
        var result = _rateDal.GetRatesByRateQuestion(id);
        return Ok(result);
    } 
     
}

