using JH_Manager.ComponentUC.SousComponents;
using System.Windows.Forms;

namespace JH_Manager.ComponentUC
{
    partial class FactureUC
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            if (disposing)
            {
                // selectionser un porduits
                foreach (stockProductUC c in panelContainer.Controls)
                {
                    c.Clique -= ClickProduct;
                    foreach (Control c2 in c.Controls)
                    {
                        c2.Dispose();
                    }
                    c.Dispose();
                }
            }

            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FactureUC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new CuoreUI.Controls.cuiButton();
            this.btnAnnul = new CuoreUI.Controls.cuiButton();
            this.btnView = new CuoreUI.Controls.cuiButton();
            this.panelFact = new System.Windows.Forms.Panel();
            this.lblArret = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backBtn = new CuoreUI.Controls.cuiButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSupp = new CuoreUI.Controls.cuiButton();
            this.BtnCreate = new CuoreUI.Controls.cuiButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Prd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchBar = new JH_Manager.JUtility.CustomTextBox();
            this.roundedPanel2 = new JH_Manager.JUtility.RoundedPanel();
            this.refQte = new System.Windows.Forms.Label();
            this.OutBtn = new CuoreUI.Controls.cuiButton();
            this.Qte = new JH_Manager.JUtility.CustomTextBox();
            this.namePRD = new System.Windows.Forms.Label();
            this.pictureBoxPrd = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.roundedPanel1 = new JH_Manager.JUtility.RoundedPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.inputAdressClient = new JH_Manager.JUtility.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputNameClient = new JH_Manager.JUtility.CustomTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelFact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrd)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.CheckButton = false;
            this.btnSearch.Checked = false;
            this.btnSearch.CheckedBackground = System.Drawing.Color.Coral;
            this.btnSearch.CheckedImageTint = System.Drawing.Color.White;
            this.btnSearch.CheckedOutline = System.Drawing.Color.Coral;
            this.btnSearch.Content = "";
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(80)))));
            this.btnSearch.HoveredImageTint = System.Drawing.Color.White;
            this.btnSearch.HoverOutline = System.Drawing.Color.Empty;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAutoCenter = true;
            this.btnSearch.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnSearch.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSearch.ImageTint = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(238, 179);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NormalBackground = System.Drawing.Color.White;
            this.btnSearch.NormalOutline = System.Drawing.Color.DimGray;
            this.btnSearch.OutlineThickness = 1.5F;
            this.btnSearch.PressedBackground = System.Drawing.Color.Coral;
            this.btnSearch.PressedImageTint = System.Drawing.Color.White;
            this.btnSearch.PressedOutline = System.Drawing.Color.Empty;
            this.btnSearch.Rounding = new System.Windows.Forms.Padding(8);
            this.btnSearch.Size = new System.Drawing.Size(38, 35);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.TextOffset = new System.Drawing.Point(0, 0);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAnnul
            // 
            this.btnAnnul.CheckButton = false;
            this.btnAnnul.Checked = false;
            this.btnAnnul.CheckedBackground = System.Drawing.Color.Coral;
            this.btnAnnul.CheckedImageTint = System.Drawing.Color.White;
            this.btnAnnul.CheckedOutline = System.Drawing.Color.Coral;
            this.btnAnnul.Content = "Annuler";
            this.btnAnnul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAnnul.ForeColor = System.Drawing.Color.White;
            this.btnAnnul.HoverBackground = System.Drawing.Color.Red;
            this.btnAnnul.HoveredImageTint = System.Drawing.Color.White;
            this.btnAnnul.HoverOutline = System.Drawing.Color.Empty;
            this.btnAnnul.Image = null;
            this.btnAnnul.ImageAutoCenter = true;
            this.btnAnnul.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnAnnul.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAnnul.ImageTint = System.Drawing.Color.White;
            this.btnAnnul.Location = new System.Drawing.Point(331, 179);
            this.btnAnnul.Name = "btnAnnul";
            this.btnAnnul.NormalBackground = System.Drawing.Color.Crimson;
            this.btnAnnul.NormalOutline = System.Drawing.Color.Empty;
            this.btnAnnul.OutlineThickness = 1.6F;
            this.btnAnnul.PressedBackground = System.Drawing.Color.Crimson;
            this.btnAnnul.PressedImageTint = System.Drawing.Color.White;
            this.btnAnnul.PressedOutline = System.Drawing.Color.Empty;
            this.btnAnnul.Rounding = new System.Windows.Forms.Padding(8);
            this.btnAnnul.Size = new System.Drawing.Size(80, 35);
            this.btnAnnul.TabIndex = 7;
            this.btnAnnul.TextOffset = new System.Drawing.Point(0, 0);
            this.btnAnnul.Click += new System.EventHandler(this.btnAnnul_Click);
            // 
            // btnView
            // 
            this.btnView.CheckButton = false;
            this.btnView.Checked = false;
            this.btnView.CheckedBackground = System.Drawing.Color.Gainsboro;
            this.btnView.CheckedImageTint = System.Drawing.Color.White;
            this.btnView.CheckedOutline = System.Drawing.Color.Coral;
            this.btnView.Content = "Apperçu";
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnView.ForeColor = System.Drawing.Color.Black;
            this.btnView.HoverBackground = System.Drawing.Color.White;
            this.btnView.HoveredImageTint = System.Drawing.Color.White;
            this.btnView.HoverOutline = System.Drawing.Color.Empty;
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageAutoCenter = true;
            this.btnView.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnView.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnView.ImageTint = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(417, 179);
            this.btnView.Name = "btnView";
            this.btnView.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnView.NormalOutline = System.Drawing.Color.Black;
            this.btnView.OutlineThickness = 1.2F;
            this.btnView.PressedBackground = System.Drawing.Color.White;
            this.btnView.PressedImageTint = System.Drawing.Color.White;
            this.btnView.PressedOutline = System.Drawing.Color.Empty;
            this.btnView.Rounding = new System.Windows.Forms.Padding(8);
            this.btnView.Size = new System.Drawing.Size(114, 35);
            this.btnView.TabIndex = 9;
            this.btnView.TextOffset = new System.Drawing.Point(5, 0);
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // panelFact
            // 
            this.panelFact.BackColor = System.Drawing.Color.White;
            this.panelFact.Controls.Add(this.lblArret);
            this.panelFact.Controls.Add(this.label5);
            this.panelFact.Controls.Add(this.backBtn);
            this.panelFact.Controls.Add(this.lblTotal);
            this.panelFact.Controls.Add(this.label4);
            this.panelFact.Controls.Add(this.btnSupp);
            this.panelFact.Controls.Add(this.BtnCreate);
            this.panelFact.Controls.Add(this.label3);
            this.panelFact.Controls.Add(this.dataGridView);
            this.panelFact.Location = new System.Drawing.Point(19, 19);
            this.panelFact.Name = "panelFact";
            this.panelFact.Size = new System.Drawing.Size(520, 490);
            this.panelFact.TabIndex = 10;
            this.panelFact.Visible = false;
            // 
            // lblArret
            // 
            this.lblArret.AutoSize = true;
            this.lblArret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblArret.Location = new System.Drawing.Point(161, 408);
            this.lblArret.Name = "lblArret";
            this.lblArret.Size = new System.Drawing.Size(65, 15);
            this.lblArret.TabIndex = 17;
            this.lblArret.Text = "Zero ariary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(27, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Arret a la somme  :";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.White;
            this.backBtn.CheckButton = false;
            this.backBtn.Checked = false;
            this.backBtn.CheckedBackground = System.Drawing.Color.Coral;
            this.backBtn.CheckedImageTint = System.Drawing.Color.White;
            this.backBtn.CheckedOutline = System.Drawing.Color.Coral;
            this.backBtn.Content = "";
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.backBtn.ForeColor = System.Drawing.Color.Black;
            this.backBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(80)))));
            this.backBtn.HoveredImageTint = System.Drawing.Color.White;
            this.backBtn.HoverOutline = System.Drawing.Color.Empty;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.ImageAutoCenter = true;
            this.backBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.backBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.backBtn.ImageTint = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(462, 5);
            this.backBtn.Name = "backBtn";
            this.backBtn.NormalBackground = System.Drawing.Color.Crimson;
            this.backBtn.NormalOutline = System.Drawing.Color.Empty;
            this.backBtn.OutlineThickness = 1.6F;
            this.backBtn.PressedBackground = System.Drawing.Color.Coral;
            this.backBtn.PressedImageTint = System.Drawing.Color.White;
            this.backBtn.PressedOutline = System.Drawing.Color.Empty;
            this.backBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.backBtn.Size = new System.Drawing.Size(31, 28);
            this.backBtn.TabIndex = 15;
            this.backBtn.TextOffset = new System.Drawing.Point(5, 0);
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTotal.Location = new System.Drawing.Point(80, 443);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(14, 15);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(27, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total :";
            // 
            // btnSupp
            // 
            this.btnSupp.BackColor = System.Drawing.Color.White;
            this.btnSupp.CheckButton = false;
            this.btnSupp.Checked = false;
            this.btnSupp.CheckedBackground = System.Drawing.Color.Coral;
            this.btnSupp.CheckedImageTint = System.Drawing.Color.White;
            this.btnSupp.CheckedOutline = System.Drawing.Color.Coral;
            this.btnSupp.Content = "Supprimer";
            this.btnSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSupp.ForeColor = System.Drawing.Color.Black;
            this.btnSupp.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(80)))));
            this.btnSupp.HoveredImageTint = System.Drawing.Color.White;
            this.btnSupp.HoverOutline = System.Drawing.Color.Empty;
            this.btnSupp.Image = ((System.Drawing.Image)(resources.GetObject("btnSupp.Image")));
            this.btnSupp.ImageAutoCenter = true;
            this.btnSupp.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnSupp.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnSupp.ImageTint = System.Drawing.Color.White;
            this.btnSupp.Location = new System.Drawing.Point(260, 442);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.NormalBackground = System.Drawing.Color.LightCoral;
            this.btnSupp.NormalOutline = System.Drawing.Color.Empty;
            this.btnSupp.OutlineThickness = 1.6F;
            this.btnSupp.PressedBackground = System.Drawing.Color.Coral;
            this.btnSupp.PressedImageTint = System.Drawing.Color.White;
            this.btnSupp.PressedOutline = System.Drawing.Color.Empty;
            this.btnSupp.Rounding = new System.Windows.Forms.Padding(8);
            this.btnSupp.Size = new System.Drawing.Size(118, 35);
            this.btnSupp.TabIndex = 12;
            this.btnSupp.TextOffset = new System.Drawing.Point(5, 0);
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.White;
            this.BtnCreate.CheckButton = false;
            this.BtnCreate.Checked = false;
            this.BtnCreate.CheckedBackground = System.Drawing.Color.GreenYellow;
            this.BtnCreate.CheckedImageTint = System.Drawing.Color.White;
            this.BtnCreate.CheckedOutline = System.Drawing.Color.Coral;
            this.BtnCreate.Content = "Creer";
            this.BtnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.BtnCreate.ForeColor = System.Drawing.Color.Black;
            this.BtnCreate.HoverBackground = System.Drawing.Color.LawnGreen;
            this.BtnCreate.HoveredImageTint = System.Drawing.Color.White;
            this.BtnCreate.HoverOutline = System.Drawing.Color.Empty;
            this.BtnCreate.Image = ((System.Drawing.Image)(resources.GetObject("BtnCreate.Image")));
            this.BtnCreate.ImageAutoCenter = true;
            this.BtnCreate.ImageExpand = new System.Drawing.Point(0, 0);
            this.BtnCreate.ImageOffset = new System.Drawing.Point(-5, 0);
            this.BtnCreate.ImageTint = System.Drawing.Color.White;
            this.BtnCreate.Location = new System.Drawing.Point(384, 442);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.NormalBackground = System.Drawing.Color.GreenYellow;
            this.BtnCreate.NormalOutline = System.Drawing.Color.Empty;
            this.BtnCreate.OutlineThickness = 1.6F;
            this.BtnCreate.PressedBackground = System.Drawing.Color.GreenYellow;
            this.BtnCreate.PressedImageTint = System.Drawing.Color.White;
            this.BtnCreate.PressedOutline = System.Drawing.Color.Empty;
            this.BtnCreate.Rounding = new System.Windows.Forms.Padding(8);
            this.BtnCreate.Size = new System.Drawing.Size(110, 35);
            this.BtnCreate.TabIndex = 11;
            this.BtnCreate.TextOffset = new System.Drawing.Point(5, 0);
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(11, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Details du Facture";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.ColumnHeadersHeight = 28;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prd,
            this.PU,
            this.Unit,
            this.Totale});
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(10, 38);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LimeGreen;
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(495, 356);
            this.dataGridView.TabIndex = 0;
            // 
            // Prd
            // 
            this.Prd.HeaderText = "Produit";
            this.Prd.Name = "Prd";
            // 
            // PU
            // 
            this.PU.FillWeight = 70F;
            this.PU.HeaderText = "PU";
            this.PU.Name = "PU";
            // 
            // Unit
            // 
            this.Unit.FillWeight = 50F;
            this.Unit.HeaderText = "Qte";
            this.Unit.Name = "Unit";
            // 
            // Totale
            // 
            this.Totale.FillWeight = 80F;
            this.Totale.HeaderText = "Total";
            this.Totale.Name = "Totale";
            // 
            // SearchBar
            // 
            this.SearchBar.BackColor = System.Drawing.Color.Transparent;
            this.SearchBar.BorderColor = System.Drawing.Color.DimGray;
            this.SearchBar.Content = "";
            this.SearchBar.FillColor = System.Drawing.Color.White;
            this.SearchBar.IsRounded = true;
            this.SearchBar.Location = new System.Drawing.Point(27, 179);
            this.SearchBar.MarginT = 20;
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Padding = new System.Windows.Forms.Padding(10);
            this.SearchBar.Placeholder = "Nom ou ID du produit";
            this.SearchBar.Size = new System.Drawing.Size(205, 35);
            this.SearchBar.TabIndex = 5;
            this.SearchBar.EnterTouch += new System.EventHandler(this.SearchProduct);
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BorderRadius = 3;
            this.roundedPanel2.Controls.Add(this.refQte);
            this.roundedPanel2.Controls.Add(this.OutBtn);
            this.roundedPanel2.Controls.Add(this.Qte);
            this.roundedPanel2.Controls.Add(this.namePRD);
            this.roundedPanel2.Controls.Add(this.pictureBoxPrd);
            this.roundedPanel2.Controls.Add(this.panelContainer);
            this.roundedPanel2.FillColor = System.Drawing.Color.White;
            this.roundedPanel2.Location = new System.Drawing.Point(27, 223);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.RadiusBottomLeft = 0;
            this.roundedPanel2.RadiusBottomRight = 0;
            this.roundedPanel2.RadiusTopLeft = 30;
            this.roundedPanel2.RadiusTopRight = 30;
            this.roundedPanel2.Size = new System.Drawing.Size(504, 286);
            this.roundedPanel2.TabIndex = 1;
            // 
            // refQte
            // 
            this.refQte.AutoSize = true;
            this.refQte.BackColor = System.Drawing.Color.White;
            this.refQte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.refQte.ForeColor = System.Drawing.SystemColors.ControlText;
            this.refQte.Location = new System.Drawing.Point(440, 193);
            this.refQte.Name = "refQte";
            this.refQte.Size = new System.Drawing.Size(22, 15);
            this.refQte.TabIndex = 11;
            this.refQte.Text = "Kg";
            // 
            // OutBtn
            // 
            this.OutBtn.BackColor = System.Drawing.Color.White;
            this.OutBtn.CheckButton = false;
            this.OutBtn.Checked = false;
            this.OutBtn.CheckedBackground = System.Drawing.Color.Coral;
            this.OutBtn.CheckedImageTint = System.Drawing.Color.White;
            this.OutBtn.CheckedOutline = System.Drawing.Color.Coral;
            this.OutBtn.Content = "Sortie";
            this.OutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.OutBtn.ForeColor = System.Drawing.Color.White;
            this.OutBtn.HoverBackground = System.Drawing.Color.CornflowerBlue;
            this.OutBtn.HoveredImageTint = System.Drawing.Color.White;
            this.OutBtn.HoverOutline = System.Drawing.Color.Empty;
            this.OutBtn.Image = ((System.Drawing.Image)(resources.GetObject("OutBtn.Image")));
            this.OutBtn.ImageAutoCenter = true;
            this.OutBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.OutBtn.ImageOffset = new System.Drawing.Point(-5, 0);
            this.OutBtn.ImageTint = System.Drawing.Color.White;
            this.OutBtn.Location = new System.Drawing.Point(319, 238);
            this.OutBtn.Name = "OutBtn";
            this.OutBtn.NormalBackground = System.Drawing.Color.RoyalBlue;
            this.OutBtn.NormalOutline = System.Drawing.Color.Empty;
            this.OutBtn.OutlineThickness = 1.6F;
            this.OutBtn.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.OutBtn.PressedImageTint = System.Drawing.Color.White;
            this.OutBtn.PressedOutline = System.Drawing.Color.Empty;
            this.OutBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.OutBtn.Size = new System.Drawing.Size(178, 35);
            this.OutBtn.TabIndex = 9;
            this.OutBtn.TextOffset = new System.Drawing.Point(5, 0);
            this.OutBtn.Click += new System.EventHandler(this.OutBtn_Click);
            // 
            // Qte
            // 
            this.Qte.BackColor = System.Drawing.Color.Transparent;
            this.Qte.BorderColor = System.Drawing.Color.Black;
            this.Qte.Content = "";
            this.Qte.FillColor = System.Drawing.Color.White;
            this.Qte.IsRounded = true;
            this.Qte.Location = new System.Drawing.Point(319, 184);
            this.Qte.MarginT = 10;
            this.Qte.Name = "Qte";
            this.Qte.Padding = new System.Windows.Forms.Padding(10);
            this.Qte.Placeholder = "Quantiter";
            this.Qte.Size = new System.Drawing.Size(115, 35);
            this.Qte.TabIndex = 5;
            this.Qte.EnterTouch += new System.EventHandler(this.TextControlChanged);
            // 
            // namePRD
            // 
            this.namePRD.AutoSize = true;
            this.namePRD.BackColor = System.Drawing.Color.White;
            this.namePRD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.namePRD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.namePRD.Location = new System.Drawing.Point(316, 155);
            this.namePRD.Name = "namePRD";
            this.namePRD.Size = new System.Drawing.Size(84, 17);
            this.namePRD.TabIndex = 5;
            this.namePRD.Text = "Oreo biscuit";
            // 
            // pictureBoxPrd
            // 
            this.pictureBoxPrd.BackColor = System.Drawing.Color.White;
            this.pictureBoxPrd.Image = global::JH_Manager.Properties.Resources.oreo;
            this.pictureBoxPrd.Location = new System.Drawing.Point(319, 11);
            this.pictureBoxPrd.Name = "pictureBoxPrd";
            this.pictureBoxPrd.Size = new System.Drawing.Size(166, 128);
            this.pictureBoxPrd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPrd.TabIndex = 5;
            this.pictureBoxPrd.TabStop = false;
            // 
            // panelContainer
            // 
            this.panelContainer.AutoScroll = true;
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Location = new System.Drawing.Point(5, 11);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(300, 266);
            this.panelContainer.TabIndex = 0;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.BorderRadius = 23;
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.inputAdressClient);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Controls.Add(this.inputNameClient);
            this.roundedPanel1.Controls.Add(this.pictureBox1);
            this.roundedPanel1.FillColor = System.Drawing.Color.White;
            this.roundedPanel1.Location = new System.Drawing.Point(27, 19);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.RadiusBottomLeft = 0;
            this.roundedPanel1.RadiusBottomRight = 0;
            this.roundedPanel1.RadiusTopLeft = 0;
            this.roundedPanel1.RadiusTopRight = 0;
            this.roundedPanel1.Size = new System.Drawing.Size(504, 147);
            this.roundedPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(28, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Remplissez les formulaires ci-dessous";
            // 
            // inputAdressClient
            // 
            this.inputAdressClient.BackColor = System.Drawing.Color.Transparent;
            this.inputAdressClient.BorderColor = System.Drawing.Color.Black;
            this.inputAdressClient.Content = "";
            this.inputAdressClient.FillColor = System.Drawing.Color.White;
            this.inputAdressClient.IsRounded = false;
            this.inputAdressClient.Location = new System.Drawing.Point(221, 84);
            this.inputAdressClient.MarginT = 10;
            this.inputAdressClient.Name = "inputAdressClient";
            this.inputAdressClient.Padding = new System.Windows.Forms.Padding(10);
            this.inputAdressClient.Placeholder = "Adress du client";
            this.inputAdressClient.Size = new System.Drawing.Size(134, 35);
            this.inputAdressClient.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Createur de facture";
            // 
            // inputNameClient
            // 
            this.inputNameClient.BackColor = System.Drawing.Color.Transparent;
            this.inputNameClient.BorderColor = System.Drawing.Color.Black;
            this.inputNameClient.Content = "";
            this.inputNameClient.FillColor = System.Drawing.Color.White;
            this.inputNameClient.IsRounded = false;
            this.inputNameClient.Location = new System.Drawing.Point(31, 84);
            this.inputNameClient.MarginT = 10;
            this.inputNameClient.Name = "inputNameClient";
            this.inputNameClient.Padding = new System.Windows.Forms.Padding(10);
            this.inputNameClient.Placeholder = "Nom du client";
            this.inputNameClient.Size = new System.Drawing.Size(174, 35);
            this.inputNameClient.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(372, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FactureUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelFact);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAnnul);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.Name = "FactureUC";
            this.Size = new System.Drawing.Size(561, 509);
            this.panelFact.ResumeLayout(false);
            this.panelFact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrd)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private JUtility.RoundedPanel roundedPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private JUtility.CustomTextBox inputAdressClient;
        private System.Windows.Forms.Label label1;
        private JUtility.CustomTextBox inputNameClient;
        private JUtility.RoundedPanel roundedPanel2;
        private JUtility.CustomTextBox SearchBar;
        private CuoreUI.Controls.cuiButton btnSearch;
        private CuoreUI.Controls.cuiButton btnAnnul;
        private System.Windows.Forms.FlowLayoutPanel panelContainer;
        private System.Windows.Forms.PictureBox pictureBoxPrd;
        private System.Windows.Forms.Label namePRD;
        private JUtility.CustomTextBox Qte;
        private CuoreUI.Controls.cuiButton OutBtn;
        private System.Windows.Forms.Label refQte;
        private CuoreUI.Controls.cuiButton btnView;
        private System.Windows.Forms.Panel panelFact;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label3;
        private CuoreUI.Controls.cuiButton BtnCreate;
        private CuoreUI.Controls.cuiButton btnSupp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private CuoreUI.Controls.cuiButton backBtn;
        private DataGridViewTextBoxColumn Prd;
        private DataGridViewTextBoxColumn PU;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn Totale;
        private Label label5;
        private Label lblArret;
    }
}
