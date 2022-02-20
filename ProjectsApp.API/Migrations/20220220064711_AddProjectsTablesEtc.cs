using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectsApp.API.Migrations
{
    public partial class AddProjectsTablesEtc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(nullable: true),
                    ProjectManager = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    ProjectOwner = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true),
                    ProjectArea = table.Column<string>(nullable: true),
                    PODate = table.Column<DateTime>(nullable: false),
                    PONo = table.Column<string>(nullable: true),
                    ProjectAmount = table.Column<decimal>(nullable: false),
                    ProjectStartDate = table.Column<DateTime>(nullable: false),
                    ProjectEndDate = table.Column<DateTime>(nullable: false),
                    ProjectPeriod = table.Column<int>(nullable: false),
                    RemainingPeriod = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Project_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Executions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Item = table.Column<string>(nullable: true),
                    Qty = table.Column<int>(nullable: false),
                    AdditionalQty = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    TotalPrice = table.Column<decimal>(nullable: false),
                    CompleteQty = table.Column<decimal>(nullable: false),
                    CompleteCost = table.Column<decimal>(nullable: false),
                    RemainingQty = table.Column<decimal>(nullable: false),
                    RemainingCost = table.Column<decimal>(nullable: false),
                    ProjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Executions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Executions_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Materials = table.Column<string>(nullable: true),
                    Accomodation = table.Column<decimal>(nullable: false),
                    Sites = table.Column<decimal>(nullable: false),
                    Uniform = table.Column<decimal>(nullable: false),
                    LaborTools = table.Column<decimal>(nullable: false),
                    OT = table.Column<decimal>(nullable: false),
                    Tickets = table.Column<decimal>(nullable: false),
                    Vehicles = table.Column<decimal>(nullable: false),
                    Equipments = table.Column<decimal>(nullable: false),
                    Fuel = table.Column<decimal>(nullable: false),
                    Warehouse = table.Column<decimal>(nullable: false),
                    Asphalt = table.Column<decimal>(nullable: false),
                    SubContract = table.Column<decimal>(nullable: false),
                    Documents = table.Column<decimal>(nullable: false),
                    Penalties = table.Column<decimal>(nullable: false),
                    Consultancy = table.Column<decimal>(nullable: false),
                    ProjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expenses_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlannedDate = table.Column<DateTime>(nullable: false),
                    IssuanceDate = table.Column<DateTime>(nullable: false),
                    PlannedRemDays = table.Column<int>(nullable: false),
                    ActualDays = table.Column<int>(nullable: false),
                    DelayedDays = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    InvoiceNo = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    ProjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Risks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Issue = table.Column<string>(nullable: true),
                    RiskDate = table.Column<DateTime>(nullable: false),
                    Impact = table.Column<string>(nullable: true),
                    CorrectiveAction = table.Column<string>(nullable: true),
                    Owner = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    ProjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Risks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Risks_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Executions_ProjectId",
                table: "Executions",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ProjectId",
                table: "Expenses",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ProjectId",
                table: "Invoices",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_UserId",
                table: "Project",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Risks_ProjectId",
                table: "Risks",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Executions");

            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Risks");

            migrationBuilder.DropTable(
                name: "Project");
        }
    }
}
