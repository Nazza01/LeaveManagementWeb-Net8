using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94d50ee2-8c92-4109-9681-bfb6e66a40a4", "AQAAAAIAAYagAAAAEETKwUCD+6MSdk3ksFzRtVblEmhcKCmz7RuKVsadKnIehLdFA1YZ1wYG0lSGFz3WAw==", "edb343e3-57a8-4839-959c-8111f298c053" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "886c3e88-297e-4846-ae0f-7df625887b20", "AQAAAAIAAYagAAAAEOQZTHoiWjgwp8sczt0b1E+dcx8icUSwYsLWlLbi7y2RRbXVFdqIfW6KmQacIOAitg==", "c80ffe3c-d613-4e0c-acc5-8ad65c0539ef" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01a92054-efaf-437c-86ef-8a1e16a6635f", "AQAAAAIAAYagAAAAEJZ0tlgO/3EaFBtbHNJYDQMsUfk1Q58AQiu9/08vezLcxsEH/+k7chY9LGxYnUuR+g==", "119cdf7e-3eee-4004-82aa-6f08fdacefea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "335819d8-58e8-4ae7-b793-c2b0a48a37f3", "AQAAAAIAAYagAAAAEBGDglPRXlhJTxnxSKcNaqfDAbev6O8JJzcKxJx2VGz5uX3TsHudrYgjdZoGZR1mOg==", "7f56012a-6c22-4e5f-a7fc-12ba1c7e2e48" });
        }
    }
}
