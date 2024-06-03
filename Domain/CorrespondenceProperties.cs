using Domain.Properties;
using Microsoft.EntityFrameworkCore;

namespace Domain;

public partial class CorrespondenceContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new StatusProperties());
        modelBuilder.ApplyConfiguration(new AuthorityExceptionProperties());
        modelBuilder.ApplyConfiguration(new ArchiveProperties());
        modelBuilder.ApplyConfiguration(new AttachementProperties());
        modelBuilder.ApplyConfiguration(new AttachementTypeProperties());
        modelBuilder.ApplyConfiguration(new CorrespondenceProperties());
        modelBuilder.ApplyConfiguration(new CorrespondenceInboxProperties());
        modelBuilder.ApplyConfiguration(new CorrespondenceTypeProperties());
        modelBuilder.ApplyConfiguration(new CorrespondenceTagProperties());
        modelBuilder.ApplyConfiguration(new CorrespondenceWorkflowStepProperties());
        modelBuilder.ApplyConfiguration(new CorrespondencesOutboxProperties());
        modelBuilder.ApplyConfiguration(new CorrespondenceSubTypeProperties());
        modelBuilder.ApplyConfiguration(new DelegateProperties());
        modelBuilder.ApplyConfiguration(new DraftProperties());
        modelBuilder.ApplyConfiguration(new ExternalUnitProperties());
        modelBuilder.ApplyConfiguration(new ExternalUnitTypeProperties());
        modelBuilder.ApplyConfiguration(new OrgUnitProperties());
        modelBuilder.ApplyConfiguration(new GroupProperties());
        modelBuilder.ApplyConfiguration(new GroupDetailProperties());
        modelBuilder.ApplyConfiguration(new OrgUnitTypeProperties());
        modelBuilder.ApplyConfiguration(new ProcedureProperties());
        modelBuilder.ApplyConfiguration(new PrivilegeSecurityGroupProperties());
        modelBuilder.ApplyConfiguration(new PrivilegeProperties());
        modelBuilder.ApplyConfiguration(new PrivilegeCategoryProperties());
        modelBuilder.ApplyConfiguration(new PublicRecordProperties());
        modelBuilder.ApplyConfiguration(new PublicRecordStatusProperties());
        modelBuilder.ApplyConfiguration(new SecurityGroupProperties());
        modelBuilder.ApplyConfiguration(new SentToOrgUnitProperties());
        modelBuilder.ApplyConfiguration(new SentToExternalUnitProperties());
        modelBuilder.ApplyConfiguration(new SentToUserOrgUnitProperties());
        modelBuilder.ApplyConfiguration(new SubexternalUnitProperties());
        modelBuilder.ApplyConfiguration(new SystemModuleProperties());
        modelBuilder.ApplyConfiguration(new TemplateProperties());
        modelBuilder.ApplyConfiguration(new TemplateCorresponednceSubTypeProperties());
        modelBuilder.ApplyConfiguration(new TemplateOrgUnitProperties());
        modelBuilder.ApplyConfiguration(new TrackerProperties());
        modelBuilder.ApplyConfiguration(new TrackerStatusProperties());
        modelBuilder.ApplyConfiguration(new TagProperties());
        modelBuilder.ApplyConfiguration(new UserProperties());
        modelBuilder.ApplyConfiguration(new UserOrgUnitProperties());
        modelBuilder.ApplyConfiguration(new ViewProperties());
        modelBuilder.ApplyConfiguration(new WorkflowProperties());
        modelBuilder.ApplyConfiguration(new WorkflowTypeProperties());
        modelBuilder.ApplyConfiguration(new WorkflowRoleProperties());
        modelBuilder.ApplyConfiguration(new WorkflowStepProperties());
        modelBuilder.ApplyConfiguration(new CorrespondenceActionsProperties());

        OnModelCreatingPartial(modelBuilder);
    }
}
