using System;
using System.Collections.Generic;

namespace APIMilhieCreation.Models
{
	public class Category
	{
		public virtual Int32 CategoryId { get; set; }
		public virtual String Name { get; set; }
		public virtual ICollection<UnderCategory> UnderCategories { get; set; }
	}
}