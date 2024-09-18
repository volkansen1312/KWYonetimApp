using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWApp.Database
{
	public class Musteri : Insan
	{
		[Key]
		public int MusteriID { get; set; }
		public string MusteriTipi { get; set; }
		public string MusteriNot { get; set; }
		public DateTime MusteriKayitTarihi { get; set; }
	}
}
