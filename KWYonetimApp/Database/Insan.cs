using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWApp.Database
{
	public class Insan
	{
		public string Ad { get; set; }
		public string Soyad { get; set; }
		public DateTime DogumTarihi { get; set; }
		public string Adres { get; set; }
		public long TelefonNumarasi { get; set; }
		public string MailAdresi { get; set; }
		public bool Aktiflik { get; set; }
	}
}
