namespace CRM.Entity.Concrete;
public class RateResult 
{
    public int Id { get; set; } 
     
    public string Notes { get; set; }
    public int RateId { get; set; }
    public int? CustomerId { get; set; } 
    public int? TaskId { get; set; } 
    public string CreatedBy { get; set; } 
    public DateTime CreatedOn { get; set; }
     
    public virtual ICollection<RateResultDetail> RateResultDetails { get; set; }
}

