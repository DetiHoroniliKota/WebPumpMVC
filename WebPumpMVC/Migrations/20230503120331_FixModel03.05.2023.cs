using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebPumpMVC.Migrations
{
    public partial class FixModel03052023 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Automation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Typ = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Automation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cap",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Typ = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cap", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clamp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diameter = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Typ = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clamp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HydraulicAccumulator",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Volume = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Typ = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HydraulicAccumulator", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pipe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diameter = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pipe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pump",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    H = table.Column<int>(type: "int", nullable: false),
                    Q = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Typ = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pump", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rope",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diameter = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rope", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnderwaterСable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Section = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnderwaterСable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PumpsTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RopeTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HydraulicAccumulatorTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClampTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PipeTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CapTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnderwaterСableTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AutomationTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PumpId = table.Column<int>(type: "int", nullable: false),
                    RopeId = table.Column<int>(type: "int", nullable: false),
                    HydraulicAccumulatorId = table.Column<int>(type: "int", nullable: false),
                    ClampId = table.Column<int>(type: "int", nullable: false),
                    PipeId = table.Column<int>(type: "int", nullable: false),
                    Capid = table.Column<int>(type: "int", nullable: false),
                    UnderwaterСableId = table.Column<int>(type: "int", nullable: false),
                    AutomationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipment_Automation_AutomationId",
                        column: x => x.AutomationId,
                        principalTable: "Automation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipment_Cap_Capid",
                        column: x => x.Capid,
                        principalTable: "Cap",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipment_Clamp_ClampId",
                        column: x => x.ClampId,
                        principalTable: "Clamp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipment_HydraulicAccumulator_HydraulicAccumulatorId",
                        column: x => x.HydraulicAccumulatorId,
                        principalTable: "HydraulicAccumulator",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipment_Pipe_PipeId",
                        column: x => x.PipeId,
                        principalTable: "Pipe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipment_Pump_PumpId",
                        column: x => x.PumpId,
                        principalTable: "Pump",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipment_Rope_RopeId",
                        column: x => x.RopeId,
                        principalTable: "Rope",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipment_UnderwaterСable_UnderwaterСableId",
                        column: x => x.UnderwaterСableId,
                        principalTable: "UnderwaterСable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_AutomationId",
                table: "Equipment",
                column: "AutomationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_Capid",
                table: "Equipment",
                column: "Capid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_ClampId",
                table: "Equipment",
                column: "ClampId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_HydraulicAccumulatorId",
                table: "Equipment",
                column: "HydraulicAccumulatorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_PipeId",
                table: "Equipment",
                column: "PipeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_PumpId",
                table: "Equipment",
                column: "PumpId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_RopeId",
                table: "Equipment",
                column: "RopeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_UnderwaterСableId",
                table: "Equipment",
                column: "UnderwaterСableId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "Automation");

            migrationBuilder.DropTable(
                name: "Cap");

            migrationBuilder.DropTable(
                name: "Clamp");

            migrationBuilder.DropTable(
                name: "HydraulicAccumulator");

            migrationBuilder.DropTable(
                name: "Pipe");

            migrationBuilder.DropTable(
                name: "Pump");

            migrationBuilder.DropTable(
                name: "Rope");

            migrationBuilder.DropTable(
                name: "UnderwaterСable");
        }
    }
}
