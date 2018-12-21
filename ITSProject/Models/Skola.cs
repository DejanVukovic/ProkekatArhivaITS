using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ITSProject.Models
{
	public class Skola
	{
		[Key]
		public int Id
		{
		 get;
			set;
		}

		[Required]
		[StringLength(50)]
		[Column(TypeName = "nvarchar")]
		[Display(Name = "Naziv")]
		public string Naziv { get; set; }

		
		[Required]
		[StringLength(50)]
		[Column(TypeName = "nvarchar")]
		[Display(Name = "Adresa registracije")]
		public string AdresaReg { get; set; }


		[Required]
		[StringLength(50)]
		[Column(TypeName = "nvarchar")]
		[Display(Name = "Opština")]
		public string Opstina { get; set; }


		[Required]
		[StringLength(10)]
		[Column(TypeName = "varchar")]
		[Display(Name = "Poštanski broj")]
		public string PostanskiBroj { get; set; }


		[Required]
		[StringLength(20)]
		[Column(TypeName = "varchar")]
		[Display(Name = "Matični broj")]
		public string MaticniBroj { get; set; }


		[Required]
		[StringLength(15)]
		[Column(TypeName = "varchar")]
		public string PIB { get; set; }


		[Required]
		[StringLength(10)]
		[Column(TypeName = "varchar")]
		[Display(Name = "Broj računa")]
		public string BrojRacuna { get; set; }


		[Required]
		[StringLength(100)]
		[Column(TypeName = "nvarchar")]
		[Display(Name = "Web Stranica")]
		public string WebStranica { get; set; }

        // Ne vidi se u CreateView-u
        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Kontakt")]
        public string Kontakt { get; set; }


		[Required]
		[StringLength(100)]
		[Column(TypeName = "varchar")]
		public string Pecat { get; set; }



		[StringLength(320)]
		[Column(TypeName = "nvarchar")]
		[Display(Name = "Beleška")]
		public string Beleska { get; set; }

		public virtual ApplicationUser ApplicationUser { get; set; } //dodato

		public string ApplicationUserID { get; set; }


	}
}