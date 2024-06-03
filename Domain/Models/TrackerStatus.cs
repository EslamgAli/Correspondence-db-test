using Domain.Base;
namespace Domain.Models;

public class TrackerStatus : EntityBase
{

    public string NameAr { get; set; } = null!;

    public string NameEn { get; set; } = null!;

    public virtual ICollection<Tracker> Trackers { get; set; } = new List<Tracker>();
}
