using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWApp.Database
{
	public class Gorusme
	{
		[Key]
		public int GorusmeID { get; set; }
		public Musteri Musteri { get; set; }
		[ForeignKey(nameof(Musteri))]
		public int MusteriID { get; set; }
		public Calisan Calisan { get; set; }
		[ForeignKey(nameof(Calisan))]
		public int CalisanID { get; set; }
		
		public string GorusmeKonusu { get; set; }
		public string GorusmeNotu { get; set; }
		public DateTime GorusmeTarihi { get; set; }
	}
}
