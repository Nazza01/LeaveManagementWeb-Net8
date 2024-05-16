using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRequestComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f170ba0-5b95-496d-a942-046a13e1149a", "AQAAAAIAAYagAAAAEJdbbQHzoBMO6m3VjmzfQv2LnuiHjdSPPwtN3xGaQh2S6f6/R1DUX2nMvvqejYZIGQ==", "8f510105-0213-49b6-a286-a788686ce1e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b4e7570-8360-47e3-a031-a93182e66c67", "AQAAAAIAAYagAAAAEK1kSoOSouq/SxnLG/N1l7ex1DdvsNzWnk24cDe80g3mZlEY48UvWgMYMhEfx4/csg==", "9eb5c85c-27be-4e20-b36b-de1d62cedded" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc6ba61a-003b-4928-bc02-13b903212e53", "AQAAAAIAAYagAAAAEJC2HygXJ9e1GA7Ej3sauoFxXE5nUHmRYoE+X2kmy2j/Pw9s9fBPHVbDYbjCXu0x3A==", "15d4d20b-7a86-4776-96c3-5cf100f472ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "409465ea-e9d8-44d6-a549-6f4e0558c9af", "AQAAAAIAAYagAAAAENmNpqcu7GyL9Xa/bIrL+SSf+z2UY7oSApDF6WV3NvwEd/BVdi6FLXb7RcvTVKL0LA==", "e988f92f-ed17-47cc-98e8-c9e3f05b5d0f" });
        }
    }
}
