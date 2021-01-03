using System;
using System.Collections.Generic;

namespace APIMilhieCreation.Models
{
	public class UnderCategory
	{
		public Int32 UnderCategoryId { get; set; }
		public String Name { get; set; }
		public ICollection<Product> Products { get; set; }
		public Int32 CategoryId { get; set; }
	}
}