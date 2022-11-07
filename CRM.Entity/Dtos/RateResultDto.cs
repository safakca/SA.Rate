using AutoMapper;
using CRM.Entity.Concrete;

namespace CRM.Entity.Dtos;
public class RateResultDto 
{  
    public string? Notes { get; set; }
    public int? RateId { get; set; }
    public int? CustomerId { get; set; }
    public int? TaskId { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }

    public virtual ICollection<RateResultDetail>? RateResultDetails { get; set; }


}

public class RateResultProfile : Profile
{ 
    public RateResultProfile()
    {
        CreateMap<RateResultDto, RateResult>().ReverseMap(); 
    } 
}

