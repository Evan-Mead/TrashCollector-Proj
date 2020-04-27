using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class UpdateDb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38b6e769-c2ce-4be3-854e-7c5e5ecc0198");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa99125b-3c96-4f39-a825-e4c5b89580fc");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "38b6e769-c2ce-4be3-854e-7c5e5ecc0198", "63318f28-e84d-41a0-88a7-cbe4e51ee06e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fa99125b-3c96-4f39-a825-e4c5b89580fc", "f71e5165-c2a8-4619-af4f-b5cbd698627c", "Employee", "EMPLOYEE" });
        }
    }
}
