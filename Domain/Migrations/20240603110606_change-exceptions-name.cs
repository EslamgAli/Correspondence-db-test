using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class changeexceptionsname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApprovalAuthorityExceptions");

            migrationBuilder.CreateTable(
                name: "AuthorityExceptions",
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
                    table.PrimaryKey("PK_AuthorityExceptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorityExceptions_OrgUnits",
                        column: x => x.OrgUnitId,
                        principalTable: "OrgUnits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AuthorityExceptions_UserOrgUnit",
                        column: x => x.UserOrgUnitId,
                        principalTable: "UserOrgUnit",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AuthorityExceptions_UserOrgUnit_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "UserOrgUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuthorityExceptions_UserOrgUnit_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "UserOrgUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorityExceptions_CreatedBy",
                table: "AuthorityExceptions",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorityExceptions_OrgUnitId",
                table: "AuthorityExceptions",
                column: "OrgUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorityExceptions_UpdatedBy",
                table: "AuthorityExceptions",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorityExceptions_UserOrgUnitId",
                table: "AuthorityExceptions",
                column: "UserOrgUnitId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorityExceptions");

            migrationBuilder.CreateTable(
                name: "ApprovalAuthorityExceptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    OrgUnitId = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UserOrgUnitId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApprovalAuthorityExceptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApprovalAuthorityExceptions_OrgUnits",
                        column: x => x.OrgUnitId,
                        principalTable: "OrgUnits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApprovalAuthorityExceptions_UserOrgUnit",
                        column: x => x.UserOrgUnitId,
                        principalTable: "UserOrgUnit",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApprovalAuthorityExceptions_UserOrgUnit_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "UserOrgUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ApprovalAuthorityExceptions_UserOrgUnit_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "UserOrgUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
        }
    }
}
