using JH_Manager.ComponentUC.SousComponents;
using JH_Manager.DataManager;
using JH_Manager.Produits;
using System;
using System.Windows.Forms;

namespace JH_Manager.ComponentUC
{
    public partial class ProductUC : UserControl
    {
        private int index;
        private int stockIntern;
        private bool isOut;
        private Timer timer;
        private string reff;
        public ProductUC(Produit newp, bool isOut)
        {
            this.isOut = isOut;
            InitializeComponent();

            // Optimisation
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            ChangeViewPanel();

            pDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            pName.Text = newp.Name;
            pPicture.Image = ImageProcessor.ByteToImage(newp.Image);
            pStock.Text = $"Stock : {newp.Stock} {newp.Unit}";
            pBenef.Text = $"Benefice : {newp.NBOut * newp.Price - newp.NBIn * newp.InitPrice} Ar";
            pPU.Text = $"PU : {newp.Price}";
            index = newp.Index;
            stockIntern = newp.Stock;
            reff = newp.Unit;

            timer = new Timer();
            timer.Interval = 600;
            timer.Tick += UpdateSwitch;
            timer.Enabled = true;
            timer.Start();

            pweight.ContentChanged += ContentChangedTxt;

            // affichage de tout les historic du produits
            foreach (History h in newp.historic)
            {
                HistoryUC uc = new HistoryUC(h);
                historyContainer.Controls.Add(uc);
                uc.BringToFront();
            }
        }

        private void ContentChangedTxt(object sender, EventArgs e)
        {
            AutoCalculateStock();
        }

        private void UpdateSwitch(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Tick -= UpdateSwitch;
            timer.Dispose();

            BtnSwitch.CheckedChanged -= CheckedChanged;
            BtnSwitch.Checked = isOut;
            BtnSwitch.Invalidate(); BtnSwitch.Update();
            BtnSwitch.CheckedChanged += CheckedChanged;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (pweight.Content == "" || pweight.Content == "0") pweight.Content = "1";
            else
            {
                try
                {
                    pweight.Content = (Convert.ToInt32(pweight.Content) + 1).ToString();
                }
                catch (Exception excp)
                {
                    MessageBox.Show(excp.Message);
                }
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (pweight.Content == "" || pweight.Content == "0") pweight.Content = "0";
            else
            {
                try
                {
                    if (Convert.ToInt32(pweight.Content) < 0)
                    {
                        pweight.Content = "0"; return;
                    }
                    pweight.Content = (Convert.ToInt32(pweight.Content) - 1).ToString();
                }
                catch (Exception excp)
                {
                    MessageBox.Show(excp.Message);
                }
            }
        }

        private bool AutoCalculateStock()
        {
            try
            {
                long n = isOut ? stockIntern - Convert.ToInt32(pweight.Content) : stockIntern + Convert.ToInt32(pweight.Content);
                if (n < 0)
                {
                    MessageBox.Show("Nombre de stock insuffisant", "Echec de l'operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pweight.Content = $"{(isOut ? Bigdata.produits[index].Stock : 0)}";
                    n = isOut ? stockIntern - Convert.ToInt32(pweight.Content) : stockIntern + Convert.ToInt32(pweight.Content);
                    pStock.Text = $"Stock : {n} {reff}";
                    return false;
                }
                else
                {
                    pStock.Text = $"Stock : {n} {reff}";
                    return true;
                }
            }
            catch (Exception ex)
            {
                if (pweight.Content != "") MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!AutoCalculateStock())
                {
                    MessageBox.Show("Verifier la quantité");
                    btnSave.Checked = false;
                    return;
                }
                Produit p = Bigdata.produits[index];
                p.Stock = isOut ? stockIntern - Convert.ToInt32(pweight.Content) : stockIntern + Convert.ToInt32(pweight.Content);

                // Revenir
                Bigdata.indexToRefresh = index;
                ShopUC s = Form1.uscActive[1] as ShopUC;
                s.RefreshUC();
                Form1.usc = s;

                this.Parent.Controls.Add(Form1.usc);

                // ajout l'histoire
                History h = new History()
                {
                    index = index,
                    date = DateTime.Now,
                    note = pNote.Content,
                    type = TextType.Text,
                    weight = Convert.ToInt32(pweight.Content),
                    client = pFournisseur.Content
                };

                p.historic.Add(h);


                if (isOut) p.NBOut += Convert.ToInt32(pweight.Content);
                else p.NBIn += Convert.ToInt32(pweight.Content);

                // netoyer
                p = null;
                this.Parent.Controls.Remove(this);
                this.Dispose();
                Form1.usc.BringToFront();
                MessageBox.Show("Modification enregistrer");
            }
            catch (Exception ex)
            {
                if (pweight.Content == "") pweight.Content = "0";
                else MessageBox.Show(ex.Message);
            }
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            isOut = !isOut;
            pFournisseur.Placeholder = isOut ? "Client" : "Fournisseur";
            ChangeViewPanel();
            AutoCalculateStock();
        }

        private void ChangeViewPanel()
        {
            roundedPanelType.FillColor = isOut ? BtnSwitch.CheckedForeground : BtnSwitch.UncheckedForeground;
            TextType.Text = isOut ? "Sortie" : "Entrer";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pweight.Content = "0";
            AutoCalculateStock();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1.usc = Form1.uscActive[1];
            ChangedView();
        }

        private void ChangedView()
        {
            this.Parent.Controls.Add(Form1.usc);
            this.Parent.Controls.Remove(this);
            this.Dispose();
            Form1.usc.BringToFront();
        }

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            if (Bigdata.produits[index].historic.Count <= 1)
            {
                MessageBox.Show("Votre nombre d'historiques est trop petit pour une vue globale");
                return;
            }
            Form1.usc = new ReviewUC(Bigdata.produits[index]);
            ChangedView();
        }
    }
}
