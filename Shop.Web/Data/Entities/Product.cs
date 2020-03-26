namespace Shop.Web.Data.Entities
{
	using System;
	using System.ComponentModel.DataAnnotations;
	public class Product
	{
		public int Id { get; set; }
		
		[MaxLength (50, ErrorMessage = "El nombre no debe rebasarl os 50 Caracteres" )]
		[Required]
		public string Name { get; set; }

		[DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
		public double Price { get; set; }

		[Display(Name = "Image")]
		public string ImageUrl { get; set; }

		[Display(Name = "Last Purchase")]
		public DateTime? LastPurchase { get; set; }

		[Display(Name = "Last Sale")]
		public DateTime? LastSale { get; set; }

		[Display(Name = "Is Availabe?")]
		public bool IsAvailabe { get; set; }

		[DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
		public double Stock { get; set; }
	}

}
