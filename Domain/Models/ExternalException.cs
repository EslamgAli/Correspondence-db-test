using Domain.Base;

namespace Domain.Models
{
    public class ExternalException : EntityBase
    {
        public int OrgUnitId { get; set; }
        public OrgUnit OrgUnit { get; set; }
    }
}
