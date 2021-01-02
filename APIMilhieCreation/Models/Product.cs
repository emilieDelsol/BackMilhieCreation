﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace APIMilhieCreation.Models
{
	public class Product
	{
		public virtual  Int32 ProductId { get; set; }
		public virtual  String Title { get; set; }
		public virtual  Decimal Price { get; set; }
		public virtual  String Gemme { get; set; }
		public virtual  String Description { get; set; }
		public virtual  String Link { get; set; }
		public virtual  bool Disponibility { get; set; }
		public virtual String Reference { get; set; }
		[NotMapped]
		public virtual String[] Images { get ; set ; } 
		public virtual Int32 CategoryId { get; set; }
		[JsonIgnore]
		public virtual Category Category { get; set; }
	}
}