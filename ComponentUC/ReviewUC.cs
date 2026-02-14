using JH_Manager.ComponentUC.SousComponents;
using JH_Manager.Produits;
using System.Drawing;
using System.Windows.Forms;

namespace JH_Manager.ComponentUC
{
    public partial class ReviewUC : UserControl
    {
        private readonly GraphXY graphXY;
        public ReviewUC(Produit p)
        {
            InitializeComponent();

            // Placer le graphique
            graphXY = new GraphXY(p.Name, Color.Transparent, Color.FromArgb(32, 32, 32), Color.LimeGreen)
            {
                Location = panelRef.Location,
                Size = panelRef.Size
            };
            Controls.Remove(panelRef);
            panelRef.Dispose();
            Controls.Add(graphXY);

            graphXY.GetListInProduct(p);


            // Autres
            labelNOut.Text = $"Nombre de sortie : {p.NBOut} {p.Unit}";
            labelNIn.Text = $"Nombre d'entrer : {p.NBIn} {p.Unit}";

            StockLabel.Text = $"{p.Stock} {p.Unit}";
            BudgetLabel.Text = $"{p.Price * p.NBIn} Ar";
        }
        private void BtnRetour_Click(object sender, System.EventArgs e)
        {
            Form1.usc = Form1.uscActive[Form1.IndexActive];

            this.Parent.Controls.Add(Form1.usc);
            this.Parent.Controls.Remove(this);
            Dispose();
            Form1.usc.BringToFront();
        }
    }
}
