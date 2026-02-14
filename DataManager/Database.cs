using JH_Manager.Produits;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace JH_Manager.DataManager
{
    public static class Database
    {
        public static void Save()
        {
            string jsonString = JsonSerializer.Serialize(Bigdata.produits,
               new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText("produits.json", jsonString);
        }

        public static void Load()
        {
            string jsonRead = File.ReadAllText("produits.json");
            Dictionary<int, Produit> data = JsonSerializer.Deserialize<Dictionary<int, Produit>>(jsonRead);
            Bigdata.produits = data;
        }
    }
}
