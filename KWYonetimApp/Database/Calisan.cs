using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWApp.Database
{
	public class Calisan : Insan
	{
		[Key]
		public int CalisanID { get; set; }
		public string Sifre { get; set; }
		public DateTime CalisanKayitTarihi { get; set; }
	}
}
