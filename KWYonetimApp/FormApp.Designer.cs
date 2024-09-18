namespace KWYonetimApp
{
	partial class FormApp
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApp));
			topPage2 = new TabControl();
			tabPage1 = new TabPage();
			label4 = new Label();
			label3 = new Label();
			buttonKaldir = new Button();
			label1 = new Label();
			comboBoxIlanlar2 = new ComboBox();
			groupBoxEkle = new GroupBox();
			textBoxIlanIDE = new TextBox();
			button1 = new Button();
			textBoxFiyatE = new TextBox();
			textBoxIlanIcerigiIDE = new TextBox();
			textBoxIlanTuruIDE = new TextBox();
			comboBoxAdresE = new ComboBox();
			textBoxAciklamaE = new TextBox();
			textBoxSaticiIDE = new TextBox();
			textBoxCalisanIDE = new TextBox();
			textBoxIlanAdiE = new TextBox();
			buttonİlanEkle = new Button();
			label2 = new Label();
			groupBoxDegisiklikler = new GroupBox();
			textBoxIlanNumarasıG = new TextBox();
			buttonGuncelle = new Button();
			textBoxFiyatG = new TextBox();
			textBoxIlanIcerigiG = new TextBox();
			textBoxIlanTuruIDG = new TextBox();
			comboBoxAdresG = new ComboBox();
			textBoxAciklamaG = new TextBox();
			textBoxMusteriIDG = new TextBox();
			textBoxCalisanIDG = new TextBox();
			textBoxIlanAdiG = new TextBox();
			comboBoxIlanlar = new ComboBox();
			listİlanlar = new ListView();
			tabPage2 = new TabPage();
			buttonKaldır = new Button();
			comboBoxMusteriIdleri = new ComboBox();
			label6 = new Label();
			groupBox1 = new GroupBox();
			buttonMusteriEkle = new Button();
			comboBoxMusteriTipi = new ComboBox();
			label5 = new Label();
			textBoxMusteriMail = new TextBox();
			textBoxMusteriTelefon = new TextBox();
			comboBoxMusteriAdres = new ComboBox();
			dateTimePickerMusteriDogumTarihi = new DateTimePicker();
			textBoxNot = new TextBox();
			textBoxMusteriSoyadi = new TextBox();
			comboBoxMusteriAktiflik = new ComboBox();
			textBoxMusteriAdi = new TextBox();
			listMusteriler = new ListView();
			tabPage3 = new TabPage();
			buttonGorusmeEkle = new Button();
			textBoxGorusmeNotu = new TextBox();
			textBoxGorusmeKonusu = new TextBox();
			comboBoxGCalisanID = new ComboBox();
			comboBoxGMusteriID = new ComboBox();
			listGorusmeler = new ListView();
			label8 = new Label();
			label9 = new Label();
			groupBox2 = new GroupBox();
			topPage2.SuspendLayout();
			tabPage1.SuspendLayout();
			groupBoxEkle.SuspendLayout();
			groupBoxDegisiklikler.SuspendLayout();
			tabPage2.SuspendLayout();
			groupBox1.SuspendLayout();
			tabPage3.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// topPage2
			// 
			topPage2.Controls.Add(tabPage1);
			topPage2.Controls.Add(tabPage2);
			topPage2.Controls.Add(tabPage3);
			topPage2.Location = new Point(0, 1);
			topPage2.Name = "topPage2";
			topPage2.SelectedIndex = 0;
			topPage2.Size = new Size(846, 585);
			topPage2.TabIndex = 0;
			// 
			// tabPage1
			// 
			tabPage1.BackColor = Color.Gainsboro;
			tabPage1.Controls.Add(label4);
			tabPage1.Controls.Add(label3);
			tabPage1.Controls.Add(buttonKaldir);
			tabPage1.Controls.Add(label1);
			tabPage1.Controls.Add(comboBoxIlanlar2);
			tabPage1.Controls.Add(groupBoxEkle);
			tabPage1.Controls.Add(buttonİlanEkle);
			tabPage1.Controls.Add(label2);
			tabPage1.Controls.Add(groupBoxDegisiklikler);
			tabPage1.Controls.Add(comboBoxIlanlar);
			tabPage1.Controls.Add(listİlanlar);
			tabPage1.Location = new Point(4, 29);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(838, 552);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "tabPage1";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(304, 127);
			label4.Name = "label4";
			label4.Size = new Size(207, 20);
			label4.TabIndex = 15;
			label4.Text = "Yeni ilan için butona tıklayınız.";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(554, 238);
			label3.Name = "label3";
			label3.Size = new Size(278, 80);
			label3.TabIndex = 14;
			label3.Text = "Çalışan ID: İlandan sorumlu çalışanın IDsi\r\nSatıcı ID: İlanı satan müşterinin ID'si\r\nİlan Türü ID: Satılık için 1, Kiralık için 2\r\nİlan İçeriği ID: Konut için 1, Arsa için 2";
			label3.Click += label3_Click;
			// 
			// buttonKaldir
			// 
			buttonKaldir.Location = new Point(555, 203);
			buttonKaldir.Name = "buttonKaldir";
			buttonKaldir.Size = new Size(274, 29);
			buttonKaldir.TabIndex = 11;
			buttonKaldir.Text = "Kaldır";
			buttonKaldir.UseVisualStyleBackColor = true;
			buttonKaldir.Click += buttonKaldir_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(554, 127);
			label1.Name = "label1";
			label1.Size = new Size(232, 20);
			label1.TabIndex = 13;
			label1.Text = "İlan kaldırmak için İlan No seçiniz.";
			// 
			// comboBoxIlanlar2
			// 
			comboBoxIlanlar2.FormattingEnabled = true;
			comboBoxIlanlar2.Location = new Point(555, 150);
			comboBoxIlanlar2.Name = "comboBoxIlanlar2";
			comboBoxIlanlar2.Size = new Size(274, 28);
			comboBoxIlanlar2.TabIndex = 12;
			comboBoxIlanlar2.SelectedIndexChanged += comboBoxİlanlar2_SelectedIndexChanged;
			// 
			// groupBoxEkle
			// 
			groupBoxEkle.Controls.Add(textBoxIlanIDE);
			groupBoxEkle.Controls.Add(button1);
			groupBoxEkle.Controls.Add(textBoxFiyatE);
			groupBoxEkle.Controls.Add(textBoxIlanIcerigiIDE);
			groupBoxEkle.Controls.Add(textBoxIlanTuruIDE);
			groupBoxEkle.Controls.Add(comboBoxAdresE);
			groupBoxEkle.Controls.Add(textBoxAciklamaE);
			groupBoxEkle.Controls.Add(textBoxSaticiIDE);
			groupBoxEkle.Controls.Add(textBoxCalisanIDE);
			groupBoxEkle.Controls.Add(textBoxIlanAdiE);
			groupBoxEkle.Location = new Point(304, 177);
			groupBoxEkle.Name = "groupBoxEkle";
			groupBoxEkle.Size = new Size(245, 373);
			groupBoxEkle.TabIndex = 11;
			groupBoxEkle.TabStop = false;
			groupBoxEkle.Text = "Yeni İlan Bilgileri";
			groupBoxEkle.Visible = false;
			// 
			// textBoxIlanIDE
			// 
			textBoxIlanIDE.Location = new Point(6, 194);
			textBoxIlanIDE.Name = "textBoxIlanIDE";
			textBoxIlanIDE.PlaceholderText = "İlan Numarası";
			textBoxIlanIDE.Size = new Size(232, 27);
			textBoxIlanIDE.TabIndex = 10;
			// 
			// button1
			// 
			button1.Location = new Point(5, 336);
			button1.Name = "button1";
			button1.Size = new Size(233, 29);
			button1.TabIndex = 9;
			button1.Text = "Ekle";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBoxFiyatE
			// 
			textBoxFiyatE.Location = new Point(6, 294);
			textBoxFiyatE.Name = "textBoxFiyatE";
			textBoxFiyatE.PlaceholderText = "Fiyat";
			textBoxFiyatE.Size = new Size(232, 27);
			textBoxFiyatE.TabIndex = 8;
			// 
			// textBoxIlanIcerigiIDE
			// 
			textBoxIlanIcerigiIDE.Location = new Point(5, 261);
			textBoxIlanIcerigiIDE.Name = "textBoxIlanIcerigiIDE";
			textBoxIlanIcerigiIDE.PlaceholderText = "İlan İçeriği ID";
			textBoxIlanIcerigiIDE.Size = new Size(233, 27);
			textBoxIlanIcerigiIDE.TabIndex = 7;
			// 
			// textBoxIlanTuruIDE
			// 
			textBoxIlanTuruIDE.Location = new Point(6, 228);
			textBoxIlanTuruIDE.Name = "textBoxIlanTuruIDE";
			textBoxIlanTuruIDE.PlaceholderText = "İlan Türü ID";
			textBoxIlanTuruIDE.Size = new Size(232, 27);
			textBoxIlanTuruIDE.TabIndex = 6;
			// 
			// comboBoxAdresE
			// 
			comboBoxAdresE.FormattingEnabled = true;
			comboBoxAdresE.Location = new Point(6, 160);
			comboBoxAdresE.Name = "comboBoxAdresE";
			comboBoxAdresE.Size = new Size(232, 28);
			comboBoxAdresE.TabIndex = 5;
			// 
			// textBoxAciklamaE
			// 
			textBoxAciklamaE.Location = new Point(6, 127);
			textBoxAciklamaE.Name = "textBoxAciklamaE";
			textBoxAciklamaE.PlaceholderText = "Açıklama";
			textBoxAciklamaE.Size = new Size(232, 27);
			textBoxAciklamaE.TabIndex = 3;
			// 
			// textBoxSaticiIDE
			// 
			textBoxSaticiIDE.Location = new Point(5, 94);
			textBoxSaticiIDE.Name = "textBoxSaticiIDE";
			textBoxSaticiIDE.PlaceholderText = "Satıcı ID";
			textBoxSaticiIDE.Size = new Size(232, 27);
			textBoxSaticiIDE.TabIndex = 2;
			// 
			// textBoxCalisanIDE
			// 
			textBoxCalisanIDE.Location = new Point(5, 61);
			textBoxCalisanIDE.Name = "textBoxCalisanIDE";
			textBoxCalisanIDE.PlaceholderText = "Çalışan ID";
			textBoxCalisanIDE.Size = new Size(232, 27);
			textBoxCalisanIDE.TabIndex = 1;
			// 
			// textBoxIlanAdiE
			// 
			textBoxIlanAdiE.Location = new Point(6, 28);
			textBoxIlanAdiE.Name = "textBoxIlanAdiE";
			textBoxIlanAdiE.PlaceholderText = "İlan Adı";
			textBoxIlanAdiE.Size = new Size(232, 27);
			textBoxIlanAdiE.TabIndex = 0;
			// 
			// buttonİlanEkle
			// 
			buttonİlanEkle.Location = new Point(304, 149);
			buttonİlanEkle.Name = "buttonİlanEkle";
			buttonİlanEkle.Size = new Size(238, 28);
			buttonİlanEkle.TabIndex = 4;
			buttonİlanEkle.Text = "Yeni İlan Ekle";
			buttonİlanEkle.UseVisualStyleBackColor = true;
			buttonİlanEkle.Click += buttonİlanEkle_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(8, 126);
			label2.Name = "label2";
			label2.Size = new Size(217, 20);
			label2.TabIndex = 3;
			label2.Text = "Güncelleme için İlan No seçiniz.";
			// 
			// groupBoxDegisiklikler
			// 
			groupBoxDegisiklikler.Controls.Add(textBoxIlanNumarasıG);
			groupBoxDegisiklikler.Controls.Add(buttonGuncelle);
			groupBoxDegisiklikler.Controls.Add(textBoxFiyatG);
			groupBoxDegisiklikler.Controls.Add(textBoxIlanIcerigiG);
			groupBoxDegisiklikler.Controls.Add(textBoxIlanTuruIDG);
			groupBoxDegisiklikler.Controls.Add(comboBoxAdresG);
			groupBoxDegisiklikler.Controls.Add(textBoxAciklamaG);
			groupBoxDegisiklikler.Controls.Add(textBoxMusteriIDG);
			groupBoxDegisiklikler.Controls.Add(textBoxCalisanIDG);
			groupBoxDegisiklikler.Controls.Add(textBoxIlanAdiG);
			groupBoxDegisiklikler.Location = new Point(8, 177);
			groupBoxDegisiklikler.Name = "groupBoxDegisiklikler";
			groupBoxDegisiklikler.Size = new Size(248, 373);
			groupBoxDegisiklikler.TabIndex = 2;
			groupBoxDegisiklikler.TabStop = false;
			groupBoxDegisiklikler.Text = "Değişikler";
			groupBoxDegisiklikler.Visible = false;
			// 
			// textBoxIlanNumarasıG
			// 
			textBoxIlanNumarasıG.Location = new Point(6, 194);
			textBoxIlanNumarasıG.Name = "textBoxIlanNumarasıG";
			textBoxIlanNumarasıG.PlaceholderText = "İlan Numarası";
			textBoxIlanNumarasıG.Size = new Size(242, 27);
			textBoxIlanNumarasıG.TabIndex = 10;
			// 
			// buttonGuncelle
			// 
			buttonGuncelle.Location = new Point(6, 336);
			buttonGuncelle.Name = "buttonGuncelle";
			buttonGuncelle.Size = new Size(242, 29);
			buttonGuncelle.TabIndex = 9;
			buttonGuncelle.Text = "Güncelle";
			buttonGuncelle.UseVisualStyleBackColor = true;
			buttonGuncelle.Click += buttonGuncelle_Click;
			// 
			// textBoxFiyatG
			// 
			textBoxFiyatG.Location = new Point(6, 294);
			textBoxFiyatG.Name = "textBoxFiyatG";
			textBoxFiyatG.PlaceholderText = "Fiyat";
			textBoxFiyatG.Size = new Size(242, 27);
			textBoxFiyatG.TabIndex = 8;
			// 
			// textBoxIlanIcerigiG
			// 
			textBoxIlanIcerigiG.Location = new Point(6, 261);
			textBoxIlanIcerigiG.Name = "textBoxIlanIcerigiG";
			textBoxIlanIcerigiG.PlaceholderText = "İlan İçeriği ID";
			textBoxIlanIcerigiG.Size = new Size(242, 27);
			textBoxIlanIcerigiG.TabIndex = 7;
			// 
			// textBoxIlanTuruIDG
			// 
			textBoxIlanTuruIDG.Location = new Point(6, 228);
			textBoxIlanTuruIDG.Name = "textBoxIlanTuruIDG";
			textBoxIlanTuruIDG.PlaceholderText = "İlan Türü ID";
			textBoxIlanTuruIDG.Size = new Size(242, 27);
			textBoxIlanTuruIDG.TabIndex = 6;
			// 
			// comboBoxAdresG
			// 
			comboBoxAdresG.FormattingEnabled = true;
			comboBoxAdresG.Location = new Point(6, 160);
			comboBoxAdresG.Name = "comboBoxAdresG";
			comboBoxAdresG.Size = new Size(242, 28);
			comboBoxAdresG.TabIndex = 5;
			// 
			// textBoxAciklamaG
			// 
			textBoxAciklamaG.Location = new Point(6, 127);
			textBoxAciklamaG.Name = "textBoxAciklamaG";
			textBoxAciklamaG.PlaceholderText = "Açıklama";
			textBoxAciklamaG.Size = new Size(242, 27);
			textBoxAciklamaG.TabIndex = 3;
			// 
			// textBoxMusteriIDG
			// 
			textBoxMusteriIDG.Location = new Point(6, 94);
			textBoxMusteriIDG.Name = "textBoxMusteriIDG";
			textBoxMusteriIDG.PlaceholderText = "Satıcı ID";
			textBoxMusteriIDG.Size = new Size(242, 27);
			textBoxMusteriIDG.TabIndex = 2;
			// 
			// textBoxCalisanIDG
			// 
			textBoxCalisanIDG.Location = new Point(6, 61);
			textBoxCalisanIDG.Name = "textBoxCalisanIDG";
			textBoxCalisanIDG.PlaceholderText = "Çalışan ID";
			textBoxCalisanIDG.Size = new Size(242, 27);
			textBoxCalisanIDG.TabIndex = 1;
			// 
			// textBoxIlanAdiG
			// 
			textBoxIlanAdiG.Location = new Point(6, 28);
			textBoxIlanAdiG.Name = "textBoxIlanAdiG";
			textBoxIlanAdiG.PlaceholderText = "İlan Adı";
			textBoxIlanAdiG.Size = new Size(242, 27);
			textBoxIlanAdiG.TabIndex = 0;
			// 
			// comboBoxIlanlar
			// 
			comboBoxIlanlar.FormattingEnabled = true;
			comboBoxIlanlar.Location = new Point(14, 149);
			comboBoxIlanlar.Name = "comboBoxIlanlar";
			comboBoxIlanlar.Size = new Size(242, 28);
			comboBoxIlanlar.TabIndex = 0;
			comboBoxIlanlar.SelectedIndexChanged += comboBoxIlanlar_SelectedIndexChanged;
			// 
			// listİlanlar
			// 
			listİlanlar.Location = new Point(8, 6);
			listİlanlar.Name = "listİlanlar";
			listİlanlar.Size = new Size(830, 118);
			listİlanlar.TabIndex = 0;
			listİlanlar.UseCompatibleStateImageBehavior = false;
			listİlanlar.View = View.Details;
			listİlanlar.SelectedIndexChanged += listİlanlar_SelectedIndexChanged;
			// 
			// tabPage2
			// 
			tabPage2.BackColor = Color.Gainsboro;
			tabPage2.Controls.Add(buttonKaldır);
			tabPage2.Controls.Add(comboBoxMusteriIdleri);
			tabPage2.Controls.Add(label6);
			tabPage2.Controls.Add(groupBox1);
			tabPage2.Controls.Add(listMusteriler);
			tabPage2.Location = new Point(4, 29);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(838, 552);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "tabPage2";
			// 
			// buttonKaldır
			// 
			buttonKaldır.Location = new Point(295, 184);
			buttonKaldır.Name = "buttonKaldır";
			buttonKaldır.Size = new Size(247, 29);
			buttonKaldır.TabIndex = 11;
			buttonKaldır.Text = "Sil";
			buttonKaldır.UseVisualStyleBackColor = true;
			buttonKaldır.Click += buttonKaldır_Click;
			// 
			// comboBoxMusteriIdleri
			// 
			comboBoxMusteriIdleri.FormattingEnabled = true;
			comboBoxMusteriIdleri.Location = new Point(295, 153);
			comboBoxMusteriIdleri.Name = "comboBoxMusteriIdleri";
			comboBoxMusteriIdleri.Size = new Size(247, 28);
			comboBoxMusteriIdleri.TabIndex = 11;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(295, 129);
			label6.Name = "label6";
			label6.Size = new Size(314, 20);
			label6.TabIndex = 3;
			label6.Text = "Silmek istediğiniz müşteri kaydı için ID seçiniz:";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(buttonMusteriEkle);
			groupBox1.Controls.Add(comboBoxMusteriTipi);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(textBoxMusteriMail);
			groupBox1.Controls.Add(textBoxMusteriTelefon);
			groupBox1.Controls.Add(comboBoxMusteriAdres);
			groupBox1.Controls.Add(dateTimePickerMusteriDogumTarihi);
			groupBox1.Controls.Add(textBoxNot);
			groupBox1.Controls.Add(textBoxMusteriSoyadi);
			groupBox1.Controls.Add(comboBoxMusteriAktiflik);
			groupBox1.Controls.Add(textBoxMusteriAdi);
			groupBox1.Location = new Point(10, 129);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(259, 417);
			groupBox1.TabIndex = 2;
			groupBox1.TabStop = false;
			groupBox1.Text = "Müşteri Bilgileri";
			// 
			// buttonMusteriEkle
			// 
			buttonMusteriEkle.Location = new Point(6, 385);
			buttonMusteriEkle.Name = "buttonMusteriEkle";
			buttonMusteriEkle.Size = new Size(247, 29);
			buttonMusteriEkle.TabIndex = 10;
			buttonMusteriEkle.Text = "Ekle";
			buttonMusteriEkle.UseVisualStyleBackColor = true;
			buttonMusteriEkle.Click += buttonMusteriEkle_Click;
			// 
			// comboBoxMusteriTipi
			// 
			comboBoxMusteriTipi.FormattingEnabled = true;
			comboBoxMusteriTipi.Items.AddRange(new object[] { "Satıcı", "Alıcı" });
			comboBoxMusteriTipi.Location = new Point(6, 24);
			comboBoxMusteriTipi.Name = "comboBoxMusteriTipi";
			comboBoxMusteriTipi.Size = new Size(247, 28);
			comboBoxMusteriTipi.TabIndex = 9;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(6, 328);
			label5.Name = "label5";
			label5.Size = new Size(106, 20);
			label5.TabIndex = 2;
			label5.Text = "Aktiflik seçiniz:";
			// 
			// textBoxMusteriMail
			// 
			textBoxMusteriMail.Location = new Point(6, 298);
			textBoxMusteriMail.Name = "textBoxMusteriMail";
			textBoxMusteriMail.PlaceholderText = "Müşteri Mail Adresi";
			textBoxMusteriMail.Size = new Size(247, 27);
			textBoxMusteriMail.TabIndex = 8;
			// 
			// textBoxMusteriTelefon
			// 
			textBoxMusteriTelefon.Location = new Point(6, 264);
			textBoxMusteriTelefon.Name = "textBoxMusteriTelefon";
			textBoxMusteriTelefon.PlaceholderText = "Müşteri Telefon Numarası";
			textBoxMusteriTelefon.Size = new Size(247, 27);
			textBoxMusteriTelefon.TabIndex = 7;
			// 
			// comboBoxMusteriAdres
			// 
			comboBoxMusteriAdres.FormattingEnabled = true;
			comboBoxMusteriAdres.Location = new Point(6, 230);
			comboBoxMusteriAdres.Name = "comboBoxMusteriAdres";
			comboBoxMusteriAdres.Size = new Size(247, 28);
			comboBoxMusteriAdres.TabIndex = 6;
			// 
			// dateTimePickerMusteriDogumTarihi
			// 
			dateTimePickerMusteriDogumTarihi.Location = new Point(6, 197);
			dateTimePickerMusteriDogumTarihi.Name = "dateTimePickerMusteriDogumTarihi";
			dateTimePickerMusteriDogumTarihi.Size = new Size(247, 27);
			dateTimePickerMusteriDogumTarihi.TabIndex = 5;
			// 
			// textBoxNot
			// 
			textBoxNot.Location = new Point(6, 123);
			textBoxNot.Multiline = true;
			textBoxNot.Name = "textBoxNot";
			textBoxNot.PlaceholderText = "Not";
			textBoxNot.Size = new Size(247, 68);
			textBoxNot.TabIndex = 4;
			// 
			// textBoxMusteriSoyadi
			// 
			textBoxMusteriSoyadi.Location = new Point(6, 90);
			textBoxMusteriSoyadi.Name = "textBoxMusteriSoyadi";
			textBoxMusteriSoyadi.PlaceholderText = "Müşteri Soyadı";
			textBoxMusteriSoyadi.Size = new Size(247, 27);
			textBoxMusteriSoyadi.TabIndex = 3;
			// 
			// comboBoxMusteriAktiflik
			// 
			comboBoxMusteriAktiflik.FormattingEnabled = true;
			comboBoxMusteriAktiflik.Items.AddRange(new object[] { "True ", "False" });
			comboBoxMusteriAktiflik.Location = new Point(6, 351);
			comboBoxMusteriAktiflik.Name = "comboBoxMusteriAktiflik";
			comboBoxMusteriAktiflik.Size = new Size(247, 28);
			comboBoxMusteriAktiflik.TabIndex = 1;
			// 
			// textBoxMusteriAdi
			// 
			textBoxMusteriAdi.Location = new Point(6, 57);
			textBoxMusteriAdi.Name = "textBoxMusteriAdi";
			textBoxMusteriAdi.PlaceholderText = "Müşteri Adı";
			textBoxMusteriAdi.Size = new Size(247, 27);
			textBoxMusteriAdi.TabIndex = 0;
			// 
			// listMusteriler
			// 
			listMusteriler.Location = new Point(3, 6);
			listMusteriler.Name = "listMusteriler";
			listMusteriler.Size = new Size(832, 118);
			listMusteriler.TabIndex = 1;
			listMusteriler.UseCompatibleStateImageBehavior = false;
			listMusteriler.View = View.Details;
			// 
			// tabPage3
			// 
			tabPage3.BackColor = Color.Gainsboro;
			tabPage3.Controls.Add(groupBox2);
			tabPage3.Controls.Add(listGorusmeler);
			tabPage3.Location = new Point(4, 29);
			tabPage3.Name = "tabPage3";
			tabPage3.Padding = new Padding(3);
			tabPage3.Size = new Size(838, 552);
			tabPage3.TabIndex = 2;
			tabPage3.Text = "tabPage3";
			// 
			// buttonGorusmeEkle
			// 
			buttonGorusmeEkle.Location = new Point(6, 246);
			buttonGorusmeEkle.Name = "buttonGorusmeEkle";
			buttonGorusmeEkle.Size = new Size(247, 29);
			buttonGorusmeEkle.TabIndex = 14;
			buttonGorusmeEkle.Text = "Ekle";
			buttonGorusmeEkle.UseVisualStyleBackColor = true;
			buttonGorusmeEkle.Click += buttonGorusmeEkle_Click;
			// 
			// textBoxGorusmeNotu
			// 
			textBoxGorusmeNotu.Location = new Point(6, 174);
			textBoxGorusmeNotu.Multiline = true;
			textBoxGorusmeNotu.Name = "textBoxGorusmeNotu";
			textBoxGorusmeNotu.PlaceholderText = "Not";
			textBoxGorusmeNotu.Size = new Size(247, 66);
			textBoxGorusmeNotu.TabIndex = 13;
			// 
			// textBoxGorusmeKonusu
			// 
			textBoxGorusmeKonusu.Location = new Point(6, 141);
			textBoxGorusmeKonusu.Name = "textBoxGorusmeKonusu";
			textBoxGorusmeKonusu.PlaceholderText = "Görüşme Konusu";
			textBoxGorusmeKonusu.Size = new Size(247, 27);
			textBoxGorusmeKonusu.TabIndex = 12;
			// 
			// comboBoxGCalisanID
			// 
			comboBoxGCalisanID.FormattingEnabled = true;
			comboBoxGCalisanID.Location = new Point(6, 107);
			comboBoxGCalisanID.Name = "comboBoxGCalisanID";
			comboBoxGCalisanID.Size = new Size(247, 28);
			comboBoxGCalisanID.TabIndex = 11;
			// 
			// comboBoxGMusteriID
			// 
			comboBoxGMusteriID.FormattingEnabled = true;
			comboBoxGMusteriID.Location = new Point(4, 49);
			comboBoxGMusteriID.Name = "comboBoxGMusteriID";
			comboBoxGMusteriID.Size = new Size(247, 28);
			comboBoxGMusteriID.TabIndex = 10;
			// 
			// listGorusmeler
			// 
			listGorusmeler.Location = new Point(3, 6);
			listGorusmeler.Name = "listGorusmeler";
			listGorusmeler.Size = new Size(832, 118);
			listGorusmeler.TabIndex = 2;
			listGorusmeler.UseCompatibleStateImageBehavior = false;
			listGorusmeler.View = View.Details;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(6, 26);
			label8.Name = "label8";
			label8.Size = new Size(128, 20);
			label8.TabIndex = 15;
			label8.Text = "Müşteri ID seçiniz:";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(6, 80);
			label9.Name = "label9";
			label9.Size = new Size(126, 20);
			label9.TabIndex = 16;
			label9.Text = "Çalışan ID seçiniz:";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(buttonGorusmeEkle);
			groupBox2.Controls.Add(label9);
			groupBox2.Controls.Add(comboBoxGMusteriID);
			groupBox2.Controls.Add(label8);
			groupBox2.Controls.Add(comboBoxGCalisanID);
			groupBox2.Controls.Add(textBoxGorusmeKonusu);
			groupBox2.Controls.Add(textBoxGorusmeNotu);
			groupBox2.Location = new Point(8, 135);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(263, 293);
			groupBox2.TabIndex = 17;
			groupBox2.TabStop = false;
			groupBox2.Text = "Görüşme Bilgileri";
			// 
			// FormApp
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Gainsboro;
			ClientSize = new Size(845, 599);
			Controls.Add(topPage2);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "FormApp";
			Text = "KWYonetimApp";
			Load += FormApp_Load;
			topPage2.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tabPage1.PerformLayout();
			groupBoxEkle.ResumeLayout(false);
			groupBoxEkle.PerformLayout();
			groupBoxDegisiklikler.ResumeLayout(false);
			groupBoxDegisiklikler.PerformLayout();
			tabPage2.ResumeLayout(false);
			tabPage2.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			tabPage3.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TabControl topPage2;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private TabPage tabPage3;
		private ListView listİlanlar;
		private ComboBox comboBoxIlanlar;
		private GroupBox groupBoxDegisiklikler;
		private TextBox textBoxCalisanIDG;
		private TextBox textBoxIlanAdiG;
		private TextBox textBoxFiyatG;
		private TextBox textBoxIlanIcerigiG;
		private TextBox textBoxIlanTuruIDG;
		private ComboBox comboBoxAdresG;
		private TextBox textBoxAciklamaG;
		private TextBox textBoxMusteriIDG;
		private Button buttonGuncelle;
		private TextBox textBoxIlanNumarasıG;
		private Button buttonİlanEkle;
		private Label label2;
		private GroupBox groupBoxEkle;
		private TextBox textBoxIlanIDE;
		private Button button1;
		private TextBox textBoxFiyatE;
		private TextBox textBoxIlanIcerigiIDE;
		private TextBox textBoxIlanTuruIDE;
		private ComboBox comboBoxAdresE;
		private TextBox textBoxAciklamaE;
		private TextBox textBoxSaticiIDE;
		private TextBox textBoxCalisanIDE;
		private TextBox textBoxIlanAdiE;
		private Label label1;
		private ComboBox comboBoxIlanlar2;
		private Button buttonKaldir;
		private Label label4;
		private Label label3;
		private ListView listMusteriler;
		private GroupBox groupBox1;
		private TextBox textBoxMusteriAdi;
		private ComboBox comboBoxMusteriAdres;
		private DateTimePicker dateTimePickerMusteriDogumTarihi;
		private TextBox textBoxNot;
		private TextBox textBoxMusteriSoyadi;
		private Label label5;
		private ComboBox comboBoxMusteriAktiflik;
		private TextBox textBoxMusteriMail;
		private TextBox textBoxMusteriTelefon;
		private Button buttonMusteriEkle;
		private ComboBox comboBoxMusteriTipi;
		private Label label6;
		private ComboBox comboBoxMusteriIdleri;
		private Button buttonKaldır;
		private ListView listGorusmeler;
		private TextBox textBoxGorusmeKonusu;
		private ComboBox comboBoxGCalisanID;
		private ComboBox comboBoxGMusteriID;
		private Button buttonGorusmeEkle;
		private TextBox textBoxGorusmeNotu;
		private GroupBox groupBox2;
		private Label label9;
		private Label label8;
	}
}