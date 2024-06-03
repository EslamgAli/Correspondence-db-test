using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.SqlServer.Types;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class testuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApprovalAuthorityExceptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserOrgUnitId = table.Column<int>(type: "int", nullable: false),
                    OrgUnitId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApprovalAuthorityExceptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Archive",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CorrespondenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserOrgUnitId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Archive", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attachements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AttachementTypeId = table.Column<int>(type: "int", nullable: false),
                    CorrespondenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AttachementTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttachementTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CorrespondenceInbox",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CorrespondenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserOrgUnitId = table.Column<int>(type: "int", nullable: false),
                    FromUserOrgUnitId = table.Column<int>(type: "int", nullable: false),
                    SeenAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActionId = table.Column<int>(type: "int", nullable: true),
                    ProcedureId = table.Column<int>(type: "int", nullable: true),
                    CanReplay = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorrespondenceInbox", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Correspondences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsUrgent = table.Column<bool>(type: "bit", nullable: false),
                    IsSecret = table.Column<bool>(type: "bit", nullable: false),
                    RefNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    CorrespondenceTypeId = table.Column<int>(type: "int", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ApprovalAuthorityExceptionId = table.Column<int>(type: "int", nullable: true),
                    SendToAllEmp = table.Column<bool>(type: "bit", nullable: false),
                    SendToAllOrgUnit = table.Column<bool>(type: "bit", nullable: false),
                    WorkflowId = table.Column<int>(type: "int", nullable: true),
                    TemplateId = table.Column<int>(type: "int", nullable: false),
                    ExternalUnitId = table.Column<int>(type: "int", nullable: true),
                    ReceivingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DecisionTypeId = table.Column<int>(type: "int", nullable: true),
                    IsPublicDecision = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Correspondences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Correspondences_Correspondences",
                        column: x => x.ParentId,
                        principalTable: "Correspondences",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CorrespondencesOutbox",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserOrgUnitId = table.Column<int>(type: "int", nullable: false),
                    ActionId = table.Column<int>(type: "int", nullable: false),
                    ProcedureId = table.Column<int>(type: "int", nullable: false),
                    ToUserOrgUnitId = table.Column<int>(type: "int", nullable: false),
                    CorrespondenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorrespondencesOutbox", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CorrespondencesOutbox_Correspondences",
                        column: x => x.CorrespondenceId,
                        principalTable: "Correspondences",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CorrespondenceTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CorrespondenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorrespondenceTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CorrespondenceTags_Correspondences_CorrespondenceId",
                        column: x => x.CorrespondenceId,
                        principalTable: "Correspondences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CorrespondenceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsExternalUnits = table.Column<bool>(type: "bit", nullable: false),
                    OrgUnitResponsibilityId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorrespondenceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CorrespondenceWorkflowSteps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkfloStepId = table.Column<int>(type: "int", nullable: false),
                    CorrespondenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorrespondenceWorkflowSteps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CorrespondenceWorkflowSteps_Correspondences",
                        column: x => x.CorrespondenceId,
                        principalTable: "Correspondences",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DecisionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DecisionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Delegates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    From = table.Column<DateOnly>(type: "date", nullable: false),
                    To = table.Column<DateOnly>(type: "date", nullable: true),
                    DelegateFrom = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delegates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Draft",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CorrespondenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserOrgUnitId = table.Column<int>(type: "int", nullable: false),
                    CanEdit = table.Column<bool>(type: "bit", nullable: false),
                    CanDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Draft", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Draft_Correspondences",
                        column: x => x.CorrespondenceId,
                        principalTable: "Correspondences",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ExternalUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ExternalUnitTypeId = table.Column<int>(type: "int", nullable: false),
                    SubexternalUnitId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExternalUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExternalUnitTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExternalUnitTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroupDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    UserOrgUnitId = table.Column<int>(type: "int", nullable: true),
                    OrgUnitId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    UserOrgUnitId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrgUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Hid = table.Column<SqlHierarchyId>(type: "hierarchyid", nullable: true),
                    Lvl = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    OrgUnitTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrgUnit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrgUnitType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrgUnitType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrivilegeCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SortNum = table.Column<int>(type: "int", nullable: false),
                    SystemModuleId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivilegeCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Privileges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPrivilegeCategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Privileges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Privileges_PrivilegeCategories_UserPrivilegeCategoryId",
                        column: x => x.UserPrivilegeCategoryId,
                        principalTable: "PrivilegeCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrivilegeSecurityGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrivilegeId = table.Column<int>(type: "int", nullable: false),
                    SecurityGroupId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivilegeSecurityGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrivilegeSecurityGroups_Privileges_PrivilegeId",
                        column: x => x.PrivilegeId,
                        principalTable: "Privileges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Procedures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PublicRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CorrespondenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PublicRecordStatusId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PublicRecord_Correspondences",
                        column: x => x.CorrespondenceId,
                        principalTable: "Correspondences",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PublicRecordStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicRecordStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SecurityGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecurityGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SentToExternalUnit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CorrespodenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExternalUnitId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SentToExternalUnit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SentToExternalUnits_Correspondences",
                        column: x => x.CorrespodenceId,
                        principalTable: "Correspondences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SentToExternalUnits_ExternalUnits",
                        column: x => x.ExternalUnitId,
                        principalTable: "ExternalUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SentToOrgUnit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsCopy = table.Column<bool>(type: "bit", nullable: false),
                    OrgUnitid = table.Column<int>(type: "int", nullable: false),
                    CorrespondenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SentToOrgUnit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SentToOrgUnit_Correspondences",
                        column: x => x.CorrespondenceId,
                        principalTable: "Correspondences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SentToOrgUnit_OrgUnits",
                        column: x => x.OrgUnitid,
                        principalTable: "OrgUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SentToUserOrgUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsCopy = table.Column<bool>(type: "bit", nullable: false),
                    UserOrgUnitId = table.Column<int>(type: "int", nullable: false),
                    CorrespondenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SentToUserOrgUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SentToUserOrgUnits_Correspondences",
                        column: x => x.CorrespondenceId,
                        principalTable: "Correspondences",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubexternalUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubexternalUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemModules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemModules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TemplateCorresponednceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CorresponednceTypeId = table.Column<int>(type: "int", nullable: false),
                    TemplateId = table.Column<int>(type: "int", nullable: false),
                    DecisionTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateCorresponednceTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TemplateCorresponednceTypes_CorrespondenceTypes",
                        column: x => x.CorresponednceTypeId,
                        principalTable: "CorrespondenceTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TemplateCorresponednceTypes_DecisionTypes",
                        column: x => x.DecisionTypeId,
                        principalTable: "DecisionTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TemplateOrgUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrgUnitId = table.Column<int>(type: "int", nullable: false),
                    TemplateId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateOrgUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Templates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplatePath = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Templates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trackers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromUserOrgUnitId = table.Column<int>(type: "int", nullable: false),
                    ToUserOrgUnitId = table.Column<int>(type: "int", nullable: true),
                    ActionId = table.Column<int>(type: "int", nullable: true),
                    CorrespondenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrackerStatusId = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trackers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trackers_Actions",
                        column: x => x.ActionId,
                        principalTable: "Statuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Trackers_Correspondences",
                        column: x => x.CorrespondenceId,
                        principalTable: "Correspondences",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TrackerStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackerStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserOrgUnit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OrgUnitId = table.Column<int>(type: "int", nullable: false),
                    IsDefaultRole = table.Column<bool>(type: "bit", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsManager = table.Column<bool>(type: "bit", nullable: false),
                    DelegateId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOrgUnit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserOrgUnit_Delegate",
                        column: x => x.DelegateId,
                        principalTable: "Delegates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserOrgUnit_OrgUnits",
                        column: x => x.OrgUnitId,
                        principalTable: "OrgUnits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserOrgUnit_UserOrgUnit_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "UserOrgUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserOrgUnit_UserOrgUnit_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "UserOrgUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstNameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstNameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastNameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastNameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NicknameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitleAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitleEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SignatureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityGroupId = table.Column<int>(type: "int", nullable: false),
                    IsActiveDirectoryUser = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserOrgUnitId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_SecurityGroups_SecurityGroupId",
                        column: x => x.SecurityGroupId,
                        principalTable: "SecurityGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_UserOrgUnit_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "UserOrgUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_UserOrgUnit_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "UserOrgUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_UserOrgUnit_UserOrgUnitId",
                        column: x => x.UserOrgUnitId,
                        principalTable: "UserOrgUnit",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Views",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CorrespondenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserOrgUnitId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Views", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Views_Correspondences",
                        column: x => x.CorrespondenceId,
                        principalTable: "Correspondences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Views_UserOrgUnit",
                        column: x => x.UserOrgUnitId,
                        principalTable: "UserOrgUnit",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Views_UserOrgUnit_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "UserOrgUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Views_UserOrgUnit_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "UserOrgUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkflowRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmpId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkflowRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkflowRoles_UserOrgUnit_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "UserOrgUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkflowRoles_UserOrgUnit_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "UserOrgUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkflowType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkflowType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkflowType_UserOrgUnit_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "UserOrgUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkflowType_UserOrgUnit_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "UserOrgUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Workflows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TemplateId = table.Column<int>(type: "int", nullable: true),
                    Secret = table.Column<int>(type: "int", nullable: true),
                    WorkflowTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workflows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workflows_Templates",
                        column: x => x.TemplateId,
                        principalTable: "Templates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Workflows_UserOrgUnit_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "UserOrgUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Workflows_UserOrgUnit_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "UserOrgUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Workflows_WorkflowType_WorkflowTypeId",
                        column: x => x.WorkflowTypeId,
                        principalTable: "WorkflowType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkflowSteps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkflowId = table.Column<int>(type: "int", nullable: false),
                    WorkflowRoleId = table.Column<int>(type: "int", nullable: false),
                    OrderNum = table.Column<int>(type: "int", nullable: false),
                    CanWithdrawRequest = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkflowSteps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkflowSteps_UserOrgUnit_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "UserOrgUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkflowSteps_UserOrgUnit_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "UserOrgUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkflowSteps_WorkflowRoles",
                        column: x => x.WorkflowRoleId,
                        principalTable: "WorkflowRoles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WorkflowSteps_Workflows",
                        column: x => x.WorkflowId,
                        principalTable: "Workflows",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AttachementTypes",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "NameAr", "NameEn", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "ملف نصي", "Word file", null, null },
                    { 2, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "ملف PDF", "PDF file", null, null }
                });

            migrationBuilder.InsertData(
                table: "CorrespondenceTypes",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsExternalUnits", "NameAr", "NameEn", "OrgUnitResponsibilityId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, false, "وارد داخلي", "وارد داخلي", null, null, null },
                    { 2, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, false, "صادر داخلي", "صادر داخلي", null, null, null },
                    { 3, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, true, "وارد خارجي", "وارد خارجي", null, null, null },
                    { 4, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, true, "صادر خارجي", "صادر خارجي", null, null, null },
                    { 5, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, false, "قرارت", "قرارت", null, null, null },
                    { 6, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, false, "تعاميم", "تعاميم", null, null, null },
                    { 7, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, false, "سجل عام", "سجل عام", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "DecisionTypes",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "NameAr", "NameEn", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "جزاء", "جزاء", null, null },
                    { 2, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "خصم", "خصم", null, null },
                    { 3, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "ترقيه", "ترقيه", null, null }
                });

            migrationBuilder.InsertData(
                table: "ExternalUnitTypes",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "NameAr", "NameEn", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "حكومي", "حكومي", null, null },
                    { 2, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "خاص", "خاص", null, null }
                });

            migrationBuilder.InsertData(
                table: "OrgUnitType",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "NameAr", "NameEn", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "Root", "Root", null, null },
                    { 2, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "مؤسسة", "مؤسسة", null, null }
                });

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "NameAr", "NameEn", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "توجيه", "توجيه", null, null },
                    { 2, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "تصعيد", "تصعيد", null, null },
                    { 3, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "اسناد", "اسناد", null, null },
                    { 4, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "الغاء", "الغاء", null, null },
                    { 5, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "تصديق", "تصديق", null, null },
                    { 6, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "ارسال للموافقة", "ارسال للموافقة", null, null }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "NameAr", "NameEn", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "ارسال للموافقة", "ارسال للموافقة", null, null },
                    { 2, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "اعادة", "اعادة", null, null },
                    { 3, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "مرفوض", "مرفوض", null, null },
                    { 4, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "مؤجلة", "مؤجلة", null, null },
                    { 5, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "جديد", "جديد", null, null },
                    { 6, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "قيد التنفيذ", "قيد التنفيذ", null, null },
                    { 7, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "جارى التنفيذ", "جارى التنفيذ", null, null },
                    { 8, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "مسودة", "مسودة", null, null },
                    { 9, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "حذف", "حذف", null, null },
                    { 10, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "متأخره", "متأخره", null, null }
                });

            migrationBuilder.InsertData(
                table: "SubexternalUnits",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "NameAr", "NameEn", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "ألامين العام", "ألامين العام", null, null },
                    { 2, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "السجل العام", "السجل العام", null, null },
                    { 3, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "السكرتارية", "السكرتارية", null, null }
                });

            migrationBuilder.InsertData(
                table: "TrackerStatus",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "NameAr", "NameEn", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "انشاء", "انشاء", null, null },
                    { 2, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "ارسال للموافقة", "ارسال للموافقة", null, null },
                    { 3, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "تصديق", "تصديق", null, null },
                    { 4, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "تحرير", "تحرير", null, null },
                    { 5, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "تعديل", "تعديل", null, null },
                    { 6, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "المصادقة", "المصادقة", null, null },
                    { 7, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "جديد", "جديد", null, null },
                    { 8, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "تحويل لاجراء اللازم", "تحويل لاجراء اللازم", null, null }
                });

            migrationBuilder.InsertData(
                table: "WorkflowType",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "NameAr", "NameEn", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "هيكل تنظيمي", "Hierarchy orgunit", null, null },
                    { 2, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "مخصص", "ad-hock", null, null },
                    { 3, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "تسلسلي", "Sequential", null, null }
                });

            migrationBuilder.InsertData(
                table: "OrgUnits",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Hid", "IsActive", "Lvl", "Name", "OrgUnitTypeId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/0/"), false, 0, "الهيكل التنظيمى", 1, null, null },
                    { 2, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, Microsoft.SqlServer.Types.SqlHierarchyId.Parse("/0/"), false, 1, "الامانه العامه للاوقاف", 2, null, null }
                });

            migrationBuilder.InsertData(
                table: "Workflows",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "NameAr", "NameEn", "Secret", "TemplateId", "UpdatedAt", "UpdatedBy", "WorkflowTypeId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "هيكل تنظيمي", "Hierarchy orgunit", null, null, null, null, 1 },
                    { 2, new DateTime(2024, 5, 22, 11, 8, 24, 765, DateTimeKind.Utc).AddTicks(2032), null, "مخصص", "ad-hock", null, null, null, null, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApprovalAuthorityExceptions_CreatedBy",
                table: "ApprovalAuthorityExceptions",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ApprovalAuthorityExceptions_OrgUnitId",
                table: "ApprovalAuthorityExceptions",
                column: "OrgUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ApprovalAuthorityExceptions_UpdatedBy",
                table: "ApprovalAuthorityExceptions",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ApprovalAuthorityExceptions_UserOrgUnitId",
                table: "ApprovalAuthorityExceptions",
                column: "UserOrgUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Archive_CorrespondenceId",
                table: "Archive",
                column: "CorrespondenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Archive_CreatedBy",
                table: "Archive",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Archive_UpdatedBy",
                table: "Archive",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Archive_UserOrgUnitId",
                table: "Archive",
                column: "UserOrgUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachements_AttachementTypeId",
                table: "Attachements",
                column: "AttachementTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachements_CorrespondenceId",
                table: "Attachements",
                column: "CorrespondenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachements_CreatedBy",
                table: "Attachements",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Attachements_UpdatedBy",
                table: "Attachements",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AttachementTypes_CreatedBy",
                table: "AttachementTypes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AttachementTypes_UpdatedBy",
                table: "AttachementTypes",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CorrespondenceInbox_ActionId",
                table: "CorrespondenceInbox",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_CorrespondenceInbox_CorrespondenceId",
                table: "CorrespondenceInbox",
                column: "CorrespondenceId");

            migrationBuilder.CreateIndex(
                name: "IX_CorrespondenceInbox_CreatedBy",
                table: "CorrespondenceInbox",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CorrespondenceInbox_FromUserOrgUnitId",
                table: "CorrespondenceInbox",
                column: "FromUserOrgUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_CorrespondenceInbox_ProcedureId",
                table: "CorrespondenceInbox",
                column: "ProcedureId");

            migrationBuilder.CreateIndex(
                name: "IX_CorrespondenceInbox_UpdatedBy",
                table: "CorrespondenceInbox",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CorrespondenceInbox_UserOrgUnitId",
                table: "CorrespondenceInbox",
                column: "UserOrgUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Correspondences_CorrespondenceTypeId",
                table: "Correspondences",
                column: "CorrespondenceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Correspondences_CreatedBy",
                table: "Correspondences",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Correspondences_DecisionTypeId",
                table: "Correspondences",
                column: "DecisionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Correspondences_ExternalUnitId",
                table: "Correspondences",
                column: "ExternalUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Correspondences_ParentId",
                table: "Correspondences",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Correspondences_TemplateId",
                table: "Correspondences",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Correspondences_UpdatedBy",
                table: "Correspondences",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Correspondences_WorkflowId",
                table: "Correspondences",
                column: "WorkflowId");

            migrationBuilder.CreateIndex(
                name: "IX_CorrespondencesOutbox_ActionId",
                table: "CorrespondencesOutbox",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_CorrespondencesOutbox_CorrespondenceId",
                table: "CorrespondencesOutbox",
                column: "CorrespondenceId");

            migrationBuilder.CreateIndex(
                name: "IX_CorrespondencesOutbox_CreatedBy",
                table: "CorrespondencesOutbox",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CorrespondencesOutbox_ProcedureId",
                table: "CorrespondencesOutbox",
                column: "ProcedureId");

            migrationBuilder.CreateIndex(
                name: "IX_CorrespondencesOutbox_ToUserOrgUnitId",
                table: "CorrespondencesOutbox",
                column: "ToUserOrgUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_CorrespondencesOutbox_UpdatedBy",
                table: "CorrespondencesOutbox",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CorrespondencesOutbox_UserOrgUnitId",
                table: "CorrespondencesOutbox",
                column: "UserOrgUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_CorrespondenceTags_CorrespondenceId",
                table: "CorrespondenceTags",
                column: "CorrespondenceId");

            migrationBuilder.CreateIndex(
                name: "IX_CorrespondenceTags_CreatedBy",
                table: "CorrespondenceTags",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CorrespondenceTags_TagId",
                table: "CorrespondenceTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_CorrespondenceTags_UpdatedBy",
                table: "CorrespondenceTags",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CorrespondenceTypes_CreatedBy",
                table: "CorrespondenceTypes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CorrespondenceTypes_OrgUnitResponsibilityId",
                table: "CorrespondenceTypes",
                column: "OrgUnitResponsibilityId");

            migrationBuilder.CreateIndex(
                name: "IX_CorrespondenceTypes_UpdatedBy",
                table: "CorrespondenceTypes",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CorrespondenceWorkflowSteps_CorrespondenceId",
                table: "CorrespondenceWorkflowSteps",
                column: "CorrespondenceId");

            migrationBuilder.CreateIndex(
                name: "IX_CorrespondenceWorkflowSteps_CreatedBy",
                table: "CorrespondenceWorkflowSteps",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CorrespondenceWorkflowSteps_UpdatedBy",
                table: "CorrespondenceWorkflowSteps",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CorrespondenceWorkflowSteps_WorkfloStepId",
                table: "CorrespondenceWorkflowSteps",
                column: "WorkfloStepId");

            migrationBuilder.CreateIndex(
                name: "IX_DecisionTypes_CreatedBy",
                table: "DecisionTypes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DecisionTypes_UpdatedBy",
                table: "DecisionTypes",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Delegates_CreatedBy",
                table: "Delegates",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Delegates_DelegateFrom",
                table: "Delegates",
                column: "DelegateFrom");

            migrationBuilder.CreateIndex(
                name: "IX_Delegates_UpdatedBy",
                table: "Delegates",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Draft_CorrespondenceId",
                table: "Draft",
                column: "CorrespondenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Draft_CreatedBy",
                table: "Draft",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Draft_UpdatedBy",
                table: "Draft",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Draft_UserOrgUnitId",
                table: "Draft",
                column: "UserOrgUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalUnits_CreatedBy",
                table: "ExternalUnits",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalUnits_ExternalUnitTypeId",
                table: "ExternalUnits",
                column: "ExternalUnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalUnits_SubexternalUnitId",
                table: "ExternalUnits",
                column: "SubexternalUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalUnits_UpdatedBy",
                table: "ExternalUnits",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalUnitTypes_CreatedBy",
                table: "ExternalUnitTypes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalUnitTypes_UpdatedBy",
                table: "ExternalUnitTypes",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GroupDetails_CreatedBy",
                table: "GroupDetails",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GroupDetails_GroupId",
                table: "GroupDetails",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupDetails_OrgUnitId",
                table: "GroupDetails",
                column: "OrgUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupDetails_UpdatedBy",
                table: "GroupDetails",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GroupDetails_UserOrgUnitId",
                table: "GroupDetails",
                column: "UserOrgUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_CreatedBy",
                table: "Groups",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_UpdatedBy",
                table: "Groups",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_UserOrgUnitId",
                table: "Groups",
                column: "UserOrgUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_OrgUnits_CreatedBy",
                table: "OrgUnits",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrgUnits_OrgUnitTypeId",
                table: "OrgUnits",
                column: "OrgUnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrgUnits_UpdatedBy",
                table: "OrgUnits",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrgUnitType_CreatedBy",
                table: "OrgUnitType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrgUnitType_UpdatedBy",
                table: "OrgUnitType",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PrivilegeCategories_CreatedBy",
                table: "PrivilegeCategories",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PrivilegeCategories_SystemModuleId",
                table: "PrivilegeCategories",
                column: "SystemModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_PrivilegeCategories_UpdatedBy",
                table: "PrivilegeCategories",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Privileges_CreatedBy",
                table: "Privileges",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Privileges_UpdatedBy",
                table: "Privileges",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Privileges_UserPrivilegeCategoryId",
                table: "Privileges",
                column: "UserPrivilegeCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PrivilegeSecurityGroups_CreatedBy",
                table: "PrivilegeSecurityGroups",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PrivilegeSecurityGroups_PrivilegeId",
                table: "PrivilegeSecurityGroups",
                column: "PrivilegeId");

            migrationBuilder.CreateIndex(
                name: "IX_PrivilegeSecurityGroups_SecurityGroupId",
                table: "PrivilegeSecurityGroups",
                column: "SecurityGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_PrivilegeSecurityGroups_UpdatedBy",
                table: "PrivilegeSecurityGroups",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Procedures_CreatedBy",
                table: "Procedures",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Procedures_UpdatedBy",
                table: "Procedures",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PublicRecord_CorrespondenceId",
                table: "PublicRecord",
                column: "CorrespondenceId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicRecord_CreatedBy",
                table: "PublicRecord",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PublicRecord_PublicRecordStatusId",
                table: "PublicRecord",
                column: "PublicRecordStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicRecord_UpdatedBy",
                table: "PublicRecord",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PublicRecordStatuses_CreatedBy",
                table: "PublicRecordStatuses",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PublicRecordStatuses_UpdatedBy",
                table: "PublicRecordStatuses",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SecurityGroups_CreatedBy",
                table: "SecurityGroups",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SecurityGroups_UpdatedBy",
                table: "SecurityGroups",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SentToExternalUnit_CorrespodenceId",
                table: "SentToExternalUnit",
                column: "CorrespodenceId");

            migrationBuilder.CreateIndex(
                name: "IX_SentToExternalUnit_CreatedBy",
                table: "SentToExternalUnit",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SentToExternalUnit_ExternalUnitId",
                table: "SentToExternalUnit",
                column: "ExternalUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_SentToExternalUnit_UpdatedBy",
                table: "SentToExternalUnit",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SentToOrgUnit_CorrespondenceId",
                table: "SentToOrgUnit",
                column: "CorrespondenceId");

            migrationBuilder.CreateIndex(
                name: "IX_SentToOrgUnit_CreatedBy",
                table: "SentToOrgUnit",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SentToOrgUnit_OrgUnitid",
                table: "SentToOrgUnit",
                column: "OrgUnitid");

            migrationBuilder.CreateIndex(
                name: "IX_SentToOrgUnit_UpdatedBy",
                table: "SentToOrgUnit",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SentToUserOrgUnits_CorrespondenceId",
                table: "SentToUserOrgUnits",
                column: "CorrespondenceId");

            migrationBuilder.CreateIndex(
                name: "IX_SentToUserOrgUnits_CreatedBy",
                table: "SentToUserOrgUnits",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SentToUserOrgUnits_UpdatedBy",
                table: "SentToUserOrgUnits",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SentToUserOrgUnits_UserOrgUnitId",
                table: "SentToUserOrgUnits",
                column: "UserOrgUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Statuses_CreatedBy",
                table: "Statuses",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Statuses_UpdatedBy",
                table: "Statuses",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SubexternalUnits_CreatedBy",
                table: "SubexternalUnits",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SubexternalUnits_UpdatedBy",
                table: "SubexternalUnits",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SystemModules_CreatedBy",
                table: "SystemModules",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SystemModules_UpdatedBy",
                table: "SystemModules",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_CreatedBy",
                table: "Tags",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_UpdatedBy",
                table: "Tags",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateCorresponednceTypes_CorresponednceTypeId",
                table: "TemplateCorresponednceTypes",
                column: "CorresponednceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateCorresponednceTypes_CreatedBy",
                table: "TemplateCorresponednceTypes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateCorresponednceTypes_DecisionTypeId",
                table: "TemplateCorresponednceTypes",
                column: "DecisionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateCorresponednceTypes_TemplateId",
                table: "TemplateCorresponednceTypes",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateCorresponednceTypes_UpdatedBy",
                table: "TemplateCorresponednceTypes",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateOrgUnits_CreatedBy",
                table: "TemplateOrgUnits",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateOrgUnits_OrgUnitId",
                table: "TemplateOrgUnits",
                column: "OrgUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateOrgUnits_TemplateId",
                table: "TemplateOrgUnits",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateOrgUnits_UpdatedBy",
                table: "TemplateOrgUnits",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Templates_CreatedBy",
                table: "Templates",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Templates_UpdatedBy",
                table: "Templates",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Trackers_ActionId",
                table: "Trackers",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_Trackers_CorrespondenceId",
                table: "Trackers",
                column: "CorrespondenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Trackers_CreatedBy",
                table: "Trackers",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Trackers_FromUserOrgUnitId",
                table: "Trackers",
                column: "FromUserOrgUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Trackers_ToUserOrgUnitId",
                table: "Trackers",
                column: "ToUserOrgUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Trackers_TrackerStatusId",
                table: "Trackers",
                column: "TrackerStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Trackers_UpdatedBy",
                table: "Trackers",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TrackerStatus_CreatedBy",
                table: "TrackerStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TrackerStatus_UpdatedBy",
                table: "TrackerStatus",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserOrgUnit_CreatedBy",
                table: "UserOrgUnit",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserOrgUnit_DelegateId",
                table: "UserOrgUnit",
                column: "DelegateId",
                unique: true,
                filter: "[DelegateId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserOrgUnit_OrgUnitId",
                table: "UserOrgUnit",
                column: "OrgUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOrgUnit_UpdatedBy",
                table: "UserOrgUnit",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserOrgUnit_UserId",
                table: "UserOrgUnit",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CreatedBy",
                table: "Users",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SecurityGroupId",
                table: "Users",
                column: "SecurityGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UpdatedBy",
                table: "Users",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserOrgUnitId",
                table: "Users",
                column: "UserOrgUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Views_CorrespondenceId",
                table: "Views",
                column: "CorrespondenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Views_CreatedBy",
                table: "Views",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Views_UpdatedBy",
                table: "Views",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Views_UserOrgUnitId",
                table: "Views",
                column: "UserOrgUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowRoles_CreatedBy",
                table: "WorkflowRoles",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowRoles_UpdatedBy",
                table: "WorkflowRoles",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Workflows_CreatedBy",
                table: "Workflows",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Workflows_TemplateId",
                table: "Workflows",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Workflows_UpdatedBy",
                table: "Workflows",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Workflows_WorkflowTypeId",
                table: "Workflows",
                column: "WorkflowTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowSteps_CreatedBy",
                table: "WorkflowSteps",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowSteps_UpdatedBy",
                table: "WorkflowSteps",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowSteps_WorkflowId",
                table: "WorkflowSteps",
                column: "WorkflowId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowSteps_WorkflowRoleId",
                table: "WorkflowSteps",
                column: "WorkflowRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowType_CreatedBy",
                table: "WorkflowType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowType_UpdatedBy",
                table: "WorkflowType",
                column: "UpdatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_ApprovalAuthorityExceptions_OrgUnits",
                table: "ApprovalAuthorityExceptions",
                column: "OrgUnitId",
                principalTable: "OrgUnits",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApprovalAuthorityExceptions_UserOrgUnit",
                table: "ApprovalAuthorityExceptions",
                column: "UserOrgUnitId",
                principalTable: "UserOrgUnit",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApprovalAuthorityExceptions_UserOrgUnit_CreatedBy",
                table: "ApprovalAuthorityExceptions",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApprovalAuthorityExceptions_UserOrgUnit_UpdatedBy",
                table: "ApprovalAuthorityExceptions",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Archive_Correspondences",
                table: "Archive",
                column: "CorrespondenceId",
                principalTable: "Correspondences",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Archive_UserOrgUnit",
                table: "Archive",
                column: "UserOrgUnitId",
                principalTable: "UserOrgUnit",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Archive_UserOrgUnit_CreatedBy",
                table: "Archive",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Archive_UserOrgUnit_UpdatedBy",
                table: "Archive",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Attachements_AttachementTypes",
                table: "Attachements",
                column: "AttachementTypeId",
                principalTable: "AttachementTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachements_Correspondences",
                table: "Attachements",
                column: "CorrespondenceId",
                principalTable: "Correspondences",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachements_UserOrgUnit_CreatedBy",
                table: "Attachements",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Attachements_UserOrgUnit_UpdatedBy",
                table: "Attachements",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AttachementTypes_UserOrgUnit_CreatedBy",
                table: "AttachementTypes",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AttachementTypes_UserOrgUnit_UpdatedBy",
                table: "AttachementTypes",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CorrespondenceInbox_Actions",
                table: "CorrespondenceInbox",
                column: "ActionId",
                principalTable: "Statuses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CorrespondenceInbox_Correspondences",
                table: "CorrespondenceInbox",
                column: "CorrespondenceId",
                principalTable: "Correspondences",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CorrespondenceInbox_Procedures",
                table: "CorrespondenceInbox",
                column: "ProcedureId",
                principalTable: "Procedures",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CorrespondenceInbox_UserOrgUnit",
                table: "CorrespondenceInbox",
                column: "UserOrgUnitId",
                principalTable: "UserOrgUnit",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CorrespondenceInbox_UserOrgUnit1",
                table: "CorrespondenceInbox",
                column: "FromUserOrgUnitId",
                principalTable: "UserOrgUnit",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CorrespondenceInbox_UserOrgUnit_CreatedBy",
                table: "CorrespondenceInbox",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CorrespondenceInbox_UserOrgUnit_UpdatedBy",
                table: "CorrespondenceInbox",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Correspondences_CorrespondenceTypes_CorrespondenceTypeId",
                table: "Correspondences",
                column: "CorrespondenceTypeId",
                principalTable: "CorrespondenceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Correspondences_DecisionTypes_DecisionTypeId",
                table: "Correspondences",
                column: "DecisionTypeId",
                principalTable: "DecisionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Correspondences_ExternalUnits_ExternalUnitId",
                table: "Correspondences",
                column: "ExternalUnitId",
                principalTable: "ExternalUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Correspondences_Templates_TemplateId",
                table: "Correspondences",
                column: "TemplateId",
                principalTable: "Templates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Correspondences_UserOrgUnit_CreatedBy",
                table: "Correspondences",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Correspondences_UserOrgUnit_UpdatedBy",
                table: "Correspondences",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Correspondences_Workflows_WorkflowId",
                table: "Correspondences",
                column: "WorkflowId",
                principalTable: "Workflows",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CorrespondencesOutbox_Actions",
                table: "CorrespondencesOutbox",
                column: "ActionId",
                principalTable: "Statuses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CorrespondencesOutbox_Procedures",
                table: "CorrespondencesOutbox",
                column: "ProcedureId",
                principalTable: "Procedures",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CorrespondencesOutbox_UserOrgUnit",
                table: "CorrespondencesOutbox",
                column: "UserOrgUnitId",
                principalTable: "UserOrgUnit",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CorrespondencesOutbox_UserOrgUnit1",
                table: "CorrespondencesOutbox",
                column: "ToUserOrgUnitId",
                principalTable: "UserOrgUnit",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CorrespondencesOutbox_UserOrgUnit_CreatedBy",
                table: "CorrespondencesOutbox",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CorrespondencesOutbox_UserOrgUnit_UpdatedBy",
                table: "CorrespondencesOutbox",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CorrespondenceTags_Tags_TagId",
                table: "CorrespondenceTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CorrespondenceTags_UserOrgUnit_CreatedBy",
                table: "CorrespondenceTags",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CorrespondenceTags_UserOrgUnit_UpdatedBy",
                table: "CorrespondenceTags",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CorrespondenceTypes_OrgUnits_OrgUnitResponsibilityId",
                table: "CorrespondenceTypes",
                column: "OrgUnitResponsibilityId",
                principalTable: "OrgUnits",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CorrespondenceTypes_UserOrgUnit_CreatedBy",
                table: "CorrespondenceTypes",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CorrespondenceTypes_UserOrgUnit_UpdatedBy",
                table: "CorrespondenceTypes",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CorrespondenceWorkflowSteps_UserOrgUnit_CreatedBy",
                table: "CorrespondenceWorkflowSteps",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CorrespondenceWorkflowSteps_UserOrgUnit_UpdatedBy",
                table: "CorrespondenceWorkflowSteps",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CorrespondenceWorkflowSteps_WorkflowSteps",
                table: "CorrespondenceWorkflowSteps",
                column: "WorkfloStepId",
                principalTable: "WorkflowSteps",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DecisionTypes_UserOrgUnit_CreatedBy",
                table: "DecisionTypes",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DecisionTypes_UserOrgUnit_UpdatedBy",
                table: "DecisionTypes",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Delegates_UserOrgUnit",
                table: "Delegates",
                column: "DelegateFrom",
                principalTable: "UserOrgUnit",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Delegates_UserOrgUnit_CreatedBy",
                table: "Delegates",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Delegates_UserOrgUnit_UpdatedBy",
                table: "Delegates",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Draft_UserOrgUnit",
                table: "Draft",
                column: "UserOrgUnitId",
                principalTable: "UserOrgUnit",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Draft_UserOrgUnit_CreatedBy",
                table: "Draft",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Draft_UserOrgUnit_UpdatedBy",
                table: "Draft",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalUnits_ExternalUnitTypes",
                table: "ExternalUnits",
                column: "ExternalUnitTypeId",
                principalTable: "ExternalUnitTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalUnits_SubexternalUnits_SubexternalUnitId",
                table: "ExternalUnits",
                column: "SubexternalUnitId",
                principalTable: "SubexternalUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalUnits_UserOrgUnit_CreatedBy",
                table: "ExternalUnits",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalUnits_UserOrgUnit_UpdatedBy",
                table: "ExternalUnits",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalUnitTypes_UserOrgUnit_CreatedBy",
                table: "ExternalUnitTypes",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalUnitTypes_UserOrgUnit_UpdatedBy",
                table: "ExternalUnitTypes",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupDetails_Groups",
                table: "GroupDetails",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupDetails_OrgUnits",
                table: "GroupDetails",
                column: "OrgUnitId",
                principalTable: "OrgUnits",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupDetails_UserOrgUnit",
                table: "GroupDetails",
                column: "UserOrgUnitId",
                principalTable: "UserOrgUnit",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupDetails_UserOrgUnit_CreatedBy",
                table: "GroupDetails",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupDetails_UserOrgUnit_UpdatedBy",
                table: "GroupDetails",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_UserOrgUnit",
                table: "Groups",
                column: "UserOrgUnitId",
                principalTable: "UserOrgUnit",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_UserOrgUnit_CreatedBy",
                table: "Groups",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_UserOrgUnit_UpdatedBy",
                table: "Groups",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrgUnits_OrgUnitType",
                table: "OrgUnits",
                column: "OrgUnitTypeId",
                principalTable: "OrgUnitType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrgUnits_UserOrgUnit_CreatedBy",
                table: "OrgUnits",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrgUnits_UserOrgUnit_UpdatedBy",
                table: "OrgUnits",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrgUnitType_UserOrgUnit_CreatedBy",
                table: "OrgUnitType",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrgUnitType_UserOrgUnit_UpdatedBy",
                table: "OrgUnitType",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrivilegeCategories_SystemModules_SystemModuleId",
                table: "PrivilegeCategories",
                column: "SystemModuleId",
                principalTable: "SystemModules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrivilegeCategories_UserOrgUnit_CreatedBy",
                table: "PrivilegeCategories",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrivilegeCategories_UserOrgUnit_UpdatedBy",
                table: "PrivilegeCategories",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Privileges_UserOrgUnit_CreatedBy",
                table: "Privileges",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Privileges_UserOrgUnit_UpdatedBy",
                table: "Privileges",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrivilegeSecurityGroups_SecurityGroups_SecurityGroupId",
                table: "PrivilegeSecurityGroups",
                column: "SecurityGroupId",
                principalTable: "SecurityGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrivilegeSecurityGroups_UserOrgUnit_CreatedBy",
                table: "PrivilegeSecurityGroups",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrivilegeSecurityGroups_UserOrgUnit_UpdatedBy",
                table: "PrivilegeSecurityGroups",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Procedures_UserOrgUnit_CreatedBy",
                table: "Procedures",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Procedures_UserOrgUnit_UpdatedBy",
                table: "Procedures",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PublicRecord_PublicRecordStatuses_PublicRecordStatusId",
                table: "PublicRecord",
                column: "PublicRecordStatusId",
                principalTable: "PublicRecordStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PublicRecord_UserOrgUnit_CreatedBy",
                table: "PublicRecord",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PublicRecord_UserOrgUnit_UpdatedBy",
                table: "PublicRecord",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PublicRecordStatuses_UserOrgUnit_CreatedBy",
                table: "PublicRecordStatuses",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PublicRecordStatuses_UserOrgUnit_UpdatedBy",
                table: "PublicRecordStatuses",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SecurityGroups_UserOrgUnit_CreatedBy",
                table: "SecurityGroups",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SecurityGroups_UserOrgUnit_UpdatedBy",
                table: "SecurityGroups",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SentToExternalUnit_UserOrgUnit_CreatedBy",
                table: "SentToExternalUnit",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SentToExternalUnit_UserOrgUnit_UpdatedBy",
                table: "SentToExternalUnit",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SentToOrgUnit_UserOrgUnit_CreatedBy",
                table: "SentToOrgUnit",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SentToOrgUnit_UserOrgUnit_UpdatedBy",
                table: "SentToOrgUnit",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SentToUserOrgUnits_UserOrgUnit",
                table: "SentToUserOrgUnits",
                column: "UserOrgUnitId",
                principalTable: "UserOrgUnit",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SentToUserOrgUnits_UserOrgUnit_CreatedBy",
                table: "SentToUserOrgUnits",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SentToUserOrgUnits_UserOrgUnit_UpdatedBy",
                table: "SentToUserOrgUnits",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Statuses_UserOrgUnit_CreatedBy",
                table: "Statuses",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Statuses_UserOrgUnit_UpdatedBy",
                table: "Statuses",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubexternalUnits_UserOrgUnit_CreatedBy",
                table: "SubexternalUnits",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubexternalUnits_UserOrgUnit_UpdatedBy",
                table: "SubexternalUnits",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SystemModules_UserOrgUnit_CreatedBy",
                table: "SystemModules",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SystemModules_UserOrgUnit_UpdatedBy",
                table: "SystemModules",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_UserOrgUnit_CreatedBy",
                table: "Tags",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_UserOrgUnit_UpdatedBy",
                table: "Tags",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TemplateCorresponednceTypes_Templates",
                table: "TemplateCorresponednceTypes",
                column: "TemplateId",
                principalTable: "Templates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TemplateCorresponednceTypes_UserOrgUnit_CreatedBy",
                table: "TemplateCorresponednceTypes",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TemplateCorresponednceTypes_UserOrgUnit_UpdatedBy",
                table: "TemplateCorresponednceTypes",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TemplateOrgUnits_Templates",
                table: "TemplateOrgUnits",
                column: "TemplateId",
                principalTable: "Templates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TemplateOrgUnits_UserOrgUnit",
                table: "TemplateOrgUnits",
                column: "OrgUnitId",
                principalTable: "UserOrgUnit",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TemplateOrgUnits_UserOrgUnit_CreatedBy",
                table: "TemplateOrgUnits",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TemplateOrgUnits_UserOrgUnit_UpdatedBy",
                table: "TemplateOrgUnits",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Templates_UserOrgUnit_CreatedBy",
                table: "Templates",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Templates_UserOrgUnit_UpdatedBy",
                table: "Templates",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trackers_TrackerStatus",
                table: "Trackers",
                column: "TrackerStatusId",
                principalTable: "TrackerStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trackers_UserOrgUnit",
                table: "Trackers",
                column: "FromUserOrgUnitId",
                principalTable: "UserOrgUnit",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trackers_UserOrgUnit1",
                table: "Trackers",
                column: "ToUserOrgUnitId",
                principalTable: "UserOrgUnit",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trackers_UserOrgUnit_CreatedBy",
                table: "Trackers",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trackers_UserOrgUnit_UpdatedBy",
                table: "Trackers",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrackerStatus_UserOrgUnit_CreatedBy",
                table: "TrackerStatus",
                column: "CreatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrackerStatus_UserOrgUnit_UpdatedBy",
                table: "TrackerStatus",
                column: "UpdatedBy",
                principalTable: "UserOrgUnit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserOrgUnit_Users",
                table: "UserOrgUnit",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserOrgUnit_OrgUnits",
                table: "UserOrgUnit");

            migrationBuilder.DropForeignKey(
                name: "FK_Delegates_UserOrgUnit",
                table: "Delegates");

            migrationBuilder.DropForeignKey(
                name: "FK_Delegates_UserOrgUnit_CreatedBy",
                table: "Delegates");

            migrationBuilder.DropForeignKey(
                name: "FK_Delegates_UserOrgUnit_UpdatedBy",
                table: "Delegates");

            migrationBuilder.DropForeignKey(
                name: "FK_SecurityGroups_UserOrgUnit_CreatedBy",
                table: "SecurityGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_SecurityGroups_UserOrgUnit_UpdatedBy",
                table: "SecurityGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserOrgUnit_CreatedBy",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserOrgUnit_UpdatedBy",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserOrgUnit_UserOrgUnitId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "ApprovalAuthorityExceptions");

            migrationBuilder.DropTable(
                name: "Archive");

            migrationBuilder.DropTable(
                name: "Attachements");

            migrationBuilder.DropTable(
                name: "CorrespondenceInbox");

            migrationBuilder.DropTable(
                name: "CorrespondencesOutbox");

            migrationBuilder.DropTable(
                name: "CorrespondenceTags");

            migrationBuilder.DropTable(
                name: "CorrespondenceWorkflowSteps");

            migrationBuilder.DropTable(
                name: "Draft");

            migrationBuilder.DropTable(
                name: "GroupDetails");

            migrationBuilder.DropTable(
                name: "PrivilegeSecurityGroups");

            migrationBuilder.DropTable(
                name: "PublicRecord");

            migrationBuilder.DropTable(
                name: "SentToExternalUnit");

            migrationBuilder.DropTable(
                name: "SentToOrgUnit");

            migrationBuilder.DropTable(
                name: "SentToUserOrgUnits");

            migrationBuilder.DropTable(
                name: "TemplateCorresponednceTypes");

            migrationBuilder.DropTable(
                name: "TemplateOrgUnits");

            migrationBuilder.DropTable(
                name: "Trackers");

            migrationBuilder.DropTable(
                name: "Views");

            migrationBuilder.DropTable(
                name: "AttachementTypes");

            migrationBuilder.DropTable(
                name: "Procedures");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "WorkflowSteps");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Privileges");

            migrationBuilder.DropTable(
                name: "PublicRecordStatuses");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "TrackerStatus");

            migrationBuilder.DropTable(
                name: "Correspondences");

            migrationBuilder.DropTable(
                name: "WorkflowRoles");

            migrationBuilder.DropTable(
                name: "PrivilegeCategories");

            migrationBuilder.DropTable(
                name: "CorrespondenceTypes");

            migrationBuilder.DropTable(
                name: "DecisionTypes");

            migrationBuilder.DropTable(
                name: "ExternalUnits");

            migrationBuilder.DropTable(
                name: "Workflows");

            migrationBuilder.DropTable(
                name: "SystemModules");

            migrationBuilder.DropTable(
                name: "ExternalUnitTypes");

            migrationBuilder.DropTable(
                name: "SubexternalUnits");

            migrationBuilder.DropTable(
                name: "Templates");

            migrationBuilder.DropTable(
                name: "WorkflowType");

            migrationBuilder.DropTable(
                name: "OrgUnits");

            migrationBuilder.DropTable(
                name: "OrgUnitType");

            migrationBuilder.DropTable(
                name: "UserOrgUnit");

            migrationBuilder.DropTable(
                name: "Delegates");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "SecurityGroups");
        }
    }
}
