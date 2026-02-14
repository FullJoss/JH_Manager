using JH_Manager.DataManager;
using JH_Manager.Produits;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace JH_Manager
{
    public struct History
    {
        public int index;
        public string type;
        public long weight;
        public string note;
        public DateTime date;
        public string client;
    }

    public struct Category
    {
        public string name;
        public List<int> indexs;
        public Category(string name, List<int> indexs)
        {
            this.name = name;
            this.indexs = indexs;
        }
    }

    public static class Bigdata
    {
        public static Dictionary<int, Produit> produits;
        public static List<History> histo;
        public static Dictionary<int, int> facture;
        public static int nFact = 0;
        public static List<int> OutOfStock;
        public static User user;
        public static List<Category> Categories;
        public static int indexToRefresh;
        public static Dictionary<int, Image> ImageData;
        public static void Init()
        {
            ImageData = new Dictionary<int, Image>();

            user = new User("Admin", "Admin", DateTime.Now, 0);

            produits = new Dictionary<int, Produit>();
            histo = new List<History>();
            facture = new Dictionary<int, int>();

            indexToRefresh = -1;

            Produit prd1 = new Produit
            {
                Note = "first product on beta",
                Name = "KitKat",
                Price = 200,
                Index = 0,
                Image = ImageProcessor.ImageToByte(Properties.Resources.kitkat),
                InitPrice = 50
            };
            Produit prd2 = new Produit
            {
                Note = "second product on beta",
                Name = "Coca cola",
                Price = 1500,
                Index = 1,
                Image = ImageProcessor.ImageToByte(Properties.Resources.coca),
                InitPrice = 200
            };
            Produit prd3 = new Produit
            {
                Note = "first product on beta",
                Name = "Oreo Biscuit",
                Price = 500,
                Index = 2,
                Image = ImageProcessor.ImageToByte(Properties.Resources.oreo),
                InitPrice = 300
            };
            Produit prd4 = new Produit
            {
                Note = "second product on beta",
                Name = "Bueno delice",
                Price = 2000,
                Index = 3,
                Image = ImageProcessor.ImageToByte(Properties.Resources.bueno),
                InitPrice = 400
            };
            Produit prd5 = new Produit
            {
                Note = "second product on beta",
                Name = "Sprite Boost",
                Price = 1500,
                Index = 4,
                Image = ImageProcessor.ImageToByte(Properties.Resources.sprite),
                InitPrice = 300
            };
            Produit prd6 = new Produit
            {
                Note = "second product on beta",
                Name = "Cheetos R",
                Price = 1000,
                Index = 5,
                Image = ImageProcessor.ImageToByte(Properties.Resources.cheetos),
                InitPrice = 200
            };
            Produit prd7 = new Produit
            {
                Note = "second product on beta",
                Name = "Lays jaune",
                Price = 2100,
                Index = 6,
                Image = ImageProcessor.ImageToByte(Properties.Resources.LaysClassic),
                InitPrice = 350
            };

            produits.Add(prd1.Index, prd1);
            produits.Add(prd2.Index, prd2);
            produits.Add(prd3.Index, prd3);
            produits.Add(prd4.Index, prd4);
            produits.Add(prd5.Index, prd5);
            produits.Add(prd6.Index, prd6);
            produits.Add(prd7.Index, prd7);

            foreach (Produit p in produits.Values)
            {
                ImageData.Add(p.Index, ImageProcessor.ByteToImage(p.Image));
            }

            CheckedOutOfStock();

            Categories = new List<Category>()
            {
                new Category("Tout", produits.Keys.ToList()),
                new Category("Boisson", new List<int>() {4, 1}),
                new Category("Chips", new List<int>() {6, 5}),
                new Category("Biscuit", new List<int>() {0, 2, 3}),
            };
        }

        public static void CheckedOutOfStock()
        {
            List<int> value = new List<int>();
            foreach (KeyValuePair<int, Produit> p in produits)
            {
                if (p.Value.Stock <= p.Value.MinStock)
                {
                    value.Add(p.Key);
                }
            }

            OutOfStock = value;
        }
        public static void Paid()
        {
            foreach (int i in facture.Keys)
            {
                if (produits.ContainsKey(i))
                {
                    produits[i].Stock -= produits[i].NBOut = facture[i];
                    // Nettoyer
                    facture.Remove(i);
                }
            }
        }

        public static string ConvertString(int value)
        {
            if (value < 1000) return value.ToString();
            else if (value < 1000000)
            {
                return $"{value / 1000D:0.##}k";
            }
            return (value / 1000000D).ToString("F2") + "M";
        }
    }
}
