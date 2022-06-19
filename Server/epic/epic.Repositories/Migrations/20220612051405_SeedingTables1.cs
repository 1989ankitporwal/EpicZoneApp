﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace epic.Repositories.Migrations
{
    public partial class SeedingTables1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastActive", "PasswordHash", "PasswordSalt", "RefreshTokenExpiryTime" },
                values: new object[] { new DateTime(2022, 6, 12, 10, 44, 5, 446, DateTimeKind.Local).AddTicks(2871), new DateTime(2022, 6, 12, 10, 44, 5, 446, DateTimeKind.Local).AddTicks(2872), new byte[] { 128, 88, 75, 56, 189, 255, 83, 17, 203, 147, 97, 171, 138, 115, 12, 181, 124, 214, 117, 66, 172, 218, 203, 37, 33, 40, 15, 26, 155, 0, 236, 194, 139, 84, 222, 203, 57, 45, 84, 65, 221, 49, 93, 127, 80, 93, 110, 35, 128, 122, 103, 37, 191, 177, 154, 29, 175, 71, 55, 216, 87, 112, 114, 211 }, new byte[] { 239, 87, 149, 81, 74, 66, 119, 248, 193, 124, 105, 28, 115, 208, 167, 116, 27, 231, 222, 158, 82, 116, 179, 112, 235, 215, 229, 246, 29, 38, 53, 96, 105, 178, 69, 45, 156, 145, 249, 13, 154, 204, 192, 145, 116, 176, 85, 35, 25, 184, 220, 76, 201, 217, 206, 226, 122, 114, 54, 203, 173, 70, 16, 4, 10, 239, 93, 67, 65, 225, 113, 73, 233, 177, 51, 40, 58, 106, 13, 236, 98, 87, 81, 215, 80, 3, 241, 219, 144, 44, 142, 134, 130, 242, 152, 127, 127, 64, 97, 156, 189, 221, 16, 223, 71, 35, 122, 120, 235, 155, 251, 69, 160, 199, 21, 135, 79, 61, 169, 127, 102, 19, 84, 191, 7, 36, 13, 212 }, new DateTime(2022, 6, 12, 10, 44, 5, 446, DateTimeKind.Local).AddTicks(2871) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastActive", "PasswordHash", "PasswordSalt", "RefreshTokenExpiryTime" },
                values: new object[] { new DateTime(2022, 6, 12, 10, 44, 5, 446, DateTimeKind.Local).AddTicks(2876), new DateTime(2022, 6, 12, 10, 44, 5, 446, DateTimeKind.Local).AddTicks(2876), new byte[] { 128, 88, 75, 56, 189, 255, 83, 17, 203, 147, 97, 171, 138, 115, 12, 181, 124, 214, 117, 66, 172, 218, 203, 37, 33, 40, 15, 26, 155, 0, 236, 194, 139, 84, 222, 203, 57, 45, 84, 65, 221, 49, 93, 127, 80, 93, 110, 35, 128, 122, 103, 37, 191, 177, 154, 29, 175, 71, 55, 216, 87, 112, 114, 211 }, new byte[] { 239, 87, 149, 81, 74, 66, 119, 248, 193, 124, 105, 28, 115, 208, 167, 116, 27, 231, 222, 158, 82, 116, 179, 112, 235, 215, 229, 246, 29, 38, 53, 96, 105, 178, 69, 45, 156, 145, 249, 13, 154, 204, 192, 145, 116, 176, 85, 35, 25, 184, 220, 76, 201, 217, 206, 226, 122, 114, 54, 203, 173, 70, 16, 4, 10, 239, 93, 67, 65, 225, 113, 73, 233, 177, 51, 40, 58, 106, 13, 236, 98, 87, 81, 215, 80, 3, 241, 219, 144, 44, 142, 134, 130, 242, 152, 127, 127, 64, 97, 156, 189, 221, 16, 223, 71, 35, 122, 120, 235, 155, 251, 69, 160, 199, 21, 135, 79, 61, 169, 127, 102, 19, 84, 191, 7, 36, 13, 212 }, new DateTime(2022, 6, 12, 10, 44, 5, 446, DateTimeKind.Local).AddTicks(2875) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastActive", "PasswordHash", "PasswordSalt", "RefreshTokenExpiryTime" },
                values: new object[] { new DateTime(2022, 6, 12, 10, 35, 58, 187, DateTimeKind.Local).AddTicks(7559), new DateTime(2022, 6, 12, 10, 35, 58, 187, DateTimeKind.Local).AddTicks(7561), new byte[] { 90, 136, 234, 13, 199, 143, 151, 166, 206, 63, 44, 126, 248, 88, 237, 31, 42, 114, 166, 127, 252, 147, 105, 17, 170, 166, 253, 137, 242, 150, 24, 11, 126, 114, 60, 53, 17, 127, 68, 137, 184, 85, 218, 235, 217, 121, 52, 62, 85, 112, 141, 229, 238, 99, 108, 239, 104, 0, 50, 155, 101, 104, 104, 203 }, new byte[] { 101, 105, 146, 222, 54, 226, 77, 79, 32, 110, 179, 47, 169, 198, 21, 243, 122, 28, 124, 243, 9, 70, 149, 181, 142, 179, 36, 163, 13, 42, 97, 132, 218, 239, 214, 66, 151, 156, 124, 253, 74, 113, 186, 89, 244, 178, 160, 105, 158, 241, 223, 39, 106, 19, 177, 175, 210, 137, 17, 96, 159, 220, 106, 70, 174, 23, 17, 200, 222, 230, 152, 188, 249, 68, 176, 150, 85, 78, 150, 238, 168, 156, 203, 73, 151, 120, 117, 25, 1, 253, 113, 72, 226, 28, 100, 87, 9, 200, 156, 255, 222, 26, 156, 13, 112, 54, 77, 205, 13, 167, 204, 80, 96, 180, 75, 46, 252, 18, 158, 6, 148, 128, 32, 38, 15, 94, 183, 252 }, new DateTime(2022, 6, 12, 10, 35, 58, 187, DateTimeKind.Local).AddTicks(7557) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastActive", "PasswordHash", "PasswordSalt", "RefreshTokenExpiryTime" },
                values: new object[] { new DateTime(2022, 6, 12, 10, 35, 58, 187, DateTimeKind.Local).AddTicks(7570), new DateTime(2022, 6, 12, 10, 35, 58, 187, DateTimeKind.Local).AddTicks(7572), new byte[] { 90, 136, 234, 13, 199, 143, 151, 166, 206, 63, 44, 126, 248, 88, 237, 31, 42, 114, 166, 127, 252, 147, 105, 17, 170, 166, 253, 137, 242, 150, 24, 11, 126, 114, 60, 53, 17, 127, 68, 137, 184, 85, 218, 235, 217, 121, 52, 62, 85, 112, 141, 229, 238, 99, 108, 239, 104, 0, 50, 155, 101, 104, 104, 203 }, new byte[] { 101, 105, 146, 222, 54, 226, 77, 79, 32, 110, 179, 47, 169, 198, 21, 243, 122, 28, 124, 243, 9, 70, 149, 181, 142, 179, 36, 163, 13, 42, 97, 132, 218, 239, 214, 66, 151, 156, 124, 253, 74, 113, 186, 89, 244, 178, 160, 105, 158, 241, 223, 39, 106, 19, 177, 175, 210, 137, 17, 96, 159, 220, 106, 70, 174, 23, 17, 200, 222, 230, 152, 188, 249, 68, 176, 150, 85, 78, 150, 238, 168, 156, 203, 73, 151, 120, 117, 25, 1, 253, 113, 72, 226, 28, 100, 87, 9, 200, 156, 255, 222, 26, 156, 13, 112, 54, 77, 205, 13, 167, 204, 80, 96, 180, 75, 46, 252, 18, 158, 6, 148, 128, 32, 38, 15, 94, 183, 252 }, new DateTime(2022, 6, 12, 10, 35, 58, 187, DateTimeKind.Local).AddTicks(7569) });
        }
    }
}