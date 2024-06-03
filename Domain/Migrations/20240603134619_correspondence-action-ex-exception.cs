using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class correspondenceactionexexception : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CorrespondenceSources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorrespondenceSources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CorrespondenceSources_UserOrgUnit_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "UserOrgUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CorrespondenceSources_UserOrgUnit_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "UserOrgUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExternalExceptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrgUnitId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExternalExceptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExternalExceptions_OrgUnits_OrgUnitId",
                        column: x => x.OrgUnitId,
                        principalTable: "OrgUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExternalExceptions_UserOrgUnit_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "UserOrgUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExternalExceptions_UserOrgUnit_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "UserOrgUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaskActions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskActions_UserOrgUnit_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "UserOrgUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TaskActions_UserOrgUnit_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "UserOrgUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CorrespondenceSources_CreatedBy",
                table: "CorrespondenceSources",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CorrespondenceSources_UpdatedBy",
                table: "CorrespondenceSources",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalExceptions_CreatedBy",
                table: "ExternalExceptions",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalExceptions_OrgUnitId",
                table: "ExternalExceptions",
                column: "OrgUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalExceptions_UpdatedBy",
                table: "ExternalExceptions",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TaskActions_CreatedBy",
                table: "TaskActions",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TaskActions_UpdatedBy",
                table: "TaskActions",
                column: "UpdatedBy");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CorrespondenceSources");

            migrationBuilder.DropTable(
                name: "ExternalExceptions");

            migrationBuilder.DropTable(
                name: "TaskActions");
        }
    }
}
