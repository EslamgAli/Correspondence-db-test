using Domain.Base;

namespace Domain.Models;

public class Tag : EntityBase
{

    public string Name { get; set; } = null!;

    public virtual ICollection<CorrespondenceTag> CorrespondenceTags { get; set; } = new List<CorrespondenceTag>();
}
