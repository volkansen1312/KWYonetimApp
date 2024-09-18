using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWApp.Database
{
	public class Ilan
	{
		[Key]
		public int IlanID { get; set; }
		public long IlanNo { get; set; }
		public string IlanAdi { get; set; }
		public Musteri IlanSahibiMusteri { get; set; }
		[ForeignKey(nameof(IlanSahibiMusteri))]
		public int IlanSahibiMusteriID { get; set; }
		public Calisan IlanSorumlusuCalisan { get; set; }
		[ForeignKey(nameof(IlanSorumlusuCalisan))]
		public int IlanSorumlusuCalisanID { get; set; }
		public string IlanAciklamasi { get; set; }
		public DateTime IlanTarihi { get; set; }
		public string IlanAdresi { get; set; }
		public IlanTuru IlanTuru { get; set; }
		[ForeignKey(nameof(IlanTuru))]
		public int IlanTuruID { get; set; }
		public IlanIcerigi IlanIcerigi { get; set; }
		[ForeignKey(nameof(IlanIcerigi))]
		public int IlanIcerigiID { get; set; }
		public float IlanFiyati { get; set; }
	}
}
