using Domain.Base;

namespace Domain.Models;

public class SentToExternalUnit : EntityBase
{
    public Guid CorrespodenceId { get; set; }

    public int ExternalUnitId { get; set; }

    public virtual Correspondence Correspodence { get; set; } = null!;

    public virtual ExternalUnit ExternalUnit { get; set; } = null!;
}
