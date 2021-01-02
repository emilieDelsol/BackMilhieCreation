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
		public IEnumerable<Product> GetAllProducts()
			{
			IEnumerable<Product> products = new List<Product>();
			products = from a in _context.Products  select a;
			return products;
			}
		
		[HttpGet("[controller]/LifeTree")]
		public IEnumerable<Product> GetAllLifeTree()
			{
			IEnumerable<Product> products = new List<Product>();
			products = from a in _context.Products where a.Category.Name=="LifeTree" select a ;
			return products;
			}

		[HttpGet("[controller]/Jewerly")]
		public IEnumerable<Product> GetJewerly()
		{
			IEnumerable<Product> products = new List<Product>();
			products = from a in _context.Products select a;
			return products;
		}
	}
}
