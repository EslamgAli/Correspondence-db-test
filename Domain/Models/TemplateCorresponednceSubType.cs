using Domain.Base;
namespace Domain.Models;

public partial class TemplateCorresponednceSubType : EntityBase
{

    public int TemplateId { get; set; }

    public int CorrespondenceSubTypeId { get; set; }//??
   
    public virtual CorrespondenceSubType CorrespondenceSubType { get; set; } = null!;//??

    public virtual Template Template { get; set; } = null!;
}
