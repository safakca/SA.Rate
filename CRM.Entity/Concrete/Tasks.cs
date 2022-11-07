namespace CRM.Entity.Concrete;
public class Tasks 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<RateResult> RateResults { get; set; }
}

