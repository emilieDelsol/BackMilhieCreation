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
			//CreateDatabase();
			CreateHostBuilder(args).Build().Run();
		}

	/*	private static void CreateDatabase()
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
						"https://milhiecreation.milhie.fr/images/piegesReves/piege.jpeg"
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
			ICollection<Product> wallDecos = new List<Product>
			{
				new Product
				{
					Title= "Dinosaures:",
					Price = 30,
					Gemme="None",
					Description="<p>Décoration murale pour chambre d'enfant inspiration dinosaures</p><p>Largeur: 30cm.</p> ",
					Link="",
					Disponibility=false,
					Reference="dino_01" ,
					Images=new String[]{
						"https://www.milhiecreation.milhie.fr/images/decosMurales/decoDino1.jpeg"
					}
				},
			new Product
				{
					Title= "Dinosaures:",
					Price = 30,
					Gemme="None",
					Description="<p>Décoration murale pour chambre d'enfant inspiration dinosaures</p><p>Largeur: 30cm.</p> ",
					Link="",
					Disponibility=false,
					Reference="dino_02" ,
					Images=new String[]{
						"https://www.milhiecreation.milhie.fr/images/decosMurales/decoDino2.jpeg"
					}
				},
			new Product
				{
					Title= "Camion de pompiers:",
					Price = 25,
					Gemme="None",
					Description="<p>Décoration murale pour chambre d'enfant camion de pompiers</p><p>Largeur: 30cm.</p> ",
					Link="",
					Disponibility=false,
					Reference="pompiers_01" ,
					Images=new String[]{
						"https://www.milhiecreation.milhie.fr/images/decosMurales/decoPompier.jpeg"
					}
				},
			new Product
				{
					Title= "Chateau de princesse:",
					Price = 30,
					Gemme="None",
					Description="<p>Décoration murale pour chambre d'enfant chateau de princesse</p><p>Largeur: 30cm.</p> ",
					Link="",
					Disponibility=false,
					Reference="princess_01" ,
					Images=new String[]{
						"https://www.milhiecreation.milhie.fr/images/decosMurales/decoChateauPrincess.jpeg"
					}
				},
			new Product
				{
					Title= "Chateau fort:",
					Price = 30,
					Gemme="None",
					Description="<p>Décoration murale pour chambre d'enfant chateau fort</p><p>Largeur: 30cm.</p> ",
					Link="",
					Disponibility=false,
					Reference="castel_01" ,
					Images=new String[]{
						"https://www.milhiecreation.milhie.fr/images/decosMurales/decoChateauFort.jpeg"
					}
				},
			new Product
				{
					Title= "Nuage coeurs:",
					Price = 20,
					Gemme="None",
					Description="<p>Décoration murale pour chambre d'enfant nuages et coeurs</p><p>Largeur: 25cm.</p> ",
					Link="",
					Disponibility=false,
					Reference="coeur_01" ,
					Images=new String[]{
						"https://www.milhiecreation.milhie.fr/images/decosMurales/decoNuage.png"
					}
				},
			new Product
				{
					Title= "Bateau pirate:",
					Price = 30,
					Gemme="None",
					Description="<p>Décoration murale pour chambre d'enfant bateau pirate</p><p>Largeur: 30cm.</p> ",
					Link="",
					Disponibility=false,
					Reference="coeur_01" ,
					Images=new String[]{
						"https://www.milhiecreation.milhie.fr/images/decosMurales/decoNuage.png"
					}
				},
			new Product
				{
					Title= "Vélo:",
					Price = 30,
					Gemme="None",
					Description="<p>Décoration murale pour chambre d'enfant vélo</p><p>Largeur: 30cm.</p> ",
					Link="",
					Disponibility=false,
					Reference="coeur_01" ,
					Images=new String[]{
						"https://www.milhiecreation.milhie.fr/images/decosMurales/velo.jpeg"
					}
				},
			new Product
				{
					Title= "Fanart buzz l'éclair:",
					Price = 30,
					Gemme="None",
					Description="<p>Décoration murale pour chambre buzz l'éclair</p><p>Largeur: 30cm.</p> ",
					Link="",
					Disponibility=false,
					Reference="buzz_01" ,
					Images=new String[]{
						"https://www.milhiecreation.milhie.fr/images/decosMurales/buzz.png"
					}
				},
			new Product
				{
					Title= "Décoration de porte:",
					Price = 15,
					Gemme="None",
					Description="<p>Décoration de porte pour chambre </p><p>Largeur: 20cm.</p> ",
					Link="",
					Disponibility=false,
					Reference="buzz_01" ,
					Images=new String[]{
						"https://www.milhiecreation.milhie.fr/images/decosMurales/coeur.jpeg"
					}
				},
			new Product
				{
					Title= "Loup dans les étoiles:",
					Price = 25,
					Gemme="None",
					Description="<p>Décoration  pour chambre d'enfant </p><p>Largeur: 30cm.</p> ",
					Link="",
					Disponibility=false,
					Reference="wolf_01" ,
					Images=new String[]{
						"https://www.milhiecreation.milhie.fr/images/decosMurales/loup.png"
					}
				},
			new Product
				{
					Title= "Chat dans les étoiles:",
					Price = 25,
					Gemme="None",
					Description="<p>Décoration  pour chambre d'enfant </p><p>Largeur: 30cm.</p> ",
					Link="",
					Disponibility=false,
					Reference="cat_01" ,
					Images=new String[]{
						"https://www.milhiecreation.milhie.fr/images/decosMurales/chat.jpeg"
					}
				},
			};
			ICollection<Product> weddingDecos = new List<Product>
			{
				new Product
				{
					Title= "Marque place 'coeur' personnalisable.",
					Price = 3,
					Gemme="None",
					Description=" Marque place en fil d'aluminium.<br/>Idéal pour une table de mariage. Forme et couleur du fil au choix.<br/>Prévoir un délais de fabrication et un délais supplémentaire si la couleur demandée n'est pas en stock.<br/>Réduction sur les grosses commandes.<br/>Entièrement personnalisable. ",
					Link="https://www.vinted.fr/femmes/autres-bijoux/257059466-marque-place-mariage-personnalisable",
					Disponibility =false,
					Reference="wedding_01" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/decosMariage/mariage1.jpeg",
						"https://milhiecreation.milhie.fr/images/decosMariage/mariage1.jpeg(01).jpeg",
						"https://milhiecreation.milhie.fr/images/decosMariage/mariage1.jpeg(02).jpeg",
						"https://milhiecreation.milhie.fr/images/decosMariage/mariage1.jpeg(03).jpeg",
						"https://milhiecreation.milhie.fr/images/decosMariage/mariage1.jpeg(04).jpeg",
						"https://milhiecreation.milhie.fr/images/decosMariage/mariage1.jpeg(05).jpeg"
					}
				},
				new Product
				{
					Title= "Marque place 'coeur' personnalisable couleur argent.",
					Price = 3,
					Gemme="None",
					Description="Idéal pour une table de mariage. Forme et couleur du fil au choix. <br/>Prévoir un délais de fabrication et un délais supplémentaire si la couleur demandée n'est pas en stock.<br/>Réduction sur les grosses commandes.<br/>Entièrement personnalisable.",
					Link="https://www.vinted.fr/femmes/autres-bijoux/257059466-marque-place-mariage-personnalisable",
					Disponibility =false,
					Reference="wedding_02" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/decosMariage/mariage2.jpeg",
						"https://milhiecreation.milhie.fr/images/decosMariage/mariage2(01).jpeg",
						"https://milhiecreation.milhie.fr/images/decosMariage/mariage2(02).jpeg",
						"https://milhiecreation.milhie.fr/images/decosMariage/mariage2(03).jpeg",
						"https://milhiecreation.milhie.fr/images/decosMariage/mariage2(04).jpeg",
						"https://milhiecreation.milhie.fr/images/decosMariage/mariage2(05).jpeg",
						"https://milhiecreation.milhie.fr/images/decosMariage/mariage2(06).jpeg",
						"https://milhiecreation.milhie.fr/images/decosMariage/mariage2(07).jpeg",
						"https://milhiecreation.milhie.fr/images/decosMariage/mariage2(08).jpeg",
						"https://milhiecreation.milhie.fr/images/decosMariage/mariage2(09).jpeg",
						"https://milhiecreation.milhie.fr/images/decosMariage/mariage2(10).jpeg"
					}
				},
			};
			ICollection<Product> ring = new List<Product>
			{
				new Product
				{
					Title= "Bague N°1:",
					Price = 8,
					Gemme="None",
					Description="Fleur en résine. ",
					Link="",
					Disponibility =false,
					Reference="ring_01" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/bagues/bague1_259.jpeg"
					}
				},
				new Product
				{
					Title= "Bague N°2:",
					Price = 5,
					Gemme="None",
					Description="Clé de sol. ",
					Link="",
					Disponibility =false,
					Reference="ring_02" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/bagues/bague2_259.jpeg"
					}
				},
				new Product
				{
					Title= "Bague N°3:",
					Price = 5,
					Gemme="None",
					Description="Toupies en verre. ",
					Link="",
					Disponibility =false,
					Reference="ring_03" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/bagues/bague3_259.jpeg"
					}
				},
				new Product
				{
					Title= "Bague N°4:",
					Price = 8,
					Gemme="None",
					Description="Hématite et toupies en verre. ",
					Link="",
					Disponibility =false,
					Reference="ring_04" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/bagues/bague4_259.jpeg"
					}
				},
				new Product
				{
					Title= "Bague N°5:",
					Price = 8,
					Gemme="None",
					Description="Bague en fil d'aluminium. ",
					Link="",
					Disponibility =false,
					Reference="ring_05" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/bagues/bague5_259.jpg"
					}
				},
				new Product
				{
					Title= "Bague N°6:",
					Price = 8,
					Gemme="None",
					Description="Hématite et perle. ",
					Link="",
					Disponibility =false,
					Reference="ring_06" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/bagues/bague6_259.jpg"
					}
				},
				new Product
				{
					Title= "Bague N°7:",
					Price = 8,
					Gemme="None",
					Description="Perles en verre. ",
					Link="",
					Disponibility =false,
					Reference="ring_07" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/bagues/bague7_259.jpg"
					}
				},
				new Product
				{
					Title= "Bague N°8:",
					Price = 5,
					Gemme="None",
					Description="Arbre de vie. ",
					Link="",
					Disponibility =false,
					Reference="ring_08" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/bagues/bague8_259.jpg"
					}
				},
			};
			ICollection<Product> earrings = new List<Product>
			{
				new Product
				{
					Title= "Boucle N°1:",
					Price = 6,
					Gemme="None",
					Description="Boucles d'oreilles en fil d'aluminium. ",
					Link="https://www.vinted.fr/femmes/boucles-doreilles/241562348-boucles-doreilles-fil-aluminium",
					Disponibility =true,
					Reference="earring_01" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/bijoux/boucles/boucles1.jpeg"
					}
				},
				new Product
				{
					Title= "Boucle N°2:",
					Price = 0,
					Gemme="None",
					Description="Boucles d'oreilles en fil d'aluminium. ",
					Link="https://www.vinted.fr/femmes/boucles-doreilles/241562348-boucles-doreilles-fil-aluminium",
					Disponibility =true,
					Reference="earring_02" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/under.jpg"
					}
				},
				new Product
				{
					Title= "Boucle N°3:",
					Price = 0,
					Gemme="None",
					Description="Boucles d'oreilles en fil d'aluminium. ",
					Link="https://www.vinted.fr/femmes/boucles-doreilles/241562348-boucles-doreilles-fil-aluminium",
					Disponibility =true,
					Reference="earring_03" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/under.jpg"
					}
				},
				new Product
				{
					Title= "Boucle N°4:",
					Price = 0,
					Gemme="None",
					Description="Boucles d'oreilles en fil d'aluminium. ",
					Link="https://www.vinted.fr/femmes/boucles-doreilles/241562348-boucles-doreilles-fil-aluminium",
					Disponibility =true,
					Reference="earring_04" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/under.jpg"
					}
				},
			};
			ICollection<Product> slimBracelet = new List<Product>
			{
				new Product
				{
					Title= "Tricolore:",
					Price = 7,
					Gemme="None",
					Description="bracelet en fil d'aluminium et fil de cuivre tricolore, or, argent et cuivre.<br />Réglable.<br />En photo poignet de 15 cm de circonférence. ",
					Link="https://www.vinted.fr/femmes/bracelets/250387983-bracelet-en-aluminium-et-cuivre",
					Disponibility =true,
					Reference="bracelet_fin_01" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/bracelets/fin1.jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/fin1(01).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/fin1(02).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/fin1(03).jpeg"
					}
				},
				new Product
				{
					Title= "Bracelet tourbillons:",
					Price = 7,
					Gemme="None",
					Description="Bracelet en fil d'aluminium ''tourbillons''.<br />Ajustable. ",
					Link="https://www.vinted.fr/femmes/bracelets/248802009-bracelet-en-fil-daluminium",
					Disponibility =true,
					Reference="bracelet_fin_02" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/bracelets/fin2.jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/fin2(01).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/fin2(02).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/fin2(03).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/fin2(04).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/fin2(05).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/fin2(06).jpeg"
					}
				},
				new Product
				{
					Title= "Bracelet aluminium et cuivre:",
					Price = 10,
					Gemme="None",
					Description="Bracelet fin en fil d'aluminium et de cuivre.<br />Ajustable. ",
					Link="https://www.vinted.fr/femmes/bracelets/248802009-bracelet-en-fil-daluminium",
					Disponibility =true,
					Reference="bracelet_fin_03" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/bracelets/fin3.jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/fin3(01).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/fin3(02).jpeg"
					}
				},
				new Product
				{
					Title= "Braceleten fil d' aluminium bicolore:",
					Price = 7,
					Gemme="None",
					Description="Bracelet fin en fil d'aluminium argenté et doré.<br />Ajustable. ",
					Link="https://www.vinted.fr/femmes/bracelets/250043220-bracelet-en-fil-daluminium",
					Disponibility =true,
					Reference="bracelet_fin_04" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/bracelets/fin4.jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/fin4(01).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/fin4(02).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/fin4(03).jpeg"
					}
				},
				new Product
				{
					Title= "Braceleten fil d' aluminium et cuivre:",
					Price = 7,
					Gemme="None",
					Description="Bracelet fin en fil d'aluminium et fil de cuivre.<br />Taille sur mesure. ",
					Link="https://www.vinted.fr/femmes/bracelets/250043220-bracelet-en-fil-daluminium",
					Disponibility =false,
					Reference="bracelet_fin_05" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/bracelets/fin5.jpeg"
					}
				},
				new Product
				{
					Title= "Bracelet bicolore:",
					Price = 10,
					Gemme="None",
					Description="Bracelet fin en fil d'aluminium couleur or et argent.<br />Ajustable. ",
					Link="https://www.vinted.fr/femmes/bracelets/248829998-bracelet-ajustable-fait-main",
					Disponibility =false,
					Reference="bracelet_fin_06" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/bracelets/fin6.jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/fin6(01).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/fin6(02).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/fin6(03).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/fin6(04).jpeg"
					}
				},
			};
			ICollection<Product> manchettes = new List<Product>
			{
				new Product
				{
					Title= "Manchette N°1:",
					Price = 26,
					Gemme="None",
					Description=" Manchette arbre de vie en fil d'aluminium argenté et perles de rocaille, fait main.<br /><br />Réglable. ",
					Link="https://www.vinted.fr/femmes/bracelets/243523664-manchette-arbre-de-vie-reglable",
					Disponibility =false,
					Reference="manchette_01" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/bracelets/manchette1.jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/manchette1(01).jpeg"
					}
				},
				new Product
				{
					Title= "Manchette N°2:",
					Price = 25,
					Gemme="None",
					Description="Manchette arbre de vie en fil d'aluminium noir et argenté, fait main.<br /><br />Réglable.",
					Link="https://www.vinted.fr/femmes/bracelets/243523664-manchette-arbre-de-vie-reglable",
					Disponibility =true,
					Reference="manchette_02" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/bracelets/manchette2.jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/manchette2(01).jpeg"
					}
				},
				new Product
				{
					Title= "Manchette N°3:",
					Price = 25,
					Gemme="None",
					Description="Manchette arbre de vie en fil d'aluminium argenté, fait main.<br /><br />Réglable.",
					Link="https://www.vinted.fr/femmes/bracelets/246388490-manchette-arbre-de-vie-en-fil-daluminium",
					Disponibility =true,
					Reference="manchette_03" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/bracelets/manchette3.jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/manchette3(01).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/manchette3(02).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/manchette3(03).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/manchette3(04).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/manchette3(05).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/manchette3(06).jpeg"
					}
				},
				new Product
				{
					Title= "Manchette N°4:",
					Price = 25,
					Gemme="None",
					Description="Manchette arbre de vie en fil d'aluminium argenté, fait main.<br /><br />Réglable.",
					Link="https://www.vinted.fr/femmes/bracelets/255627160-manchette-arbre-de-vie",
					Disponibility =true,
					Reference="manchette_04" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/bracelets/manchette4.jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/manchette4(01).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/manchette4(02).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/manchette4(03).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/manchette4(04).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/manchette4(05).jpeg"
					}
				},
				new Product
				{
					Title= "Manchette N°5:",
					Price = 25,
					Gemme="None",
					Description="Manchette arbre de vie en fil d'aluminium bicolore argent et or, fait main.<br /><br />Réglable.",
					Link="https://www.vinted.fr/femmes/bracelets/243523664-manchette-arbre-de-vie-reglable",
					Disponibility =false,
					Reference="manchette_05" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/bracelets/manchette5.jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/manchette5(01).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/manchette5(02).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/manchette5(03).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/manchette5(04).jpeg"
					}
				},
				new Product
				{
					Title= "Manchette N°6:",
					Price = 26,
					Gemme="None",
					Description="Manchette arbre de vie en fil d'aluminium argenté et perles miyuki bleues, fait main.<br /><br />Réglable.",
					Link="https://www.vinted.fr/femmes/bracelets/305323588-manchette-arbre-de-vie",
					Disponibility =true,
					Reference="manchette_06" ,
					Images=new String[]{
						"https://milhiecreation.milhie.fr/images/bracelets/manchette6.jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/manchette6(01).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/manchette6(02).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/manchette6(03).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/manchette6(04).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/manchette6(05).jpeg",
						"https://milhiecreation.milhie.fr/images/bracelets/manchette6(06).jpeg"
					}
				},
			};
			ICollection<Product> lyto = new List<Product>
			{
				new Product
				{
					Title= "Bracelet arbre de vie sur aventurine:",
					Price = 30,
					Gemme="Aventurine",
					Description=" Bracelet arbre de vie fait main en fil d'aluminium monté sur une aventurine.<br/>Ce modèle est également disponible à la commande avec d'autres pierres de lytothérapie: améthyste, œil de tigre, labradorite et bien d'autres...<br/>Produit fait main, chaque modèle est unique.<br/>En photo poignet de 15cm de circonférence, possibilité d'ajuster en fonction de la taille de votre poignet, n'hésitez pas à me contacter pour d'autres tailles.",
					Link="https://www.vinted.fr/femmes/bracelets/419378353-bracelet-arbre-de-vie-sur-pierre-aventurine",
					Disponibility =false,
					Reference="lyto_01" ,
					Images=new String[]{
						"https://php.milhie.fr/images/bracelets/lyto1.jpeg",
						"https://php.milhie.fr/images/bracelets/lyto1(01).jpeg",
						"https://php.milhie.fr/images/bracelets/lyto1(02).jpeg",
						"https://php.milhie.fr/images/bracelets/lyto1(03).jpeg",
						"https://php.milhie.fr/images/bracelets/lyto1(04).jpeg"
					}
				},
				new Product
				{
					Title= "Bracelet arbre de vie sur howlite:",
					Price = 30,
					Gemme="Howlite",
					Description=" Bracelet arbre de vie fait main en fil d'aluminium monté sur une howlite.<br/>Ce modèle est également disponible à la commande avec d'autres pierres de lytothérapie: améthyste, œil de tigre, labradorite et bien d'autres...<br/>Produit fait main, chaque modèle est unique.<br/>En photo poignet de 15cm de circonférence, possibilité d'ajuster en fonction de la taille de votre poignet, n'hésitez pas à me contacter pour d'autres tailles.",
					Link="https://www.vinted.fr/femmes/bracelets/419378353-bracelet-arbre-de-vie-sur-pierre-aventurine",
					Disponibility =false,
					Reference="lyto_02" ,
					Images=new String[]{
						"https://php.milhie.fr/images/bracelets/lyto2.jpeg",
						"https://php.milhie.fr/images/bracelets/lyto2(01).jpeg",
						"https://php.milhie.fr/images/bracelets/lyto2(02).jpeg",
						"https://php.milhie.fr/images/bracelets/lyto2(03).jpeg",
						"https://php.milhie.fr/images/bracelets/lyto2(04).jpeg",
						"https://php.milhie.fr/images/bracelets/lyto2(05).jpeg"
					}
				},
			};
			ICollection<Product> braceletAlu = new List<Product>
			{
				new Product
				{
					Title= "Bracelet fleur en résine:",
					Price = 20,
					Gemme="none",
					Description="Bracelet en fil d'aluminium et perles en verre.<br />Fleur en résine fait main.<br />Bracelet ajustable.<br />Idéal pour sublimer une tenue de mariage.<br />Possibilité de création de colliers, boucles d'oreilles et bijoux de cheveux assortis.",
					Link="https://www.vinted.fr/femmes/bracelets/241504920-bracelet-en-fil-daluminium-ideal-en-bijou-de-mariage",
					Disponibility =false,
					Reference="bracelet_01" ,
					Images=new String[]{
						"https://php.milhie.fr/images/bracelets/bracelet1.jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet1(01).jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet1(02).jpeg"
					}
				},
				new Product
				{
					Title= "Bracelet en fil d'aluminium et perles en verre.",
					Price = 20,
					Gemme="none",
					Description="Bracelet en fil d'aluminium et perles en verre.<br />Bracelet ajustable.<br />Idéal pour sublimer une tenue de mariage.<br />Possibilité de création de colliers, boucles d'oreilles et bijoux de cheveux assortis.",
					Link="https://www.vinted.fr/femmes/bracelets/241557075-bracelet-en-fil-daluminium-fait-main-ideal-en-bijou-de-mariage",
					Disponibility =false,
					Reference="bracelet_02" ,
					Images=new String[]{
						"https://php.milhie.fr/images/bracelets/bracelet2.jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet2(01).jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet2(02).jpeg"
					}
				},
				new Product
				{
					Title= "Bracelet en fil d'aluminiujm et fleur.",
					Price = 10,
					Gemme="none",
					Description="Bracelet en fil d'aluminium et perles en verre.<br />Fleur en résine fait main.<br />Bracelet ajustable.<br />Idéal pour sublimer une tenue de mariage.<br />Possibilité de création de colliers, boucles d'oreilles et bijoux de cheveux assortis.",
					Link="https://www.vinted.fr/femmes/bracelets/241557075-bracelet-en-fil-daluminium-fait-main-ideal-en-bijou-de-mariage",
					Disponibility =true,
					Reference="bracelet_03" ,
					Images=new String[]{
						"https://php.milhie.fr/images/bracelets/bracelet3.jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet3(01).jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet3(02).jpeg"
					}
				},
				new Product
				{
					Title= "Bracelet perles cristal et verre..",
					Price = 15,
					Gemme="none",
					Description="Bracelet en fil d'aluminium, perles en verre et toupies cristal.<br />Bracelet ajustable.<br />Possibilité de création de colliers, boucles d'oreilles et bijoux de cheveux assortis.",
					Link="https://www.vinted.fr/femmes/bracelets/241557075-bracelet-en-fil-daluminium-fait-main-ideal-en-bijou-de-mariage",
					Disponibility =true,
					Reference="bracelet_04" ,
					Images=new String[]{
						"https://php.milhie.fr/images/bracelets/bracelet4.jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet4(01).jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet4(02).jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet4(03).jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet4(04).jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet4(05).jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet4(06).jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet4(07).jpeg"
					}
				},
				new Product
				{
					Title= "Bracelet 3 fils.",
					Price = 10,
					Gemme="none",
					Description="Bracelet en fil d'aluminium.<br />Ajustable.<br />Possibilité de création de colliers, boucles d'oreilles et bijoux de cheveux assortis.",
					Link="https://www.vinted.fr/femmes/bracelets/241557075-bracelet-en-fil-daluminium-fait-main-ideal-en-bijou-de-mariage",
					Disponibility =false,
					Reference="bracelet_05" ,
					Images=new String[]{
						"https://php.milhie.fr/images/bracelets/bracelet5.jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet5(01).jpeg"
					}
				},
				new Product
				{
					Title= "Bracelet fil d'aluminium noir et argent.",
					Price = 5,
					Gemme="none",
					Description="Bracelet en fil d'aluminium noir et argenté.<br />Bracelet fabriqué sur mesure.",
					Link="https://www.vinted.fr/femmes/bracelets/241557075-bracelet-en-fil-daluminium-fait-main-ideal-en-bijou-de-mariage",
					Disponibility =false,
					Reference="bracelet_06" ,
					Images=new String[]{
						"https://php.milhie.fr/images/bracelets/bracelet6.jpeg"
					}
				},
				new Product
				{
					Title= "Bracelet bicolore.",
					Price = 20,
					Gemme="none",
					Description=" Bracelet en fil d'aluminium doré et argenté.<br />Fait main.<br />Possibilité de création d'un collier ou boucles d'oreilles assortis.",
					Link="https://www.vinted.fr/femmes/bracelets/252728157-bracelet-en-fil-daluminium-tenue-de-mariage-ou-de-fete",
					Disponibility =true,
					Reference="bracelet_07" ,
					Images=new String[]{
						"https://php.milhie.fr/images/bracelets/bracelet7.jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet7(01).jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet7(02).jpeg"
					}
				},
				new Product
				{
					Title= "Bracelet inspiration épée.",
					Price = 20,
					Gemme="none",
					Description="Bracelet fait main en fil d'aluminium.<br />Idéal pour un poignet de 15 cm de circonférence.<br />Disponible à la commande, réalisé sur mesure.",
					Link="https://www.vinted.fr/femmes/bracelets/301284573-bracelet-en-fil-daluminium",
					Disponibility =true,
					Reference="bracelet_08" ,
					Images=new String[]{
						"https://php.milhie.fr/images/bracelets/bracelet8.jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet8(01).jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet8(02).jpeg"
					}
				},
				new Product
				{
					Title= "Bracelet 4 brins.",
					Price = 20,
					Gemme="none",
					Description="Bracelet en fil d'aluminium argenté.<br />Fait main.<br />Possibilité de création d'un collier ou boucles d'oreilles assortis.",
					Link="https://www.vinted.fr/femmes/bracelets/306263313-bracelet-en-fil-daluminium",
					Disponibility =true,
					Reference="bracelet_09" ,
					Images=new String[]{
						"https://php.milhie.fr/images/bracelets/bracelet9.jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet9(01).jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet9(02).jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet9(03).jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet9(04).jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet9(05).jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet9(06).jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet9(07).jpeg"
					}
				},
				new Product
				{
					Title= "Bracelet triskel.",
					Price = 20,
					Gemme="none",
					Description="Bracelet triskel positif en fil d'aluminium fait main.<br />En photo : poignet de 15 cm de circonférence.< br />Possibilité de faire sur demande un triskel ''négatif''(qui tourne dans le sens inverse des aiguilles d'une montre. )",
					Link ="https://www.vinted.fr/femmes/bracelets/306292788-bracelet-triskel-en-fil-daluminium",
					Disponibility =true,
					Reference="bracelet_10" ,
					Images=new String[]{
						"https://php.milhie.fr/images/bracelets/bracelet10.jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet10(01).jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet10(02).jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet10(03).jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet10(04).jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet10(05).jpeg"
					}
				},
				new Product
				{
					Title= "Bracelet fil d'aluminium et perles.",
					Price = 20,
					Gemme="none",
					Description="Bracelet en fil d'aluminium et perles en verrefait main.<br />En photo : poignet de 15 cm de circonférence.< br />Couleur des perles au choix.",
					Link ="https://www.vinted.fr/femmes/bracelets/306292788-bracelet-triskel-en-fil-daluminium",
					Disponibility =false,
					Reference="bracelet_11" ,
					Images=new String[]{
						"https://php.milhie.fr/images/bracelets/bracelet11.jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet11(01).jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet11(02).jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet11(03).jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet11(04).jpeg",
						"https://php.milhie.fr/images/bracelets/bracelet11(05).jpeg"
					}
				},
				new Product
				{
					Title= "Bracelet 3 brins.",
					Price = 20,
					Gemme="none",
					Description=" Bracelet en fil d'aluminium 3 brins.<br />En photo : poignet de 15 cm de circonférence.",
					Link ="https://www.vinted.fr/femmes/bracelets/306292788-bracelet-triskel-en-fil-daluminium",
					Disponibility =false,
					Reference="bracelet_12" ,
					Images=new String[]{
						"https://php.milhie.fr/images/bracelets/bracelet12.jpeg"
					}
				},
			};

			ICollection<Product> necklace = new List<Product>
			{
				new Product
				{
					Title= "Collier simple '2 fils'.",
					Price = 20,
					Gemme="none",
					Description="Collier simple. Fait main en fil d'aluminium.<br />Bicolore argent et or.",
					Link="https://www.vinted.fr/femmes/colliers-and-pendentifs/358636657-pendentif-arbre-de-vie",
					Disponibility =false,
					Reference="necklace_01" ,
					Images=new String[]{
						"https://php.milhie.fr/images/colliers/collier2_259.jpeg",
						"https://php.milhie.fr/images/colliers/collier2(1)_259.jpeg"
					}
				},
				new Product
				{
					Title= "Collier fleurs et perles'.",
					Price = 35,
					Gemme="none",
					Description="Collier fleur et perle en verre.<br />Fait main. Couleur de la fleur et des perles au choix.",
					Link="https://www.vinted.fr/femmes/colliers-and-pendentifs/358636657-pendentif-arbre-de-vie",
					Disponibility =false,
					Reference="necklace_02" ,
					Images=new String[]{
						"https://php.milhie.fr/images/colliers/collier1_259.jpeg",
						"https://php.milhie.fr/images/colliers/collier1(2)_259.jpeg",
						"https://php.milhie.fr/images/colliers/collier1(3)_259.jpeg",
						"https://php.milhie.fr/images/colliers/collier1(4)_259.jpeg"
					}
				},
			};

			ICollection<Product> pendantChakras = new List<Product>
			{
				new Product
				{
					Title= "Pendentif fleur de vie 7 chakras.",
					Price = 30,
					Gemme="none",
					Description="Pendentif fleur de vie 7 chakras en fil d'aluminium et pierres semi précieuses.<br /><br />6,5 cm de diamètre<br />Produit unique, fait main.",
					Link="https://www.vinted.fr/femmes/colliers-and-pendentifs/306946884-pendentif-fleur-de-vie",
					Disponibility =true,
					Reference="pendant_chakras_01" ,
					Images=new String[]{
						"https://php.milhie.fr/images/pendentifs/pendentif3.jpeg",
						"https://php.milhie.fr/images/pendentifs/pendentif3(01).jpeg",
						"https://php.milhie.fr/images/pendentifs/pendentif3(02).jpeg",
						"https://php.milhie.fr/images/pendentifs/pendentif3(03).jpeg",
						"https://php.milhie.fr/images/pendentifs/pendentif3(04).jpeg"
					}
				},
				new Product
				{
					Title= "Pendentif arbre de vie 7 Chakras.",
					Price = 30,
					Gemme="none",
					Description="Pendentif arbre de vie 7 chakras, fait main en fil d'aluminium.",
					Link="https://www.vinted.fr/femmes/colliers-and-pendentifs/437901598-pendentif-arbre-de-vie-7-chacras",
					Disponibility =true,
					Reference="pendant_chakras_02" ,
					Images=new String[]{
						"https://php.milhie.fr/images/pendentifs/pendentif4.jpeg",
						"https://php.milhie.fr/images/pendentifs/pendentif4(01).jpeg"
					}
				},
				new Product
				{
					Title= "Pendentif arbre de vie .",
					Price = 10,
					Gemme="none",
					Description="Pendentif arbre de vie , fait main en fil d'aluminium.",
					Link="https://www.vinted.fr/femmes/colliers-and-pendentifs/243526871-pendentif-arbre-de-vie",
					Disponibility =true,
					Reference="pendant_chakras_03" ,
					Images=new String[]{
						"https://php.milhie.fr/images/pendentifs/pendentif5_259.jpeg"
					}
				},
			};
			ICollection<Product> pendantLyto = new List<Product>
			{
				new Product
				{
					Title= "Pendentif arbre de vie sur labradorite.",
					Price = 40,
					Gemme="Labradorite",
					Description="Pendentif arbre de vie sur labradorite.<br />Fait main en fil d'aluminium.",
					Link="https://www.vinted.fr/femmes/colliers-and-pendentifs/358636657-pendentif-arbre-de-vie",
					Disponibility =true,
					Reference="pendant_lyto_01" ,
					Images=new String[]{
						"https://php.milhie.fr/images/pendentifs/lab1.jpeg",
						"https://php.milhie.fr/images/pendentifs/lab1(01).jpeg",
						"https://php.milhie.fr/images/pendentifs/lab1(02).jpeg",
						"https://php.milhie.fr/images/pendentifs/lab1(03).jpeg",
						"https://php.milhie.fr/images/pendentifs/lab1(04).jpeg",
						"https://php.milhie.fr/images/pendentifs/lab1(05).jpeg"
					}
				},
				new Product
				{
					Title= "Pendentif arbre de vie sur labradorite.",
					Price = 40,
					Gemme="Labradorite",
					Description="Pendentif arbre de vie en fil d'aluminium et fil acier inoxydable monté sur labradorite .<br /><br />Produit fait main.",
					Link="https://www.vinted.fr/femmes/colliers-and-pendentifs/358636657-pendentif-arbre-de-vie",
					Disponibility =true,
					Reference="pendant_lyto_02" ,
					Images=new String[]{
						"https://php.milhie.fr/images/pendentifs/lab2.jpeg",
						"https://php.milhie.fr/images/pendentifs/lab2(01).jpeg",
						"https://php.milhie.fr/images/pendentifs/lab2(02).jpeg",
						"https://php.milhie.fr/images/pendentifs/lab2(03).jpeg",
						"https://php.milhie.fr/images/pendentifs/lab2(04).jpeg"
					}
				},
				new Product
				{
					Title= "Pendentif arbre de vie sur améthyste.",
					Price = 40,
					Gemme="Amethyst",
					Description="Pendentif arbre de vie en fil d'aluminium et fil acier inoxydable monté sur améthyste .<br /><br />Produit fait main.<br />N'hésitez pas à me contacter. (Le prix varie en fonction de la pierre : entre 35 et 45€)",
					Link ="https://www.vinted.fr/femmes/colliers-and-pendentifs/359438646-pendentif-arbre-de-vie-sur-amethyste",
					Disponibility =true,
					Reference="pendant_lyto_03" ,
					Images=new String[]{
						"https://php.milhie.fr/images/pendentifs/amethyst01.jpeg",
						"https://php.milhie.fr/images/pendentifs/amethyst01(01).jpeg",
						"https://php.milhie.fr/images/pendentifs/amethyst01(02).jpeg"
					}
				},
				new Product
				{
					Title= "Pendentif arbre de vie sur obsidienne.",
					Price = 50,
					Gemme="Obsidienne",
					Description="Grand pendentif arbre de vie sur obsidienne noire.Fait main en fil d'aluminium.<br /><br />Idéal à porter en sautoir.<br />Hauteur: 5,5cm",
					Link ="https://www.vinted.fr/femmes/colliers-and-pendentifs/373350889-grand-pendentif-arbre-de-vie",
					Disponibility =true,
					Reference="pendant_lyto_04" ,
					Images=new String[]{
						"https://php.milhie.fr/images/pendentifs/obs01.jpeg",
						"https://php.milhie.fr/images/pendentifs/obs01(01).jpeg",
						"https://php.milhie.fr/images/pendentifs/obs01(02).jpeg",
						"https://php.milhie.fr/images/pendentifs/obs01(03).jpeg",
						"https://php.milhie.fr/images/pendentifs/obs01(04).jpeg"
					}
				},
				new Product
				{
					Title= "Pendentif arbre de vie sur obsidienne.",
					Price = 35,
					Gemme="Obsidienne",
					Description=" Pendentif arbre de vie sur obsidienne.<br />Fait main en fil d'aluminium.",
					Link ="https://www.vinted.fr/femmes/bracelets/419378353-bracelet-arbre-de-vie-sur-pierre-aventurine",
					Disponibility =true,
					Reference="pendant_lyto_05" ,
					Images=new String[]{
						"https://php.milhie.fr/images/pendentifs/obs02.jpeg",
						"https://php.milhie.fr/images/pendentifs/obs02(01).jpeg",
						"https://php.milhie.fr/images/pendentifs/obs02(02).jpeg",
						"https://php.milhie.fr/images/pendentifs/obs02(03).jpeg"
					}
				},
				new Product
				{
					Title= "Pendentif arbre de vie sur obsidienne.",
					Price = 35,
					Gemme="Obsidienne",
					Description=" Pendentif arbre de vie sur obsidienne.<br />Fait main en fil d'aluminium.",
					Link ="https://www.vinted.fr/femmes/colliers-and-pendentifs/373350889-grand-pendentif-arbre-de-vie",
					Disponibility =true,
					Reference="pendant_lyto_06" ,
					Images=new String[]{
						"https://php.milhie.fr/images/pendentifs/obs03.jpeg",
						"https://php.milhie.fr/images/pendentifs/obs03(01).jpeg",
						"https://php.milhie.fr/images/pendentifs/obs03(02).jpeg",
						"https://php.milhie.fr/images/pendentifs/obs03(03).jpeg"
					}
				},
				new Product
				{
					Title= "Pendentif arbre de vie sur obsidienne.",
					Price = 45,
					Gemme="Obsidienne",
					Description="Pendentif arbre de vie fait main en fil d'aluminium, moyen modèle, monté sur une obsidienne noire.<br /><br />Hauteur: 4,5cm",
					Link ="https://www.vinted.fr/femmes/colliers-and-pendentifs/373357317-pendentif-arbre-de-vie",
					Disponibility =true,
					Reference="pendant_lyto_07" ,
					Images=new String[]{
						"https://php.milhie.fr/images/pendentifs/obs04.jpeg",
						"https://php.milhie.fr/images/pendentifs/obs04(01).jpeg",
						"https://php.milhie.fr/images/pendentifs/obs04(02).jpeg",
						"https://php.milhie.fr/images/pendentifs/obs04(03).jpeg"
					}
				},
			};
			ICollection<UnderCategory> trees = new List<UnderCategory>
			{
				new UnderCategory { Name = "Big life trees", Products = bigLifeTree } ,
				new UnderCategory { Name = "Medium life trees", Products = mediumLifeTree },
				new UnderCategory { Name= "Small Life trees", Products=smallLifeTree }
			};
			ICollection<UnderCategory> decorations = new List<UnderCategory>
			{
				new UnderCategory{ Name="Dreamcatcher", Products=dreamcatcher},
				new UnderCategory{ Name="WallDecos", Products=wallDecos},
				new UnderCategory{ Name="Wedding",Products=weddingDecos}
			};
			ICollection<UnderCategory> jewerly = new List<UnderCategory>
			{
				new UnderCategory {Name="Rings", Products=ring},
				new UnderCategory {Name="Earrings", Products=earrings},
				new UnderCategory { Name="BraceletsFins", Products=slimBracelet},
				new UnderCategory { Name="Manchettes", Products=manchettes},
				new UnderCategory { Name="BraceletsLytothérapie", Products=lyto},
				new UnderCategory { Name="BraceletsAluminium", Products=braceletAlu},
				new UnderCategory { Name="Colliers", Products=necklace},
				new UnderCategory { Name="PendentifsChakras", Products=pendantChakras},
				new UnderCategory { Name="PendentifsLytothérapie", Products=pendantLyto},
			};
			Category lifeTrees = new Category { Name = "LifeTrees", UnderCategories = trees };
			Category decos = new Category { Name = "Decorations", UnderCategories = decorations };
			Category jewerlies = new Category { Name = "Bijoux", UnderCategories = jewerly };

			context.AddRange(lifeTrees, decos, jewerlies);
			context.SaveChanges();
		}*/

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				});
	}
}
