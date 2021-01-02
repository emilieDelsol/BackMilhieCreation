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
						"https://milhiecreation.milhie.fr/images/arbres/arbre01.jpeg" ,
						"https://milhiecreation.milhie.fr/images/arbres/arbre01(01).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre01(02).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre01(03).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre01(04).jpeg",
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
						"https://milhiecreation.milhie.fr/images/arbres/arbre02.jpeg" ,
						"https://milhiecreation.milhie.fr/images/arbres/arbre02(01).jpeg" ,
						"https://milhiecreation.milhie.fr/images/arbres/arbre02(02).jpeg"
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
						"https://milhiecreation.milhie.fr/images/arbres/arbre03.jpeg" ,
						"https://milhiecreation.milhie.fr/images/arbres/arbre03(01).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre03(02).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre03(03).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre03(04).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre03(05).jpeg"
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
						"https://milhiecreation.milhie.fr/images/arbres/arbre04(01).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre04(02).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre04(03).jpeg"
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
						"https://milhiecreation.milhie.fr/images/arbres/arbre05(02).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre05(03).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre05(04).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre05(01).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre05(05).jpeg"
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
						"https://milhiecreation.milhie.fr/images/arbres/arbre06.jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre06(01).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre06(02).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre06(03).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre06(04).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre06(05).jpeg"
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
						"https://milhiecreation.milhie.fr/images/arbres/arbre07.jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre07(01).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre07(02).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre07(03).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre07(04).jpeg"
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
						"https://milhiecreation.milhie.fr/images/arbres/arbre08.jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre08(01).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre08(02).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre08(03).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre08(04).jpeg"
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
						"https://milhiecreation.milhie.fr/images/arbres/arbre09.jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre09(01).jpeg" ,
						"https://milhiecreation.milhie.fr/images/arbres/arbre09(02).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre09(03).jpeg" ,
						"https://milhiecreation.milhie.fr/images/arbres/arbre09(04).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre09(05).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre09(06).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre09(07).jpeg" ,
						"https://milhiecreation.milhie.fr/images/arbres/arbre09(08).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre09(09).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre09(10).jpeg" ,
						"https://milhiecreation.milhie.fr/images/arbres/arbre09(11).jpeg" ,
						"https://milhiecreation.milhie.fr/images/arbres/arbre09(12).jpeg" ,
						"https://milhiecreation.milhie.fr/images/arbres/arbre09(13).jpeg ",
						"https://milhiecreation.milhie.fr/images/arbres/arbre09(14).jpeg" ,
						"https://milhiecreation.milhie.fr/images/arbres/arbre09(15).jpeg" ,
						"https://milhiecreation.milhie.fr/images/arbres/arbre09(16).jpeg" ,
						"https://milhiecreation.milhie.fr/images/arbres/arbre09(17).jpeg,",
						"https://milhiecreation.milhie.fr/images/arbres/arbre09(18).jpeg" ,
						"https://milhiecreation.milhie.fr/images/arbres/arbre09(19).jpeg" ,
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
						"https://milhiecreation.milhie.fr/images/arbres/arbre10.jpeg" ,
						"https://milhiecreation.milhie.fr/images/arbres/arbre10(01).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre10(02).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre10(03).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre10(04).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre10(05).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre10(06).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre10(07).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre10(08).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre10(09).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre10(10).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre10(11).jpeg ",
						"https://milhiecreation.milhie.fr/images/arbres/arbre10(12).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre10(13).jpeg ",
						"https://milhiecreation.milhie.fr/images/arbres/arbre10(14).jpeg"
					}
				},
				new Product
				{
					Title= "Arbre de vie 7 chakras sur tourmaline noire.",
					Price = 70,
					Gemme="Tourmaline",
					Description=" arbre de vie fait main en fil d'aluminium et perles d'ambre le tout monté sur une tourmaline noire.<br />Pièce d'art unique. <br /><br />hauteur: 17 cm< br />largeur: 10 cm< br />poids: 396g",
					Link="https://fr.shopping.rakuten.com/offer/buy/5179818575/arbre-de-vie-ambre.html",
					Disponibility=false,
					Reference="big_life_tree_11" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/arbres/arbre11.jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre11(01).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre11(02).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre11(03).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre11(04).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre11(05).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre11(06).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre11(07).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre11(08).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre11(09).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre11(10).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre11(11).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre11(12).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre11(13).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre11(14).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre11(15).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre11(16).jpeg"
					}
				},
				new Product
				{
					Title= "Arbre de vie perles d'ambre sur tourmaline noire.",
					Price = 70,
					Gemme="Tourmaline",
					Description="arbre de vie fait main en fil d'aluminium et perles d'ambre le tout monté sur une tourmaline noire.<br />Pièce d'art unique. <br /><br />hauteur:14cm< br />largeur: 9cm< br />poids:219g",
					Link="https://fr.shopping.rakuten.com/offer/buy/5179955392/arbre-de-vie-ambre.html",
					Disponibility=false,
					Reference="big_life_tree_12" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/arbres/arbre12.jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre12(01).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre12(02).jpg"
					}
				},
				new Product
				{
					Title= "Arbre de vie perles d'ambre sur une druse d'améthyste.",
					Price = 70,
					Gemme="Tourmaline",
					Description="arbre de vie fait main en fil d'aluminium et perles d'ambre le tout monté sur une druse d'améthyste.<br />Pièce d'art unique. <br /><br />hauteur:12cm ",
					Link="https://fr.shopping.rakuten.com/offer/buy/5179955392/arbre-de-vie-ambre.html",
					Disponibility=true,
					Reference="big_life_tree_13" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/arbres/arbre13.jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre13(01).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre13(02).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre13(03).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre13(04).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre13(05).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre13(06).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre13(07).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre13(08).jpg"
					}
				},
				new Product
				{
					Title= "Arbre de vie perles de rocailles sur géode de quartz.",
					Price = 90,
					Gemme="Tourmaline",
					Description=" arbre de vie fait main en fil d'aluminium et perles de rocaille vertes, le tout monté sur un géode de quartz.<br />Pièce d'art unique. <br /><br />hauteur: 20cm ",
					Link="https://fr.shopping.rakuten.com/offer/buy/5179955392/arbre-de-vie-ambre.html",
					Disponibility=true,
					Reference="big_life_tree_14" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/arbres/arbre14.jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre14(01).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre14(02).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre14(03).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre14(04).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre14(05).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre14(06).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre14(07).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre14(08).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre14(09).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre14(10).jpg"
					}
				},
				new Product
				{
					Title= "Sculpture en fil d'aluminium.",
					Price = 70,
					Gemme="Other",
					Description=" arbre de vie fait main en fil d'aluminium fait main.<br />Pièce d'art unique. <br /><br />hauteur: 20cm< br />largeur: 15cm",
					Link="https://www.vinted.fr/femmes/accessoires-autres-accessoires/568013559-sculpture-arbre-de-vie",
					Disponibility=true,
					Reference="big_life_tree_15" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/arbres/arbre15.jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre15(01).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre15(02).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre15(03).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre15(04).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre15(05).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre15(06).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre15(07).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre15(08).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre15(09).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre15(10).jpg"
					}
				},
				new Product
				{
					Title= "Grande sculpture en fil d'aluminium.",
					Price = 120,
					Gemme="Other",
					Description=" arbre de vie fait main en fil d'aluminium fait main.<br />Pièce d'art unique. <br /><br />hauteur: 40cm",
					Link="https://www.vinted.fr/femmes/accessoires-autres-accessoires/568013559-sculpture-arbre-de-vie",
					Disponibility=true,
					Reference="big_life_tree_16" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/arbres/arbre16.jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre16(01).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre16(02).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre16(03).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre16(04).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre16(05).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre16(06).jpg"
					}
				},
				new Product
				{
					Title= "Grand arbre de vie sur améthyste.",
					Price = 120,
					Gemme="Amethyst",
					Description="Arbre de vie sur améthyste. Fait main en fil d'aluminium.<br /><br />Hauteur: 25cm< br />Largeur: 15cm",
					Link="https://www.etsy.com/fr/MilhieCreation/listing/838459402/",
					Disponibility=true,
					Reference="big_life_tree_17" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/arbres/arbre17.jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre17(01).jpg",
						"https://milhiecreation.milhie.fr/images/arbres/arbre17(02).jpg"
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
					"https://milhiecreation.milhie.fr/images/arbres/arbreM01.jpeg" ,
					"https://milhiecreation.milhie.fr/images/arbres/arbreM01(01).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreM01(02).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreM01(03).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreM01(04).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreM01(05).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreM01(06).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreM01(07).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreM01(08).jpeg",
					}
				},
				new Product
				{
					Title= "Arbre de vie sur cristal de roche teinté.",
					Price = 90,
					Gemme="Quartz",
					Description="Arbre de vie fait main en fil de fer et perles de rocaille le tout monté sur une géode de quartz de roche teinté.<br /><br />Hauteur: 11cm< br />Largeur: 7.5cm",
					Link="https://fr.shopping.rakuten.com/offer/buy/4804029395/arbre-de-vie-sur-amethyste.html",
					Disponibility=false,
					Reference="medium_life_tree_02" ,
					Images=new String[]{
					"https://milhiecreation.milhie.fr/images/arbres/arbreM02.jpeg" ,
					"https://milhiecreation.milhie.fr/images/arbres/arbreM02(01).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreM02(02).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreM02(03).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreM02(04).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreM02(05).jpeg",
					}
				},
				new Product
				{
					Title= "Arbre de vie sur cristal de roche teinté.",
					Price = 40,
					Gemme="Quartz",
					Description="Arbre de vie fait main en fil de fer et perles de rocaille le tout monté sur une géode de quartz de roche teinté.<br /><br />Hauteur: 11cm< br />Largeur: 7.5cm",
					Link="https://fr.shopping.rakuten.com/offer/buy/4804029395/arbre-de-vie-sur-amethyste.html",
					Disponibility=false,
					Reference="medium_life_tree_03" ,
					Images=new String[]{
					"https://milhiecreation.milhie.fr/images/arbres/arbreM03.jpeg" ,
					"https://milhiecreation.milhie.fr/images/arbres/arbreM03(01).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreM03(02).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreM03(03).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreM03(04).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreM03(05).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreM03(06).jpeg",
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
					"https://milhiecreation.milhie.fr/images/arbres/arbreM04.jpeg" ,
					"https://milhiecreation.milhie.fr/images/arbres/arbreM04(01).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreM04(02).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreM04(03).jpeg",
					}
				},
				new Product
				{
					Title= "Arbre de vie sur cristal de roche teinté.",
					Price = 40,
					Gemme="Quartz",
					Description="Arbre de vie fait main en fil de fer et perles de rocaille le tout monté sur une géode de cristal de roche teinté.<br /><br />Hauteur : 11cm< br />Largeur : 7cm",
					Link="https://fr.shopping.rakuten.com/offer/buy/4806967089/arbre-de-vie-sur-cristal-de-roche-teinte.html",
					Disponibility=true,
					Reference="medium_life_tree_05" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/arbres/arbreM05.jpeg" ,
						"https://milhiecreation.milhie.fr/images/arbres/arbreM05(01).jpeg" ,
						"https://milhiecreation.milhie.fr/images/arbres/arbreM05(02).jpeg" ,
						"https://milhiecreation.milhie.fr/images/arbres/arbreM05(03).jpeg" ,
						"https://milhiecreation.milhie.fr/images/arbres/arbreM05(04).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbreM05(05).jpeg" ,
					}
				},
				new Product
				{
					Title= "Arbre de vie sur tranche de bois pétrifié.",
					Price = 60,
					Gemme="Other",
					Description="Arbre de vie fait main en fil de fer et perles miyuki sur quartz brut .<br /><br />27 cm de hauteur<br />Poids: 644g",
					Link="https://fr.shopping.rakuten.com/offer/buy/4863359924/arbre-de-vie-bonsai-sur-tranche-de-bois-petrifie.html",
					Disponibility=true,
					Reference="medium_life_tree_06" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/arbres/arbreM06.jpeg" ,
						"https://milhiecreation.milhie.fr/images/arbres/arbreM06(01).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbreM06(02).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbreM06(03).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbreM06(04).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbreM06(05).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbreM06(06).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbreM06(07).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbreM06(08).jpeg",
						"https://milhiecreation.milhie.fr/images/arbres/arbreM06(09).jpeg",
					}
				},
			};
			ICollection<Product> smallLifeTree = new List<Product>
			{
				new Product
				{
					Title= "Arbre de vie bonsaï sur pierre.",
					Price = 10,
					Gemme="Other",
					Description="Joli bonsaï en fil de fer et perles de rocaille sur pierre fait main .<br /><br />Hauteur: 10 cm< br />Largeur: 8 cm< br />Poids: 100g.",
					Link="https://fr.shopping.rakuten.com/offer/buy/4806967092/arbre-de-vie-bonsai-sur-pierre.html",
					Disponibility=true,
					Reference="small_life_tree_01" ,
					Images=new String[]{
					"https://milhiecreation.milhie.fr/images/arbres/arbreS01.jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreS01(01).jpeg"	
					}
				},
				new Product
				{
					Title= "Arbre de vie améthyste.",
					Price = 10,
					Gemme="Amethyst",
					Description="Petit arbre de vie en fil d'argent monté sur druse d'améthyste et perles en améthyste.<br /><br />Hauteur: 5cm< br />Largeur: 3,5cm",
					Link="https://fr.shopping.rakuten.com/offer/buy/4806967094/petit-arbre-de-vie-sur-amethyste.html",
					Disponibility=true,
					Reference="small_life_tree_02" ,
					Images=new String[]{
					"https://milhiecreation.milhie.fr/images/arbres/arbreS02.jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreS02(01).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreS02(02).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreS02(03).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreS02(04).jpeg"
					}
				},
				new Product
				{
					Title= "Arbre de vie sur cristal de roche.",
					Price = 10,
					Gemme="Quartz",
					Description="Petit arbre de vie en fil d'argent monté sur cristal de roche et perles en cristal de roche.<br /><br />Hauteur: 5cm< br />Largeur: 3cm",
					Link="https://fr.shopping.rakuten.com/offer/buy/4806967096/petit-arbre-de-vie-sur-cristal-de-roche.html",
					Disponibility=true,
					Reference="small_life_tree_03" ,
					Images=new String[]{
					"https://milhiecreation.milhie.fr/images/arbres/arbreS03.jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreS03(01).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreS03(02).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreS03(03).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreS03(04).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreS03(05).jpeg"
					}
				},
				new Product
				{
					Title= "Arbre de vie sur pierre.",
					Price = 8,
					Gemme="Other",
					Description="Bonsaï en fil de fer fait main sur pierre. chaque modèle est unique, créé par mes soins.<br /><br />Hauteur: 10 cm< br />Largeur: 10 cm< br />Poids: 80g",
					Link="https://fr.shopping.rakuten.com/offer/buy/4804029395/arbre-de-vie-sur-amethyste.html",
					Disponibility=false,
					Reference="small_life_tree_04" ,
					Images=new String[]{
					"https://milhiecreation.milhie.fr/images/arbres/arbreS04.jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreS04(01).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreS04(02).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreS04(03).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreS04(04).jpeg"
					}
				},
				new Product
				{
					Title= "Arbre de vie sur marbre blanc.",
					Price = 10,
					Gemme="Other",
					Description="Bonsaï en fil de fer sur pierre de marbre blanc fait main.<br /><br />Hauteur: 12 cm< br />Largeur: 10 cm",
					Link="https://fr.shopping.rakuten.com/offer/buy/4806967100/arbre-de-vie-bonsai-sur-pierre.html",
					Disponibility=true,
					Reference="small_life_tree_05" ,
					Images=new String[]{
					"https://milhiecreation.milhie.fr/images/arbres/arbreS05.jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreS05(01).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreS05(02).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreS05(03).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreS05(04).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreS05(05).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreS05(06).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreS05(07).jpeg"
					}
				},
				new Product
				{
					Title= "Arbre de vie sur marbre blanc.",
					Price = 5,
					Gemme="Other",
					Description="Arbre en fil de fer doré fait main sur pierre de marbre blanc.<br /><br />Hauteur: 5cm< br />Largeur: 7cm< br />Poids: 57g",
					Link="https://fr.shopping.rakuten.com/offer/buy/4806967100/arbre-de-vie-bonsai-sur-pierre.html",
					Disponibility=true,
					Reference="small_life_tree_06" ,
					Images=new String[]{
					"https://milhiecreation.milhie.fr/images/arbres/arbreS06.jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreS06(01).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreS06(02).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreS06(04).jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreS06(05).jpeg"
					}
				},
				new Product
				{
					Title= "Arbre de vie sur marbre blanc.",
					Price = 5,
					Gemme="Other",
					Description="Arbre en fil de fer doré fait main sur pierre de marbre blanc.<br /><br />Hauteur: 5cm",
					Link="https://fr.shopping.rakuten.com/offer/buy/4806967105/petit-arbre-de-vie-sur-marbre-blanc.html",
					Disponibility=true,
					Reference="small_life_tree_07" ,
					Images=new String[]{
					"https://milhiecreation.milhie.fr/images/arbres/arbreS07.jpeg",
					"https://milhiecreation.milhie.fr/images/arbres/arbreS07(01).jpeg"
					}
				},
			};

			ICollection<Product> dreamcatcher = new List<Product>
			{
				new Product
				{
					Title= "Piège à rêves n°1:",
					Price = 35,
					Gemme="None",
					Description="<p>Diamètre du cercle principal: 30cm.</p><p>Hauteur: 70cm </ p >< p > Attrape rêve fait main en fil d'aluminium, fil de coton , perles en verre et plumes naturelles.</p> ",
					Link="https://www.vinted.fr/femmes/accessoires-autres-accessoires/246854940-petit-attrape-reve-avec-arbre-de-vie-fait-main",
					Disponibility=false,
					Reference="dreamcatcher_01" ,
					Images=new String[]{
						"https://php.milhie.fr/images/piegesReves/piege.jpeg"
					}
				},
				new Product
				{
					Title= "Piège à rêves n°2:",
					Price = 35,
					Gemme="None",
					Description="<p>Diamètre du cercle principal: 30cm.</p><p>Hauteur: 60cm </ p >< p > Attrape rêve fait main en fil d'aluminium, fil de coton , perles en verre et plumes naturelles.</p> ",
					Link="https://www.vinted.fr/femmes/accessoires-autres-accessoires/246854940-petit-attrape-reve-avec-arbre-de-vie-fait-main",
					Disponibility=false,
					Reference="dreamcatcher_02" ,
					Images=new String[]{
						"https://www.milhiecreation.milhie.fr/images/piegesReves/piege01.jpeg"
					}
				},
				new Product
				{
					Title= "Piège à rêves n°3:",
					Price = 35,
					Gemme="None",
					Description="<p>Diamètre du cercle principal: 30cm.</p><p>Hauteur: 75cm </ p >< p > Attrape rêve fait main en fil d'aluminium, fil de coton beige, marron clair et foncé, perles en verre et plumes naturelles.</p> ",
					Link="https://www.vinted.fr/femmes/accessoires-autres-accessoires/246854940-petit-attrape-reve-avec-arbre-de-vie-fait-main",
					Disponibility=false,
					Reference="dreamcatcher_03" ,
					Images=new String[]{
						"https://www.milhiecreation.milhie.fr/images/piegesReves/piege02.jpeg"
					}
				},
				new Product
				{
					Title= "Piège à rêves n°4:",
					Price = 18,
					Gemme="None",
					Description="<p>Hauteur: 20cm</p><p>Piège à rêve fait main, cercle en fil d'aluminium noir, fils de coton blanc, perles en verre noires, arbre de vie en fil de fer noir et plumes naturelles.<br/>Idéal en décoration de rétroviseur</p> ",
					Link="https://www.vinted.fr/femmes/accessoires-autres-accessoires/246854940-petit-attrape-reve-avec-arbre-de-vie-fait-main",
					Disponibility=true,
					Reference="dreamcatcher_04" ,
					Images=new String[]{
						"https://www.milhiecreation.milhie.fr/images/piegesReves/piege03.jpeg"
					}
				},
				new Product
				{
					Title= "Piège à rêves n°5:",
					Price = 18,
					Gemme="None",
					Description="<p>Diametre: 20cm</p><p>Petit piège à rêve fait main, plumes naturelles.<br/>Idéal en décoration de rétroviseur</p> ",
					Link="https://www.vinted.fr/femmes/sacs-autres/247948481-attrape-reve",
					Disponibility=true,
					Reference="dreamcatcher_05" ,
					Images=new String[]{
						"https://www.milhiecreation.milhie.fr/images/piegesReves/piege04.jpeg"
					}
				},
				new Product
				{
					Title= "Piège à rêves n°6:",
					Price = 18,
					Gemme="None",
					Description="<p>Petit attrape rêve fait main.</p><p>Diamètre: 20cm </ p >< p > Fil de coton bleu ciel et bleu-vert pour le centre, perles en verre et hématite au centre.Plumes synthétiques.</p> ",
					Link="https://www.vinted.fr/femmes/sacs-autres/247948481-attrape-reve",
					Disponibility=true,
					Reference="dreamcatcher_05" ,
					Images=new String[]{
						"https://www.milhiecreation.milhie.fr/images/piegesReves/piege05.jpeg"
					}
				},
			};

			ICollection<UnderCategory> trees = new List<UnderCategory>
			{
				new UnderCategory { Name = "Big life trees", Products = bigLifeTree } ,
				new UnderCategory { Name = "Medium life trees", Products = mediumLifeTree },
				new UnderCategory { Name= "Small Life trees", Products=smallLifeTree }
			};
			ICollection<UnderCategory> underDecos = new List<UnderCategory>
			{
				new UnderCategory{ Name="Dreamcatcher", Products=dreamcatcher}
			};
			Category lifeTrees = new Category { Name = "Life trees", UnderCategories = trees };
			Category decos = new Category { Name = "Decorations", UnderCategories = underDecos };
			context.AddRange(lifeTrees, decos);
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
