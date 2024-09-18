using KWApp.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KWYonetimApp
{
	public partial class FormApp : Form
	{
		public FormApp()
		{
			InitializeComponent();
		}
		private void IlanlariGetir()
		{
			KWYonetimAppDbContext context = new KWYonetimAppDbContext();
			listİlanlar.Clear();

			listİlanlar.Columns.Add("Ilan No", 100);
			listİlanlar.Columns.Add("Ilan Adı", 150);
			listİlanlar.Columns.Add("Çalışan ID", 50);
			listİlanlar.Columns.Add("Çalışan Adı Soyadı", 150);
			listİlanlar.Columns.Add("Satıcı ID", 50);
			listİlanlar.Columns.Add("Satıcı Adı Soyadı", 150);
			listİlanlar.Columns.Add("Açıklama", 150);
			listİlanlar.Columns.Add("Tarih", 100);
			listİlanlar.Columns.Add("Adres", 100);
			listİlanlar.Columns.Add("Tür ID", 50);
			listİlanlar.Columns.Add("Tür", 150);
			listİlanlar.Columns.Add("İçerik ID", 50);
			listİlanlar.Columns.Add("İçerik", 150);
			listİlanlar.Columns.Add("Fiyat", 100);

			var ilanlar = context.Ilanlar.Include(a => a.IlanSahibiMusteri).Include(a => a.IlanSorumlusuCalisan).Include(a => a.IlanTuru).Include(a => a.IlanIcerigi).ToList();
			foreach (var ilan in ilanlar)
			{
				var musteriAdSoyad = $"{ilan.IlanSahibiMusteri.Ad} {ilan.IlanSahibiMusteri.Soyad}";
				var calisanAdSoyad = $"{ilan.IlanSorumlusuCalisan.Ad} " +
					$"{ilan.IlanSorumlusuCalisan.Soyad}";
				var ilanturu = $"{ilan.IlanTuru.IlanTuruAdi} ";
				var ilanicerigi = $"{ilan.IlanIcerigi.IlanIcerigiAdi} ";
				var item = new ListViewItem(Convert.ToString(ilan.IlanNo));
				item.SubItems.Add(ilan.IlanAdi);
				item.SubItems.Add(Convert.ToString(ilan.IlanSorumlusuCalisanID));
				item.SubItems.Add(calisanAdSoyad);
				item.SubItems.Add(Convert.ToString(ilan.IlanSahibiMusteriID));
				item.SubItems.Add(musteriAdSoyad);
				item.SubItems.Add(ilan.IlanAciklamasi);
				item.SubItems.Add(Convert.ToString(ilan.IlanTarihi));
				item.SubItems.Add(ilan.IlanAdresi);
				item.SubItems.Add(Convert.ToString(ilan.IlanTuruID));
				item.SubItems.Add(ilanturu);
				item.SubItems.Add(ilanicerigi);
				item.SubItems.Add(Convert.ToString(ilan.IlanIcerigiID));
				item.SubItems.Add(Convert.ToString(ilan.IlanFiyati));
				listİlanlar.Items.Add(item);
			}
			comboBoxIlanlar.Items.Clear();
			comboBoxIlanlar2.Items.Clear();
			foreach (var ilan in ilanlar)
			{
				comboBoxIlanlar.Items.Add(ilan.IlanNo);
				comboBoxIlanlar2.Items.Add(ilan.IlanNo);
			}
			for (int i = 0; i < ilanlar.Count; i++)
			{
				if (i % 2 == 0)
				{
					listİlanlar.Items[i].BackColor = Color.Coral;
				}
				else
				{
					listİlanlar.Items[i].BackColor = Color.MistyRose;
				}
			}
		}
		private void MusterileriGetir()
		{
			comboBoxMusteriIdleri.Items.Clear();
			KWYonetimAppDbContext context = new KWYonetimAppDbContext();
			listMusteriler.Clear();
			listMusteriler.Columns.Add("Müşteri ID", 50);
			listMusteriler.Columns.Add("Müşteri Tipi", 50);
			listMusteriler.Columns.Add("Ad", 100);
			listMusteriler.Columns.Add("Soyad", 100);
			listMusteriler.Columns.Add("Not", 150);
			listMusteriler.Columns.Add("Kayıt Tarihi", 100);
			listMusteriler.Columns.Add("Doğum Tarihi", 150);
			listMusteriler.Columns.Add("Adres", 100);
			listMusteriler.Columns.Add("Telefon", 100);
			listMusteriler.Columns.Add("Mail", 100);
			listMusteriler.Columns.Add("Aktiflik", 100);
			var musteriler = context.Musteriler.ToList();
			foreach (var musteri in musteriler)
			{
				var item = new ListViewItem(Convert.ToString(musteri.MusteriID));
				item.SubItems.Add(musteri.MusteriTipi);
				item.SubItems.Add(musteri.Ad);
				item.SubItems.Add(musteri.Soyad);
				item.SubItems.Add(musteri.MusteriNot);
				item.SubItems.Add(Convert.ToString(musteri.MusteriKayitTarihi));
				item.SubItems.Add(Convert.ToString(musteri.DogumTarihi));
				item.SubItems.Add(musteri.Adres);
				item.SubItems.Add(Convert.ToString(musteri.TelefonNumarasi));
				item.SubItems.Add(musteri.MailAdresi);
				item.SubItems.Add(Convert.ToString(musteri.Aktiflik));
				listMusteriler.Items.Add(item);
			}
			var musteriidleri = context.Musteriler.Select(a => a.MusteriID);
			foreach (var item in musteriidleri)
			{
				comboBoxMusteriIdleri.Items.Add(item);
				comboBoxGMusteriID.Items.Add(item);
			}
			for (int i = 0; i < musteriler.Count; i++)
			{
				if (i % 2 == 0)
				{
					listMusteriler.Items[i].BackColor = Color.Coral;
				}
				else
				{
					listMusteriler.Items[i].BackColor = Color.MistyRose;
				}
			}

		}
		private void GorusmeleriGetir()
		{
			KWYonetimAppDbContext context = new KWYonetimAppDbContext();
			listGorusmeler.Clear();
			listGorusmeler.Columns.Add("Görüşme ID", 50);
			listGorusmeler.Columns.Add("Müşteri ID", 50);
			listGorusmeler.Columns.Add("Müşteri Ad Soyad", 150);
			listGorusmeler.Columns.Add("Çalışan ID", 50);
			listGorusmeler.Columns.Add("Çalışan Ad Soyad", 150);
			listGorusmeler.Columns.Add("Görüşme Konusu", 250);
			listGorusmeler.Columns.Add("Görüşme Notu", 250);
			listGorusmeler.Columns.Add("Görüşme Tarihi", 150);
			var gorusmeler = context.Gorusmeler.Include(g => g.Musteri).Include(g => g.Calisan).ToList();
			foreach (var gorusme in gorusmeler)
			{
				var musteriAdSoyad = $"{gorusme.Musteri.Ad} {gorusme.Musteri.Soyad}";
				var calisanAdSoyad = $"{gorusme.Calisan.Ad} {gorusme.Calisan.Soyad}";
				var item = new ListViewItem(Convert.ToString(gorusme.MusteriID));
				item.SubItems.Add(Convert.ToString(gorusme.MusteriID));
				item.SubItems.Add(musteriAdSoyad);
				item.SubItems.Add(Convert.ToString(gorusme.CalisanID));
				item.SubItems.Add(calisanAdSoyad);
				item.SubItems.Add(gorusme.GorusmeKonusu);
				item.SubItems.Add(gorusme.GorusmeNotu);
				item.SubItems.Add(Convert.ToString(gorusme.GorusmeTarihi));
				listGorusmeler.Items.Add(item);
			}
			for (int i = 0; i < gorusmeler.Count; i++)
			{
				if (i % 2 == 0)
				{
					listGorusmeler.Items[i].BackColor = Color.Coral;
				}
				else
				{
					listGorusmeler.Items[i].BackColor = Color.MistyRose;
				}
			}
		}

		private void FormApp_Load(object sender, EventArgs e)
		{
			KWYonetimAppDbContext context = new KWYonetimAppDbContext();
			tabPage1.Text = "İlanlar";
			tabPage2.Text = "Müşteriler";
			tabPage3.Text = "Görüşmeler";

			IlanlariGetir();
			MusterileriGetir();
			GorusmeleriGetir();
			var ilanidleri = context.Ilanlar.Select(i => i.IlanNo);

			var sehirler = context.Adresler.Select(a => a.AdresAdi);
			foreach (var sehir in sehirler)
			{
				comboBoxAdresG.Items.Add(sehir);
			}
			foreach (var sehir in sehirler)
			{
				comboBoxAdresE.Items.Add(sehir);
			}
			foreach (var sehir in sehirler)
			{
				comboBoxMusteriAdres.Items.Add(sehir);
			}
			var calisanidleri = context.Calisanlar.Select(a => a.CalisanID);
			foreach (var item in calisanidleri)
			{
				comboBoxGCalisanID.Items.Add(item);
			}


		}

		private void listİlanlar_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBoxIlanlar_SelectedIndexChanged(object sender, EventArgs e)
		{

			groupBoxDegisiklikler.Visible = true;
			groupBoxEkle.Visible = false;
			
		}

		private void buttonİlanEkle_Click(object sender, EventArgs e)
		{
			groupBoxEkle.Visible = true;
			groupBoxDegisiklikler.Visible = false;
		}

		private void buttonGuncelle_Click(object sender, EventArgs e)
		{
			if (textBoxIlanAdiG.Text != "")
			{
				if (textBoxCalisanIDG.Text != "")
				{
					if (textBoxMusteriIDG.Text != "")
					{
						if (textBoxAciklamaG.Text != "")
						{
							if (comboBoxAdresG.Text != "")
							{
								if (textBoxIlanNumarasıG.Text != "")
								{
									if (textBoxIlanTuruIDG.Text != "")
									{
										if (textBoxIlanIcerigiG.Text != "")
										{
											if (textBoxFiyatG.Text != "")
											{
												KWYonetimAppDbContext context = new KWYonetimAppDbContext();
												long id = Convert.ToInt64(comboBoxIlanlar.Text);
												int calisanid = Convert.ToInt32(textBoxCalisanIDG.Text);
												int musteriid = Convert.ToInt32(textBoxMusteriIDG.Text);
												long ilanno = Convert.ToInt64(textBoxIlanNumarasıG.Text);
												int ilanturuid = Convert.ToInt32(textBoxIlanIcerigiG.Text);
												int ilanicerigiid = Convert.ToInt32(textBoxIlanIcerigiG.Text);
												long fiyat = Convert.ToInt64(textBoxFiyatG.Text);
												var degisecekilan = context.Ilanlar.SingleOrDefault(a => a.IlanNo == id);
												degisecekilan.IlanAdi = textBoxIlanAdiG.Text;
												degisecekilan.IlanSorumlusuCalisanID = calisanid;
												degisecekilan.IlanSahibiMusteriID = musteriid;
												degisecekilan.IlanAciklamasi = textBoxAciklamaG.Text;
												degisecekilan.IlanAdresi = comboBoxAdresG.Text;
												degisecekilan.IlanNo = ilanno;
												degisecekilan.IlanTuruID = ilanturuid;
												degisecekilan.IlanIcerigiID = ilanicerigiid;
												degisecekilan.IlanFiyati = fiyat;
												context.SaveChanges();
												MessageBox.Show("İlan başarıyla güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
											}
											IlanlariGetir();
											textBoxIlanAdiG.Text = "";
											textBoxMusteriIDG.Text = "";
											textBoxMusteriIDG.Text = "";
											textBoxAciklamaG.Text = "";
											comboBoxAdresG.Text = "";
											textBoxIlanNumarasıG.Text = "";
											textBoxIlanTuruIDG.Text = "";
											textBoxIlanIcerigiG.Text = "";
											textBoxFiyatG.Text = "";
										}
										else
										{
											MessageBox.Show("İlan içeriği ID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
										}
									}
									else
									{
										MessageBox.Show("İlan türü ID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
									}
								}
								else
								{
									MessageBox.Show("İlan numarası giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
								}
							}
							else
							{
								MessageBox.Show("Adres seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
						else
						{
							MessageBox.Show("Açıklama giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					else
					{
						MessageBox.Show("Müşteri ID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBox.Show("Çalışan ID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("İlan adı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBoxIlanAdiE.Text != "")
			{
				if (textBoxCalisanIDE.Text != "")
				{
					if (textBoxSaticiIDE.Text != "")
					{
						if (textBoxAciklamaE.Text != "")
						{
							if (comboBoxAdresE.Text != "")
							{
								if (textBoxIlanIDE.Text != "")
								{
									if (textBoxIlanTuruIDE.Text != "")
									{
										if (textBoxIlanIcerigiIDE.Text != "")
										{
											if (textBoxFiyatE.Text != "")
											{
												KWYonetimAppDbContext context = new KWYonetimAppDbContext();
												long id = Convert.ToInt64(textBoxIlanIDE.Text);
												int calisanid = Convert.ToInt32(textBoxCalisanIDE.Text);
												int musteriid = Convert.ToInt32(textBoxSaticiIDE.Text);
												long ilanno = Convert.ToInt64(textBoxIlanIcerigiIDE.Text);
												int ilanturuid = Convert.ToInt32(textBoxIlanTuruIDE.Text);
												int ilanicerigiid = Convert.ToInt32(textBoxIlanIcerigiIDE.Text);
												long fiyat = Convert.ToInt64(textBoxFiyatE.Text);
												Ilan ilan = new Ilan()
												{
													IlanAdi = textBoxIlanAdiE.Text,
													IlanSorumlusuCalisanID = calisanid,
													IlanSahibiMusteriID = musteriid,
													IlanAciklamasi = textBoxAciklamaE.Text,
													IlanAdresi = comboBoxAdresE.Text,
													IlanNo = ilanno,
													IlanTuruID = ilanturuid,
													IlanIcerigiID = ilanicerigiid,
													IlanFiyati = fiyat,
													IlanTarihi = DateTime.Now
												};
												context.Ilanlar.Add(ilan);
												context.SaveChanges();
												MessageBox.Show("İlan başarıyla eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
												IlanlariGetir();
												textBoxIlanAdiE.Text = "";
												textBoxAciklamaE.Text = "";
												textBoxCalisanIDE.Text = "";
												textBoxSaticiIDE.Text = "";
												textBoxAciklamaE.Text = "";
												comboBoxAdresE.Text = "";
												textBoxIlanIDE.Text = "";
												textBoxIlanTuruIDE.Text = "";
												textBoxIlanIcerigiIDE.Text = "";
												textBoxFiyatE.Text = "";
											}
										}
									}
									else
									{
										MessageBox.Show("İlan içeriği ID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
									}
								}
								else
								{
									MessageBox.Show("İlan türü ID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
								}
							}
							else
							{
								MessageBox.Show("İlan numarası giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
						else
						{
							MessageBox.Show("Adres seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					else
					{
						MessageBox.Show("Açıklama giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBox.Show("Müşteri ID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Çalışan ID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonKaldir_Click(object sender, EventArgs e)
		{
			KWYonetimAppDbContext context = new KWYonetimAppDbContext();
			long kaldirilacakilan = Convert.ToInt64(comboBoxIlanlar2.Text);
			var silinecekilan = context.Ilanlar.SingleOrDefault(x => x.IlanNo == kaldirilacakilan);
			context.Ilanlar.Remove(silinecekilan);
			context.SaveChanges();
			MessageBox.Show("İlan başarıyla kaldırıldı.","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
			comboBoxIlanlar2.Text = "";
			IlanlariGetir();
		}

		private void comboBoxMusteriler_SelectedValueChanged(object sender, EventArgs e)
		{

		}

		private void buttonMusteriEkle_Click(object sender, EventArgs e)
		{
			if (comboBoxMusteriTipi.Text != "")
			{
				if (textBoxMusteriAdi.Text != "")
				{
					if (textBoxMusteriSoyadi.Text != "")
					{
						if (textBoxNot.Text != "")
						{
							if (dateTimePickerMusteriDogumTarihi.Value != DateTime.Now)
							{
								if (comboBoxMusteriAdres.Text != "")
								{
									if (textBoxMusteriTelefon.Text != "")
									{
										if (textBoxMusteriMail.Text != "")
										{
											if (comboBoxMusteriAktiflik.Text != "")
											{
												KWYonetimAppDbContext context = new KWYonetimAppDbContext();
												string musteritipi = comboBoxMusteriTipi.Text;
												string musteriadi = textBoxMusteriAdi.Text;
												string musterisoyadi = textBoxMusteriSoyadi.Text;
												DateTime musteridogumtarihi = dateTimePickerMusteriDogumTarihi.Value;
												DateTime musterikayittarihi = DateTime.Now;
												string musteriadresi = comboBoxMusteriAdres.Text;
												long musteritelefonno = Convert.ToInt64(textBoxMusteriTelefon.Text);
												string musterimailadresi = textBoxMusteriMail.Text;
												bool musteriaktiflik = Convert.ToBoolean(comboBoxMusteriAktiflik.Text);
												Musteri musteri = new Musteri()
												{
													MusteriTipi = comboBoxMusteriTipi.Text,
													Ad = textBoxMusteriAdi.Text,
													Soyad = textBoxMusteriSoyadi.Text,
													DogumTarihi = dateTimePickerMusteriDogumTarihi.Value,
													MusteriKayitTarihi = DateTime.Now,
													Adres = comboBoxMusteriAdres.Text,
													MusteriNot = textBoxNot.Text,
													TelefonNumarasi = musteritelefonno,
													MailAdresi = textBoxMusteriMail.Text,
													Aktiflik = musteriaktiflik
												};
												context.Musteriler.Add(musteri);
												context.SaveChanges();
												MessageBox.Show("Kayıt başarıyla eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
												comboBoxMusteriTipi.Text = "";
												textBoxMusteriAdi.Text = "";
												textBoxMusteriSoyadi.Text = "";
												dateTimePickerMusteriDogumTarihi.Value = DateTime.Now;
												comboBoxMusteriAdres.Text = "";
												textBoxMusteriTelefon.Text = "";
												textBoxMusteriMail.Text = "";
												comboBoxMusteriAktiflik.Text = "";
												MusterileriGetir();
											}

											else
											{
												MessageBox.Show("Lütfen müşteri aktifliğini belirtiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
											}
										}
										else
										{
											MessageBox.Show("Lütfen müşteri mail adresi giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
										}
									}
									else
									{
										MessageBox.Show("Lütfen müşteri telefon numarası giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
									}
								}
								else
								{
									MessageBox.Show("Lütfen müşteri adresi giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
								}
							}
							else
							{
								MessageBox.Show("Lütfen müşteri doğum tarihi giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
						else
						{
							MessageBox.Show("Lütfen not giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					else
					{
						MessageBox.Show("Lütfen müşteri soyadı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBox.Show("Lütfen müşteri adı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Lütfen müşteri tipi seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonKaldır_Click(object sender, EventArgs e)
		{
			if (comboBoxMusteriIdleri.Text != "")
			{
				KWYonetimAppDbContext context = new KWYonetimAppDbContext();
				long silinecekmusteriid = Convert.ToInt64(comboBoxMusteriIdleri.Text);
				var silinecekmusteri = context.Musteriler.SingleOrDefault(a => a.MusteriID == silinecekmusteriid);
				context.Musteriler.Remove(silinecekmusteri);
				context.SaveChanges();
				MessageBox.Show("Kayıt başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
				comboBoxMusteriIdleri.Text = "";
				MusterileriGetir();
			}
			else
			{
				MessageBox.Show("Silinecek müşteri ID seçilmedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonGorusmeEkle_Click(object sender, EventArgs e)
		{
			if (comboBoxGMusteriID.Text != "")
			{
				if (comboBoxGCalisanID.Text != "")
				{
					if (textBoxGorusmeKonusu.Text != "")
					{
						if (textBoxGorusmeNotu.Text != "")
						{
							KWYonetimAppDbContext context = new KWYonetimAppDbContext();
							int musteriid = Convert.ToInt32(comboBoxGMusteriID.Text);
							int calisanid = Convert.ToInt32(comboBoxGCalisanID.Text);
							Gorusme gorusme = new Gorusme()
							{
								MusteriID = musteriid,
								CalisanID = calisanid,
								GorusmeKonusu = textBoxGorusmeKonusu.Text,
								GorusmeNotu = textBoxGorusmeNotu.Text,
								GorusmeTarihi = DateTime.Now
							};
							context.Gorusmeler.Add(gorusme);
							context.SaveChanges();
							MessageBox.Show("Görüşme kaydı başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
							GorusmeleriGetir();
							comboBoxGMusteriID.Text = "";
							comboBoxGCalisanID.Text = "";
							textBoxGorusmeKonusu.Text = "";
							textBoxGorusmeNotu.Text = "";
						}
						else
						{
							MessageBox.Show("Lütfen görüşme notu yazınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					else
					{
						MessageBox.Show("Lütfen görüşme konusunu belirtiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBox.Show("Lütfen Çalışan ID seçimi yapınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Lütfen Müşteri ID seçimi yapınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void comboBoxİlanlar2_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
	}
}
