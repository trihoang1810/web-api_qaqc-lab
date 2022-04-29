using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChaQaQcLabApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "EntityFrameworkHiLoSequence",
                incrementBy: 10);

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tester",
                columns: table => new
                {
                    EmployeeId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tester", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "CurlingForceTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    TestPurpose = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    TesterEmployeeId = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurlingForceTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurlingForceTests_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurlingForceTests_Tester_TesterEmployeeId",
                        column: x => x.TesterEmployeeId,
                        principalTable: "Tester",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ForcedCloseTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ExpectedOutcome_FallTime = table.Column<int>(type: "int", nullable: false),
                    ExpectedOutcome_IsIntact = table.Column<bool>(type: "bit", nullable: false),
                    ExpectedOutcome_IsUnleaked = table.Column<bool>(type: "bit", nullable: false),
                    ExpectedOutcome_Passed = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    TestPurpose = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    TesterEmployeeId = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForcedCloseTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForcedCloseTests_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ForcedCloseTests_Tester_TesterEmployeeId",
                        column: x => x.TesterEmployeeId,
                        principalTable: "Tester",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RockTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    TestPurpose = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    TesterEmployeeId = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RockTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RockTests_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RockTests_Tester_TesterEmployeeId",
                        column: x => x.TesterEmployeeId,
                        principalTable: "Tester",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SoftCloseTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    SeatLidExpectedOutcome_FallTime = table.Column<int>(type: "int", nullable: false),
                    SeatLidExpectedOutcome_IsBumperIntact = table.Column<bool>(type: "bit", nullable: false),
                    SeatLidExpectedOutcome_IsUnleaked = table.Column<bool>(type: "bit", nullable: false),
                    SeatLidExpectedOutcome_Passed = table.Column<bool>(type: "bit", nullable: false),
                    SeatRingExpectedOutcome_FallTime = table.Column<int>(type: "int", nullable: false),
                    SeatRingExpectedOutcome_IsBumperIntact = table.Column<bool>(type: "bit", nullable: false),
                    SeatRingExpectedOutcome_IsUnleaked = table.Column<bool>(type: "bit", nullable: false),
                    SeatRingExpectedOutcome_Passed = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    TestPurpose = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    TesterEmployeeId = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoftCloseTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SoftCloseTests_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SoftCloseTests_Tester_TesterEmployeeId",
                        column: x => x.TesterEmployeeId,
                        principalTable: "Tester",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StaticLoadTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    TestPurpose = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    TesterEmployeeId = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaticLoadTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaticLoadTests_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StaticLoadTests_Tester_TesterEmployeeId",
                        column: x => x.TesterEmployeeId,
                        principalTable: "Tester",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurlingForceTestSamples",
                columns: table => new
                {
                    CurlingForceTestId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SampleNumber = table.Column<int>(type: "int", nullable: false),
                    Load = table.Column<double>(type: "float", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    DeformationDegree = table.Column<double>(type: "float", nullable: false),
                    NumberOfErrors = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurlingForceTestSamples", x => new { x.CurlingForceTestId, x.Id });
                    table.ForeignKey(
                        name: "FK_CurlingForceTestSamples_CurlingForceTests_CurlingForceTestId",
                        column: x => x.CurlingForceTestId,
                        principalTable: "CurlingForceTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ForcedCloseTestSamples",
                columns: table => new
                {
                    ForcedCloseTestId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SampleNumber = table.Column<int>(type: "int", nullable: false),
                    Result_FallTime = table.Column<int>(type: "int", nullable: false),
                    Result_IsIntact = table.Column<bool>(type: "bit", nullable: false),
                    Result_IsUnleaked = table.Column<bool>(type: "bit", nullable: false),
                    Result_Passed = table.Column<bool>(type: "bit", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForcedCloseTestSamples", x => new { x.ForcedCloseTestId, x.Id });
                    table.ForeignKey(
                        name: "FK_ForcedCloseTestSamples_ForcedCloseTests_ForcedCloseTestId",
                        column: x => x.ForcedCloseTestId,
                        principalTable: "ForcedCloseTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RockTestSamples",
                columns: table => new
                {
                    RockTestId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Load = table.Column<double>(type: "float", nullable: false),
                    TestedTimes = table.Column<int>(type: "int", nullable: false),
                    Passed = table.Column<bool>(type: "bit", nullable: false),
                    NumberOfErrors = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RockTestSamples", x => new { x.RockTestId, x.Id });
                    table.ForeignKey(
                        name: "FK_RockTestSamples_RockTests_RockTestId",
                        column: x => x.RockTestId,
                        principalTable: "RockTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SoftCloseTestSamples",
                columns: table => new
                {
                    SoftCloseTestId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SampleNumber = table.Column<int>(type: "int", nullable: false),
                    SeatLidResult_FallTime = table.Column<int>(type: "int", nullable: false),
                    SeatLidResult_IsBumperIntact = table.Column<bool>(type: "bit", nullable: false),
                    SeatLidResult_IsUnleaked = table.Column<bool>(type: "bit", nullable: false),
                    SeatLidResult_Passed = table.Column<bool>(type: "bit", nullable: false),
                    SeatRingResult_FallTime = table.Column<int>(type: "int", nullable: false),
                    SeatRingResult_IsBumperIntact = table.Column<bool>(type: "bit", nullable: false),
                    SeatRingResult_IsUnleaked = table.Column<bool>(type: "bit", nullable: false),
                    SeatRingResult_Passed = table.Column<bool>(type: "bit", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoftCloseTestSamples", x => new { x.SoftCloseTestId, x.Id });
                    table.ForeignKey(
                        name: "FK_SoftCloseTestSamples_SoftCloseTests_SoftCloseTestId",
                        column: x => x.SoftCloseTestId,
                        principalTable: "SoftCloseTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StaticLoadTestSamples",
                columns: table => new
                {
                    StaticLoadTestId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfErrors = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaticLoadTestSamples", x => new { x.StaticLoadTestId, x.Id });
                    table.ForeignKey(
                        name: "FK_StaticLoadTestSamples_StaticLoadTests_StaticLoadTestId",
                        column: x => x.StaticLoadTestId,
                        principalTable: "StaticLoadTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CurlingForceTests_Id",
                table: "CurlingForceTests",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CurlingForceTests_ProductId",
                table: "CurlingForceTests",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CurlingForceTests_TesterEmployeeId",
                table: "CurlingForceTests",
                column: "TesterEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ForcedCloseTests_Id",
                table: "ForcedCloseTests",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ForcedCloseTests_ProductId",
                table: "ForcedCloseTests",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ForcedCloseTests_TesterEmployeeId",
                table: "ForcedCloseTests",
                column: "TesterEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Id",
                table: "Products",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RockTests_Id",
                table: "RockTests",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RockTests_ProductId",
                table: "RockTests",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_RockTests_TesterEmployeeId",
                table: "RockTests",
                column: "TesterEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_SoftCloseTests_Id",
                table: "SoftCloseTests",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SoftCloseTests_ProductId",
                table: "SoftCloseTests",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SoftCloseTests_TesterEmployeeId",
                table: "SoftCloseTests",
                column: "TesterEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_StaticLoadTests_Id",
                table: "StaticLoadTests",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StaticLoadTests_ProductId",
                table: "StaticLoadTests",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StaticLoadTests_TesterEmployeeId",
                table: "StaticLoadTests",
                column: "TesterEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tester_EmployeeId",
                table: "Tester",
                column: "EmployeeId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurlingForceTestSamples");

            migrationBuilder.DropTable(
                name: "ForcedCloseTestSamples");

            migrationBuilder.DropTable(
                name: "RockTestSamples");

            migrationBuilder.DropTable(
                name: "SoftCloseTestSamples");

            migrationBuilder.DropTable(
                name: "StaticLoadTestSamples");

            migrationBuilder.DropTable(
                name: "CurlingForceTests");

            migrationBuilder.DropTable(
                name: "ForcedCloseTests");

            migrationBuilder.DropTable(
                name: "RockTests");

            migrationBuilder.DropTable(
                name: "SoftCloseTests");

            migrationBuilder.DropTable(
                name: "StaticLoadTests");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Tester");

            migrationBuilder.DropSequence(
                name: "EntityFrameworkHiLoSequence");
        }
    }
}
