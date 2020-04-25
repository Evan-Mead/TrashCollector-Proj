using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class UpdatedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09b61aff-1ff4-4b3c-83ce-b4cf5b387f19");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c68731cb-dd6a-476c-8e14-0a55a46da2d8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "38b6e769-c2ce-4be3-854e-7c5e5ecc0198", "63318f28-e84d-41a0-88a7-cbe4e51ee06e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fa99125b-3c96-4f39-a825-e4c5b89580fc", "f71e5165-c2a8-4619-af4f-b5cbd698627c", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38b6e769-c2ce-4be3-854e-7c5e5ecc0198");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa99125b-3c96-4f39-a825-e4c5b89580fc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09b61aff-1ff4-4b3c-83ce-b4cf5b387f19", "f3e15ce8-e774-49ce-965c-a88dae53807c", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c68731cb-dd6a-476c-8e14-0a55a46da2d8", "45367c2d-b202-4bc9-90b9-0975d0562fb6", "Employee", "EMPLOYEE" });
        }
    }
}
