using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChaQaQcLabApi.Migrations
{
    public partial class AddFkForTests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurlingForceTests_Tester_TesterEmployeeId",
                table: "CurlingForceTests");

            migrationBuilder.DropForeignKey(
                name: "FK_ForcedCloseTests_Tester_TesterEmployeeId",
                table: "ForcedCloseTests");

            migrationBuilder.DropForeignKey(
                name: "FK_RockTests_Tester_TesterEmployeeId",
                table: "RockTests");

            migrationBuilder.DropForeignKey(
                name: "FK_SoftCloseTests_Tester_TesterEmployeeId",
                table: "SoftCloseTests");

            migrationBuilder.DropForeignKey(
                name: "FK_StaticLoadTests_Tester_TesterEmployeeId",
                table: "StaticLoadTests");

            migrationBuilder.RenameColumn(
                name: "TesterEmployeeId",
                table: "StaticLoadTests",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_StaticLoadTests_TesterEmployeeId",
                table: "StaticLoadTests",
                newName: "IX_StaticLoadTests_EmployeeId");

            migrationBuilder.RenameColumn(
                name: "TesterEmployeeId",
                table: "SoftCloseTests",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_SoftCloseTests_TesterEmployeeId",
                table: "SoftCloseTests",
                newName: "IX_SoftCloseTests_EmployeeId");

            migrationBuilder.RenameColumn(
                name: "TesterEmployeeId",
                table: "RockTests",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_RockTests_TesterEmployeeId",
                table: "RockTests",
                newName: "IX_RockTests_EmployeeId");

            migrationBuilder.RenameColumn(
                name: "TesterEmployeeId",
                table: "ForcedCloseTests",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_ForcedCloseTests_TesterEmployeeId",
                table: "ForcedCloseTests",
                newName: "IX_ForcedCloseTests_EmployeeId");

            migrationBuilder.RenameColumn(
                name: "TesterEmployeeId",
                table: "CurlingForceTests",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_CurlingForceTests_TesterEmployeeId",
                table: "CurlingForceTests",
                newName: "IX_CurlingForceTests_EmployeeId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "StaticLoadTests",
                newName: "TesterEmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_StaticLoadTests_EmployeeId",
                table: "StaticLoadTests",
                newName: "IX_StaticLoadTests_TesterEmployeeId");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "SoftCloseTests",
                newName: "TesterEmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_SoftCloseTests_EmployeeId",
                table: "SoftCloseTests",
                newName: "IX_SoftCloseTests_TesterEmployeeId");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "RockTests",
                newName: "TesterEmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_RockTests_EmployeeId",
                table: "RockTests",
                newName: "IX_RockTests_TesterEmployeeId");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "ForcedCloseTests",
                newName: "TesterEmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_ForcedCloseTests_EmployeeId",
                table: "ForcedCloseTests",
                newName: "IX_ForcedCloseTests_TesterEmployeeId");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "CurlingForceTests",
                newName: "TesterEmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_CurlingForceTests_EmployeeId",
                table: "CurlingForceTests",
                newName: "IX_CurlingForceTests_TesterEmployeeId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AddForeignKey(
                name: "FK_CurlingForceTests_Tester_TesterEmployeeId",
                table: "CurlingForceTests",
                column: "TesterEmployeeId",
                principalTable: "Tester",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ForcedCloseTests_Tester_TesterEmployeeId",
                table: "ForcedCloseTests",
                column: "TesterEmployeeId",
                principalTable: "Tester",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RockTests_Tester_TesterEmployeeId",
                table: "RockTests",
                column: "TesterEmployeeId",
                principalTable: "Tester",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SoftCloseTests_Tester_TesterEmployeeId",
                table: "SoftCloseTests",
                column: "TesterEmployeeId",
                principalTable: "Tester",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StaticLoadTests_Tester_TesterEmployeeId",
                table: "StaticLoadTests",
                column: "TesterEmployeeId",
                principalTable: "Tester",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
