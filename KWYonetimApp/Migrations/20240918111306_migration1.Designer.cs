﻿// <auto-generated />
using System;
using KWApp.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KWYonetimApp.Migrations
{
    [DbContext(typeof(KWYonetimAppDbContext))]
    [Migration("20240918111306_migration1")]
    partial class migration1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KWApp.Database.Adres", b =>
                {
                    b.Property<int>("AdresID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdresID"));

                    b.Property<string>("AdresAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdresID");

                    b.ToTable("Adresler");

                    b.HasData(
                        new
                        {
                            AdresID = 1,
                            AdresAdi = "Adana"
                        },
                        new
                        {
                            AdresID = 2,
                            AdresAdi = "Adıyaman"
                        },
                        new
                        {
                            AdresID = 3,
                            AdresAdi = "Afyonkarahisar"
                        },
                        new
                        {
                            AdresID = 4,
                            AdresAdi = "Ağrı"
                        },
                        new
                        {
                            AdresID = 5,
                            AdresAdi = "Amasya"
                        },
                        new
                        {
                            AdresID = 6,
                            AdresAdi = "Ankara"
                        },
                        new
                        {
                            AdresID = 7,
                            AdresAdi = "Antalya"
                        },
                        new
                        {
                            AdresID = 8,
                            AdresAdi = "Artvin"
                        },
                        new
                        {
                            AdresID = 9,
                            AdresAdi = "Aydın"
                        },
                        new
                        {
                            AdresID = 10,
                            AdresAdi = "Balıkesir"
                        },
                        new
                        {
                            AdresID = 11,
                            AdresAdi = "Bilecik"
                        },
                        new
                        {
                            AdresID = 12,
                            AdresAdi = "Bingöl"
                        },
                        new
                        {
                            AdresID = 13,
                            AdresAdi = "Bitlis"
                        },
                        new
                        {
                            AdresID = 14,
                            AdresAdi = "Bolu"
                        },
                        new
                        {
                            AdresID = 15,
                            AdresAdi = "Burdur"
                        },
                        new
                        {
                            AdresID = 16,
                            AdresAdi = "Bursa"
                        },
                        new
                        {
                            AdresID = 17,
                            AdresAdi = "Çanakkale"
                        },
                        new
                        {
                            AdresID = 18,
                            AdresAdi = "Çankırı"
                        },
                        new
                        {
                            AdresID = 19,
                            AdresAdi = "Çorum"
                        },
                        new
                        {
                            AdresID = 20,
                            AdresAdi = "Denizli"
                        },
                        new
                        {
                            AdresID = 21,
                            AdresAdi = "Diyarbakır"
                        },
                        new
                        {
                            AdresID = 22,
                            AdresAdi = "Edirne"
                        },
                        new
                        {
                            AdresID = 23,
                            AdresAdi = "Elazığ"
                        },
                        new
                        {
                            AdresID = 24,
                            AdresAdi = "Erzincan"
                        },
                        new
                        {
                            AdresID = 25,
                            AdresAdi = "Erzurum"
                        },
                        new
                        {
                            AdresID = 26,
                            AdresAdi = "Eskişehir"
                        },
                        new
                        {
                            AdresID = 27,
                            AdresAdi = "Gaziantep"
                        },
                        new
                        {
                            AdresID = 28,
                            AdresAdi = "Giresun"
                        },
                        new
                        {
                            AdresID = 29,
                            AdresAdi = "Gümüşhane"
                        },
                        new
                        {
                            AdresID = 30,
                            AdresAdi = "Hakkari"
                        },
                        new
                        {
                            AdresID = 31,
                            AdresAdi = "Hatay"
                        },
                        new
                        {
                            AdresID = 32,
                            AdresAdi = "Isparta"
                        },
                        new
                        {
                            AdresID = 33,
                            AdresAdi = "Mersin"
                        },
                        new
                        {
                            AdresID = 34,
                            AdresAdi = "İstanbul"
                        },
                        new
                        {
                            AdresID = 35,
                            AdresAdi = "İzmir"
                        },
                        new
                        {
                            AdresID = 36,
                            AdresAdi = "Kars"
                        },
                        new
                        {
                            AdresID = 37,
                            AdresAdi = "Kastamonu"
                        },
                        new
                        {
                            AdresID = 38,
                            AdresAdi = "Kayseri"
                        },
                        new
                        {
                            AdresID = 39,
                            AdresAdi = "Kırklareli"
                        },
                        new
                        {
                            AdresID = 40,
                            AdresAdi = "Kırşehir"
                        },
                        new
                        {
                            AdresID = 41,
                            AdresAdi = "Kocaeli"
                        },
                        new
                        {
                            AdresID = 42,
                            AdresAdi = "Konya"
                        },
                        new
                        {
                            AdresID = 43,
                            AdresAdi = "Kütahya"
                        },
                        new
                        {
                            AdresID = 44,
                            AdresAdi = "Malatya"
                        },
                        new
                        {
                            AdresID = 45,
                            AdresAdi = "Manisa"
                        },
                        new
                        {
                            AdresID = 46,
                            AdresAdi = "Kahramanmaraş"
                        },
                        new
                        {
                            AdresID = 47,
                            AdresAdi = "Mardin"
                        },
                        new
                        {
                            AdresID = 48,
                            AdresAdi = "Muğla"
                        },
                        new
                        {
                            AdresID = 49,
                            AdresAdi = "Muş"
                        },
                        new
                        {
                            AdresID = 50,
                            AdresAdi = "Nevşehir"
                        },
                        new
                        {
                            AdresID = 51,
                            AdresAdi = "Niğde"
                        },
                        new
                        {
                            AdresID = 52,
                            AdresAdi = "Ordu"
                        },
                        new
                        {
                            AdresID = 53,
                            AdresAdi = "Rize"
                        },
                        new
                        {
                            AdresID = 54,
                            AdresAdi = "Sakarya"
                        },
                        new
                        {
                            AdresID = 55,
                            AdresAdi = "Samsun"
                        },
                        new
                        {
                            AdresID = 56,
                            AdresAdi = "Siirt"
                        },
                        new
                        {
                            AdresID = 57,
                            AdresAdi = "Sinop"
                        },
                        new
                        {
                            AdresID = 58,
                            AdresAdi = "Sivas"
                        },
                        new
                        {
                            AdresID = 59,
                            AdresAdi = "Tekirdağ"
                        },
                        new
                        {
                            AdresID = 60,
                            AdresAdi = "Tokat"
                        },
                        new
                        {
                            AdresID = 61,
                            AdresAdi = "Trabzon"
                        },
                        new
                        {
                            AdresID = 62,
                            AdresAdi = "Tunceli"
                        },
                        new
                        {
                            AdresID = 63,
                            AdresAdi = "Şanlıurfa"
                        },
                        new
                        {
                            AdresID = 64,
                            AdresAdi = "Uşak"
                        },
                        new
                        {
                            AdresID = 65,
                            AdresAdi = "Van"
                        },
                        new
                        {
                            AdresID = 66,
                            AdresAdi = "Yozgat"
                        },
                        new
                        {
                            AdresID = 67,
                            AdresAdi = "Zonguldak"
                        },
                        new
                        {
                            AdresID = 68,
                            AdresAdi = "Aksaray"
                        },
                        new
                        {
                            AdresID = 69,
                            AdresAdi = "Bayburt"
                        },
                        new
                        {
                            AdresID = 70,
                            AdresAdi = "Karaman"
                        },
                        new
                        {
                            AdresID = 71,
                            AdresAdi = "Kırıkkale"
                        },
                        new
                        {
                            AdresID = 72,
                            AdresAdi = "Batman"
                        },
                        new
                        {
                            AdresID = 73,
                            AdresAdi = "Şırnak"
                        },
                        new
                        {
                            AdresID = 74,
                            AdresAdi = "Bartın"
                        },
                        new
                        {
                            AdresID = 75,
                            AdresAdi = "Ardahan"
                        },
                        new
                        {
                            AdresID = 76,
                            AdresAdi = "Iğdır"
                        },
                        new
                        {
                            AdresID = 77,
                            AdresAdi = "Yalova"
                        },
                        new
                        {
                            AdresID = 78,
                            AdresAdi = "Karabük"
                        },
                        new
                        {
                            AdresID = 79,
                            AdresAdi = "Kilis"
                        },
                        new
                        {
                            AdresID = 80,
                            AdresAdi = "Osmaniye"
                        },
                        new
                        {
                            AdresID = 81,
                            AdresAdi = "Düzce"
                        });
                });

            modelBuilder.Entity("KWApp.Database.Calisan", b =>
                {
                    b.Property<int>("CalisanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CalisanID"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Aktiflik")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CalisanKayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("MailAdresi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("TelefonNumarasi")
                        .HasColumnType("bigint");

                    b.HasKey("CalisanID");

                    b.ToTable("Calisanlar");

                    b.HasData(
                        new
                        {
                            CalisanID = 1,
                            Ad = "Volkan",
                            Adres = "Çanakkale",
                            Aktiflik = true,
                            CalisanKayitTarihi = new DateTime(2024, 9, 18, 14, 13, 5, 908, DateTimeKind.Local).AddTicks(4429),
                            DogumTarihi = new DateTime(1998, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MailAdresi = "volkansen1312@gmail.com",
                            Sifre = "54175417",
                            Soyad = "Şen",
                            TelefonNumarasi = 1234567890L
                        },
                        new
                        {
                            CalisanID = 2,
                            Ad = "Ahmet",
                            Adres = "Çanakkale",
                            Aktiflik = false,
                            CalisanKayitTarihi = new DateTime(2024, 9, 18, 14, 13, 5, 908, DateTimeKind.Local).AddTicks(4434),
                            DogumTarihi = new DateTime(2000, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MailAdresi = "ahmetzahmet@gmail.com",
                            Sifre = "11111111",
                            Soyad = "Zahmet",
                            TelefonNumarasi = 987654321L
                        },
                        new
                        {
                            CalisanID = 3,
                            Ad = "Bilal",
                            Adres = "Çanakkale",
                            Aktiflik = true,
                            CalisanKayitTarihi = new DateTime(2024, 9, 18, 14, 13, 5, 908, DateTimeKind.Local).AddTicks(4438),
                            DogumTarihi = new DateTime(1996, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MailAdresi = "bilaluzun@gmail.com",
                            Sifre = "22222222",
                            Soyad = "Uzun",
                            TelefonNumarasi = 1234567890L
                        });
                });

            modelBuilder.Entity("KWApp.Database.Gorusme", b =>
                {
                    b.Property<int>("GorusmeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GorusmeID"));

                    b.Property<int>("CalisanID")
                        .HasColumnType("int");

                    b.Property<string>("GorusmeKonusu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GorusmeNotu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GorusmeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("MusteriID")
                        .HasColumnType("int");

                    b.HasKey("GorusmeID");

                    b.HasIndex("CalisanID");

                    b.HasIndex("MusteriID");

                    b.ToTable("Gorusmeler");

                    b.HasData(
                        new
                        {
                            GorusmeID = 1,
                            CalisanID = 1,
                            GorusmeKonusu = "1+1 ev ilanı fiyat anlaşması",
                            GorusmeNotu = "Müşteri indirim yapılmasını talep ediyor.",
                            GorusmeTarihi = new DateTime(2024, 9, 18, 14, 13, 5, 908, DateTimeKind.Local).AddTicks(4504),
                            MusteriID = 4
                        },
                        new
                        {
                            GorusmeID = 2,
                            CalisanID = 3,
                            GorusmeKonusu = "2+1 ev",
                            GorusmeNotu = "Müşteri ilan fiyatına zam istiyor..",
                            GorusmeTarihi = new DateTime(2024, 9, 18, 14, 13, 5, 908, DateTimeKind.Local).AddTicks(4508),
                            MusteriID = 5
                        });
                });

            modelBuilder.Entity("KWApp.Database.Ilan", b =>
                {
                    b.Property<int>("IlanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IlanID"));

                    b.Property<string>("IlanAciklamasi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IlanAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IlanAdresi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("IlanFiyati")
                        .HasColumnType("real");

                    b.Property<int>("IlanIcerigiID")
                        .HasColumnType("int");

                    b.Property<long>("IlanNo")
                        .HasColumnType("bigint");

                    b.Property<int>("IlanSahibiMusteriID")
                        .HasColumnType("int");

                    b.Property<int>("IlanSorumlusuCalisanID")
                        .HasColumnType("int");

                    b.Property<DateTime>("IlanTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("IlanTuruID")
                        .HasColumnType("int");

                    b.HasKey("IlanID");

                    b.HasIndex("IlanIcerigiID");

                    b.HasIndex("IlanNo")
                        .IsUnique();

                    b.HasIndex("IlanSahibiMusteriID");

                    b.HasIndex("IlanSorumlusuCalisanID");

                    b.HasIndex("IlanTuruID");

                    b.ToTable("Ilanlar");

                    b.HasData(
                        new
                        {
                            IlanID = 1,
                            IlanAciklamasi = "Bursa'da 55 mkare ev",
                            IlanAdi = "Bursada 1+1 ev",
                            IlanAdresi = "Bursa",
                            IlanFiyati = 2000000f,
                            IlanIcerigiID = 1,
                            IlanNo = 11111111L,
                            IlanSahibiMusteriID = 3,
                            IlanSorumlusuCalisanID = 1,
                            IlanTarihi = new DateTime(2024, 9, 18, 14, 13, 5, 908, DateTimeKind.Local).AddTicks(4466),
                            IlanTuruID = 1
                        },
                        new
                        {
                            IlanID = 2,
                            IlanAciklamasi = "Balıkesir'de 85 mkare ev",
                            IlanAdi = "Balıkesir'de 2+1 ev",
                            IlanAdresi = "Balıkesir",
                            IlanFiyati = 2400000f,
                            IlanIcerigiID = 1,
                            IlanNo = 22222222L,
                            IlanSahibiMusteriID = 2,
                            IlanSorumlusuCalisanID = 1,
                            IlanTarihi = new DateTime(2024, 9, 18, 14, 13, 5, 908, DateTimeKind.Local).AddTicks(4471),
                            IlanTuruID = 1
                        },
                        new
                        {
                            IlanID = 3,
                            IlanAciklamasi = "Kocaeli'de 85 mkare ev",
                            IlanAdi = "Kocaeli'de 2+1 ev",
                            IlanAdresi = "Kocaeli",
                            IlanFiyati = 3000000f,
                            IlanIcerigiID = 1,
                            IlanNo = 33333333L,
                            IlanSahibiMusteriID = 5,
                            IlanSorumlusuCalisanID = 3,
                            IlanTarihi = new DateTime(2024, 9, 18, 14, 13, 5, 908, DateTimeKind.Local).AddTicks(4475),
                            IlanTuruID = 1
                        });
                });

            modelBuilder.Entity("KWApp.Database.IlanIcerigi", b =>
                {
                    b.Property<int>("IlanIcerigiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IlanIcerigiID"));

                    b.Property<string>("IlanIcerigiAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IlanIcerigiID");

                    b.ToTable("IlanIcerigi");

                    b.HasData(
                        new
                        {
                            IlanIcerigiID = 1,
                            IlanIcerigiAdi = "Konut"
                        },
                        new
                        {
                            IlanIcerigiID = 2,
                            IlanIcerigiAdi = "Arsa"
                        });
                });

            modelBuilder.Entity("KWApp.Database.IlanTuru", b =>
                {
                    b.Property<int>("IlanTuruID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IlanTuruID"));

                    b.Property<string>("IlanTuruAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IlanTuruID");

                    b.ToTable("IlanTuru");

                    b.HasData(
                        new
                        {
                            IlanTuruID = 1,
                            IlanTuruAdi = "Satılık"
                        },
                        new
                        {
                            IlanTuruID = 2,
                            IlanTuruAdi = "Kiralık"
                        });
                });

            modelBuilder.Entity("KWApp.Database.Musteri", b =>
                {
                    b.Property<int>("MusteriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MusteriID"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Aktiflik")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("MailAdresi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MusteriKayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("MusteriNot")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MusteriTipi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("TelefonNumarasi")
                        .HasColumnType("bigint");

                    b.HasKey("MusteriID");

                    b.ToTable("Musteriler");

                    b.HasData(
                        new
                        {
                            MusteriID = 1,
                            Ad = "Ahmet",
                            Adres = "Çanakkale",
                            Aktiflik = true,
                            DogumTarihi = new DateTime(1970, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MailAdresi = "ahmetmehmet@gmail.com",
                            MusteriKayitTarihi = new DateTime(2024, 9, 18, 14, 13, 5, 908, DateTimeKind.Local).AddTicks(4360),
                            MusteriNot = "Müşteri 3+1 ev almak istiyor ve bütçesi 2400000 TL.",
                            MusteriTipi = "Alıcı",
                            Soyad = "Mehmet",
                            TelefonNumarasi = 5555555555L
                        },
                        new
                        {
                            MusteriID = 2,
                            Ad = "Suat",
                            Adres = "Balıkesir",
                            Aktiflik = true,
                            DogumTarihi = new DateTime(1980, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MailAdresi = "suatmuat@gmail.com",
                            MusteriKayitTarihi = new DateTime(2024, 9, 18, 14, 13, 5, 908, DateTimeKind.Local).AddTicks(4380),
                            MusteriNot = "Müşteri 2+1 ev satıyor.",
                            MusteriTipi = "Satıcı",
                            Soyad = "Muat",
                            TelefonNumarasi = 4444444444L
                        },
                        new
                        {
                            MusteriID = 3,
                            Ad = "Hüsnü",
                            Adres = "Bursa",
                            Aktiflik = true,
                            DogumTarihi = new DateTime(1965, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MailAdresi = "husnukuruntu@gmail.com",
                            MusteriKayitTarihi = new DateTime(2024, 9, 18, 14, 13, 5, 908, DateTimeKind.Local).AddTicks(4386),
                            MusteriNot = "Müşteri 1+1 ev satıyor.",
                            MusteriTipi = "Satıcı",
                            Soyad = "Kuruntu",
                            TelefonNumarasi = 3333333333L
                        },
                        new
                        {
                            MusteriID = 4,
                            Ad = "Tuana",
                            Adres = "İstanbul",
                            Aktiflik = true,
                            DogumTarihi = new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MailAdresi = "tuanabuana@gmail.com",
                            MusteriKayitTarihi = new DateTime(2024, 9, 18, 14, 13, 5, 908, DateTimeKind.Local).AddTicks(4390),
                            MusteriNot = "Müşteri 1+1 ev arıyor.",
                            MusteriTipi = "Alıcı",
                            Soyad = "Buana",
                            TelefonNumarasi = 2222222222L
                        },
                        new
                        {
                            MusteriID = 5,
                            Ad = "Hasan",
                            Adres = "Edirne",
                            Aktiflik = true,
                            DogumTarihi = new DateTime(1992, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MailAdresi = "hasankazan@gmail.com",
                            MusteriKayitTarihi = new DateTime(2024, 9, 18, 14, 13, 5, 908, DateTimeKind.Local).AddTicks(4394),
                            MusteriNot = "Müşteri 2+1 ev satıyor.",
                            MusteriTipi = "Satıcı",
                            Soyad = "Kazan",
                            TelefonNumarasi = 1111111111L
                        },
                        new
                        {
                            MusteriID = 6,
                            Ad = "Kazım",
                            Adres = "Kocaeli",
                            Aktiflik = true,
                            DogumTarihi = new DateTime(1992, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MailAdresi = "kazımnazım@gmail.com",
                            MusteriKayitTarihi = new DateTime(2024, 9, 18, 14, 13, 5, 908, DateTimeKind.Local).AddTicks(4398),
                            MusteriNot = "Müşteri 2+1 ev almak istiyor.",
                            MusteriTipi = "Alıcı",
                            Soyad = "Nazım",
                            TelefonNumarasi = 1111111111L
                        });
                });

            modelBuilder.Entity("KWApp.Database.Gorusme", b =>
                {
                    b.HasOne("KWApp.Database.Calisan", "Calisan")
                        .WithMany()
                        .HasForeignKey("CalisanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KWApp.Database.Musteri", "Musteri")
                        .WithMany()
                        .HasForeignKey("MusteriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Calisan");

                    b.Navigation("Musteri");
                });

            modelBuilder.Entity("KWApp.Database.Ilan", b =>
                {
                    b.HasOne("KWApp.Database.IlanIcerigi", "IlanIcerigi")
                        .WithMany()
                        .HasForeignKey("IlanIcerigiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KWApp.Database.Musteri", "IlanSahibiMusteri")
                        .WithMany()
                        .HasForeignKey("IlanSahibiMusteriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KWApp.Database.Calisan", "IlanSorumlusuCalisan")
                        .WithMany()
                        .HasForeignKey("IlanSorumlusuCalisanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KWApp.Database.IlanTuru", "IlanTuru")
                        .WithMany()
                        .HasForeignKey("IlanTuruID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IlanIcerigi");

                    b.Navigation("IlanSahibiMusteri");

                    b.Navigation("IlanSorumlusuCalisan");

                    b.Navigation("IlanTuru");
                });
#pragma warning restore 612, 618
        }
    }
}
