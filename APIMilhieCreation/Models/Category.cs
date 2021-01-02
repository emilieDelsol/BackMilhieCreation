using System;
using System.Collections.Generic;

namespace APIMilhieCreation.Models
{
	public class Category
	{
		public  Int32 CategoryId { get; set; }
		public  String Name { get; set; }
		public  ICollection<UnderCategory> UnderCategories { get; set; }
	}
}