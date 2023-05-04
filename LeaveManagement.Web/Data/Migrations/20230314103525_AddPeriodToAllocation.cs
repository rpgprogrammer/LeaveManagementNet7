using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPeriodToAllocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82a4fa39-60b2-43b7-8598-bf794f2f17e7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5427cfb4-b252-413f-9f22-0e61d06db9c5", "AQAAAAIAAYagAAAAEPvpP5l9wyHAy47/U3pDvYf9fg56TVN5lYO42RQOqXulff1861FZ2HqfbUKtqAimZg==", "b42d3bb5-4432-40a2-af32-b5d36bb625e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82a4fa39-60b2-60b2-8598-bf794f2f17e7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7064a6d-f615-458a-bbf7-11dceef4ac69", "AQAAAAIAAYagAAAAEJO4RRrpqD5ga9KPPatsG2eqGTNvi9aRqhknmrSyi6udvKfA7RhSs0fGDTZFyXCGJw==", "61a2b1f0-dd4a-4870-bc45-70010442e69b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82a4fa39-60b2-43b7-8598-bf794f2f17e7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "128d8000-c633-480f-a983-bd2201be9b4c", "AQAAAAIAAYagAAAAEObWLGJhI/e/UGP78zB2xfPuJ4L5x53iT2W5g5YNGZz+PLUdUo556YId7765fIA1Cg==", "cf336865-3cdd-4d1d-a29f-04b7002e35c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82a4fa39-60b2-60b2-8598-bf794f2f17e7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38502d65-4777-4752-9d6a-9e253e26061e", "AQAAAAIAAYagAAAAEBH7eehO8i3AsDi07Sx3xABmHWCd2hxQfjgvnCZ7hu2W9Wkc7R9cr8eb2GjCHghvMQ==", "25a56c11-4c1a-488f-929b-07a71b479194" });
        }
    }
}
