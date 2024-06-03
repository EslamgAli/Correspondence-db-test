using Domain.Base;

namespace Domain.Models;

public partial class PublicRecordStatus : EntityBase
{

    public string NameAr { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public virtual ICollection<PublicRecord> PublicRecords { get; set; } = new List<PublicRecord>();
}
