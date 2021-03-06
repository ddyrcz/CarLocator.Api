using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarLocator.Api.Migrations
{
    public partial class Location : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("38e599d7-067e-45f1-b1bb-da3ee309f169"));

            migrationBuilder.AddColumn<double>(
                name: "MostRecentLocation_Lat",
                table: "Vehicles",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MostRecentLocation_Lon",
                table: "Vehicles",
                type: "float",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MostRecentLocation_Lat",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "MostRecentLocation_Lon",
                table: "Vehicles");

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("38e599d7-067e-45f1-b1bb-da3ee309f169"), "IVECO WW 12345" });
        }
    }
}
