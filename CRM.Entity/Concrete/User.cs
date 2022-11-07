namespace CRM.Entity.Concrete;
public class User 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<RateResult> RateResults { get; set; }
}
