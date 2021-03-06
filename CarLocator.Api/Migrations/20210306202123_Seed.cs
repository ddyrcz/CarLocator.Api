using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarLocator.Api.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("38e599d7-067e-45f1-b1bb-da3ee309f169"), "IVECO WW 12345" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("38e599d7-067e-45f1-b1bb-da3ee309f169"));
        }
    }
}
