using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChaQaQcLabApi.Migrations
{
    public partial class InitialMySql : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Testers",
                columns: table => new
                {
                    EmployeeId = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FirstName = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testers", x => x.EmployeeId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CurlingForceTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ProductId = table.Column<string>(type: "varchar(40)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TestPurpose = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ForcedCloseTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ProductId = table.Column<string>(type: "varchar(40)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TestPurpose = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RockTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ProductId = table.Column<string>(type: "varchar(40)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TestPurpose = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SoftCloseTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ProductId = table.Column<string>(type: "varchar(40)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TestPurpose = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StaticLoadTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ProductId = table.Column<string>(type: "varchar(40)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TestPurpose = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WaterProofingTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ProductId = table.Column<string>(type: "varchar(40)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TestPurpose = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterProofingTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WaterProofingTests_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CurlingForceTestSamples",
                columns: table => new
                {
                    CurlingForceTestId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Load = table.Column<double>(type: "double", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    DeformationDegree = table.Column<double>(type: "double", nullable: false),
                    EmployeeId = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumberOfError = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                    table.ForeignKey(
                        name: "FK_CurlingForceTestSamples_Testers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Testers",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ForcedCloseTestSamples",
                columns: table => new
                {
                    ForcedCloseTestId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NumberOfClosing = table.Column<int>(type: "int", nullable: false),
                    SeatRingResult_FallTime = table.Column<int>(type: "int", nullable: false),
                    SeatRingResult_IsIntact = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SeatRingResult_IsUnleaked = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SeatRingResult_Passed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SeatLidResult_FallTime = table.Column<int>(type: "int", nullable: false),
                    SeatLidResult_IsIntact = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SeatLidResult_IsUnleaked = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SeatLidResult_Passed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    EmployeeId = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumberOfError = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                    table.ForeignKey(
                        name: "FK_ForcedCloseTestSamples_Testers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Testers",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RockTestSamples",
                columns: table => new
                {
                    RockTestId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Load = table.Column<double>(type: "double", nullable: false),
                    TestedTimes = table.Column<int>(type: "int", nullable: false),
                    Passed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    EmployeeId = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumberOfError = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                    table.ForeignKey(
                        name: "FK_RockTestSamples_Testers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Testers",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SoftCloseTestSamples",
                columns: table => new
                {
                    SoftCloseTestId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NumberOfClosing = table.Column<int>(type: "int", nullable: false),
                    SeatLidResult_FallTime = table.Column<int>(type: "int", nullable: false),
                    SeatLidResult_IsBumperIntact = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SeatLidResult_IsUnleaked = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SeatLidResult_Passed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SeatRingResult_FallTime = table.Column<int>(type: "int", nullable: false),
                    SeatRingResult_IsBumperIntact = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SeatRingResult_IsUnleaked = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SeatRingResult_Passed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    EmployeeId = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumberOfError = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                    table.ForeignKey(
                        name: "FK_SoftCloseTestSamples_Testers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Testers",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StaticLoadTestSamples",
                columns: table => new
                {
                    StaticLoadTestId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmployeeId = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumberOfError = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                    table.ForeignKey(
                        name: "FK_StaticLoadTestSamples_Testers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Testers",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WaterProofingTestSamples",
                columns: table => new
                {
                    WaterProofingTestId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Temperature = table.Column<double>(type: "double", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Passed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    EmployeeId = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumberOfError = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterProofingTestSamples", x => new { x.WaterProofingTestId, x.Id });
                    table.ForeignKey(
                        name: "FK_WaterProofingTestSamples_Testers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Testers",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WaterProofingTestSamples_WaterProofingTests_WaterProofingTes~",
                        column: x => x.WaterProofingTestId,
                        principalTable: "WaterProofingTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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
                name: "IX_CurlingForceTestSamples_EmployeeId",
                table: "CurlingForceTestSamples",
                column: "EmployeeId");

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
                name: "IX_ForcedCloseTestSamples_EmployeeId",
                table: "ForcedCloseTestSamples",
                column: "EmployeeId");

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
                name: "IX_RockTestSamples_EmployeeId",
                table: "RockTestSamples",
                column: "EmployeeId");

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
                name: "IX_SoftCloseTestSamples_EmployeeId",
                table: "SoftCloseTestSamples",
                column: "EmployeeId");

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
                name: "IX_StaticLoadTestSamples_EmployeeId",
                table: "StaticLoadTestSamples",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Testers_EmployeeId",
                table: "Testers",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WaterProofingTests_Id",
                table: "WaterProofingTests",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WaterProofingTests_ProductId",
                table: "WaterProofingTests",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterProofingTestSamples_EmployeeId",
                table: "WaterProofingTestSamples",
                column: "EmployeeId");
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
                name: "WaterProofingTestSamples");

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
                name: "Testers");

            migrationBuilder.DropTable(
                name: "WaterProofingTests");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
