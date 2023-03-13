using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddindRolesANdSEEdings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82a4fa39-60b2-43b7-8598-bf794f2f17e7",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "128d8000-c633-480f-a983-bd2201be9b4c", true, "PAULGEORGECODE@GMAIL.COM", "AQAAAAIAAYagAAAAEObWLGJhI/e/UGP78zB2xfPuJ4L5x53iT2W5g5YNGZz+PLUdUo556YId7765fIA1Cg==", "cf336865-3cdd-4d1d-a29f-04b7002e35c7", "paulgeorgecode@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82a4fa39-60b2-60b2-8598-bf794f2f17e7",
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "38502d65-4777-4752-9d6a-9e253e26061e", "userpaulgeorgecode@gmail.com", true, "USERPAULGEORGECODE@GMAIL.COM", "USERPAULGEORGECODE@GMAIL.COM", "AQAAAAIAAYagAAAAEBH7eehO8i3AsDi07Sx3xABmHWCd2hxQfjgvnCZ7hu2W9Wkc7R9cr8eb2GjCHghvMQ==", "25a56c11-4c1a-488f-929b-07a71b479194", "userpaulgeorgecode@gmail.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82a4fa39-60b2-43b7-8598-bf794f2f17e7",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "02c98ed0-f6ed-4425-a16c-6458ac377cd0", false, null, "AQAAAAIAAYagAAAAEHfC0RUr8AGFfXSI2KKLjpVZeJUvQxBJf/PpeWgi34ahkWtavzBlxz/nlwpvJCPJYg==", "643f2df1-2199-4990-b376-a58bdc1fda1c", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82a4fa39-60b2-60b2-8598-bf794f2f17e7",
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "00be7e3d-d8e0-4b6d-8fdd-19a47cc436ff", "paulgeorgecode@gmail.com", false, "PAULGEORGECODE@GMAIL.COM", null, "AQAAAAIAAYagAAAAEJcLvhzBZjTRaEAu8nk6pscY+CBhfhEjBQxpyjhP7ShWFtkdNvbg/4C2HqFc/OHv6A==", "afe418a0-d3f0-4f0d-a8f0-98bbaa1e1450", null });
        }
    }
}
