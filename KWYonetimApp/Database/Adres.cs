using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWApp.Database
{
	public class Adres
	{
		[Key]
		public int AdresID { get; set; }
		public string AdresAdi { get; set; }
	}
}
