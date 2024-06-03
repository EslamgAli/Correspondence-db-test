using Domain.Models;

namespace Domain.Base;

public class EntityBase<TKey> : CoreEntityBase<TKey>
{

    public virtual int? CreatedBy { get; set; }
    public virtual UserOrgUnit? CreatedByUser { get; set; }
    public int? UpdatedBy { get; set; }
    public UserOrgUnit? UpdatedByUser { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set;}
}

public class CoreEntityBase<TKey>
{
    public TKey Id { get; set; }
}

public class EntityBase : EntityBase<int>
{

}
