using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Delegate = Domain.Models.Delegate;

namespace Domain;

public partial class CorrespondenceContext
{
    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<AuthorityException> AuthorityExceptions { get; set; }

    public virtual DbSet<Archive> Archives { get; set; }

    public virtual DbSet<Attachement> Attachements { get; set; }

    public virtual DbSet<AttachementType> AttachementTypes { get; set; }

    public virtual DbSet<Correspondence> Correspondences { get; set; }

    public virtual DbSet<CorrespondenceInbox> CorrespondenceInboxes { get; set; }

    public virtual DbSet<CorrespondenceTag> CorrespondenceTags { get; set; }

    public virtual DbSet<CorrespondenceType> CorrespondenceTypes { get; set; }

    public virtual DbSet<CorrespondenceWorkflowStep> CorrespondenceWorkflowSteps { get; set; }

    public virtual DbSet<CorrespondencesOutbox> CorrespondencesOutboxes { get; set; }

    public virtual DbSet<CorrespondenceSubType> CorrespondenceSubTypes { get; set; }

    public virtual DbSet<Delegate> Delegates { get; set; }

    public virtual DbSet<Draft> Drafts { get; set; }

    public virtual DbSet<ExternalUnit> ExternalUnits { get; set; }
    public virtual DbSet<SubexternalUnit> SubexternalUnits { get; set; }

    public virtual DbSet<ExternalUnitType> ExternalUnitTypes { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<GroupDetail> GroupDetails { get; set; }

    public virtual DbSet<OrgUnit> OrgUnits { get; set; }

    public virtual DbSet<OrgUnitType> OrgUnitTypes { get; set; }

    public virtual DbSet<Procedure> Procedures { get; set; }

    public virtual DbSet<PublicRecord> PublicRecords { get; set; }

    public virtual DbSet<PublicRecordStatus> PublicRecordStatuses { get; set; }

    public virtual DbSet<SystemModule> SystemModules { get; set; }
    public virtual DbSet<PrivilegeCategory> PrivilegeCategories { get; set; }
    public virtual DbSet<Privilege> Privileges { get; set; }
    public virtual DbSet<PrivilegeSecurityGroup> PrivilegeSecurityGroups { get; set; }

    public virtual DbSet<SecurityGroup> SecurityGroups { get; set; }

    public virtual DbSet<SentToOrgUnit> SentToOrgUnits { get; set; }

    public virtual DbSet<SentToUserOrgUnit> SentToUserOrgUnits { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    public virtual DbSet<Template> Templates { get; set; }

    public virtual DbSet<TemplateCorresponednceSubType> TemplateCorresponednceSubTypes { get; set; }

    public virtual DbSet<TemplateOrgUnit> TemplateOrgUnits { get; set; }

    public virtual DbSet<Tracker> Trackers { get; set; }

    public virtual DbSet<TrackerStatus> TrackerStatuses { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserOrgUnit> UserOrgUnits { get; set; }

    public virtual DbSet<View> Views { get; set; }

    public virtual DbSet<Workflow> Workflows { get; set; }
    public virtual DbSet<WorkflowType> WorkflowType { get; set; }

    public virtual DbSet<WorkflowRole> WorkflowRoles { get; set; }

    public virtual DbSet<WorkflowStep> WorkflowSteps { get; set; }
    public virtual DbSet<CorrespondenceAction> CorrespondenceActions { get; set; }
}
