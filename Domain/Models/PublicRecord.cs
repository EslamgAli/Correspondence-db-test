using Domain.Base;

namespace Domain.Models;

public partial class PublicRecord : EntityBase
{

    public Guid CorrespondenceId { get; set; }

    public int PublicRecordStatusId { get; set; }

    public virtual Correspondence Correspondence { get; set; } = null!;

    public virtual PublicRecordStatus PublicRecordStatus { get; set; } = null!;
}
