using CuoreUI.Controls;
using JH_Manager.ComponentUC.SousComponents;
using JH_Manager.Produits;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JH_Manager.ComponentUC
{
    public partial class StockG : UserControl
    {
        private int lastIndex = -1;
        private Timer timerView;
        public StockG()
        {
            InitializeComponent();
            DataGridViewShow();

            InitialisePanel();

            timerView = new Timer()
            {
                Enabled = false,
                Interval = 50,
            };
            timerView.Tick += AnimateFun;

            // Initialisation finale
            panDetails.Visible = false;
            panDetails.Location = new System.Drawing.Point(555, 16);

            CheckedBtn(btnStockMode, btnBudgetMode);

        }

        public void RefreshUC()
        {
            InitialisePanel();
        }

        private void AnimateFun(object sender, EventArgs e)
        {
            if (panDetails.Location.X > 29)
            {
                panDetails.Location = new System.Drawing.Point(panDetails.Location.X - 30, 16);
            }
            else
            {
                panDetails.BringToFront();
                timerView.Enabled = false;
                timerView.Stop();
            }
        }

        private void DataGridViewShow()
        {
            foreach (Produit p in Bigdata.produits.Values)
            {
                gridView.Rows.Add(p.Name, p.ID, p.Stock, p.NBIn, p.NBOut);
            }
        }

        private void InitialisePanel()
        {
            int last = 1;
            panelContainer.Controls.Clear();
            foreach (Produit p in Bigdata.produits.Values)
            {
                if (last > 5) break;
                if (p.Index <= lastIndex) continue;
                StocListPrdUC s = new StocListPrdUC(p);
                panelContainer.Controls.Add(s);
                lastIndex = p.Index;
                last++;
            }
        }

        private void cuiButton5_Click(object sender, System.EventArgs e)
        {
            InitialisePanel();
        }

        private void cuiButton6_Click(object sender, System.EventArgs e)
        {
            if (lastIndex >= 5) lastIndex -= 6;
            else if (Bigdata.produits.Count < 5) lastIndex = -1;
            InitialisePanel();
        }

        private void btnDetails_Click(object sender, System.EventArgs e)
        {
            panStock.Visible = false;
            panDetails.Visible = true;
            timerView.Enabled = true;
            timerView.Start();
        }
        private void cuiButton1_Click(object sender, EventArgs e)
        {
            panDetails.Visible = false;
            panStock.Visible = true;
            panDetails.Location = new System.Drawing.Point(555, 16);
        }

        private void btnFact_Click(object sender, EventArgs e)
        {
            Form1.usc = new ComponentUC.FactureUC();
            Form1.usc.Location = new System.Drawing.Point(0, 0);
            Form1.usc.Size = Parent.Size;
            this.Parent.Controls.Add(Form1.usc);
            this.Parent.Controls.Remove(this);
        }
        private void SearchBarTouch(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            panelContainer.AutoScroll = true;
            btnNext.Enabled = btnPrev.Enabled = false;
            foreach (Produit p in Bigdata.produits.Values)
            {
                if (p.Name.ToLower().Contains(SearchBar.Content.ToLower()) || p.ID == SearchBar.Content || SearchBar.Content == "")
                {
                    StocListPrdUC s = new StocListPrdUC(p);
                    panelContainer.Controls.Add(s);
                }
                if (SearchBar.Content == "")
                {
                    panelContainer.AutoScroll = false;
                    btnNext.Enabled = btnPrev.Enabled = true;
                }
            }
        }

        private void cuiButton3_Click(object sender, EventArgs e)
        {
            SearchBarTouch(sender, e);
        }

        private void btnStockMode_Click(object sender, EventArgs e)
        {
            foreach (Control c in panDetails.Controls)
            {
                if (c is GraphXY)
                {
                    panDetails.Controls.Remove(c);
                    c.Dispose();
                }
            }

            gridView.Visible = true;

            CheckedBtn(btnStockMode, btnBudgetMode);
        }

        private void btnBudgetMode_Click(object sender, EventArgs e)
        {
            bool notVide = false;
            foreach (Produit p in Bigdata.produits.Values)
            {
                if (p.historic.Count > 0)
                {
                    notVide = true;
                    break;
                }
            }
            if (!notVide)
            {
                MessageBox.Show("Votre historique est encore trop court\n\nVeuillez effectuer une transaction",
                    "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Placer le graphique
            GraphXY graphXY = new GraphXY("Evolution du budget chaque jours", Color.Transparent, Color.DarkBlue, Color.GreenYellow);
            graphXY.Location = gridView.Location;
            graphXY.Size = gridView.Size;
            panDetails.Controls.Add(graphXY);
            graphXY.GetAllPriceList();

            graphXY.Visible = true;
            gridView.Visible = false;
            CheckedBtn(btnBudgetMode, btnStockMode);
        }

        private void CheckedBtn(cuiButton b1, cuiButton b2)
        {
            // Active le boutton
            b1.NormalBackground = Color.FromArgb(32, 32, 32);
            b1.PressedBackground = Color.FromArgb(32, 32, 32);
            b1.CheckedBackground = Color.FromArgb(32, 32, 32);
            b1.HoverBackground = Color.FromArgb(64, 64, 64);
            b1.ForeColor = Color.White;

            // Desactive le boutton
            b2.NormalBackground = Color.Silver;
            b2.PressedBackground = Color.Silver;
            b2.CheckedBackground = Color.Silver;
            b2.HoverBackground = Color.LightGray;
            b2.ForeColor = Color.FromArgb(64, 64, 64);
        }
    }

}