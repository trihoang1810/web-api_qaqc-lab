using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChaQaQcLabApi.Migrations
{
    public partial class FixNameColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurlingForceTests_Tester_EmployeeId",
                table: "CurlingForceTests");

            migrationBuilder.DropForeignKey(
                name: "FK_ForcedCloseTests_Tester_EmployeeId",
                table: "ForcedCloseTests");

            migrationBuilder.DropForeignKey(
                name: "FK_RockTests_Tester_EmployeeId",
                table: "RockTests");

            migrationBuilder.DropForeignKey(
                name: "FK_SoftCloseTests_Tester_EmployeeId",
                table: "SoftCloseTests");

            migrationBuilder.DropForeignKey(
                name: "FK_StaticLoadTests_Tester_EmployeeId",
                table: "StaticLoadTests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tester",
                table: "Tester");

            migrationBuilder.RenameTable(
                name: "Tester",
                newName: "Testers");

            migrationBuilder.RenameIndex(
                name: "IX_Tester_EmployeeId",
                table: "Testers",
                newName: "IX_Testers_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Testers",
                table: "Testers",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CurlingForceTests_Testers_EmployeeId",
                table: "CurlingForceTests",
                column: "EmployeeId",
                principalTable: "Testers",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ForcedCloseTests_Testers_EmployeeId",
                table: "ForcedCloseTests",
                column: "EmployeeId",
                principalTable: "Testers",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RockTests_Testers_EmployeeId",
                table: "RockTests",
                column: "EmployeeId",
                principalTable: "Testers",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SoftCloseTests_Testers_EmployeeId",
                table: "SoftCloseTests",
                column: "EmployeeId",
                principalTable: "Testers",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StaticLoadTests_Testers_EmployeeId",
                table: "StaticLoadTests",
                column: "EmployeeId",
                principalTable: "Testers",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurlingForceTests_Testers_EmployeeId",
                table: "CurlingForceTests");

            migrationBuilder.DropForeignKey(
                name: "FK_ForcedCloseTests_Testers_EmployeeId",
                table: "ForcedCloseTests");

            migrationBuilder.DropForeignKey(
                name: "FK_RockTests_Testers_EmployeeId",
                table: "RockTests");

            migrationBuilder.DropForeignKey(
                name: "FK_SoftCloseTests_Testers_EmployeeId",
                table: "SoftCloseTests");

            migrationBuilder.DropForeignKey(
                name: "FK_StaticLoadTests_Testers_EmployeeId",
                table: "StaticLoadTests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Testers",
                table: "Testers");

            migrationBuilder.RenameTable(
                name: "Testers",
                newName: "Tester");

            migrationBuilder.RenameIndex(
                name: "IX_Testers_EmployeeId",
                table: "Tester",
                newName: "IX_Tester_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tester",
                table: "Tester",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CurlingForceTests_Tester_EmployeeId",
                table: "CurlingForceTests",
                column: "EmployeeId",
                principalTable: "Tester",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ForcedCloseTests_Tester_EmployeeId",
                table: "ForcedCloseTests",
                column: "EmployeeId",
                principalTable: "Tester",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RockTests_Tester_EmployeeId",
                table: "RockTests",
                column: "EmployeeId",
                principalTable: "Tester",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SoftCloseTests_Tester_EmployeeId",
                table: "SoftCloseTests",
                column: "EmployeeId",
                principalTable: "Tester",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StaticLoadTests_Tester_EmployeeId",
                table: "StaticLoadTests",
                column: "EmployeeId",
                principalTable: "Tester",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
