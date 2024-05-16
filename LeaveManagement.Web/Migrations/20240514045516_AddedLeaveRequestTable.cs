using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Migrations
{
	/// <inheritdoc />
	public partial class AddedLeaveRequestTable : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "LeaveRequests",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					LeaveTypeId = table.Column<int>(type: "int", nullable: false),
					DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
					RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
					IsApproved = table.Column<bool>(type: "bit", nullable: true),
					Cancelled = table.Column<bool>(type: "bit", nullable: false),
					RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
					DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
					DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_LeaveRequests", x => x.Id);
					table.ForeignKey(
						name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
						column: x => x.LeaveTypeId,
						principalTable: "LeaveTypes",
						principalColumn: "Id",
						onDelete: ReferentialAction.Restrict);
				});

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

			migrationBuilder.CreateIndex(
				name: "IX_LeaveRequests_LeaveTypeId",
				table: "LeaveRequests",
				column: "LeaveTypeId");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "LeaveRequests");

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
	}
}
