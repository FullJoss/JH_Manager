using JH_Manager.ComponentUC.SousComponents;
using System.Windows.Forms;

namespace JH_Manager.ComponentUC
{
    partial class ShopUC
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

            // mon code
            if (disposing)
            {
                btnIn.Click -= btnIn_Click;
                foreach (Control c in Controls)
                {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopUC));
            this.roundedPanel2 = new JH_Manager.JUtility.RoundedPanel();
            this.listPanel4 = new JH_Manager.ComponentUC.SousComponents.ListPanel();
            this.customPanel1 = new JH_Manager.JUtility.CustomPanel();
            this.dtDate = new System.Windows.Forms.Label();
            this.dtOut = new System.Windows.Forms.Label();
            this.dtIn = new System.Windows.Forms.Label();
            this.dtRef = new System.Windows.Forms.Label();
            this.dtStock = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOut = new CuoreUI.Controls.cuiButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSelect = new System.Windows.Forms.Label();
            this.pictureSelect = new System.Windows.Forms.PictureBox();
            this.btnIn = new CuoreUI.Controls.cuiButton();
            this.roundedPanel1 = new JH_Manager.JUtility.RoundedPanel();
            this.CategorBox = new JH_Manager.JUtility.CustomComboBox();
            this.SearchBar = new JH_Manager.JUtility.CustomTextBox();
            this.btnSearch = new CuoreUI.Controls.cuiButton();
            this.roundedPanel2.SuspendLayout();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSelect)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BorderRadius = 3;
            this.roundedPanel2.Controls.Add(this.listPanel4);
            this.roundedPanel2.FillColor = System.Drawing.Color.White;
            this.roundedPanel2.Location = new System.Drawing.Point(239, 113);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.RadiusBottomLeft = 0;
            this.roundedPanel2.RadiusBottomRight = 0;
            this.roundedPanel2.RadiusTopLeft = 20;
            this.roundedPanel2.RadiusTopRight = 20;
            this.roundedPanel2.Size = new System.Drawing.Size(322, 396);
            this.roundedPanel2.TabIndex = 2;
            // 
            // listPanel4
            // 
            this.listPanel4.AutoScroll = true;
            this.listPanel4.Location = new System.Drawing.Point(3, 3);
            this.listPanel4.Name = "listPanel4";
            this.listPanel4.Size = new System.Drawing.Size(319, 393);
            this.listPanel4.TabIndex = 0;
            this.listPanel4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickProduct);
            // 
            // customPanel1
            // 
            this.customPanel1.BorderColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 25F;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Controls.Add(this.dtDate);
            this.customPanel1.Controls.Add(this.dtOut);
            this.customPanel1.Controls.Add(this.dtIn);
            this.customPanel1.Controls.Add(this.dtRef);
            this.customPanel1.Controls.Add(this.dtStock);
            this.customPanel1.Controls.Add(this.label6);
            this.customPanel1.Controls.Add(this.btnOut);
            this.customPanel1.Controls.Add(this.label5);
            this.customPanel1.Controls.Add(this.label4);
            this.customPanel1.Controls.Add(this.labelSelect);
            this.customPanel1.Controls.Add(this.pictureSelect);
            this.customPanel1.Controls.Add(this.btnIn);
            this.customPanel1.FillColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(18, 16);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(200, 473);
            this.customPanel1.TabIndex = 1;
            // 
            // dtDate
            // 
            this.dtDate.AutoSize = true;
            this.dtDate.ForeColor = System.Drawing.Color.Black;
            this.dtDate.Location = new System.Drawing.Point(37, 442);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(45, 13);
            this.dtDate.TabIndex = 8;
            this.dtDate.Text = "crée le :";
            // 
            // dtOut
            // 
            this.dtOut.AutoSize = true;
            this.dtOut.ForeColor = System.Drawing.Color.Black;
            this.dtOut.Location = new System.Drawing.Point(37, 417);
            this.dtOut.Name = "dtOut";
            this.dtOut.Size = new System.Drawing.Size(67, 13);
            this.dtOut.TabIndex = 7;
            this.dtOut.Text = "Nb. sortie : 0";
            // 
            // dtIn
            // 
            this.dtIn.AutoSize = true;
            this.dtIn.ForeColor = System.Drawing.Color.Black;
            this.dtIn.Location = new System.Drawing.Point(37, 392);
            this.dtIn.Name = "dtIn";
            this.dtIn.Size = new System.Drawing.Size(77, 13);
            this.dtIn.TabIndex = 6;
            this.dtIn.Text = "Nb. d\'entrer : 0";
            // 
            // dtRef
            // 
            this.dtRef.AutoSize = true;
            this.dtRef.ForeColor = System.Drawing.Color.Black;
            this.dtRef.Location = new System.Drawing.Point(37, 366);
            this.dtRef.Name = "dtRef";
            this.dtRef.Size = new System.Drawing.Size(89, 13);
            this.dtRef.TabIndex = 5;
            this.dtRef.Text = "Reference : unité";
            // 
            // dtStock
            // 
            this.dtStock.AutoSize = true;
            this.dtStock.ForeColor = System.Drawing.Color.Black;
            this.dtStock.Location = new System.Drawing.Point(37, 343);
            this.dtStock.Name = "dtStock";
            this.dtStock.Size = new System.Drawing.Size(50, 13);
            this.dtStock.TabIndex = 4;
            this.dtStock.Text = "Stock : 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(16, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Information";
            // 
            // btnOut
            // 
            this.btnOut.CheckButton = false;
            this.btnOut.Checked = false;
            this.btnOut.CheckedBackground = System.Drawing.Color.Crimson;
            this.btnOut.CheckedImageTint = System.Drawing.Color.White;
            this.btnOut.CheckedOutline = System.Drawing.Color.Coral;
            this.btnOut.Content = "Sortie";
            this.btnOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnOut.ForeColor = System.Drawing.Color.White;
            this.btnOut.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOut.HoveredImageTint = System.Drawing.Color.White;
            this.btnOut.HoverOutline = System.Drawing.Color.Empty;
            this.btnOut.Image = ((System.Drawing.Image)(resources.GetObject("btnOut.Image")));
            this.btnOut.ImageAutoCenter = true;
            this.btnOut.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnOut.ImageOffset = new System.Drawing.Point(-3, 0);
            this.btnOut.ImageTint = System.Drawing.Color.White;
            this.btnOut.Location = new System.Drawing.Point(104, 248);
            this.btnOut.Name = "btnOut";
            this.btnOut.NormalBackground = System.Drawing.Color.Crimson;
            this.btnOut.NormalOutline = System.Drawing.Color.Empty;
            this.btnOut.OutlineThickness = 1.6F;
            this.btnOut.PressedBackground = System.Drawing.Color.Crimson;
            this.btnOut.PressedImageTint = System.Drawing.Color.White;
            this.btnOut.PressedOutline = System.Drawing.Color.Empty;
            this.btnOut.Rounding = new System.Windows.Forms.Padding(8);
            this.btnOut.Size = new System.Drawing.Size(83, 36);
            this.btnOut.TabIndex = 2;
            this.btnOut.TextOffset = new System.Drawing.Point(3, 0);
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(16, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Action";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "___________________________";
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelSelect.Location = new System.Drawing.Point(11, 21);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(0, 22);
            this.labelSelect.TabIndex = 1;
            // 
            // pictureSelect
            // 
            this.pictureSelect.Location = new System.Drawing.Point(15, 50);
            this.pictureSelect.Name = "pictureSelect";
            this.pictureSelect.Size = new System.Drawing.Size(172, 139);
            this.pictureSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSelect.TabIndex = 1;
            this.pictureSelect.TabStop = false;
            // 
            // btnIn
            // 
            this.btnIn.CheckButton = false;
            this.btnIn.Checked = false;
            this.btnIn.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnIn.CheckedImageTint = System.Drawing.Color.White;
            this.btnIn.CheckedOutline = System.Drawing.Color.Coral;
            this.btnIn.Content = "Entrer";
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnIn.ForeColor = System.Drawing.Color.White;
            this.btnIn.HoverBackground = System.Drawing.Color.CornflowerBlue;
            this.btnIn.HoveredImageTint = System.Drawing.Color.White;
            this.btnIn.HoverOutline = System.Drawing.Color.Empty;
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageAutoCenter = true;
            this.btnIn.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnIn.ImageOffset = new System.Drawing.Point(-3, 0);
            this.btnIn.ImageTint = System.Drawing.Color.White;
            this.btnIn.Location = new System.Drawing.Point(15, 248);
            this.btnIn.Name = "btnIn";
            this.btnIn.NormalBackground = System.Drawing.Color.RoyalBlue;
            this.btnIn.NormalOutline = System.Drawing.Color.Empty;
            this.btnIn.OutlineThickness = 1.6F;
            this.btnIn.PressedBackground = System.Drawing.Color.CornflowerBlue;
            this.btnIn.PressedImageTint = System.Drawing.Color.White;
            this.btnIn.PressedOutline = System.Drawing.Color.Empty;
            this.btnIn.Rounding = new System.Windows.Forms.Padding(8);
            this.btnIn.Size = new System.Drawing.Size(83, 36);
            this.btnIn.TabIndex = 1;
            this.btnIn.TextOffset = new System.Drawing.Point(3, 0);
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BorderRadius = 3;
            this.roundedPanel1.Controls.Add(this.CategorBox);
            this.roundedPanel1.Controls.Add(this.SearchBar);
            this.roundedPanel1.Controls.Add(this.btnSearch);
            this.roundedPanel1.FillColor = System.Drawing.Color.White;
            this.roundedPanel1.Location = new System.Drawing.Point(239, 0);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.RadiusBottomLeft = 50;
            this.roundedPanel1.RadiusBottomRight = 50;
            this.roundedPanel1.RadiusTopLeft = 0;
            this.roundedPanel1.RadiusTopRight = 0;
            this.roundedPanel1.Size = new System.Drawing.Size(322, 96);
            this.roundedPanel1.TabIndex = 0;
            // 
            // CategorBox
            // 
            this.CategorBox.BackColor = System.Drawing.Color.White;
            this.CategorBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CategorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CategorBox.FormattingEnabled = true;
            this.CategorBox.ItemHeight = 25;
            this.CategorBox.Location = new System.Drawing.Point(24, 10);
            this.CategorBox.Name = "CategorBox";
            this.CategorBox.Size = new System.Drawing.Size(275, 31);
            this.CategorBox.TabIndex = 4;
            // 
            // SearchBar
            // 
            this.SearchBar.BackColor = System.Drawing.Color.Transparent;
            this.SearchBar.BorderColor = System.Drawing.Color.Black;
            this.SearchBar.Content = "";
            this.SearchBar.FillColor = System.Drawing.Color.White;
            this.SearchBar.IsRounded = true;
            this.SearchBar.Location = new System.Drawing.Point(24, 50);
            this.SearchBar.MarginT = 10;
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Padding = new System.Windows.Forms.Padding(10);
            this.SearchBar.Placeholder = "Nom ou ID";
            this.SearchBar.Size = new System.Drawing.Size(236, 36);
            this.SearchBar.TabIndex = 3;
            this.SearchBar.EnterTouch += new System.EventHandler(this.BtnSearch_Click);
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
            this.btnSearch.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(80)))));
            this.btnSearch.HoveredImageTint = System.Drawing.Color.White;
            this.btnSearch.HoverOutline = System.Drawing.Color.Empty;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAutoCenter = true;
            this.btnSearch.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnSearch.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSearch.ImageTint = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(266, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnSearch.NormalOutline = System.Drawing.Color.Empty;
            this.btnSearch.OutlineThickness = 1.6F;
            this.btnSearch.PressedBackground = System.Drawing.Color.Coral;
            this.btnSearch.PressedImageTint = System.Drawing.Color.White;
            this.btnSearch.PressedOutline = System.Drawing.Color.Empty;
            this.btnSearch.Rounding = new System.Windows.Forms.Padding(8);
            this.btnSearch.Size = new System.Drawing.Size(33, 33);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.TextOffset = new System.Drawing.Point(0, 0);
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // ShopUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.roundedPanel1);
            this.Name = "ShopUC";
            this.Size = new System.Drawing.Size(569, 509);
            this.roundedPanel2.ResumeLayout(false);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSelect)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CuoreUI.Controls.cuiButton btnSearch;
        private JUtility.RoundedPanel roundedPanel1;
        private JUtility.CustomPanel customPanel1;
        private System.Windows.Forms.PictureBox pictureSelect;
        private CuoreUI.Controls.cuiButton btnOut;
        private CuoreUI.Controls.cuiButton btnIn;
        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private JUtility.RoundedPanel roundedPanel2;
        public Label dtRef;
        public Label dtStock;
        public Label dtIn;
        public Label dtOut;
        public Label dtDate;
        private JUtility.CustomTextBox SearchBar;
        private JUtility.CustomComboBox CategorBox;
        private ListPanel listPanel4;
    }
}
