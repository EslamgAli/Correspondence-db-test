using Domain.Base;
namespace Domain.Models;

public partial class UserOrgUnit : EntityBase
{

    public int UserId { get; set; }

    public int OrgUnitId { get; set; }

    public bool IsDefaultRole { get; set; }

    public string JobTitle { get; set; } = null!;

    public bool IsManager { get; set; }

    public int? DelegateId { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<AuthorityException> AuthorityExceptions { get; set; } = new List<AuthorityException>();

    public virtual ICollection<Archive> Archives { get; set; } = new List<Archive>();

    public virtual ICollection<CorrespondenceInbox> CorrespondenceInboxFromUserOrgUnits { get; set; } = new List<CorrespondenceInbox>();

    public virtual ICollection<CorrespondenceInbox> CorrespondenceInboxUserOrgUnits { get; set; } = new List<CorrespondenceInbox>();

    public virtual ICollection<CorrespondencesOutbox> CorrespondencesOutboxToUserOrgUnits { get; set; } = new List<CorrespondencesOutbox>();

    public virtual ICollection<CorrespondencesOutbox> CorrespondencesOutboxUserOrgUnits { get; set; } = new List<CorrespondencesOutbox>();
    public virtual ICollection<User> Employees { get; set; }
    public virtual Delegate? Delegate { get; set; }

    public virtual ICollection<Delegate> Delegates { get; set; } = new List<Delegate>();

    public virtual ICollection<Draft> Drafts { get; set; } = new List<Draft>();

    public virtual ICollection<GroupDetail> GroupDetails { get; set; } = new List<GroupDetail>();

    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();

    public virtual OrgUnit OrgUnit { get; set; } = null!;

    public virtual ICollection<SentToUserOrgUnit> SentToUserOrgUnits { get; set; } = new List<SentToUserOrgUnit>();

    public virtual ICollection<TemplateOrgUnit> TemplateOrgUnits { get; set; } = new List<TemplateOrgUnit>();

    public virtual ICollection<Tracker> TrackerFromUserOrgUnits { get; set; } = new List<Tracker>();

    public virtual ICollection<Tracker> TrackerToUserOrgUnits { get; set; } = new List<Tracker>();

    public virtual User User { get; set; } = null!;

    public virtual ICollection<View> Views { get; set; } = new List<View>();

    #region Audit 

    public virtual ICollection<AuthorityException> AuthorityExceptionCreate { get; set; } = new List<AuthorityException>();
    public virtual ICollection<AuthorityException> AuthorityExceptionUpdate { get; set; } = new List<AuthorityException>();

    public virtual ICollection<Archive> ArchiveCreate { get; set; } = new List<Archive>();
    public virtual ICollection<Archive> ArchiveUpdate { get; set; } = new List<Archive>();

    public virtual ICollection<Attachement> AttachementCreate { get; set; } = new List<Attachement>();
    public virtual ICollection<Attachement> AttachementUpdate { get; set; } = new List<Attachement>();

    public virtual ICollection<AttachementType> AttachementTypeCreate { get; set; } = new List<AttachementType>();
    public virtual ICollection<AttachementType> AttachementTypeUpdate { get; set; } = new List<AttachementType>();

    public virtual ICollection<CorrespondenceInbox> CorrespondenceInboxCreate { get; set; } = new List<CorrespondenceInbox>();
    public virtual ICollection<CorrespondenceInbox> CorrespondenceInboxUpdate { get; set; } = new List<CorrespondenceInbox>();

    public virtual ICollection<Correspondence> CorrespondenceCreate { get; set; } = new List<Correspondence>();
    public virtual ICollection<Correspondence> CorrespondenceUpdate { get; set; } = new List<Correspondence>();

    public virtual ICollection<CorrespondencesOutbox> CorrespondencesOutboxCreate { get; set; } = new List<CorrespondencesOutbox>();
    public virtual ICollection<CorrespondencesOutbox> CorrespondencesOutboxUpdate { get; set; } = new List<CorrespondencesOutbox>();

    public virtual ICollection<CorrespondenceType> CorrespondenceTypeCreate { get; set; } = new List<CorrespondenceType>();
    public virtual ICollection<CorrespondenceType> CorrespondenceTypeUpdate { get; set; } = new List<CorrespondenceType>();

    public virtual ICollection<CorrespondenceWorkflowStep> CorrespondenceWorkflowStepCreate { get; set; } = new List<CorrespondenceWorkflowStep>();
    public virtual ICollection<CorrespondenceWorkflowStep> CorrespondenceWorkflowStepUpdate { get; set; } = new List<CorrespondenceWorkflowStep>();

    public virtual ICollection<Delegate> DelegateCreate { get; set; } = new List<Delegate>();
    public virtual ICollection<Delegate> DelegateUpdate { get; set; } = new List<Delegate>();

    public virtual ICollection<ExternalUnit> ExternalUnitCreate { get; set; } = new List<ExternalUnit>();
    public virtual ICollection<ExternalUnit> ExternalUnitUpdate { get; set; } = new List<ExternalUnit>();

    public virtual ICollection<ExternalUnitType> ExternalUnitTypeCreate { get; set; } = new List<ExternalUnitType>();
    public virtual ICollection<ExternalUnitType> ExternalUnitTypeUpdate { get; set; } = new List<ExternalUnitType>();

    public virtual ICollection<GroupDetail> GroupDetailCreate { get; set; } = new List<GroupDetail>();
    public virtual ICollection<GroupDetail> GroupDetailUpdate { get; set; } = new List<GroupDetail>();

    public virtual ICollection<Group> GroupCreate { get; set; } = new List<Group>();
    public virtual ICollection<Group> GroupUpdate { get; set; } = new List<Group>();

    public virtual ICollection<OrgUnit> OrgUnitCreate { get; set; } = new List<OrgUnit>();
    public virtual ICollection<OrgUnit> OrgUnitUpdate { get; set; } = new List<OrgUnit>();

    public virtual ICollection<OrgUnitType> OrgUnitTypeCreate { get; set; } = new List<OrgUnitType>();
    public virtual ICollection<OrgUnitType> OrgUnitTypeUpdate { get; set; } = new List<OrgUnitType>();

    public virtual ICollection<Procedure> ProcedureCreate { get; set; } = new List<Procedure>();
    public virtual ICollection<Procedure> ProcedureUpdate { get; set; } = new List<Procedure>();

    public virtual ICollection<PublicRecord> PublicRecordCreate { get; set; } = new List<PublicRecord>();
    public virtual ICollection<PublicRecord> PublicRecordUpdate { get; set; } = new List<PublicRecord>();

    public virtual ICollection<SentToExternalUnit> SentToExternalUnitCreate { get; set; } = new List<SentToExternalUnit>();
    public virtual ICollection<SentToExternalUnit> SentToExternalUnitUpdate { get; set; } = new List<SentToExternalUnit>();

    public virtual ICollection<SentToOrgUnit> SentToOrgUnitCreate { get; set; } = new List<SentToOrgUnit>();
    public virtual ICollection<SentToOrgUnit> SentToOrgUnitUpdate { get; set; } = new List<SentToOrgUnit>();

    public virtual ICollection<SentToUserOrgUnit> SentToUserOrgUnitCreate { get; set; } = new List<SentToUserOrgUnit>();
    public virtual ICollection<SentToUserOrgUnit> SentToUserOrgUnitUpdate { get; set; } = new List<SentToUserOrgUnit>();

    public virtual ICollection<Status> StatusCreate { get; set; } = new List<Status>();
    public virtual ICollection<Status> StatusUpdate { get; set; } = new List<Status>();

    public virtual ICollection<SubexternalUnit> SubexternalUnitCreate { get; set; } = new List<SubexternalUnit>();
    public virtual ICollection<SubexternalUnit> SubexternalUnitUpdate { get; set; } = new List<SubexternalUnit>();

    public virtual ICollection<TemplateCorresponednceSubType> TemplateCorresponednceTypeCreate { get; set; } = new List<TemplateCorresponednceSubType>();
    public virtual ICollection<TemplateCorresponednceSubType> TemplateCorresponednceTypeUpdate { get; set; } = new List<TemplateCorresponednceSubType>();

    public virtual ICollection<TemplateOrgUnit> TemplateOrgUnitCreate { get; set; } = new List<TemplateOrgUnit>();
    public virtual ICollection<TemplateOrgUnit> TemplateOrgUnitUpdate { get; set; } = new List<TemplateOrgUnit>();

    public virtual ICollection<Template> TemplateCreate { get; set; } = new List<Template>();
    public virtual ICollection<Template> TemplateUpdate { get; set; } = new List<Template>();

    public virtual ICollection<Tracker> TrackerCreate { get; set; } = new List<Tracker>();
    public virtual ICollection<Tracker> TrackerUpdate { get; set; } = new List<Tracker>();

    public virtual ICollection<TrackerStatus> TrackerStatusCreate { get; set; } = new List<TrackerStatus>();
    public virtual ICollection<TrackerStatus> TrackerStatusUpdate { get; set; } = new List<TrackerStatus>();

    public virtual ICollection<UserOrgUnit> UserOrgUnitCreate { get; set; } = new List<UserOrgUnit>();
    public virtual ICollection<UserOrgUnit> UserOrgUnitUpdate { get; set; } = new List<UserOrgUnit>();

    public virtual ICollection<User> UserCreate { get; set; } = new List<User>();
    public virtual ICollection<User> UserUpdate { get; set; } = new List<User>();

    public virtual ICollection<View> ViewCreate { get; set; } = new List<View>();
    public virtual ICollection<View> ViewUpdate { get; set; } = new List<View>();

    public virtual ICollection<Workflow> WorkflowCreate { get; set; } = new List<Workflow>();
    public virtual ICollection<Workflow> WorkflowUpdate { get; set; } = new List<Workflow>();

    public virtual ICollection<Draft> DraftCreate { get; set; } = new List<Draft>();
    public virtual ICollection<Draft> DraftUpdate { get; set; } = new List<Draft>();

    public virtual ICollection<CorrespondenceSubType> CorrespondenceSubTypeCreate { get; set; } = new List<CorrespondenceSubType>();
    public virtual ICollection<CorrespondenceSubType> CorrespondenceSubTypeUpdate { get; set; } = new List<CorrespondenceSubType>();

    public virtual ICollection<WorkflowRole> WorkflowRoleCreate { get; set; } = new List<WorkflowRole>();
    public virtual ICollection<WorkflowRole> WorkflowRoleUpdate { get; set; } = new List<WorkflowRole>();

    public virtual ICollection<WorkflowStep> WorkflowStepCreate { get; set; } = new List<WorkflowStep>();
    public virtual ICollection<WorkflowStep> WorkflowStepUpdate { get; set; } = new List<WorkflowStep>();

    public virtual ICollection<WorkflowType> WorkflowTypeCreate { get; set; } = new List<WorkflowType>();
    public virtual ICollection<WorkflowType> WorkflowTypeUpdate { get; set; } = new List<WorkflowType>();

    public virtual ICollection<PrivilegeCategory> PrivilegeCategoryCreate { get; set; } = new List<PrivilegeCategory>();
    public virtual ICollection<PrivilegeCategory> PrivilegeCategoryUpdate { get; set; } = new List<PrivilegeCategory>();

    public virtual ICollection<Privilege> PrivilegeCreate { get; set; } = new List<Privilege>();
    public virtual ICollection<Privilege> PrivilegeUpdate { get; set; } = new List<Privilege>();

    public virtual ICollection<PrivilegeSecurityGroup> PrivilegeSecurityGroupCreate { get; set; } = new List<PrivilegeSecurityGroup>();
    public virtual ICollection<PrivilegeSecurityGroup> PrivilegeSecurityGroupUpdate { get; set; } = new List<PrivilegeSecurityGroup>();

    public virtual ICollection<SecurityGroup> SecurityGroupCreate { get; set; } = new List<SecurityGroup>();
    public virtual ICollection<SecurityGroup> SecurityGroupUpdate { get; set; } = new List<SecurityGroup>();

    public virtual ICollection<SystemModule> SystemModuleCreate { get; set; } = new List<SystemModule>();
    public virtual ICollection<SystemModule> SystemModuleUpdate { get; set; } = new List<SystemModule>();

    public virtual ICollection<CorrespondenceTag> CorrespondenceTagCreate { get; set; } = new List<CorrespondenceTag>();
    public virtual ICollection<CorrespondenceTag> CorrespondenceTagUpdate { get; set; } = new List<CorrespondenceTag>();

    public virtual ICollection<PublicRecordStatus> PublicRecordStatusCreate { get; set; } = new List<PublicRecordStatus>();
    public virtual ICollection<PublicRecordStatus> PublicRecordStatusUpdate { get; set; } = new List<PublicRecordStatus>();

    public virtual ICollection<Tag> TagCreate { get; set; } = new List<Tag>();
    public virtual ICollection<Tag> TagUpdate { get; set; } = new List<Tag>();

    public virtual ICollection<CorrespondenceAction> CorrespondenceActionsCreate { get; set; } = new List<CorrespondenceAction>();
    public virtual ICollection<CorrespondenceAction> CorrespondenceActionsUpdate { get; set; } = new List<CorrespondenceAction>();

    //CorrespondenceActions

    #endregion
}
