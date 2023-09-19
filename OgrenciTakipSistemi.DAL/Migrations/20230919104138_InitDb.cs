using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OgrenciTakipSistemi.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Danismanlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DanismanAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DanismanSoyadi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cinsiyet = table.Column<bool>(type: "bit", nullable: false),
                    TcNO = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Gsm = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 19, 13, 41, 38, 879, DateTimeKind.Local).AddTicks(3907))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Danismanlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dersler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DersAciklama = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 19, 13, 41, 38, 879, DateTimeKind.Local).AddTicks(7397))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dersler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ogrenciler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OgrenciSoyadi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cinsiyet = table.Column<bool>(type: "bit", nullable: false),
                    TcNO = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Gsm = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 19, 13, 41, 38, 880, DateTimeKind.Local).AddTicks(9))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenciler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 19, 13, 41, 38, 880, DateTimeKind.Local).AddTicks(3378))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roller", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Danismanlar_Email",
                table: "Danismanlar",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Danismanlar_Gsm",
                table: "Danismanlar",
                column: "Gsm",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Danismanlar_TcNO",
                table: "Danismanlar",
                column: "TcNO",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dersler_DersAdi",
                table: "Dersler",
                column: "DersAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_Email",
                table: "Ogrenciler",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_Gsm",
                table: "Ogrenciler",
                column: "Gsm",
                unique: true,
                filter: "[Gsm] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_TcNO",
                table: "Ogrenciler",
                column: "TcNO",
                unique: true,
                filter: "[TcNO] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Danismanlar");

            migrationBuilder.DropTable(
                name: "Dersler");

            migrationBuilder.DropTable(
                name: "Ogrenciler");

            migrationBuilder.DropTable(
                name: "Roller");
        }
    }
}
