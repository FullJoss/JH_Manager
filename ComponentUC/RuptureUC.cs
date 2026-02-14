using JH_Manager.ComponentUC.SousComponents;
using System;
using System.Windows.Forms;

namespace JH_Manager.ComponentUC
{
    public partial class RuptureUC : UserControl
    {
        private int Index;
        private stockProductUC last;
        public RuptureUC()
        {
            InitializeComponent();

            foreach (int i in Bigdata.OutOfStock)
            {
                panelContainProduct.Controls.Add(Bigdata.produits[i].ShowUC());
            }

            foreach (stockProductUC s in panelContainProduct.Controls)
            {
                s.Clique += OnClickProduct;
            }

            Index = -1;

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
        }
        private void OnClickProduct(object sender, EventArgs e)
        {
            try
            {
                if (last != null)
                    last.IsChecked = false;

                last = (stockProductUC)sender;

                Index = Convert.ToInt32(last.Tag);

                last.IsChecked = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        private void ChangedView()
        {
            Form1.usc.Size = this.Size;
            Form1.usc.Location = this.Location;
            this.Parent.Controls.Add(Form1.usc);
            this.Parent.Controls.Remove(this);
            Form1.usc.BringToFront();
        }
        private void Remake_Click(object sender, EventArgs e)
        {
            if (Index < 0 || !Bigdata.OutOfStock.Contains(Index))
            {
                MessageBox.Show("Selectioner un produit");
                return;
            }
            Form1.usc = new ProductUC(Bigdata.produits[Index], false);
            ChangedView();
        }
        private void ModBtn_Click(object sender, EventArgs e)
        {
            Form1.usc = new EditUC();
            ChangedView();
        }
        private void BtnSupp_Click(object sender, EventArgs e)
        {
            if (Index < 0 || !Bigdata.OutOfStock.Contains(Index))
            {
                MessageBox.Show("Selectioner un produit");
                return;
            }

            int i = Form1.IndexActive;
            switch (i)
            {
                case 0:
                    Form1.usc = new HomeUC();
                    break;
                case 1:
                    Form1.usc = new ShopUC();
                    break;
                case 2:
                    Form1.usc = new StockG();
                    break;
                case 3:
                    Form1.usc = new NewUC();
                    break;
                case 4:
                    Form1.usc = new EditUC();
                    break;
                case 5:
                    Form1.usc = new ManagerUserUC();
                    break;
                default:
                    return;
            }

            Bigdata.produits.Remove(Index);
            Bigdata.CheckedOutOfStock();

            ChangedView();
        }
    }
}
