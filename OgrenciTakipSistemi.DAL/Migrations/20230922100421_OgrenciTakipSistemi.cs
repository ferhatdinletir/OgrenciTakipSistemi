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
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 22, 13, 4, 21, 870, DateTimeKind.Local).AddTicks(7445))
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
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 22, 13, 4, 21, 871, DateTimeKind.Local).AddTicks(770))
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
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 22, 13, 4, 21, 872, DateTimeKind.Local).AddTicks(4039))
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
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 22, 13, 4, 21, 872, DateTimeKind.Local).AddTicks(6129))
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
                name: "Dersler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DersAciklama = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    DersSinavProgramiId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 22, 13, 4, 21, 871, DateTimeKind.Local).AddTicks(8492))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dersler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dersler_DersSinavProgramlari_DersSinavProgramiId",
                        column: x => x.DersSinavProgramiId,
                        principalTable: "DersSinavProgramlari",
                        principalColumn: "Id");
                });

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
                    DevamsizlikId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 22, 13, 4, 21, 871, DateTimeKind.Local).AddTicks(4021))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Danismanlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Danismanlar_Devamsizliklar_DevamsizlikId",
                        column: x => x.DevamsizlikId,
                        principalTable: "Devamsizliklar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DersNotlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    derslerId = table.Column<int>(type: "int", nullable: false),
                    DersId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vize = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Final = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 22, 13, 4, 21, 872, DateTimeKind.Local).AddTicks(1587))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersNotlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DersNotlar_Dersler_derslerId",
                        column: x => x.derslerId,
                        principalTable: "Dersler",
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
                    Password = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DanismanId = table.Column<int>(type: "int", nullable: true),
                    DevamsizlikId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 22, 13, 4, 21, 872, DateTimeKind.Local).AddTicks(8780))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenciler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ogrenciler_Danismanlar_DanismanId",
                        column: x => x.DanismanId,
                        principalTable: "Danismanlar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ogrenciler_Devamsizliklar_DevamsizlikId",
                        column: x => x.DevamsizlikId,
                        principalTable: "Devamsizliklar",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Danismanlar_DevamsizlikId",
                table: "Danismanlar",
                column: "DevamsizlikId");

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
                name: "IX_Dersler_DersSinavProgramiId",
                table: "Dersler",
                column: "DersSinavProgramiId");

            migrationBuilder.CreateIndex(
                name: "IX_DersNotlar_derslerId",
                table: "DersNotlar",
                column: "derslerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_DanismanId",
                table: "Ogrenciler",
                column: "DanismanId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_DevamsizlikId",
                table: "Ogrenciler",
                column: "DevamsizlikId");

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
                name: "IX_Ogrenciler_Password",
                table: "Ogrenciler",
                column: "Password",
                unique: true);

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
                name: "DersNotlar");

            migrationBuilder.DropTable(
                name: "Ogrenciler");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Dersler");

            migrationBuilder.DropTable(
                name: "Danismanlar");

            migrationBuilder.DropTable(
                name: "DersSinavProgramlari");

            migrationBuilder.DropTable(
                name: "Devamsizliklar");
        }
    }
}
