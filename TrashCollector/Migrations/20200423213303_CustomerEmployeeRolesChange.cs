using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class CustomerEmployeeRolesChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a646bb2-5b38-48c8-b1ea-24a429d4f086");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09b61aff-1ff4-4b3c-83ce-b4cf5b387f19", "f3e15ce8-e774-49ce-965c-a88dae53807c", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c68731cb-dd6a-476c-8e14-0a55a46da2d8", "45367c2d-b202-4bc9-90b9-0975d0562fb6", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "8a646bb2-5b38-48c8-b1ea-24a429d4f086", "f9f837b4-ece4-4bc8-a8cf-2f092edaecb0", "Admin", "ADMIN" });
        }
    }
}
