using KWApp.Database;

namespace KWYonetimApp
{
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}

		private void buttonGiris_Click(object sender, EventArgs e)
		{
			if(textBoxID.Text!="")
			{
				int id = Convert.ToInt32(textBoxID.Text);	
				if(textBoxSifre.Text!="")
				{
					string sifre = textBoxSifre.Text;
					KWYonetimAppDbContext context = new KWYonetimAppDbContext();
					var kullanýcý = context.Calisanlar.SingleOrDefault(k=>k.CalisanID==id);
					if(kullanýcý!=null)
					{
						if (kullanýcý.Sifre == sifre)
						{
							GlobalVariables.sozkonusukullanici = id;
							MessageBox.Show("Sayýn " + kullanýcý.Ad + " " + kullanýcý.Soyad + " hoþgeldiniz.","Baþarýlý",MessageBoxButtons.OK,MessageBoxIcon.Information);
							this.Hide();
							FormApp formApp = new FormApp();
							formApp.ShowDialog();
						}
                        else
                        {
							MessageBox.Show("Hatalý þifre.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
							textBoxID.Text = "";
							textBoxSifre.Text = "";
						}
                    }
					else
					{
						MessageBox.Show("Kullanýcý bulunamadý.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
						textBoxID.Text = "";
						textBoxSifre.Text = "";
					}
					
				}
				else
				{
					MessageBox.Show("Lütfen þifrenizi giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					textBoxID.Text = "";
					textBoxSifre.Text = "";
				}
			}
			else
			{
				MessageBox.Show("Lütfen kullanýcý adýnýzý giriniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
				textBoxID.Text = "";
				textBoxSifre.Text = "";
			}
		}
	}
}
