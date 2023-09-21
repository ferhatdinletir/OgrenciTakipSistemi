using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OgrenciTakipSistemi.DAL.Migrations
{
    /// <inheritdoc />
    public partial class OgrenciTakipSistemi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Roller");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Ogrenciler",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ogrenciler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 13, 27, 19, 72, DateTimeKind.Local).AddTicks(3530),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 19, 13, 41, 38, 880, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.AddColumn<int>(
                name: "DanismanId",
                table: "Ogrenciler",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DevamsizlikId",
                table: "Ogrenciler",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Dersler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 13, 27, 19, 71, DateTimeKind.Local).AddTicks(6340),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 19, 13, 41, 38, 879, DateTimeKind.Local).AddTicks(7397));

            migrationBuilder.AddColumn<int>(
                name: "DersSinavProgramiId",
                table: "Dersler",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Danismanlar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 21, 13, 27, 19, 71, DateTimeKind.Local).AddTicks(2494),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 19, 13, 41, 38, 879, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.AddColumn<int>(
                name: "DevamsizlikId",
                table: "Danismanlar",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bolumler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolumId = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    BolumAdi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 21, 13, 27, 19, 70, DateTimeKind.Local).AddTicks(6666))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolumler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Branslar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BransId = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    BransAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 21, 13, 27, 19, 70, DateTimeKind.Local).AddTicks(9637))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branslar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DersSinavProgramlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SinavTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 21, 13, 27, 19, 71, DateTimeKind.Local).AddTicks(9165))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersSinavProgramlari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Devamsizliklar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DevamsizlikTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DevamsizlikSayisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 21, 13, 27, 19, 72, DateTimeKind.Local).AddTicks(1228))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devamsizliklar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DanismanDersSinavProgrami",
                columns: table => new
                {
                    DanismanlarId = table.Column<int>(type: "int", nullable: false),
                    DersSinavProgramlariId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanismanDersSinavProgrami", x => new { x.DanismanlarId, x.DersSinavProgramlariId });
                    table.ForeignKey(
                        name: "FK_DanismanDersSinavProgrami_Danismanlar_DanismanlarId",
                        column: x => x.DanismanlarId,
                        principalTable: "Danismanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DanismanDersSinavProgrami_DersSinavProgramlari_DersSinavProgramlariId",
                        column: x => x.DersSinavProgramlariId,
                        principalTable: "DersSinavProgramlari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_DanismanId",
                table: "Ogrenciler",
                column: "DanismanId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_DevamsizlikId",
                table: "Ogrenciler",
                column: "DevamsizlikId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_Password",
                table: "Ogrenciler",
                column: "Password",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dersler_DersSinavProgramiId",
                table: "Dersler",
                column: "DersSinavProgramiId");

            migrationBuilder.CreateIndex(
                name: "IX_Danismanlar_DevamsizlikId",
                table: "Danismanlar",
                column: "DevamsizlikId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bolumler_BolumAdi",
                table: "Bolumler",
                column: "BolumAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bolumler_BolumId",
                table: "Bolumler",
                column: "BolumId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Branslar_BransAdi",
                table: "Branslar",
                column: "BransAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Branslar_BransId",
                table: "Branslar",
                column: "BransId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DanismanDersSinavProgrami_DersSinavProgramlariId",
                table: "DanismanDersSinavProgrami",
                column: "DersSinavProgramlariId");

            migrationBuilder.AddForeignKey(
                name: "FK_Danismanlar_Devamsizliklar_DevamsizlikId",
                table: "Danismanlar",
                column: "DevamsizlikId",
                principalTable: "Devamsizliklar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dersler_DersSinavProgramlari_DersSinavProgramiId",
                table: "Dersler",
                column: "DersSinavProgramiId",
                principalTable: "DersSinavProgramlari",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenciler_Danismanlar_DanismanId",
                table: "Ogrenciler",
                column: "DanismanId",
                principalTable: "Danismanlar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenciler_Devamsizliklar_DevamsizlikId",
                table: "Ogrenciler",
                column: "DevamsizlikId",
                principalTable: "Devamsizliklar",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Danismanlar_Devamsizliklar_DevamsizlikId",
                table: "Danismanlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Dersler_DersSinavProgramlari_DersSinavProgramiId",
                table: "Dersler");

            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenciler_Danismanlar_DanismanId",
                table: "Ogrenciler");

            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenciler_Devamsizliklar_DevamsizlikId",
                table: "Ogrenciler");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Bolumler");

            migrationBuilder.DropTable(
                name: "Branslar");

            migrationBuilder.DropTable(
                name: "DanismanDersSinavProgrami");

            migrationBuilder.DropTable(
                name: "Devamsizliklar");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "DersSinavProgramlari");

            migrationBuilder.DropIndex(
                name: "IX_Ogrenciler_DanismanId",
                table: "Ogrenciler");

            migrationBuilder.DropIndex(
                name: "IX_Ogrenciler_DevamsizlikId",
                table: "Ogrenciler");

            migrationBuilder.DropIndex(
                name: "IX_Ogrenciler_Password",
                table: "Ogrenciler");

            migrationBuilder.DropIndex(
                name: "IX_Dersler_DersSinavProgramiId",
                table: "Dersler");

            migrationBuilder.DropIndex(
                name: "IX_Danismanlar_DevamsizlikId",
                table: "Danismanlar");

            migrationBuilder.DropColumn(
                name: "DanismanId",
                table: "Ogrenciler");

            migrationBuilder.DropColumn(
                name: "DevamsizlikId",
                table: "Ogrenciler");

            migrationBuilder.DropColumn(
                name: "DersSinavProgramiId",
                table: "Dersler");

            migrationBuilder.DropColumn(
                name: "DevamsizlikId",
                table: "Danismanlar");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Ogrenciler",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Ogrenciler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 19, 13, 41, 38, 880, DateTimeKind.Local).AddTicks(9),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 13, 27, 19, 72, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Dersler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 19, 13, 41, 38, 879, DateTimeKind.Local).AddTicks(7397),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 13, 27, 19, 71, DateTimeKind.Local).AddTicks(6340));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Danismanlar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 19, 13, 41, 38, 879, DateTimeKind.Local).AddTicks(3907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 21, 13, 27, 19, 71, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.CreateTable(
                name: "Roller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 19, 13, 41, 38, 880, DateTimeKind.Local).AddTicks(3378)),
                    RolAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roller", x => x.Id);
                });
        }
    }
}
