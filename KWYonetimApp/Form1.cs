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
					var kullan�c� = context.Calisanlar.SingleOrDefault(k=>k.CalisanID==id);
					if(kullan�c�!=null)
					{
						if (kullan�c�.Sifre == sifre)
						{
							GlobalVariables.sozkonusukullanici = id;
							MessageBox.Show("Say�n " + kullan�c�.Ad + " " + kullan�c�.Soyad + " ho�geldiniz.","Ba�ar�l�",MessageBoxButtons.OK,MessageBoxIcon.Information);
							this.Hide();
							FormApp formApp = new FormApp();
							formApp.ShowDialog();
						}
                        else
                        {
							MessageBox.Show("Hatal� �ifre.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
							textBoxID.Text = "";
							textBoxSifre.Text = "";
						}
                    }
					else
					{
						MessageBox.Show("Kullan�c� bulunamad�.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
						textBoxID.Text = "";
						textBoxSifre.Text = "";
					}
					
				}
				else
				{
					MessageBox.Show("L�tfen �ifrenizi giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					textBoxID.Text = "";
					textBoxSifre.Text = "";
				}
			}
			else
			{
				MessageBox.Show("L�tfen kullan�c� ad�n�z� giriniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
				textBoxID.Text = "";
				textBoxSifre.Text = "";
			}
		}
	}
}
