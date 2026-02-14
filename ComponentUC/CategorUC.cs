using JH_Manager.ComponentUC.SousComponents;
using JH_Manager.Produits;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JH_Manager.ComponentUC
{
    public partial class CategorUC : UserControl
    {
        private stockProductUC last;
        public CategorUC()
        {
            InitializeComponent();

            // Initialiser les categor
            foreach (Category c in Bigdata.Categories)
            {
                TransCategor.Items.Add(c.name);
                CategorBox.Items.Add(c.name);
            }

            foreach (KeyValuePair<int, Produit> p in Bigdata.produits)
            {
                panelContainer.Controls.Add(p.Value.ShowUC());
            }

            // Optimisation
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            InitialiseResult();

            CategorBox.SelectedIndex = 0;
            TransCategor.SelectedIndex = 0;
            CategorBox.SelectedIndexChanged += BtnSearch_Click;
        }

        public void RefreshUC()
        {
            panelContainer.Controls.Clear();
            TransCategor.Items.Clear();
            CategorBox.Items.Clear();

            // Initialiser les categor
            foreach (Category c in Bigdata.Categories)
            {
                TransCategor.Items.Add(c.name);
                CategorBox.Items.Add(c.name);
            }
            foreach (KeyValuePair<int, Produit> p in Bigdata.produits)
            {
                panelContainer.Controls.Add(p.Value.ShowUC());
            }

            InitialiseResult();
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

        private void ClickProduct(object sender, EventArgs e)
        {
            try
            {
                if (last != null)
                    last.IsChecked = false;

                last = (stockProductUC)sender;

                last.IsChecked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(last.Tag);

            // Enlever les categories
            List<Category> lc = Bigdata.Categories.Where(c => c.indexs.Contains(i)).ToList();
            foreach (Category c in lc)
            {
                c.indexs.Remove(i);
            }

            // Ajout a la nouvelle categoire
            Bigdata.Categories[TransCategor.SelectedIndex].indexs.Add(i);
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            if (TransCategor.SelectedIndex == 0)
            {
                MessageBox.Show("Vous ne pouvez pas supprimer une categorie globale",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Bigdata.Categories.RemoveAt(TransCategor.SelectedIndex);

            // Initialiser les categor
            TransCategor.Items.Clear();
            CategorBox.Items.Clear();
            foreach (Category c in Bigdata.Categories)
            {
                TransCategor.Items.Add(c.name);
                CategorBox.Items.Add(c.name);
            }

            CategorBox.SelectedIndex = 0;
            TransCategor.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pNewName.Content)) return;

            Category newC = new Category(pNewName.Content, new List<int>());
            Bigdata.Categories.Add(newC);

            // Initialiser les categor
            TransCategor.Items.Clear();
            CategorBox.Items.Clear();
            foreach (Category c in Bigdata.Categories)
            {
                TransCategor.Items.Add(c.name);
                CategorBox.Items.Add(c.name);
            }

            CategorBox.SelectedIndex = 0;
            TransCategor.SelectedIndex = 0;
        }

        private void NameChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pNewName.Content))
            {
                // Desactive le boutton
                btnAdd.Enabled = false;
                btnAdd.NormalBackground = Color.Silver;
                btnAdd.PressedBackground = Color.Silver;
                btnAdd.CheckedBackground = Color.Silver;
                btnAdd.HoverBackground = Color.LightGray;
                btnAdd.ForeColor = Color.FromArgb(64, 64, 64);
            }
            else if (btnAdd.Enabled == false)
            {
                // Active le boutton
                btnAdd.Enabled = true;
                btnAdd.NormalBackground = Color.FromArgb(32, 32, 32);
                btnAdd.PressedBackground = Color.FromArgb(32, 32, 32);
                btnAdd.CheckedBackground = Color.FromArgb(32, 32, 32);
                btnAdd.HoverBackground = Color.FromArgb(64, 64, 64);
                btnAdd.ForeColor = Color.White;
            }
        }
    }
}
