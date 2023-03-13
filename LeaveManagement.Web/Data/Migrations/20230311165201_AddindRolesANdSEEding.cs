using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddindRolesANdSEEding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-ladd431ccbbf", null, "Administrator", "ADMINISTRATOR" },
                    { "cac43a6e-f7cb-4448-baaf-ladd431ccbbf", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "82a4fa39-60b2-43b7-8598-bf794f2f17e7", 0, "02c98ed0-f6ed-4425-a16c-6458ac377cd0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "paulgeorgecode@gmail.com", false, "System", "Admin", false, null, "PAULGEORGECODE@GMAIL.COM", null, "AQAAAAIAAYagAAAAEHfC0RUr8AGFfXSI2KKLjpVZeJUvQxBJf/PpeWgi34ahkWtavzBlxz/nlwpvJCPJYg==", null, false, "643f2df1-2199-4990-b376-a58bdc1fda1c", null, false, null },
                    { "82a4fa39-60b2-60b2-8598-bf794f2f17e7", 0, "00be7e3d-d8e0-4b6d-8fdd-19a47cc436ff", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "paulgeorgecode@gmail.com", false, "System", "User", false, null, "PAULGEORGECODE@GMAIL.COM", null, "AQAAAAIAAYagAAAAEJcLvhzBZjTRaEAu8nk6pscY+CBhfhEjBQxpyjhP7ShWFtkdNvbg/4C2HqFc/OHv6A==", null, false, "afe418a0-d3f0-4f0d-a8f0-98bbaa1e1450", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-ladd431ccbbf", "82a4fa39-60b2-43b7-8598-bf794f2f17e7" },
                    { "cac43a6e-f7cb-4448-baaf-ladd431ccbbf", "82a4fa39-60b2-60b2-8598-bf794f2f17e7" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-ladd431ccbbf", "82a4fa39-60b2-43b7-8598-bf794f2f17e7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7cb-4448-baaf-ladd431ccbbf", "82a4fa39-60b2-60b2-8598-bf794f2f17e7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-ladd431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7cb-4448-baaf-ladd431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82a4fa39-60b2-43b7-8598-bf794f2f17e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82a4fa39-60b2-60b2-8598-bf794f2f17e7");
        }
    }
}
