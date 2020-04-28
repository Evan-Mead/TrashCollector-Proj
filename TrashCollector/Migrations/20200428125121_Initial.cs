using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "AccountBalance",
                table: "Customers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e456fae-fd32-4ecb-82d1-a35ac95e5a0b", "64a4cbb0-096f-4c8d-a99c-6eb166cfea34", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "23e3acbf-ffa9-41ef-b9f1-9083a6b5bd8c", "d41c2781-f096-47c6-9db3-7ca135b115c9", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23e3acbf-ffa9-41ef-b9f1-9083a6b5bd8c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e456fae-fd32-4ecb-82d1-a35ac95e5a0b");

            migrationBuilder.DropColumn(
                name: "AccountBalance",
                table: "Customers");
        }
    }
}
