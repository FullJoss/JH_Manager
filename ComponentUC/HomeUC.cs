using JH_Manager.DataManager;
using JH_Manager.Produits;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace JH_Manager.ComponentUC
{
    public partial class HomeUC : UserControl
    {
        private long benefBudget = 0;
        private long prdNb = 0;
        private long[] list;
        private Color[] colors;
        private Color[] colors2;
        public HomeUC()
        {
            InitializeComponent();

            // Optimisation
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            CalculateViewPrd();

            prdNumber.Text = $"{Bigdata.produits.Count} produits enregistrer";

            // Graphique
            AnalyserGraph.offset = graph1.Location;

            RefreshUC();

            colors = new Color[3]
            {
                Color.RoyalBlue,
                Color.LimeGreen,
                Color.Maroon,
            };
            colors2 = new Color[3]
           {
                Color.Cyan,
                Color.GreenYellow,
                Color.Red,
           };
        }

        public void RefreshUC()
        {
            list = new long[3] { 0, 0, 0 };

            foreach (KeyValuePair<int, Produit> p in Bigdata.produits)
            {
                list[0] += p.Value.NBIn * p.Value.InitPrice;
                list[1] += p.Value.NBOut * p.Value.Price;
            }
            list[2] = list[1] - list[0];
            float percent = 0;
            if (list[0] != 0)
                percent = Math.Abs(list[2] * 100 / list[0]);
            if (list[2] < 0)
                labelBenef.Text = $"Perte {percent:F2}%";
            else
                labelBenef.Text = $"Bénéfice {percent:F2}%";
        }
        private void CalculateViewPrd()
        {
            long maxprd = 0; long maxBudget = 0;
            foreach (Produit p in Bigdata.produits.Values)
            {
                benefBudget += p.NBOut * p.Price;
                prdNb += p.NBOut;
                maxprd += p.NBIn; // le in et le out sont en ekilibre
                maxBudget += p.Price * p.NBIn;
            }
            float n = 0;
            if (maxprd == 0 || maxBudget == 0)
            {
                percentPrd.Text = percentagePr.Text = totalRate.Text = "0";
            }
            else
            {
                percentPrd.Text = $"{(prdNb * 100 / maxprd)}%";
                percentagePr.Text = $"{(benefBudget * 100 / maxBudget)}%";
                n = ((benefBudget * 100 / maxBudget) + (prdNb * 100 / maxprd)) / 2;
                totalRate.Text = $"{n}";
            }

            progressBar.ProgressValue = (int)n;

            productCount.Text = $"{prdNb} Products";
            budgetNow.Text = $"{benefBudget} Ar";
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private List<int> Normalize(long[] l, int newMin, int newMax)
        {
            long max = l.Max(); long min = l.Min();

            return l.Select(value => newMin + (int)((value - min) / (double)(max - min) * newMax)).ToList();

        }

        private void panelG2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int width = 20;
            int spacing = panelG2.Width / 3 - width;
            int x = spacing / 2;
            int y = panelG2.Height;

            int i = 0;
            foreach (int val in Normalize(list, panelG2.Height / 15, panelG2.Height))
            {
                int rectY = y - val;
                Rectangle rect = new Rectangle(x, rectY, width, val);
                using (LinearGradientBrush brush = new LinearGradientBrush(rect,
                    colors[i], colors2[i], LinearGradientMode.Vertical))
                {
                    g.FillRectangle(brush, rect);
                }
                // Espacer les elements
                x += width + spacing;
                i++;
            }
        }
    }
}
