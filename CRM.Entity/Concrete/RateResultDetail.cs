namespace CRM.Entity.Concrete;
public class RateResultDetail 
{

    public int Id { get; set; }
    public int RateQNId { get; set; }
    public int RateResultId { get; set; }
    public int ValueInt { get; set; }
    public string ValueString { get; set; } 

    public virtual RateQN RateQN { get; set; } 
}

