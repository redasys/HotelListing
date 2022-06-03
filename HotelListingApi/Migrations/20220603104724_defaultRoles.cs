using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListingApi.Migrations
{
    public partial class defaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "657c88ae-9569-4a02-9d84-9667936022ae", "9e53fe67-fb6d-4611-9ca1-5dad12f19404", "Administrator", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ab526541-f659-4e91-b1b4-10d764ce1f0a", "b9e4249f-640e-40de-b5ca-275001587729", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "657c88ae-9569-4a02-9d84-9667936022ae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab526541-f659-4e91-b1b4-10d764ce1f0a");
        }
    }
}
