using JH_Manager.DataManager;
using JH_Manager.Produits;
using System;
using System.Windows.Forms;

namespace JH_Manager.ComponentUC.SousComponents
{
    public partial class StocListPrdUC : UserControl
    {
        private int Index;

        public StocListPrdUC()
        {
            InitializeComponent();

            // Optimisation
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }
        public StocListPrdUC(Produit p)
        {
            InitializeComponent();

            pictureBox.Image = ImageProcessor.ByteToImage(p.Image);
            labelName.Text = p.Name;
            labelStock.Text = p.Stock.ToString();
            labelPrice.Text = p.Price + " Ar";

            Index = p.Index;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Bigdata.produits.Remove(Index);
            this.Dispose();
        }
    }
}
