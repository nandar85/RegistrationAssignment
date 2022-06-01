using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegistrationAssignmentWeb.Migrations
{
    public partial class createdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegisterUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InterestArea = table.Column<int>(type: "int", nullable: false),
                    AdditionalRequest = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegisterUserEventDays",
                columns: table => new
                {
                    RegisterUserEventDaysId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegisterUserId = table.Column<int>(type: "int", nullable: false),
                    Days = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterUserEventDays", x => x.RegisterUserEventDaysId);
                    table.ForeignKey(
                        name: "FK_RegisterUserEventDays_RegisterUser_RegisterUserId",
                        column: x => x.RegisterUserId,
                        principalTable: "RegisterUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "RegisterUser",
                columns: new[] { "Id", "AdditionalRequest", "Email", "Gender", "InterestArea", "Name", "RegisterDate" },
                values: new object[] { 1, "request1", "test1@gmail.com", "M", 160, "test1", new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "RegisterUser",
                columns: new[] { "Id", "AdditionalRequest", "Email", "Gender", "InterestArea", "Name", "RegisterDate" },
                values: new object[] { 2, "request2", "test2@gmail.com", "F", 37, "test2", new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "RegisterUser",
                columns: new[] { "Id", "AdditionalRequest", "Email", "Gender", "InterestArea", "Name", "RegisterDate" },
                values: new object[] { 3, "request3", "test3@gmail.com", "F", 37, "test3", new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "RegisterUserEventDays",
                columns: new[] { "RegisterUserEventDaysId", "Days", "RegisterUserId" },
                values: new object[] { 1, "Day 1", 1 });

            migrationBuilder.InsertData(
                table: "RegisterUserEventDays",
                columns: new[] { "RegisterUserEventDaysId", "Days", "RegisterUserId" },
                values: new object[] { 2, "Day 1", 2 });

            migrationBuilder.InsertData(
                table: "RegisterUserEventDays",
                columns: new[] { "RegisterUserEventDaysId", "Days", "RegisterUserId" },
                values: new object[] { 3, "Day 1", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_RegisterUserEventDays_RegisterUserId",
                table: "RegisterUserEventDays",
                column: "RegisterUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "RegisterUserEventDays");

            migrationBuilder.DropTable(
                name: "RegisterUser");
        }
    }
}
