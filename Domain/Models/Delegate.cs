using Domain.Base;

namespace Domain.Models;

public class Delegate : EntityBase
{

    public DateOnly From { get; set; }

    public DateOnly? To { get; set; }

    public int DelegateFrom { get; set; }

    public virtual UserOrgUnit DelegateFromNavigation { get; set; } = null!;

    public virtual UserOrgUnit UserOrgUnit { get; set; }
}
