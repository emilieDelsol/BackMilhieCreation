using System;
using System.Collections.Generic;

namespace APIMilhieCreation.Models
{
	public class UnderCategory
	{
		public virtual Int32 UnderCategoryId { get; set; }
		public virtual String Name { get; set; }
		public virtual ICollection<Product> Products { get; set; }
		public virtual Int32 CategoryId { get; set; }
	}
}