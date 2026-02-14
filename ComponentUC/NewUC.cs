using JH_Manager.DataManager;
using JH_Manager.Produits;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JH_Manager.ComponentUC
{
    public partial class NewUC : UserControl
    {
        public NewUC()
        {
            InitializeComponent();

            // Optimisation
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            // Initialisation des categories
            foreach (Category category in Bigdata.Categories)
            {
                Categor.Items.Add(category.name);
            }
            Categor.SelectedIndex = 0;
        }
        void InsertProduit(Produit p)
        {
            if (p == null) return;
            p.Name = pNom.Content;
            p.Price = Convert.ToInt32(pPU.Content);
            p.Unit = pRef.Content;
            p.Index = Bigdata.produits.Count;
            p.InitPrice = Convert.ToInt32(pMax.Content);
            p.MinStock = Convert.ToInt32(pMin.Content);
            p.ID = pID.Content;
            p.NBIn = p.Stock = Convert.ToInt32(pStock.Content);
            p.Image = ImageProcessor.ImageToByte(pPrd.Image);
            int categorie = Categor.SelectedIndex;
            if (categorie != 0)
                Bigdata.Categories[0].indexs.Add(p.Index);

            Bigdata.Categories[categorie].indexs.Add(p.Index);
            Bigdata.produits.Add(p.Index, p);
        }
        private void cuiButton3_Click(object sender, EventArgs e)
        {
            try
            {
                InsertProduit(new Produit());
                ChangedView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops ! " + ex.Message);
            }
        }

        private void cuiButton4_Click(object sender, EventArgs e)
        {
            ChangedView();
        }
        private void ChangedView()
        {
            Form1.usc = Form1.uscActive[0]; // new Home()
            this.Parent.Controls.Add(Form1.usc);
            this.Parent.Controls.Remove(this);
            Form1.usc.BringToFront();
        }
        private void cuiButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pPrd.Image = Image.FromFile(ofd.FileName);
                pPrd.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnAdapter_Click(object sender, EventArgs e)
        {
            try
            {
                int tol = Convert.ToInt32(INtol.Content);

                Bitmap img = ImageProcessor.LoadImage(pPrd);

                Bitmap result = ImageProcessor.RemoveBackground(img, tol);

                if (result != null)
                {
                    pPrd.Image = result;
                    pPrd.Invalidate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
