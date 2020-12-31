using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIMilhieCreation.Models;
namespace APIMilhieCreation
{
	public class MilhieCreationContext : DbContext
	{
		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
		public MilhieCreationContext(DbContextOptions<MilhieCreationContext> options)
	   : base(options) { }
		/*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=LOCALHOST\SQLEXPRESS;Database=MilhieCreation;Integrated Security=True;MultipleActiveResultSets=True");
		}*/
	}
}
