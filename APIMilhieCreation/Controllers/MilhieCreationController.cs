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
		
		[HttpGet("[controller]/BigLifeTree")]
		public IEnumerable<Product> GetBigLifeTree()
			{
			IEnumerable<Product> products = new List<Product>();
			products = from a in _context.Products where a.UnderCategory.UnderCategoryId==1 select a ;
			return products;
			}
		[HttpGet("[controller]/MediumLifeTree")]
		public IEnumerable<Product> GetMediumLifeTree()
		{
			IEnumerable<Product> products = new List<Product>();
			products = from a in _context.Products where a.UnderCategory.UnderCategoryId == 2 select a;
			return products;
		}
		[HttpGet("[controller]/SmallLifeTree")]
		public IEnumerable<Product> GetSmallLifeTree()
		{
			IEnumerable<Product> products = new List<Product>();
			products = from a in _context.Products where a.UnderCategory.UnderCategoryId == 3 select a;
			return products;
		}
		[HttpGet("[controller]/Dreamcatcher")]
		public IEnumerable<Product> GetDreamcatcher()
		{
			IEnumerable<Product> products = new List<Product>();
			products = from a in _context.Products where a.UnderCategory.UnderCategoryId == 4 select a;
			return products;
		}
		[HttpGet("[controller]/WallDeco")]
		public IEnumerable<Product> GetWallDecor()
		{
			IEnumerable<Product> products = new List<Product>();
			products = from a in _context.Products where a.UnderCategory.UnderCategoryId == 5 select a;
			return products;
		}
		[HttpGet("[controller]/WeddingDeco")]
		public IEnumerable<Product> GetWeddingDeco()
		{
			IEnumerable<Product> products = new List<Product>();
			products = from a in _context.Products where a.UnderCategory.UnderCategoryId == 6 select a;
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
