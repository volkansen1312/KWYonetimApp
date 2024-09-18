namespace KWYonetimApp
{
	partial class FormLogin
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
			groupBox1 = new GroupBox();
			buttonGiris = new Button();
			textBoxSifre = new TextBox();
			textBoxID = new TextBox();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(buttonGiris);
			groupBox1.Controls.Add(textBoxSifre);
			groupBox1.Controls.Add(textBoxID);
			groupBox1.ForeColor = SystemColors.Desktop;
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(492, 150);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Kullanıcı Bilgileri";
			// 
			// buttonGiris
			// 
			buttonGiris.ForeColor = SystemColors.ActiveCaptionText;
			buttonGiris.Location = new Point(12, 102);
			buttonGiris.Name = "buttonGiris";
			buttonGiris.Size = new Size(469, 35);
			buttonGiris.TabIndex = 2;
			buttonGiris.Text = "Giriş Yap";
			buttonGiris.UseVisualStyleBackColor = true;
			buttonGiris.Click += buttonGiris_Click;
			// 
			// textBoxSifre
			// 
			textBoxSifre.Location = new Point(12, 59);
			textBoxSifre.Name = "textBoxSifre";
			textBoxSifre.PasswordChar = '*';
			textBoxSifre.PlaceholderText = "Şifre";
			textBoxSifre.Size = new Size(469, 27);
			textBoxSifre.TabIndex = 1;
			// 
			// textBoxID
			// 
			textBoxID.Location = new Point(12, 26);
			textBoxID.Name = "textBoxID";
			textBoxID.PlaceholderText = "Kullanıcı Adı";
			textBoxID.Size = new Size(469, 27);
			textBoxID.TabIndex = 0;
			// 
			// FormLogin
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.LightGray;
			ClientSize = new Size(516, 171);
			Controls.Add(groupBox1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "FormLogin";
			Text = "Giriş";
			TransparencyKey = SystemColors.Control;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private Button buttonGiris;
		private TextBox textBoxSifre;
		private TextBox textBoxID;
	}
}
