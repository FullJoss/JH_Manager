using JH_Manager.ComponentUC.SousComponents;
using JH_Manager.DataManager;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JH_Manager.Produits
{
    public class Produit
    {
        public byte[] Image { get; set; } = default;
        public int Price { get; set; } = 0;
        public int InitPrice { get; set; } = 0;
        public int NBOut { get; set; } = 0;
        public long NBIn { get; set; } = 0;
        public int Index { get; set; } = 0;
        public int Stock { get; set; } = 0;
        public string Name { get; set; } = "unknown";
        public string Note { get; set; } = "none";
        public int MinStock { get; set; } = 0;
        public DateTime DateBegin { get; set; } = DateTime.Now;
        public string Unit { get; set; } = "unité";
        public string ID { get; set; } = "0000000000";

        public List<History> historic = new List<History>();

        public stockProductUC ShowUC()
        {
            stockProductUC st = new stockProductUC();
            st.nameProduit.Text = Name;
            st.LabelStok.Text = $"{Bigdata.ConvertString(Stock)} {Unit}";
            Task.Run(() => st.pictureProduit.Image = ImageProcessor.ByteToImage(Image));
            st.Tag = Index;
            st.labelPrice.Text = $"{Bigdata.ConvertString(Price)} Ar";
            return st;
        }
    }
}
