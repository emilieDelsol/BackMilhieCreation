using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace APIMilhieCreation.Models
{
	public class Product
	{
		public  Int32 ProductId { get; set; }
		public  String Title { get; set; }
		public  Decimal Price { get; set; }
		public  String Gemme { get; set; }
		public  String Description { get; set; }
		public  String Link { get; set; }
		public  bool Disponibility { get; set; }
		public String Reference { get; set; }
		[NotMapped]
		public String[] Images { get ; set ; } 
	}
}