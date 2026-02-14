using iTextSharp.text.pdf;
using JH_Manager.ComponentUC.SousComponents;
using JH_Manager.DataManager;
using JH_Manager.generatePDF;
using JH_Manager.Produits;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace JH_Manager.ComponentUC
{
    public partial class FactureUC : UserControl
    {
        private int Index = 0;
        private long total = 0;
        private stockProductUC last = null;
        public FactureUC()
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

            //Select defaut
            if (panelContainer.Controls.Count > 0)
            {
                ClickProduct(panelContainer.Controls[0], new EventArgs());
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
            if (last != null) last.IsChecked = false;
            last = (stockProductUC)sender;
            last.IsChecked = true;
            Index = Convert.ToInt32(last.Tag);

            Produit prd = Bigdata.produits[Index];

            pictureBoxPrd.Image = ImageProcessor.ByteToImage(prd.Image);
            refQte.Text = prd.Unit;
            Qte.Content = "0";
        }

        private void OutBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int qte = Convert.ToInt32(Qte.Content);
                if (Bigdata.facture.ContainsKey(Index))
                {
                    qte += Bigdata.facture[Index];
                }

                if (qte < 0 || qte > Bigdata.produits[Index].Stock)
                {
                    MessageBox.Show("Stock insuffisant");
                    Qte.Content = "0";
                    return;
                }

                if (Bigdata.facture.ContainsKey(Index))
                {
                    Bigdata.facture[Index] += qte;
                }
                else Bigdata.facture.Add(Index, qte);

                MessageBox.Show($"{Qte.Content} {Bigdata.produits[Index].Name} ajouter");
                Qte.Content = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            panelFact.Visible = true;

            total = 0;
            dataGridView.Rows.Clear();
            foreach (var value in Bigdata.facture)
            {
                Produit p = Bigdata.produits[value.Key];
                dataGridView.Rows.Add(p.Name, "Ar " + p.Price, value.Value, "Ar " + p.Price * value.Value);
                total += value.Value * p.Price;
            }

            lblTotal.Text = $"Ar {total}";
            lblArret.Text = Alphabet.NumberToAlphabet(total);

            panelFact.BringToFront();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            panelFact.Visible = false;
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count <= 0) return;
            int indx = dataGridView.CurrentCell.RowIndex;
            if (indx >= 0 && indx < Bigdata.facture.Count)
            {
                int key = Bigdata.facture.ElementAt(indx).Key;
                Bigdata.facture.Remove(key);
                dataGridView.Rows.RemoveAt(dataGridView.CurrentCell.RowIndex);
            }
        }

        private void btnAnnul_Click(object sender, EventArgs e)
        {
            Form1.usc = new ComponentUC.StockG();
            this.Parent.Controls.Add(Form1.usc);
            this.Parent.Controls.Remove(this);
            Dispose();
        }

        private void TextControlChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Qte.Content)) return;
            try
            {
                int value = Convert.ToInt32(Qte.Content);
                if (value < 0 || value > Bigdata.produits[Index].Stock)
                {
                    MessageBox.Show("Stock insuffisant");
                    Qte.Content = "0";
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}");
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        { 
            string[] blocInfo = new string[] { "6011848391", "42824 11 1248 0 52421", "jsociety01@gmail.com", DateTime.Now.ToString("dd/MM/yyyy"), "0340000000/0330000000", inputNameClient.Content, inputAdressClient.Content, "", Bigdata.nFact.ToString().PadLeft(5, '0') };
            PDFDoc doc = new PDFDoc(dataGridView, lblArret, lblTotal, blocInfo);

            string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string outfile = "facture.pdf";
            string filepath = Path.Combine(directoryPath, outfile); 

            using (FileStream fs = new FileStream(filepath, FileMode.Create))
            {
                PdfWriter.GetInstance(doc.GetDoc(), fs);
                doc.WriteInTheDoc();
            }
            //Creation du document
            string argument = "/select, \"" + filepath + "\"";
            Process.Start("explorer.exe", argument);

            // Mis a jours
            Bigdata.nFact++;

        }

        private void SearchProduct(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            foreach (KeyValuePair<int, Produit> p in Bigdata.produits)
            {
                if (p.Value.Name.ToLower().Contains(SearchBar.Content.ToLower()) || p.Value.ID == SearchBar.Content || SearchBar.Content == "")
                {
                    panelContainer.Controls.Add(p.Value.ShowUC());
                }
            }
            InitialiseResult();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchProduct(sender, e);
        }
    }
}
