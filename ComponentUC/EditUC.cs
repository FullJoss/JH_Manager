using JH_Manager.ComponentUC.SousComponents;
using JH_Manager.DataManager;
using JH_Manager.Produits;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JH_Manager.ComponentUC
{
    public partial class EditUC : UserControl
    {
        private int index = 0;
        private Produit p = null;
        private stockProductUC last = null;
        public EditUC()
        {
            InitializeComponent();

            // Optimisation
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            foreach (KeyValuePair<int, Produit> p in Bigdata.produits)
            {
                panelContainer.Controls.Add(p.Value.ShowUC());
            }

            // Initialisation des categories
            foreach (Category category in Bigdata.Categories)
            {
                CategorBox.Items.Add(category.name);
            }
            CategorBox.SelectedIndex = 0;
            CategorBox.SelectedIndexChanged += BtnSearch_Click;

            InitialiseResult();
        }

        public void RefreshUC()
        {
            CategorBox.Controls.Clear();
            panelContainer.Controls.Clear();

            foreach (KeyValuePair<int, Produit> p in Bigdata.produits)
            {
                panelContainer.Controls.Add(p.Value.ShowUC());
            }
            // Initialisation des categories
            foreach (Category category in Bigdata.Categories)
            {
                CategorBox.Items.Add(category.name);
            }
            InitialiseResult();
        }

        private void InitialiseResult()
        {
            // selectionser un porduits
            foreach (stockProductUC c in panelContainer.Controls)
            {
                c.Clique += ClickProduct;
            }

            if (panelContainer.Controls.Count > 0)
            {
                ClickProduct(panelContainer.Controls[0], new EventArgs());
            }
        }

        private void ressourceClickProduct(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            ClickProduct(c.Parent, e);
        }

        private void ClickProduct(object sender, EventArgs e)
        {
            try
            {
                if (last != null) last.IsChecked = false;

                last = (stockProductUC)sender;
                last.IsChecked = true;

                index = (int)last.Tag;
                p = Bigdata.produits[index];

                // Modification
                pNom.Content = p.Name;
                pID.Content = p.ID;
                pStock.Content = p.Stock.ToString();
                pMax.Content = p.InitPrice.ToString();
                pMin.Content = p.MinStock.ToString();
                pRef.Content = p.Unit;
                pPU.Content = p.Price.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();

            // Rechercher une valuers ou id
            foreach (Produit p in Bigdata.produits.Values)
            {
                if (!Bigdata.Categories[CategorBox.SelectedIndex].indexs.Contains(p.Index))
                    continue;
                if (p.Name.ToLower().Contains(SearchBar.Content.ToLower()) || p.ID == SearchBar.Content || SearchBar.Content == "")
                {
                    panelContainer.Controls.Add(p.ShowUC());
                }
            }

            InitialiseResult();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                // Nettoyer
                DialogResult res = MessageBox.Show("Voules vous appliquer les modification ?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                    MessageBox.Show("Modification enregistrer",
                    "Affirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else return;

                p.Name = pNom.Content;
                p.ID = pID.Content;
                p.Stock = Convert.ToInt32(pStock.Content);
                p.InitPrice = Convert.ToInt32(pMax.Content);
                p.MinStock = Convert.ToInt32(pMin.Content);
                p.Unit = pRef.Content;
                p.Price = Convert.ToInt32(pPU.Content);

                Bigdata.produits[index] = p;
                Bigdata.user.NMod++;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            if (p == null) return;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                p.Image = ImageProcessor.ImageToByte(Image.FromFile(ofd.FileName));
            }
        }
    }
}
