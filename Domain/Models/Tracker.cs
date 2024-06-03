using Domain.Base;
namespace Domain.Models;

public class Tracker : EntityBase
{
    public int FromUserOrgUnitId { get; set; }

    public int? ToUserOrgUnitId { get; set; }

    public int? ActionId { get; set; }

    public Guid CorrespondenceId { get; set; }

    public int TrackerStatusId { get; set; }

    public string? Notes { get; set; }

    public virtual Status? Action { get; set; }

    public virtual Correspondence Correspondence { get; set; } = null!;

    public virtual UserOrgUnit FromUserOrgUnit { get; set; } = null!;

    public virtual UserOrgUnit? ToUserOrgUnit { get; set; }

    public virtual TrackerStatus TrackerStatus { get; set; } = null!;
}
