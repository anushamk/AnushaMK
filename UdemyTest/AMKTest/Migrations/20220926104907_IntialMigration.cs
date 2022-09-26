using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AMKTest.Migrations
{
    public partial class IntialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblRegion",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area = table.Column<double>(type: "float", nullable: false),
                    Lat = table.Column<double>(type: "float", nullable: false),
                    Long = table.Column<double>(type: "float", nullable: false),
                    Population = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblRegion", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TblWalkDifficulty",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblWalkDifficulty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblWalk",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false),
                    RegionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WalkDifficultyID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblWalk", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblWalk_TblRegion_RegionID",
                        column: x => x.RegionID,
                        principalTable: "TblRegion",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblWalk_TblWalkDifficulty_WalkDifficultyID",
                        column: x => x.WalkDifficultyID,
                        principalTable: "TblWalkDifficulty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblWalk_RegionID",
                table: "TblWalk",
                column: "RegionID");

            migrationBuilder.CreateIndex(
                name: "IX_TblWalk_WalkDifficultyID",
                table: "TblWalk",
                column: "WalkDifficultyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblWalk");

            migrationBuilder.DropTable(
                name: "TblRegion");

            migrationBuilder.DropTable(
                name: "TblWalkDifficulty");
        }
    }
}
