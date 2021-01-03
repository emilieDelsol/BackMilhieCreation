using APIMilhieCreation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMilhieCreation.Controllers
{
	public class MilhieCreationController : ControllerBase
	{
		private MilhieCreationContext _context;
		public MilhieCreationController(MilhieCreationContext injectedMilhieCreationContext)
		{
			_context = injectedMilhieCreationContext;
		}
		[HttpGet("[controller]")]
		public IEnumerable<Product> GetAllProducts(int Id)
		{
			IEnumerable<Product> products = new List<Product>();
			products = from a in _context.Products  select a;
			return products;
		}
		[HttpGet("[controller]/{Id}")]
		public IEnumerable<Product> GetProductsById(int Id)
			{
			IEnumerable<Product> products = new List<Product>();
			products = from a in _context.Products where a.UnderCategory.UnderCategoryId == Id select a; 			
			return products;
			}

		//1 -> big Life Tree
		//2 -> medium life tree
		//3 -> small life tree
		//4 -> dreamcatcher
		//5-> wall deco
		//6-> wedding deco
		//7-> rings
		//8-> earrings
		//9-> bracelets fins
		//10-> manchettes
		//11-> bracelets lyto
		//12-> bracelets fil Alu (W)
		//13-> necklace
		//14-> pendant ch	ackras
		//15-> pendant lyto
	
	}
}
