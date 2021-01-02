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
		public DbSet<UnderCategory> UnderCategories { get; set; }
		public DbSet<Category> Categories { get; set; }

		/*public MilhieCreationContext(DbContextOptions<MilhieCreationContext> options)
	   : base(options) { }*/
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=LOCALHOST\SQLEXPRESS;Database=MilhieCreation;Integrated Security=True;MultipleActiveResultSets=True");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>()
				.Property(e =>e.Images)
				.HasConversion(
					v=>string.Join(',',v),
					v=>v.Split(',',StringSplitOptions.RemoveEmptyEntries));
		}
	}
}
