using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWApp.Database
{
	public class KWYonetimAppDbContext : DbContext
	{
		public DbSet<Adres> Adresler { get; set; }
		public DbSet<Musteri> Musteriler { get; set; }
		public DbSet<Calisan> Calisanlar { get; set; }
		public DbSet<Ilan> Ilanlar { get; set; }
		public DbSet<Gorusme> Gorusmeler { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server = VSKB\\SQLEXPRESS01 ; Database = KWYonetimApp ; User ID = sa ; Password = 13125417 ; TrustServerCertificate = True");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Ilan>()
				.HasIndex(i => i.IlanNo)
				.IsUnique();
			modelBuilder.Entity<Ilan>()
	.Property(o => o.IlanNo)
	.ValueGeneratedNever();
			modelBuilder.Entity<Adres>().HasData(
	new Adres { AdresID = 1, AdresAdi = "Adana" },
	new Adres { AdresID = 2, AdresAdi = "Adıyaman" },
	new Adres { AdresID = 3, AdresAdi = "Afyonkarahisar" },
	new Adres { AdresID = 4, AdresAdi = "Ağrı" },
	new Adres { AdresID = 5, AdresAdi = "Amasya" },
	new Adres { AdresID = 6, AdresAdi = "Ankara" },
	new Adres { AdresID = 7, AdresAdi = "Antalya" },
	new Adres { AdresID = 8, AdresAdi = "Artvin" },
	new Adres { AdresID = 9, AdresAdi = "Aydın" },
	new Adres { AdresID = 10, AdresAdi = "Balıkesir" },
	new Adres { AdresID = 11, AdresAdi = "Bilecik" },
	new Adres { AdresID = 12, AdresAdi = "Bingöl" },
	new Adres { AdresID = 13, AdresAdi = "Bitlis" },
	new Adres { AdresID = 14, AdresAdi = "Bolu" },
	new Adres { AdresID = 15, AdresAdi = "Burdur" },
	new Adres { AdresID = 16, AdresAdi = "Bursa" },
	new Adres { AdresID = 17, AdresAdi = "Çanakkale" },
	new Adres { AdresID = 18, AdresAdi = "Çankırı" },
	new Adres { AdresID = 19, AdresAdi = "Çorum" },
	new Adres { AdresID = 20, AdresAdi = "Denizli" },
	new Adres { AdresID = 21, AdresAdi = "Diyarbakır" },
	new Adres { AdresID = 22, AdresAdi = "Edirne" },
	new Adres { AdresID = 23, AdresAdi = "Elazığ" },
	new Adres { AdresID = 24, AdresAdi = "Erzincan" },
	new Adres { AdresID = 25, AdresAdi = "Erzurum" },
	new Adres { AdresID = 26, AdresAdi = "Eskişehir" },
	new Adres { AdresID = 27, AdresAdi = "Gaziantep" },
	new Adres { AdresID = 28, AdresAdi = "Giresun" },
	new Adres { AdresID = 29, AdresAdi = "Gümüşhane" },
	new Adres { AdresID = 30, AdresAdi = "Hakkari" },
	new Adres { AdresID = 31, AdresAdi = "Hatay" },
	new Adres { AdresID = 32, AdresAdi = "Isparta" },
	new Adres { AdresID = 33, AdresAdi = "Mersin" },
	new Adres { AdresID = 34, AdresAdi = "İstanbul" },
	new Adres { AdresID = 35, AdresAdi = "İzmir" },
	new Adres { AdresID = 36, AdresAdi = "Kars" },
	new Adres { AdresID = 37, AdresAdi = "Kastamonu" },
	new Adres { AdresID = 38, AdresAdi = "Kayseri" },
	new Adres { AdresID = 39, AdresAdi = "Kırklareli" },
	new Adres { AdresID = 40, AdresAdi = "Kırşehir" },
	new Adres { AdresID = 41, AdresAdi = "Kocaeli" },
	new Adres { AdresID = 42, AdresAdi = "Konya" },
	new Adres { AdresID = 43, AdresAdi = "Kütahya" },
	new Adres { AdresID = 44, AdresAdi = "Malatya" },
	new Adres { AdresID = 45, AdresAdi = "Manisa" },
	new Adres { AdresID = 46, AdresAdi = "Kahramanmaraş" },
	new Adres { AdresID = 47, AdresAdi = "Mardin" },
	new Adres { AdresID = 48, AdresAdi = "Muğla" },
	new Adres { AdresID = 49, AdresAdi = "Muş" },
	new Adres { AdresID = 50, AdresAdi = "Nevşehir" },
	new Adres { AdresID = 51, AdresAdi = "Niğde" },
	new Adres { AdresID = 52, AdresAdi = "Ordu" },
	new Adres { AdresID = 53, AdresAdi = "Rize" },
	new Adres { AdresID = 54, AdresAdi = "Sakarya" },
	new Adres { AdresID = 55, AdresAdi = "Samsun" },
	new Adres { AdresID = 56, AdresAdi = "Siirt" },
	new Adres { AdresID = 57, AdresAdi = "Sinop" },
	new Adres { AdresID = 58, AdresAdi = "Sivas" },
	new Adres { AdresID = 59, AdresAdi = "Tekirdağ" },
	new Adres { AdresID = 60, AdresAdi = "Tokat" },
	new Adres { AdresID = 61, AdresAdi = "Trabzon" },
	new Adres { AdresID = 62, AdresAdi = "Tunceli" },
	new Adres { AdresID = 63, AdresAdi = "Şanlıurfa" },
	new Adres { AdresID = 64, AdresAdi = "Uşak" },
	new Adres { AdresID = 65, AdresAdi = "Van" },
	new Adres { AdresID = 66, AdresAdi = "Yozgat" },
	new Adres { AdresID = 67, AdresAdi = "Zonguldak" },
	new Adres { AdresID = 68, AdresAdi = "Aksaray" },
	new Adres { AdresID = 69, AdresAdi = "Bayburt" },
	new Adres { AdresID = 70, AdresAdi = "Karaman" },
	new Adres { AdresID = 71, AdresAdi = "Kırıkkale" },
	new Adres { AdresID = 72, AdresAdi = "Batman" },
	new Adres { AdresID = 73, AdresAdi = "Şırnak" },
	new Adres { AdresID = 74, AdresAdi = "Bartın" },
	new Adres { AdresID = 75, AdresAdi = "Ardahan" },
	new Adres { AdresID = 76, AdresAdi = "Iğdır" },
	new Adres { AdresID = 77, AdresAdi = "Yalova" },
	new Adres { AdresID = 78, AdresAdi = "Karabük" },
	new Adres { AdresID = 79, AdresAdi = "Kilis" },
	new Adres { AdresID = 80, AdresAdi = "Osmaniye" },
	new Adres { AdresID = 81, AdresAdi = "Düzce" }
);
			modelBuilder.Entity<IlanTuru>().HasData(
	new IlanTuru { IlanTuruID = 1, IlanTuruAdi = "Satılık" },
	new IlanTuru { IlanTuruID = 2, IlanTuruAdi = "Kiralık" }
);

			modelBuilder.Entity<IlanIcerigi>().HasData(
				new IlanIcerigi { IlanIcerigiID = 1, IlanIcerigiAdi = "Konut" },
				new IlanIcerigi { IlanIcerigiID = 2, IlanIcerigiAdi = "Arsa" }
			);

			modelBuilder.Entity<Musteri>().HasData(
				new Musteri { MusteriID = 1, Ad = "Ahmet", Soyad = "Mehmet", Adres = "Çanakkale", MailAdresi = "ahmetmehmet@gmail.com", DogumTarihi = new DateTime(1970, 8, 3), MusteriKayitTarihi = DateTime.Now, MusteriTipi = "Alıcı", TelefonNumarasi = 5555555555, MusteriNot = "Müşteri 3+1 ev almak istiyor ve bütçesi 2400000 TL.", Aktiflik = true },
				new Musteri { MusteriID = 2, Ad = "Suat", Soyad = "Muat", Adres = "Balıkesir", MailAdresi = "suatmuat@gmail.com", DogumTarihi = new DateTime(1980, 5, 12), MusteriKayitTarihi = DateTime.Now, MusteriTipi = "Satıcı", TelefonNumarasi = 4444444444, MusteriNot = "Müşteri 2+1 ev satıyor.", Aktiflik = true },
				new Musteri { MusteriID = 3, Ad = "Hüsnü", Soyad = "Kuruntu", Adres = "Bursa", MailAdresi = "husnukuruntu@gmail.com", DogumTarihi = new DateTime(1965, 1, 30), MusteriKayitTarihi = DateTime.Now, MusteriTipi = "Satıcı", TelefonNumarasi = 3333333333, MusteriNot = "Müşteri 1+1 ev satıyor.", Aktiflik = true },
				new Musteri { MusteriID = 4, Ad = "Tuana", Soyad = "Buana", Adres = "İstanbul", MailAdresi = "tuanabuana@gmail.com", DogumTarihi = new DateTime(1995, 05, 05), MusteriKayitTarihi = DateTime.Now, MusteriTipi = "Alıcı", TelefonNumarasi = 2222222222, MusteriNot = "Müşteri 1+1 ev arıyor.", Aktiflik = true },
				new Musteri { MusteriID = 5, Ad = "Hasan", Soyad = "Kazan", Adres = "Edirne", MailAdresi = "hasankazan@gmail.com", DogumTarihi = new DateTime(1992,12,4), MusteriKayitTarihi = DateTime.Now, MusteriTipi = "Satıcı", TelefonNumarasi = 1111111111, MusteriNot = "Müşteri 2+1 ev satıyor.", Aktiflik = true },
				new Musteri { MusteriID = 6, Ad = "Kazım", Soyad = "Nazım", Adres = "Kocaeli", MailAdresi = "kazımnazım@gmail.com", DogumTarihi = new DateTime(1992, 12, 4), MusteriKayitTarihi = DateTime.Now, MusteriTipi = "Alıcı", TelefonNumarasi = 1111111111, MusteriNot = "Müşteri 2+1 ev almak istiyor.", Aktiflik = true }
			);

			modelBuilder.Entity<Calisan>().HasData(
				new Calisan { CalisanID = 1, Ad = "Volkan", Soyad = "Şen", Adres = "Çanakkale", MailAdresi = "volkansen1312@gmail.com", CalisanKayitTarihi = DateTime.Now, DogumTarihi = new DateTime(1998, 04, 08), Sifre = "54175417", TelefonNumarasi = 1234567890, Aktiflik = true },
				new Calisan { CalisanID = 2, Ad = "Ahmet", Soyad = "Zahmet", Adres = "Çanakkale", MailAdresi = "ahmetzahmet@gmail.com", CalisanKayitTarihi = DateTime.Now, DogumTarihi = new DateTime(2000, 12, 15), Sifre = "11111111", TelefonNumarasi = 0987654321, Aktiflik = false },
				new Calisan { CalisanID = 3, Ad = "Bilal", Soyad = "Uzun", Adres = "Çanakkale", MailAdresi = "bilaluzun@gmail.com", CalisanKayitTarihi = DateTime.Now, DogumTarihi = new DateTime(1996, 01, 28), Sifre = "22222222", TelefonNumarasi = 1234567890, Aktiflik = true }
			);

			modelBuilder.Entity<Ilan>().HasData(
				new Ilan
				{
					IlanID=1,
					IlanNo = 11111111,
					IlanAdi = "Bursada 1+1 ev",
					IlanAciklamasi = "Bursa'da 55 mkare ev",
					IlanAdresi = "Bursa",
					IlanIcerigiID = 1,  
					IlanTuruID = 1,  
					IlanFiyati = 2000000,
					IlanTarihi = DateTime.Now,
					IlanSahibiMusteriID = 3, 
					IlanSorumlusuCalisanID = 1  
				},
				new Ilan
				{
					IlanID = 2,
					IlanNo = 22222222,
					IlanAdi = "Balıkesir'de 2+1 ev",
					IlanAciklamasi = "Balıkesir'de 85 mkare ev",
					IlanAdresi = "Balıkesir",
					IlanIcerigiID = 1, 
					IlanTuruID = 1,  
					IlanFiyati = 2400000,
					IlanTarihi = DateTime.Now,
					IlanSahibiMusteriID = 2,  
					IlanSorumlusuCalisanID = 1  
				},
				new Ilan
				{
					IlanID = 3,
					IlanNo = 33333333,
					IlanAdi = "Kocaeli'de 2+1 ev",
					IlanAciklamasi = "Kocaeli'de 85 mkare ev",
					IlanAdresi = "Kocaeli",
					IlanIcerigiID = 1,
					IlanTuruID = 1,
					IlanFiyati = 3000000,
					IlanTarihi = DateTime.Now,
					IlanSahibiMusteriID = 5,
					IlanSorumlusuCalisanID = 3
				}
			);
			
			modelBuilder.Entity<Gorusme>().HasData(
				new Gorusme
				{
					GorusmeID = 1,
					MusteriID = 4,  
					CalisanID = 1,  
					GorusmeKonusu = "1+1 ev ilanı fiyat anlaşması",
					GorusmeNotu = "Müşteri indirim yapılmasını talep ediyor.",
					GorusmeTarihi = DateTime.Now
					
				},
				new Gorusme
				{
					GorusmeID = 2,
					MusteriID = 5,
					CalisanID = 3,
					GorusmeKonusu = "2+1 ev",
					GorusmeNotu = "Müşteri ilan fiyatına zam istiyor..",
					GorusmeTarihi=DateTime.Now
				}
			);


		}
	}
}
