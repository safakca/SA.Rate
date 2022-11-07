using CRM.Entity.Enums;

namespace CRM.Entity.Concrete;
public class RateQN
{
    public int Id { get; set; }
    public EQNType EQNType { get; set; }
    public int RateId { get; set; }
    public int TranslationId { get; set; }

    public virtual ICollection<RateResultDetail> RateResultDetails {get; set;}
}

