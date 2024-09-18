using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KWYonetimApp.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adresler",
                columns: table => new
                {
                    AdresID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdresAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresler", x => x.AdresID);
                });

            migrationBuilder.CreateTable(
                name: "Calisanlar",
                columns: table => new
                {
                    CalisanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CalisanKayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonNumarasi = table.Column<long>(type: "bigint", nullable: false),
                    MailAdresi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aktiflik = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calisanlar", x => x.CalisanID);
                });

            migrationBuilder.CreateTable(
                name: "IlanIcerigi",
                columns: table => new
                {
                    IlanIcerigiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanIcerigiAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IlanIcerigi", x => x.IlanIcerigiID);
                });

            migrationBuilder.CreateTable(
                name: "IlanTuru",
                columns: table => new
                {
                    IlanTuruID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanTuruAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IlanTuru", x => x.IlanTuruID);
                });

            migrationBuilder.CreateTable(
                name: "Musteriler",
                columns: table => new
                {
                    MusteriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriTipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MusteriNot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MusteriKayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonNumarasi = table.Column<long>(type: "bigint", nullable: false),
                    MailAdresi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aktiflik = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteriler", x => x.MusteriID);
                });

            migrationBuilder.CreateTable(
                name: "Gorusmeler",
                columns: table => new
                {
                    GorusmeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriID = table.Column<int>(type: "int", nullable: false),
                    CalisanID = table.Column<int>(type: "int", nullable: false),
                    GorusmeKonusu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GorusmeNotu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GorusmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gorusmeler", x => x.GorusmeID);
                    table.ForeignKey(
                        name: "FK_Gorusmeler_Calisanlar_CalisanID",
                        column: x => x.CalisanID,
                        principalTable: "Calisanlar",
                        principalColumn: "CalisanID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gorusmeler_Musteriler_MusteriID",
                        column: x => x.MusteriID,
                        principalTable: "Musteriler",
                        principalColumn: "MusteriID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ilanlar",
                columns: table => new
                {
                    IlanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanNo = table.Column<long>(type: "bigint", nullable: false),
                    IlanAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IlanSahibiMusteriID = table.Column<int>(type: "int", nullable: false),
                    IlanSorumlusuCalisanID = table.Column<int>(type: "int", nullable: false),
                    IlanAciklamasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IlanTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IlanAdresi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IlanTuruID = table.Column<int>(type: "int", nullable: false),
                    IlanIcerigiID = table.Column<int>(type: "int", nullable: false),
                    IlanFiyati = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilanlar", x => x.IlanID);
                    table.ForeignKey(
                        name: "FK_Ilanlar_Calisanlar_IlanSorumlusuCalisanID",
                        column: x => x.IlanSorumlusuCalisanID,
                        principalTable: "Calisanlar",
                        principalColumn: "CalisanID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ilanlar_IlanIcerigi_IlanIcerigiID",
                        column: x => x.IlanIcerigiID,
                        principalTable: "IlanIcerigi",
                        principalColumn: "IlanIcerigiID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ilanlar_IlanTuru_IlanTuruID",
                        column: x => x.IlanTuruID,
                        principalTable: "IlanTuru",
                        principalColumn: "IlanTuruID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ilanlar_Musteriler_IlanSahibiMusteriID",
                        column: x => x.IlanSahibiMusteriID,
                        principalTable: "Musteriler",
                        principalColumn: "MusteriID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Adresler",
                columns: new[] { "AdresID", "AdresAdi" },
                values: new object[,]
                {
                    { 1, "Adana" },
                    { 2, "Adıyaman" },
                    { 3, "Afyonkarahisar" },
                    { 4, "Ağrı" },
                    { 5, "Amasya" },
                    { 6, "Ankara" },
                    { 7, "Antalya" },
                    { 8, "Artvin" },
                    { 9, "Aydın" },
                    { 10, "Balıkesir" },
                    { 11, "Bilecik" },
                    { 12, "Bingöl" },
                    { 13, "Bitlis" },
                    { 14, "Bolu" },
                    { 15, "Burdur" },
                    { 16, "Bursa" },
                    { 17, "Çanakkale" },
                    { 18, "Çankırı" },
                    { 19, "Çorum" },
                    { 20, "Denizli" },
                    { 21, "Diyarbakır" },
                    { 22, "Edirne" },
                    { 23, "Elazığ" },
                    { 24, "Erzincan" },
                    { 25, "Erzurum" },
                    { 26, "Eskişehir" },
                    { 27, "Gaziantep" },
                    { 28, "Giresun" },
                    { 29, "Gümüşhane" },
                    { 30, "Hakkari" },
                    { 31, "Hatay" },
                    { 32, "Isparta" },
                    { 33, "Mersin" },
                    { 34, "İstanbul" },
                    { 35, "İzmir" },
                    { 36, "Kars" },
                    { 37, "Kastamonu" },
                    { 38, "Kayseri" },
                    { 39, "Kırklareli" },
                    { 40, "Kırşehir" },
                    { 41, "Kocaeli" },
                    { 42, "Konya" },
                    { 43, "Kütahya" },
                    { 44, "Malatya" },
                    { 45, "Manisa" },
                    { 46, "Kahramanmaraş" },
                    { 47, "Mardin" },
                    { 48, "Muğla" },
                    { 49, "Muş" },
                    { 50, "Nevşehir" },
                    { 51, "Niğde" },
                    { 52, "Ordu" },
                    { 53, "Rize" },
                    { 54, "Sakarya" },
                    { 55, "Samsun" },
                    { 56, "Siirt" },
                    { 57, "Sinop" },
                    { 58, "Sivas" },
                    { 59, "Tekirdağ" },
                    { 60, "Tokat" },
                    { 61, "Trabzon" },
                    { 62, "Tunceli" },
                    { 63, "Şanlıurfa" },
                    { 64, "Uşak" },
                    { 65, "Van" },
                    { 66, "Yozgat" },
                    { 67, "Zonguldak" },
                    { 68, "Aksaray" },
                    { 69, "Bayburt" },
                    { 70, "Karaman" },
                    { 71, "Kırıkkale" },
                    { 72, "Batman" },
                    { 73, "Şırnak" },
                    { 74, "Bartın" },
                    { 75, "Ardahan" },
                    { 76, "Iğdır" },
                    { 77, "Yalova" },
                    { 78, "Karabük" },
                    { 79, "Kilis" },
                    { 80, "Osmaniye" },
                    { 81, "Düzce" }
                });

            migrationBuilder.InsertData(
                table: "Calisanlar",
                columns: new[] { "CalisanID", "Ad", "Adres", "Aktiflik", "CalisanKayitTarihi", "DogumTarihi", "MailAdresi", "Sifre", "Soyad", "TelefonNumarasi" },
                values: new object[,]
                {
                    { 1, "Volkan", "Çanakkale", true, new DateTime(2024, 9, 18, 14, 13, 5, 908, DateTimeKind.Local).AddTicks(4429), new DateTime(1998, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "volkansen1312@gmail.com", "54175417", "Şen", 1234567890L },
                    { 2, "Ahmet", "Çanakkale", false, new DateTime(2024, 9, 18, 14, 13, 5, 908, DateTimeKind.Local).AddTicks(4434), new DateTime(2000, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ahmetzahmet@gmail.com", "11111111", "Zahmet", 987654321L },
                    { 3, "Bilal", "Çanakkale", true, new DateTime(2024, 9, 18, 14, 13, 5, 908, DateTimeKind.Local).AddTicks(4438), new DateTime(1996, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "bilaluzun@gmail.com", "22222222", "Uzun", 1234567890L }
                });

            migrationBuilder.InsertData(
                table: "IlanIcerigi",
                columns: new[] { "IlanIcerigiID", "IlanIcerigiAdi" },
                values: new object[,]
                {
                    { 1, "Konut" },
                    { 2, "Arsa" }
                });

            migrationBuilder.InsertData(
                table: "IlanTuru",
                columns: new[] { "IlanTuruID", "IlanTuruAdi" },
                values: new object[,]
                {
                    { 1, "Satılık" },
                    { 2, "Kiralık" }
                });

            migrationBuilder.InsertData(
                table: "Musteriler",
                columns: new[] { "MusteriID", "Ad", "Adres", "Aktiflik", "DogumTarihi", "MailAdresi", "MusteriKayitTarihi", "MusteriNot", "MusteriTipi", "Soyad", "TelefonNumarasi" },
                values: new object[,]
                {
                    { 1, "Ahmet", "Çanakkale", true, new DateTime(1970, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "ahmetmehmet@gmail.com", new DateTime(2024, 9, 18, 14, 13, 5, 908, DateTimeKind.Local).AddTicks(4360), "Müşteri 3+1 ev almak istiyor ve bütçesi 2400000 TL.", "Alıcı", "Mehmet", 5555555555L },
                    { 2, "Suat", "Balıkesir", true, new DateTime(1980, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "suatmuat@gmail.com", new DateTime(2024, 9, 18, 14, 13, 5, 908, DateTimeKind.Local).AddTicks(4380), "Müşteri 2+1 ev satıyor.", "Satıcı", "Muat", 4444444444L },
                    { 3, "Hüsnü", "Bursa", true, new DateTime(1965, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "husnukuruntu@gmail.com", new DateTime(2024, 9, 18, 14, 13, 5, 908, DateTimeKind.Local).AddTicks(4386), "Müşteri 1+1 ev satıyor.", "Satıcı", "Kuruntu", 3333333333L },
                    { 4, "Tuana", "İstanbul", true, new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "tuanabuana@gmail.com", new DateTime(2024, 9, 18, 14, 13, 5, 908, DateTimeKind.Local).AddTicks(4390), "Müşteri 1+1 ev arıyor.", "Alıcı", "Buana", 2222222222L },
                    { 5, "Hasan", "Edirne", true, new DateTime(1992, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "hasankazan@gmail.com", new DateTime(2024, 9, 18, 14, 13, 5, 908, DateTimeKind.Local).AddTicks(4394), "Müşteri 2+1 ev satıyor.", "Satıcı", "Kazan", 1111111111L },
                    { 6, "Kazım", "Kocaeli", true, new DateTime(1992, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "kazımnazım@gmail.com", new DateTime(2024, 9, 18, 14, 13, 5, 908, DateTimeKind.Local).AddTicks(4398), "Müşteri 2+1 ev almak istiyor.", "Alıcı", "Nazım", 1111111111L }
                });

            migrationBuilder.InsertData(
                table: "Gorusmeler",
                columns: new[] { "GorusmeID", "CalisanID", "GorusmeKonusu", "GorusmeNotu", "GorusmeTarihi", "MusteriID" },
                values: new object[,]
                {
                    { 1, 1, "1+1 ev ilanı fiyat anlaşması", "Müşteri indirim yapılmasını talep ediyor.", new DateTime(2024, 9, 18, 14, 13, 5, 908, DateTimeKind.Local).AddTicks(4504), 4 },
                    { 2, 3, "2+1 ev", "Müşteri ilan fiyatına zam istiyor..", new DateTime(2024, 9, 18, 14, 13, 5, 908, DateTimeKind.Local).AddTicks(4508), 5 }
                });

            migrationBuilder.InsertData(
                table: "Ilanlar",
                columns: new[] { "IlanID", "IlanAciklamasi", "IlanAdi", "IlanAdresi", "IlanFiyati", "IlanIcerigiID", "IlanNo", "IlanSahibiMusteriID", "IlanSorumlusuCalisanID", "IlanTarihi", "IlanTuruID" },
                values: new object[,]
                {
                    { 1, "Bursa'da 55 mkare ev", "Bursada 1+1 ev", "Bursa", 2000000f, 1, 11111111L, 3, 1, new DateTime(2024, 9, 18, 14, 13, 5, 908, DateTimeKind.Local).AddTicks(4466), 1 },
                    { 2, "Balıkesir'de 85 mkare ev", "Balıkesir'de 2+1 ev", "Balıkesir", 2400000f, 1, 22222222L, 2, 1, new DateTime(2024, 9, 18, 14, 13, 5, 908, DateTimeKind.Local).AddTicks(4471), 1 },
                    { 3, "Kocaeli'de 85 mkare ev", "Kocaeli'de 2+1 ev", "Kocaeli", 3000000f, 1, 33333333L, 5, 3, new DateTime(2024, 9, 18, 14, 13, 5, 908, DateTimeKind.Local).AddTicks(4475), 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gorusmeler_CalisanID",
                table: "Gorusmeler",
                column: "CalisanID");

            migrationBuilder.CreateIndex(
                name: "IX_Gorusmeler_MusteriID",
                table: "Gorusmeler",
                column: "MusteriID");

            migrationBuilder.CreateIndex(
                name: "IX_Ilanlar_IlanIcerigiID",
                table: "Ilanlar",
                column: "IlanIcerigiID");

            migrationBuilder.CreateIndex(
                name: "IX_Ilanlar_IlanNo",
                table: "Ilanlar",
                column: "IlanNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ilanlar_IlanSahibiMusteriID",
                table: "Ilanlar",
                column: "IlanSahibiMusteriID");

            migrationBuilder.CreateIndex(
                name: "IX_Ilanlar_IlanSorumlusuCalisanID",
                table: "Ilanlar",
                column: "IlanSorumlusuCalisanID");

            migrationBuilder.CreateIndex(
                name: "IX_Ilanlar_IlanTuruID",
                table: "Ilanlar",
                column: "IlanTuruID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adresler");

            migrationBuilder.DropTable(
                name: "Gorusmeler");

            migrationBuilder.DropTable(
                name: "Ilanlar");

            migrationBuilder.DropTable(
                name: "Calisanlar");

            migrationBuilder.DropTable(
                name: "IlanIcerigi");

            migrationBuilder.DropTable(
                name: "IlanTuru");

            migrationBuilder.DropTable(
                name: "Musteriler");
        }
    }
}
