using APIMilhieCreation.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMilhieCreation
{
	public class Program
	{
		public static void Main(String[] args)
		{
			CreateDatabase();
			//CreateHostBuilder(args).Build().Run();
		}

		private static void CreateDatabase()
		{
			MilhieCreationContext context = new MilhieCreationContext();

			context.Database.EnsureDeleted();
			context.Database.EnsureCreated();

			ICollection<Product> bigLifeTree = new List<Product>
			{
				new Product
				{
					Title= "Arbre de vie sur améthyste.",
					Price = 90,
					Gemme="Amethyst",
					Description="Arbre de vie sur améthyste.<br />Fait main en fil d'aluminium.<br /><br />Hauteur: 17cm",
					Link="https://fr.shopping.rakuten.com/offer/buy/4804029395/arbre-de-vie-sur-amethyste.html",
					Disponibility=false,
					Reference="big_life_tree_01" ,
					Images=new String[]{
						"http://www.milhiecreation.com/images/arbres/arbre01.jpeg" ,
						"http://www.milhiecreation.com/images/arbres/arbre01(01).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre01(02).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre01(03).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre01(04).jpeg",
					}
				},
				new Product
				{
					Title= "Arbre de vie sur améthyste.",
					Price = 90,
					Gemme="Amethyst",
					Description="Arbre de vie sur améthyste.<br />Fait main en fil d'aluminium.<br /><br />Hauteur: 17cm",
					Link="https://fr.shopping.rakuten.com/offer/buy/4804029395/arbre-de-vie-sur-amethyste.html",
					Disponibility=false,
					Reference="big_life_tree_02" ,
					Images=new String[]{
						"http://www.milhiecreation.com/images/arbres/arbre02.jpeg" ,
						"http://www.milhiecreation.com/images/arbres/arbre02(01).jpeg" ,
						"http://www.milhiecreation.com/images/arbres/arbre02(02).jpeg"
					}
				},
				new Product
				{
					Title= "Arbre de vie sur améthyste.",
					Price = 120,
					Gemme="Amethyst",
					Description=" Arbre de vie sur améthyste. Fait main en fil d'aluminium.<br />Fil en acier inoxydable, 189 perles d'améthyste (et donc le double de racines ! )< br />Le tout monté sur une amethyste.< br />Très gros travail sur les racines et leur enchevêtrement.< br />Pièce d'art unique.< br />< br />Hauteur: 17cm",
					Link="https://fr.shopping.rakuten.com/offer/buy/4804029395/arbre-de-vie-sur-amethyste.html",
					Disponibility=false,
					Reference="big_life_tree_03" ,
					Images=new String[]{
						"http://www.milhiecreation.com/images/arbres/arbre03.jpeg" ,
						"http://www.milhiecreation.com/images/arbres/arbre03(01).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre03(02).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre03(03).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre03(04).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre03(05).jpeg"
					}
				},
				new Product
				{
					Title= "Arbre de vie sur améthyste.",
					Price = 120,
					Gemme="Amethyst",
					Description="Arbre de vie sur améthyste. Fait main en fil d'aluminium.<br /><br />Hauteur: 17cm",
					Link="https://fr.shopping.rakuten.com/offer/buy/4804029395/arbre-de-vie-sur-amethyste.html",
					Disponibility=false,
					Reference="big_life_tree_04" ,
					Images=new String[]{
						"http://www.milhiecreation.com/images/arbres/arbre04(01).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre04(02).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre04(03).jpeg"
					}
				},
				new Product
				{
					Title= "Arbre de vie inspiration cerisier du Japon.",
					Price = 90,
					Gemme="Agathe",
					Description=" Arbre de vie inspiration cerisier du Japon en fil d'aluminium et perles de rocaille en verre monté sur une Agathe colorée. <br /><br />Produit fait main.<br />Modèle unique.<br />Hauteur : 15cm",
					Link="https://fr.shopping.rakuten.com/offer/buy/4804029394/arbre-de-vie-cerisier-du-japon.html",
					Disponibility=true,
					Reference="big_life_tree_05" ,
					Images=new String[]{
						"http://www.milhiecreation.com/images/arbres/arbre05(02).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre05(03).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre05(04).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre05(01).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre05(05).jpeg"
					}
				},
				new Product
				{
					Title= "Arbre de vie sur quartz.",
					Price = 120,
					Gemme="Quartz",
					Description=" Arbre de vie fait main en fil de fer et perles miyuki sur quartz brut .<br /><br />27 cm de hauteur<br />Poids: 644g",
					Link="https://fr.shopping.rakuten.com/offer/buy/4804029401/arbre-de-vie-sur-quartz.html",
					Disponibility=true,
					Reference="big_life_tree_06" ,
					Images=new String[]{
						"http://www.milhiecreation.com/images/arbres/arbre06.jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre06(01).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre06(02).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre06(03).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre06(04).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre06(05).jpeg"
					}
				},
				new Product
				{
					Title= "Arbre de vie sur améthyste.",
					Price = 90,
					Gemme="Amethyst",
					Description="Arbre de vie en fil de fer, perles en améthyste le tout monté sur une druse d'améthyste.<br /><br />Hauteur: 18 cm< br />Largeur: 10 cm< br />Poids: 416g",
					Link="https://fr.shopping.rakuten.com/offer/buy/4804029395/arbre-de-vie-sur-amethyste.html",
					Disponibility=true,
					Reference="big_life_tree_07" ,
					Images=new String[]{
						"http://www.milhiecreation.com/images/arbres/arbre07.jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre07(01).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre07(02).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre07(03).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre07(04).jpeg"
					}
				},
				new Product
				{
					Title= "Arbre de vie sur améthyste.",
					Price = 80,
					Gemme="Amethyst",
					Description="Arbre de vie en fil d'aluminium et perles d'améthyste fait main le tout monté sur une druse d'améthyste.<br />Pièce unique. <br /><br />Hauteur: 16cm< br />Largeur: 9cm",
					Link="https://fr.shopping.rakuten.com/offer/buy/4804029399/arbre-de-vie-sur-amethyste.html",
					Disponibility=true,
					Reference="big_life_tree_08" ,
					Images=new String[]{
						"http://www.milhiecreation.com/images/arbres/arbre08.jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre08(01).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre08(02).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre08(03).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre08(04).jpeg"
					}
				},
				new Product
				{
					Title= "Arbre de vie 7 chakras sur agathe géode teintée.",
					Price = 80,
					Gemme="Agathe",
					Description="Arbre de vie 7 chakras en fil d'aluminium et perles semi-précieuses fait main le tout monté sur une géode teintée.<br />Pièce unique. <br /><br />Hauteur: 21cm< br />Largeur: 11cm",
					Link="https://fr.shopping.rakuten.com/offer/buy/4863359918/arbre-de-vie-7-chakras.html",
					Disponibility=true,
					Reference="big_life_tree_09" ,
					Images=new String[]{
						"http://www.milhiecreation.com/images/arbres/arbre09.jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre09(01).jpeg" ,
						"http://www.milhiecreation.com/images/arbres/arbre09(02).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre09(03).jpeg" ,
						"http://www.milhiecreation.com/images/arbres/arbre09(04).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre09(05).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre09(06).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre09(07).jpeg" ,
						"http://www.milhiecreation.com/images/arbres/arbre09(08).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre09(09).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre09(10).jpeg" ,
						"http://www.milhiecreation.com/images/arbres/arbre09(11).jpeg" ,
						"http://www.milhiecreation.com/images/arbres/arbre09(12).jpeg" ,
						"http://www.milhiecreation.com/images/arbres/arbre09(13).jpeg ",
						"http://www.milhiecreation.com/images/arbres/arbre09(14).jpeg" ,
						"http://www.milhiecreation.com/images/arbres/arbre09(15).jpeg" ,
						"http://www.milhiecreation.com/images/arbres/arbre09(16).jpeg" ,
						"http://www.milhiecreation.com/images/arbres/arbre09(17).jpeg,",
						"http://www.milhiecreation.com/images/arbres/arbre09(18).jpeg" ,
						"http://www.milhiecreation.com/images/arbres/arbre09(19).jpeg" ,
					}
				},
				new Product
				{
					Title= "Arbre de vie 7 chakras sur tourmaline noire.",
					Price = 80,
					Gemme="Tourmaline",
					Description="Arbre de vie 7 chakras en fil d'aluminium et perles en pierre semi-précieuses fait main le tout monté sur une tourmaline noire brute.<br />Pièce unique. <br /><br />Hauteur: 16cm< br />Largeur: 9cm",
					Link="https://fr.shopping.rakuten.com/offer/buy/4804029399/arbre-de-vie-sur-amethyste.html",
					Disponibility=false,
					Reference="big_life_tree_10" ,
					Images=new String[]{
						"http://www.milhiecreation.com/images/arbres/arbre10.jpeg" ,
						"http://www.milhiecreation.com/images/arbres/arbre10(01).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre10(02).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre10(03).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre10(04).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre10(05).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre10(06).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre10(07).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre10(08).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre10(09).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre10(10).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre10(11).jpeg ",
						"http://www.milhiecreation.com/images/arbres/arbre10(12).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbre10(13).jpeg ",
						"http://www.milhiecreation.com/images/arbres/arbre10(14).jpeg"
					}
				}
			};

			ICollection<Product> mediumLifeTree = new List<Product>
			{
				new Product
				{
					Title= "Arbre de vie sur agathe géode..",
					Price = 45,
					Gemme="Agathe",
					Description="Arbre de vie fait main en fil de fer et perles d'améthyste le tout monté sur une Agathe Géode violette.<br /><br />Hauteur: 12.5cm< br />Largeur: 6cm< br />Poids: 200g",
					Link="https://www.vinted.fr/femmes/ensemble-de-bijoux/285486737-arbre-de-vie-sur-agathe-geode",
					Disponibility=true,
					Reference="medium_life_tree_01" ,
					Images=new String[]{
					"http://www.milhiecreation.com/images/arbres/arbreM01.jpeg" ,
					"http://www.milhiecreation.com/images/arbres/arbreM01(01).jpeg",
					"http://www.milhiecreation.com/images/arbres/arbreM01(02).jpeg",
					"http://www.milhiecreation.com/images/arbres/arbreM01(03).jpeg",
					"http://www.milhiecreation.com/images/arbres/arbreM01(04).jpeg",
					"http://www.milhiecreation.com/images/arbres/arbreM01(05).jpeg",
					"http://www.milhiecreation.com/images/arbres/arbreM01(06).jpeg",
					"http://www.milhiecreation.com/images/arbres/arbreM01(07).jpeg",
					"http://www.milhiecreation.com/images/arbres/arbreM01(08).jpeg",
					}
				},
				new Product
				{
					Title= "Arbre de vie sur cristal de roche teinté.",
					Price = 90,
					Gemme="Cristal de roche",
					Description="Arbre de vie fait main en fil de fer et perles de rocaille le tout monté sur une géode de quartz de roche teinté.<br /><br />Hauteur: 11cm< br />Largeur: 7.5cm",
					Link="https://fr.shopping.rakuten.com/offer/buy/4804029395/arbre-de-vie-sur-amethyste.html",
					Disponibility=false,
					Reference="medium_life_tree_02" ,
					Images=new String[]{
					"http://www.milhiecreation.com/images/arbres/arbreM02.jpeg" ,
					"http://www.milhiecreation.com/images/arbres/arbreM02(01).jpeg",
					"http://www.milhiecreation.com/images/arbres/arbreM02(02).jpeg",
					"http://www.milhiecreation.com/images/arbres/arbreM02(03).jpeg",
					"http://www.milhiecreation.com/images/arbres/arbreM02(04).jpeg",
					"http://www.milhiecreation.com/images/arbres/arbreM02(05).jpeg",
					}
				},
				new Product
				{
					Title= "Arbre de vie sur cristal de roche teinté.",
					Price = 40,
					Gemme="Cristal de roche",
					Description="Arbre de vie fait main en fil de fer et perles de rocaille le tout monté sur une géode de quartz de roche teinté.<br /><br />Hauteur: 11cm< br />Largeur: 7.5cm",
					Link="https://fr.shopping.rakuten.com/offer/buy/4804029395/arbre-de-vie-sur-amethyste.html",
					Disponibility=false,
					Reference="medium_life_tree_03" ,
					Images=new String[]{
					"http://www.milhiecreation.com/images/arbres/arbreM03.jpeg" ,
					"http://www.milhiecreation.com/images/arbres/arbreM03(01).jpeg",
					"http://www.milhiecreation.com/images/arbres/arbreM03(02).jpeg",
					"http://www.milhiecreation.com/images/arbres/arbreM03(03).jpeg",
					"http://www.milhiecreation.com/images/arbres/arbreM03(04).jpeg",
					"http://www.milhiecreation.com/images/arbres/arbreM03(05).jpeg",
					"http://www.milhiecreation.com/images/arbres/arbreM03(06).jpeg",
					}
				},
				new Product
				{
					Title= "Arbre de vie sur améthyste.",
					Price = 55,
					Gemme="Amethyst",
					Description="Arbre de vie en fil de fer et perles d'améthyste fait main , monté sur une druse d'améthyste.<br /><br />Hauteur: 17 cm< br />Largeur: 6 cm< br />Poids: 338g",
					Link="https://fr.shopping.rakuten.com/offer/buy/4804029395/arbre-de-vie-sur-amethyste.html",
					Disponibility=false,
					Reference="medium_life_tree_04" ,
					Images=new String[]{
					"http://www.milhiecreation.com/images/arbres/arbreM04.jpeg" ,
					"http://www.milhiecreation.com/images/arbres/arbreM04(01).jpeg",
					"http://www.milhiecreation.com/images/arbres/arbreM04(02).jpeg",
					"http://www.milhiecreation.com/images/arbres/arbreM04(03).jpeg",
					}
				},
				new Product
				{
					Title= "Arbre de vie sur cristal de roche teinté.",
					Price = 40,
					Gemme="Cristal de roche",
					Description="Arbre de vie fait main en fil de fer et perles de rocaille le tout monté sur une géode de cristal de roche teinté.<br /><br />Hauteur : 11cm< br />Largeur : 7cm",
					Link="https://fr.shopping.rakuten.com/offer/buy/4806967089/arbre-de-vie-sur-cristal-de-roche-teinte.html",
					Disponibility=true,
					Reference="medium_life_tree_05" ,
					Images=new String[]{
						"http://www.milhiecreation.com/images/arbres/arbreM05.jpeg" ,
						"http://www.milhiecreation.com/images/arbres/arbreM05(01).jpeg" ,
						"http://www.milhiecreation.com/images/arbres/arbreM05(02).jpeg" ,
						"http://www.milhiecreation.com/images/arbres/arbreM05(03).jpeg" ,
						"http://www.milhiecreation.com/images/arbres/arbreM05(04).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbreM05(05).jpeg" ,
					}
				},
				new Product
				{
					Title= "Arbre de vie sur tranche de bois pétrifié.",
					Price = 60,
					Gemme="Autre",
					Description="Arbre de vie fait main en fil de fer et perles miyuki sur quartz brut .<br /><br />27 cm de hauteur<br />Poids: 644g",
					Link="https://fr.shopping.rakuten.com/offer/buy/4863359924/arbre-de-vie-bonsai-sur-tranche-de-bois-petrifie.html",
					Disponibility=true,
					Reference="medium_life_tree_06" ,
					Images=new String[]{
						"http://www.milhiecreation.com/images/arbres/arbreM06.jpeg" ,
						"http://www.milhiecreation.com/images/arbres/arbreM06(01).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbreM06(02).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbreM06(03).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbreM06(04).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbreM06(05).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbreM06(06).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbreM06(07).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbreM06(08).jpeg",
						"http://www.milhiecreation.com/images/arbres/arbreM06(09).jpeg",
					}
				},
			};

			Category bigLifeTreeCategory = new Category { Name = "Big life trees", Products = bigLifeTree };
			Category mediumLifeTreeCategory = new Category { Name = "Medium life trees", Products = mediumLifeTree };

			context.AddRange(bigLifeTreeCategory,mediumLifeTreeCategory);
			context.SaveChanges();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				});
	}
}
