using Domain.Base;

namespace Domain.Models;

public class Correspondence : EntityBase<Guid>
{

    public Guid? ParentId { get; set; }

    public bool IsUrgent { get; set; }

    public bool IsSecret { get; set; }

    public string RefNumber { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string? Comment { get; set; }

    // public int CorrespondenceTypeId { get; set; }
    //   public CorrespondenceType CorrespondenceType { get; set; }

    public string? FilePath { get; set; }

    public int? ApprovalAuthorityExceptionId { get; set; }///

    public bool SendToAllEmp { get; set; }

    public bool SendToAllOrgUnit { get; set; }

    public int? WorkflowId { get; set; }
    public Workflow? Workflow { get; set; }

    public int TemplateId { get; set; }
    public Template? Template { get; set; }

    public int? ExternalUnitId { get; set; }
    public ExternalUnit? ExternalUnit { get; set; }
    public DateTime? ReceivingDate { get; set; }

    public int CorrespondenceSubTypeId { get; set; }
    public CorrespondenceSubType CorrespondenceSubType { get; set; }

    public bool IsPublicDecision { get; set; }

    public virtual ICollection<Archive> Archives { get; set; } = new List<Archive>();

    public virtual ICollection<Attachement> Attachements { get; set; } = new List<Attachement>();

    public virtual ICollection<CorrespondenceInbox> CorrespondenceInboxes { get; set; } = new List<CorrespondenceInbox>();

    public virtual ICollection<CorrespondenceTag> CorrespondenceTags { get; set; } = new List<CorrespondenceTag>();

    public virtual ICollection<CorrespondenceWorkflowStep> CorrespondenceWorkflowSteps { get; set; } = new List<CorrespondenceWorkflowStep>();

    public virtual ICollection<CorrespondencesOutbox> CorrespondencesOutboxes { get; set; } = new List<CorrespondencesOutbox>();

    public virtual ICollection<Draft> Drafts { get; set; } = new List<Draft>();

    public virtual ICollection<Correspondence> InverseParent { get; set; } = new List<Correspondence>();

    public virtual Correspondence? Parent { get; set; }

    public virtual ICollection<PublicRecord> PublicRecords { get; set; } = new List<PublicRecord>();

    public virtual ICollection<SentToExternalUnit> SentToExternalUnits { get; set; } = new List<SentToExternalUnit>();

    public virtual ICollection<SentToOrgUnit> SentToOrgUnits { get; set; } = new List<SentToOrgUnit>();

    public virtual ICollection<SentToUserOrgUnit> SentToUserOrgUnits { get; set; } = new List<SentToUserOrgUnit>();

    public virtual ICollection<Tracker> Trackers { get; set; } = new List<Tracker>();

    public virtual ICollection<View> Views { get; set; } = new List<View>();
}
