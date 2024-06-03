using Domain.Base;
namespace Domain.Models;

public partial class TemplateCorresponednceType : EntityBase
{

    //  public int CorresponednceTypeId { get; set; }

    public int TemplateId { get; set; }

    public int CorrespondenceSubTypeId { get; set; }//??
    public virtual CorrespondenceSubType CorrespondenceSubTyp { get; set; } = null!;

    // public virtual CorrespondenceType CorresponednceType { get; set; } = null!;

    public virtual CorrespondenceSubType CorrespondenceSubType { get; set; } = null!;//??

    public virtual Template Template { get; set; } = null!;
}
