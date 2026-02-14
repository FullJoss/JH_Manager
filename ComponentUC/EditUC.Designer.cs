using JH_Manager.ComponentUC.SousComponents;
using System.Windows.Forms;

namespace JH_Manager.ComponentUC
{
    partial class EditUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUC));
            this.roundedPanel2 = new JH_Manager.JUtility.RoundedPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cuiButton2 = new CuoreUI.Controls.cuiButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnter = new CuoreUI.Controls.cuiButton();
            this.pPU = new JH_Manager.JUtility.CustomTextBox();
            this.pRef = new JH_Manager.JUtility.CustomTextBox();
            this.pMin = new JH_Manager.JUtility.CustomTextBox();
            this.pMax = new JH_Manager.JUtility.CustomTextBox();
            this.pStock = new JH_Manager.JUtility.CustomTextBox();
            this.pID = new JH_Manager.JUtility.CustomTextBox();
            this.pNom = new JH_Manager.JUtility.CustomTextBox();
            this.roundedPanel1 = new JH_Manager.JUtility.RoundedPanel();
            this.CategorBox = new JH_Manager.JUtility.CustomComboBox();
            this.btnSearch = new CuoreUI.Controls.cuiButton();
            this.SearchBar = new JH_Manager.JUtility.CustomTextBox();
            this.panelContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BorderRadius = 3;
            this.roundedPanel2.Controls.Add(this.label6);
            this.roundedPanel2.Controls.Add(this.label8);
            this.roundedPanel2.Controls.Add(this.label7);
            this.roundedPanel2.Controls.Add(this.label5);
            this.roundedPanel2.Controls.Add(this.cuiButton2);
            this.roundedPanel2.Controls.Add(this.label4);
            this.roundedPanel2.Controls.Add(this.label3);
            this.roundedPanel2.Controls.Add(this.label2);
            this.roundedPanel2.Controls.Add(this.btnEnter);
            this.roundedPanel2.Controls.Add(this.pPU);
            this.roundedPanel2.Controls.Add(this.pRef);
            this.roundedPanel2.Controls.Add(this.pMin);
            this.roundedPanel2.Controls.Add(this.pMax);
            this.roundedPanel2.Controls.Add(this.pStock);
            this.roundedPanel2.Controls.Add(this.pID);
            this.roundedPanel2.Controls.Add(this.pNom);
            this.roundedPanel2.FillColor = System.Drawing.Color.White;
            this.roundedPanel2.Location = new System.Drawing.Point(337, 13);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.RadiusBottomLeft = 0;
            this.roundedPanel2.RadiusBottomRight = 150;
            this.roundedPanel2.RadiusTopLeft = 50;
            this.roundedPanel2.RadiusTopRight = 0;
            this.roundedPanel2.Size = new System.Drawing.Size(232, 484);
            this.roundedPanel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(17, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Coût de production ou prix d\'origine";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(24, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 35);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ref";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(24, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 35);
            this.label7.TabIndex = 14;
            this.label7.Text = "Min";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(24, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 35);
            this.label5.TabIndex = 12;
            this.label5.Text = "Stock";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cuiButton2
            // 
            this.cuiButton2.BackColor = System.Drawing.Color.Transparent;
            this.cuiButton2.CheckButton = false;
            this.cuiButton2.Checked = false;
            this.cuiButton2.CheckedBackground = System.Drawing.Color.Gainsboro;
            this.cuiButton2.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton2.CheckedOutline = System.Drawing.Color.Coral;
            this.cuiButton2.Content = "Changer l\'image";
            this.cuiButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton2.ForeColor = System.Drawing.Color.Black;
            this.cuiButton2.HoverBackground = System.Drawing.Color.LightGray;
            this.cuiButton2.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton2.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton2.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton2.Image")));
            this.cuiButton2.ImageAutoCenter = true;
            this.cuiButton2.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton2.ImageOffset = new System.Drawing.Point(-5, 0);
            this.cuiButton2.ImageTint = System.Drawing.Color.White;
            this.cuiButton2.Location = new System.Drawing.Point(20, 10);
            this.cuiButton2.Name = "cuiButton2";
            this.cuiButton2.NormalBackground = System.Drawing.Color.Gainsboro;
            this.cuiButton2.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton2.OutlineThickness = 1.6F;
            this.cuiButton2.PressedBackground = System.Drawing.Color.Gainsboro;
            this.cuiButton2.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton2.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton2.Size = new System.Drawing.Size(200, 42);
            this.cuiButton2.TabIndex = 11;
            this.cuiButton2.TextOffset = new System.Drawing.Point(5, 0);
            this.cuiButton2.Click += new System.EventHandler(this.cuiButton2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(17, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Parametre du stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(17, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prix de vente par unité";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Information";
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Transparent;
            this.btnEnter.CheckButton = false;
            this.btnEnter.Checked = false;
            this.btnEnter.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnEnter.CheckedImageTint = System.Drawing.Color.White;
            this.btnEnter.CheckedOutline = System.Drawing.Color.Coral;
            this.btnEnter.Content = "Appliquer";
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEnter.HoveredImageTint = System.Drawing.Color.White;
            this.btnEnter.HoverOutline = System.Drawing.Color.Empty;
            this.btnEnter.Image = null;
            this.btnEnter.ImageAutoCenter = true;
            this.btnEnter.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnEnter.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnEnter.ImageTint = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(103, 436);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnEnter.NormalOutline = System.Drawing.Color.Empty;
            this.btnEnter.OutlineThickness = 1.6F;
            this.btnEnter.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnEnter.PressedImageTint = System.Drawing.Color.White;
            this.btnEnter.PressedOutline = System.Drawing.Color.Empty;
            this.btnEnter.Rounding = new System.Windows.Forms.Padding(8);
            this.btnEnter.Size = new System.Drawing.Size(117, 36);
            this.btnEnter.TabIndex = 7;
            this.btnEnter.TextOffset = new System.Drawing.Point(0, 0);
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // pPU
            // 
            this.pPU.BackColor = System.Drawing.Color.Transparent;
            this.pPU.BorderColor = System.Drawing.Color.Black;
            this.pPU.Content = "";
            this.pPU.FillColor = System.Drawing.Color.White;
            this.pPU.IsRounded = true;
            this.pPU.Location = new System.Drawing.Point(20, 335);
            this.pPU.MarginT = 10;
            this.pPU.Name = "pPU";
            this.pPU.Padding = new System.Windows.Forms.Padding(10);
            this.pPU.Placeholder = "Prix de vente";
            this.pPU.Size = new System.Drawing.Size(200, 35);
            this.pPU.TabIndex = 6;
            // 
            // pRef
            // 
            this.pRef.BackColor = System.Drawing.Color.Transparent;
            this.pRef.BorderColor = System.Drawing.Color.Black;
            this.pRef.Content = "";
            this.pRef.FillColor = System.Drawing.Color.White;
            this.pRef.IsRounded = true;
            this.pRef.Location = new System.Drawing.Point(103, 266);
            this.pRef.MarginT = 10;
            this.pRef.Name = "pRef";
            this.pRef.Padding = new System.Windows.Forms.Padding(10);
            this.pRef.Placeholder = "Ref";
            this.pRef.Size = new System.Drawing.Size(117, 35);
            this.pRef.TabIndex = 5;
            // 
            // pMin
            // 
            this.pMin.BackColor = System.Drawing.Color.Transparent;
            this.pMin.BorderColor = System.Drawing.Color.Black;
            this.pMin.Content = "";
            this.pMin.FillColor = System.Drawing.Color.White;
            this.pMin.IsRounded = true;
            this.pMin.Location = new System.Drawing.Point(103, 225);
            this.pMin.MarginT = 10;
            this.pMin.Name = "pMin";
            this.pMin.Padding = new System.Windows.Forms.Padding(10);
            this.pMin.Placeholder = "Min stock";
            this.pMin.Size = new System.Drawing.Size(117, 35);
            this.pMin.TabIndex = 4;
            // 
            // pMax
            // 
            this.pMax.BackColor = System.Drawing.Color.Transparent;
            this.pMax.BorderColor = System.Drawing.Color.Black;
            this.pMax.Content = "";
            this.pMax.FillColor = System.Drawing.Color.White;
            this.pMax.IsRounded = true;
            this.pMax.Location = new System.Drawing.Point(20, 392);
            this.pMax.MarginT = 10;
            this.pMax.Name = "pMax";
            this.pMax.Padding = new System.Windows.Forms.Padding(10);
            this.pMax.Placeholder = "Prix initiale";
            this.pMax.Size = new System.Drawing.Size(200, 35);
            this.pMax.TabIndex = 3;
            // 
            // pStock
            // 
            this.pStock.BackColor = System.Drawing.Color.Transparent;
            this.pStock.BorderColor = System.Drawing.Color.Black;
            this.pStock.Content = "";
            this.pStock.FillColor = System.Drawing.Color.White;
            this.pStock.IsRounded = true;
            this.pStock.Location = new System.Drawing.Point(103, 184);
            this.pStock.MarginT = 10;
            this.pStock.Name = "pStock";
            this.pStock.Padding = new System.Windows.Forms.Padding(10);
            this.pStock.Placeholder = "Stock";
            this.pStock.Size = new System.Drawing.Size(117, 35);
            this.pStock.TabIndex = 2;
            // 
            // pID
            // 
            this.pID.BackColor = System.Drawing.Color.Transparent;
            this.pID.BorderColor = System.Drawing.Color.Black;
            this.pID.Content = "";
            this.pID.FillColor = System.Drawing.Color.White;
            this.pID.IsRounded = true;
            this.pID.Location = new System.Drawing.Point(20, 117);
            this.pID.MarginT = 10;
            this.pID.Name = "pID";
            this.pID.Padding = new System.Windows.Forms.Padding(10);
            this.pID.Placeholder = "ID";
            this.pID.Size = new System.Drawing.Size(200, 35);
            this.pID.TabIndex = 1;
            // 
            // pNom
            // 
            this.pNom.BackColor = System.Drawing.Color.Transparent;
            this.pNom.BorderColor = System.Drawing.Color.Black;
            this.pNom.Content = "";
            this.pNom.FillColor = System.Drawing.Color.White;
            this.pNom.IsRounded = true;
            this.pNom.Location = new System.Drawing.Point(20, 76);
            this.pNom.MarginT = 10;
            this.pNom.Name = "pNom";
            this.pNom.Padding = new System.Windows.Forms.Padding(10);
            this.pNom.Placeholder = "Nom";
            this.pNom.Size = new System.Drawing.Size(200, 35);
            this.pNom.TabIndex = 0;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.BorderRadius = 3;
            this.roundedPanel1.Controls.Add(this.CategorBox);
            this.roundedPanel1.Controls.Add(this.btnSearch);
            this.roundedPanel1.Controls.Add(this.SearchBar);
            this.roundedPanel1.Controls.Add(this.panelContainer);
            this.roundedPanel1.FillColor = System.Drawing.Color.White;
            this.roundedPanel1.Location = new System.Drawing.Point(10, 13);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.RadiusBottomLeft = 0;
            this.roundedPanel1.RadiusBottomRight = 0;
            this.roundedPanel1.RadiusTopLeft = 50;
            this.roundedPanel1.RadiusTopRight = 50;
            this.roundedPanel1.Size = new System.Drawing.Size(308, 496);
            this.roundedPanel1.TabIndex = 0;
            // 
            // CategorBox
            // 
            this.CategorBox.BackColor = System.Drawing.Color.White;
            this.CategorBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CategorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategorBox.FormattingEnabled = true;
            this.CategorBox.ItemHeight = 25;
            this.CategorBox.Location = new System.Drawing.Point(26, 16);
            this.CategorBox.Name = "CategorBox";
            this.CategorBox.Size = new System.Drawing.Size(254, 31);
            this.CategorBox.TabIndex = 4;
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
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSearch.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnSearch.HoveredImageTint = System.Drawing.Color.White;
            this.btnSearch.HoverOutline = System.Drawing.Color.Empty;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAutoCenter = true;
            this.btnSearch.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnSearch.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSearch.ImageTint = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(247, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnSearch.NormalOutline = System.Drawing.Color.Empty;
            this.btnSearch.OutlineThickness = 1.6F;
            this.btnSearch.PressedBackground = System.Drawing.Color.Coral;
            this.btnSearch.PressedImageTint = System.Drawing.Color.White;
            this.btnSearch.PressedOutline = System.Drawing.Color.Empty;
            this.btnSearch.Rounding = new System.Windows.Forms.Padding(8);
            this.btnSearch.Size = new System.Drawing.Size(33, 33);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.TextOffset = new System.Drawing.Point(0, 0);
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // SearchBar
            // 
            this.SearchBar.BackColor = System.Drawing.Color.Transparent;
            this.SearchBar.BorderColor = System.Drawing.Color.DimGray;
            this.SearchBar.Content = "";
            this.SearchBar.FillColor = System.Drawing.Color.White;
            this.SearchBar.IsRounded = true;
            this.SearchBar.Location = new System.Drawing.Point(26, 53);
            this.SearchBar.MarginT = 10;
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Padding = new System.Windows.Forms.Padding(10);
            this.SearchBar.Placeholder = "Nom ou produit";
            this.SearchBar.Size = new System.Drawing.Size(215, 35);
            this.SearchBar.TabIndex = 0;
            this.SearchBar.EnterTouch += new System.EventHandler(this.BtnSearch_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.AutoScroll = true;
            this.panelContainer.Location = new System.Drawing.Point(3, 105);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(302, 388);
            this.panelContainer.TabIndex = 1;
            // 
            // EditUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.Name = "EditUC";
            this.Size = new System.Drawing.Size(569, 509);
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private JUtility.RoundedPanel roundedPanel1;
        private System.Windows.Forms.FlowLayoutPanel panelContainer;
        private JUtility.CustomTextBox SearchBar;
        private JUtility.RoundedPanel roundedPanel2;
        private CuoreUI.Controls.cuiButton btnSearch;
        private JUtility.CustomTextBox pID;
        private JUtility.CustomTextBox pNom;
        private JUtility.CustomTextBox pMin;
        private JUtility.CustomTextBox pMax;
        private JUtility.CustomTextBox pStock;
        private JUtility.CustomTextBox pRef;
        private JUtility.CustomTextBox pPU;
        private CuoreUI.Controls.cuiButton btnEnter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private CuoreUI.Controls.cuiButton cuiButton2;
        private Label label7;
        private Label label5;
        private Label label8;
        private Label label6;
        private JUtility.CustomComboBox CategorBox;
    }
}
