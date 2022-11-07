namespace CRM.Entity.Concrete;
public class Rate
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public bool Stopped { get; set; }
     
    public virtual ICollection<RateQN> RateQNs { get; set; }
}



