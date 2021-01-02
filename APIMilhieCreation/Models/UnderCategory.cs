using System;
using System.Collections.Generic;

namespace APIMilhieCreation.Models
{
	public class UnderCategory
	{
		public Guid UnderCategoryId { get; set; }
		public String Name { get; set; }
		public ICollection<Product> Products { get; set; }
	}
}