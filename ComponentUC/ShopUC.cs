using JH_Manager.ComponentUC.SousComponents;
using JH_Manager.DataManager;
using JH_Manager.Produits;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JH_Manager.ComponentUC
{
    public partial class ShopUC : UserControl
    {
        private int Key = 0;

        public ShopUC()
        {
            InitializeComponent();
            // Optimisation
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            // Initialisation des categories
            foreach (Category category in Bigdata.Categories)
            {
                CategorBox.Items.Add(category.name);
            }
            CategorBox.SelectedIndex = 0;
            CategorBox.SelectedIndexChanged += BtnSearch_Click;

            RefreshUC();
            ClickProduct(this, new EventArgs());
        }

        public void RefreshUC()
        {
            listPanel4.SetProduit(Bigdata.produits.Values.ToList());
        }
        private void ClickProduct(object sender, EventArgs e)
        {
            int indx =Math.Max(listPanel4.IndexSelected, 0);
            try
            {
                Produit p = Bigdata.produits[indx];
                labelSelect.Text = p.Name;
                pictureSelect.Image = ImageProcessor.ByteToImage(p.Image);
                dtDate.Text = $"Crée le {p.DateBegin:dd/MM/yyyy}";
                dtStock.Text = $"Stock : {p.Stock} {p.Unit}";
                dtRef.Text = $"Reference : {p.Unit}";
                dtIn.Text = $"Entrer : {p.NBIn}";
                dtOut.Text = $"Sortie : {p.NBOut}";

                // Netoyage
                p = null;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            if (!Bigdata.produits.ContainsKey(Key)) return;
            Form1.usc = new ComponentUC.ProductUC(Bigdata.produits[Key], true);
            ChangedView();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (!Bigdata.produits.ContainsKey(Key)) return;
            Form1.usc = new ComponentUC.ProductUC(Bigdata.produits[Key], false);
            ChangedView();
        }

        private void ChangedView()
        {
            Form1.usc.Size = this.Size;
            Form1.usc.Location = this.Location;
            this.Parent.Controls.Add(Form1.usc);
            this.Parent.Controls.Remove(this);
            Form1.usc.BringToFront();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
           
        }
    }
}
