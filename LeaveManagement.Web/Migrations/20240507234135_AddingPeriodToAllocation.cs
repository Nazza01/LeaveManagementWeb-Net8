using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddingPeriodToAllocation : Migration
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
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2d2e4cb-0c3e-4385-9a07-cb08a9b4a9bd", "AQAAAAIAAYagAAAAEH2THUpjxHHwxXg+16/BLiDdiVmoAumGDcV7dOD8AiGeqTjJQ/kYul+S+U5AFxe+Iw==", "5bb1f50f-0789-451b-9fe9-0dc2fecd4f24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b264a7b-9ddc-4854-8069-b31f766aac05", "AQAAAAIAAYagAAAAEAW4vOIXS5/5uqaU3oRY+2V/KN/s1x6bxMCzUTalen3ThjPGXEJ4bcSaSqTK1bJlwQ==", "28d7c3d2-96d0-41e4-b5f0-134ab2a9d247" });
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
    }
}
