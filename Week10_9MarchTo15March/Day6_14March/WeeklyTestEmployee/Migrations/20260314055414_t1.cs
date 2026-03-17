using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeeklyTestEmployee.Migrations
{
    /// <inheritdoc />
    public partial class t1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tableDepartment",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tableDepartment", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "tableProject",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tableProject", x => x.ProjectId);
                });

            migrationBuilder.CreateTable(
                name: "tableEmployee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tableEmployee", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_tableEmployee_tableDepartment_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "tableDepartment",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tableEmployeeProject",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    AssignedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tableEmployeeProject", x => new { x.EmployeeId, x.ProjectId });
                    table.ForeignKey(
                        name: "FK_tableEmployeeProject_tableEmployee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "tableEmployee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tableEmployeeProject_tableProject_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "tableProject",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tableEmployee_DepartmentId",
                table: "tableEmployee",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_tableEmployeeProject_ProjectId",
                table: "tableEmployeeProject",
                column: "ProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tableEmployeeProject");

            migrationBuilder.DropTable(
                name: "tableEmployee");

            migrationBuilder.DropTable(
                name: "tableProject");

            migrationBuilder.DropTable(
                name: "tableDepartment");
        }
    }
}
