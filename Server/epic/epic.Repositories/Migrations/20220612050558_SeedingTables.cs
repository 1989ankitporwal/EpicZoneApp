using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace epic.Repositories.Migrations
{
    public partial class SeedingTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "User" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "FirstName", "IsActive", "LastActive", "LastName", "PasswordHash", "PasswordSalt", "RefreshToken", "RefreshTokenExpiryTime", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 12, 10, 35, 58, 187, DateTimeKind.Local).AddTicks(7559), "admin@gmail.com", "Super", true, new DateTime(2022, 6, 12, 10, 35, 58, 187, DateTimeKind.Local).AddTicks(7561), "Admin", new byte[] { 90, 136, 234, 13, 199, 143, 151, 166, 206, 63, 44, 126, 248, 88, 237, 31, 42, 114, 166, 127, 252, 147, 105, 17, 170, 166, 253, 137, 242, 150, 24, 11, 126, 114, 60, 53, 17, 127, 68, 137, 184, 85, 218, 235, 217, 121, 52, 62, 85, 112, 141, 229, 238, 99, 108, 239, 104, 0, 50, 155, 101, 104, 104, 203 }, new byte[] { 101, 105, 146, 222, 54, 226, 77, 79, 32, 110, 179, 47, 169, 198, 21, 243, 122, 28, 124, 243, 9, 70, 149, 181, 142, 179, 36, 163, 13, 42, 97, 132, 218, 239, 214, 66, 151, 156, 124, 253, 74, 113, 186, 89, 244, 178, 160, 105, 158, 241, 223, 39, 106, 19, 177, 175, 210, 137, 17, 96, 159, 220, 106, 70, 174, 23, 17, 200, 222, 230, 152, 188, 249, 68, 176, 150, 85, 78, 150, 238, 168, 156, 203, 73, 151, 120, 117, 25, 1, 253, 113, 72, 226, 28, 100, 87, 9, 200, 156, 255, 222, 26, 156, 13, 112, 54, 77, 205, 13, 167, 204, 80, 96, 180, 75, 46, 252, 18, 158, 6, 148, 128, 32, 38, 15, 94, 183, 252 }, "VBj9IOAJtZwrMiHizKy2FkOmxM6PCJw9u9vepY4lbIg=", new DateTime(2022, 6, 12, 10, 35, 58, 187, DateTimeKind.Local).AddTicks(7557), "Admin" },
                    { 2, new DateTime(2022, 6, 12, 10, 35, 58, 187, DateTimeKind.Local).AddTicks(7570), "user@gmail.com", "Super", true, new DateTime(2022, 6, 12, 10, 35, 58, 187, DateTimeKind.Local).AddTicks(7572), "User", new byte[] { 90, 136, 234, 13, 199, 143, 151, 166, 206, 63, 44, 126, 248, 88, 237, 31, 42, 114, 166, 127, 252, 147, 105, 17, 170, 166, 253, 137, 242, 150, 24, 11, 126, 114, 60, 53, 17, 127, 68, 137, 184, 85, 218, 235, 217, 121, 52, 62, 85, 112, 141, 229, 238, 99, 108, 239, 104, 0, 50, 155, 101, 104, 104, 203 }, new byte[] { 101, 105, 146, 222, 54, 226, 77, 79, 32, 110, 179, 47, 169, 198, 21, 243, 122, 28, 124, 243, 9, 70, 149, 181, 142, 179, 36, 163, 13, 42, 97, 132, 218, 239, 214, 66, 151, 156, 124, 253, 74, 113, 186, 89, 244, 178, 160, 105, 158, 241, 223, 39, 106, 19, 177, 175, 210, 137, 17, 96, 159, 220, 106, 70, 174, 23, 17, 200, 222, 230, 152, 188, 249, 68, 176, 150, 85, 78, 150, 238, 168, 156, 203, 73, 151, 120, 117, 25, 1, 253, 113, 72, 226, 28, 100, 87, 9, 200, 156, 255, 222, 26, 156, 13, 112, 54, 77, 205, 13, 167, 204, 80, 96, 180, 75, 46, 252, 18, 158, 6, 148, 128, 32, 38, 15, 94, 183, 252 }, "VBj9IOAJtZwrMiHizKy2FkOmxM6PCJw9u9vepY4lbIg=", new DateTime(2022, 6, 12, 10, 35, 58, 187, DateTimeKind.Local).AddTicks(7569), "User" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
