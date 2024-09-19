using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    public partial class NewProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e56f6f6-d4b7-4b1f-a788-ad7942ed4fe9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2e5a6bb-b67f-4c82-9227-72181d001b69");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1247dcae-5b38-4612-a34c-d1391d685db4", "d3435737-6ce2-48c2-857a-3ca38fb0fd65", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "679fea42-f561-4232-a304-85149bae6b6e", "85fc55d2-e36d-4779-af89-41026786ef05", "Member", "MEMBER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1247dcae-5b38-4612-a34c-d1391d685db4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "679fea42-f561-4232-a304-85149bae6b6e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e56f6f6-d4b7-4b1f-a788-ad7942ed4fe9", "799ebfd2-c7dc-4053-920d-44bfebdff19c", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b2e5a6bb-b67f-4c82-9227-72181d001b69", "abb2e9e0-a3f3-4dd5-b067-f1ec77419db0", "Admin", "ADMIN" });
        }
    }
}
