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
    // TODO: rate ve rateQn icin sadece get yapilacak seed data dan
    // TODO: rateResult ve detail icin post islemide yapilacak DTO kullanarak bi endPointte 2 tabloya kayit atabilirsin

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

    //[HttpGet("GetByFilterRate")]
    //public IActionResult GetByFilter(int id)
    //{
    //    var result = _rateDal.GetByFilter(x => x.Id == id);
    //    return Ok(result);
    //}

    //[HttpPost("InsertRate")]
    //public IActionResult Create([FromBody] Rate rate)
    //{
    //    _rateDal.Add(rate);
    //    return Ok();
    //}

    //[HttpPut("UpdateRate")]
    //public IActionResult Update([FromBody] Rate rate)
    //{
    //    _rateDal.Update(rate);
    //    return Ok();
    //}

    //[HttpDelete("RemoveRate")]
    //public IActionResult Remove(Rate rate)
    //{
    //    _rateDal.Delete(rate);
    //    return Ok();
    //}
}

