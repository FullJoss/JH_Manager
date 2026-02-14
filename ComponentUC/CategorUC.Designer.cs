namespace JH_Manager.ComponentUC
{
    partial class CategorUC
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
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategorUC));
            this.btnTrans = new CuoreUI.Controls.cuiButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSupp = new CuoreUI.Controls.cuiButton();
            this.label4 = new System.Windows.Forms.Label();
            this.TransCategor = new JH_Manager.JUtility.CustomComboBox();
            this.roundedPanel2 = new JH_Manager.JUtility.RoundedPanel();
            this.btnAdd = new CuoreUI.Controls.cuiButton();
            this.pNewName = new JH_Manager.JUtility.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedPanel1 = new JH_Manager.JUtility.RoundedPanel();
            this.CategorBox = new JH_Manager.JUtility.CustomComboBox();
            this.btnSearch = new CuoreUI.Controls.cuiButton();
            this.SearchBar = new JH_Manager.JUtility.CustomTextBox();
            this.panelContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTrans
            // 
            this.btnTrans.CheckButton = false;
            this.btnTrans.Checked = false;
            this.btnTrans.CheckedBackground = System.Drawing.Color.Green;
            this.btnTrans.CheckedImageTint = System.Drawing.Color.White;
            this.btnTrans.CheckedOutline = System.Drawing.SystemColors.ControlText;
            this.btnTrans.Content = "Transferer";
            this.btnTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnTrans.ForeColor = System.Drawing.Color.White;
            this.btnTrans.HoverBackground = System.Drawing.Color.GreenYellow;
            this.btnTrans.HoveredImageTint = System.Drawing.Color.White;
            this.btnTrans.HoverOutline = System.Drawing.Color.Empty;
            this.btnTrans.Image = ((System.Drawing.Image)(resources.GetObject("btnTrans.Image")));
            this.btnTrans.ImageAutoCenter = true;
            this.btnTrans.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnTrans.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnTrans.ImageTint = System.Drawing.Color.White;
            this.btnTrans.Location = new System.Drawing.Point(386, 237);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.NormalBackground = System.Drawing.Color.Green;
            this.btnTrans.NormalOutline = System.Drawing.Color.Empty;
            this.btnTrans.OutlineThickness = 1.6F;
            this.btnTrans.PressedBackground = System.Drawing.Color.Green;
            this.btnTrans.PressedImageTint = System.Drawing.Color.White;
            this.btnTrans.PressedOutline = System.Drawing.Color.Empty;
            this.btnTrans.Rounding = new System.Windows.Forms.Padding(8);
            this.btnTrans.Size = new System.Drawing.Size(119, 35);
            this.btnTrans.TabIndex = 8;
            this.btnTrans.TextOffset = new System.Drawing.Point(5, 0);
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(333, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Changer le catégorie d\'un produit";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(350, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Transferer vers :";
            // 
            // btnSupp
            // 
            this.btnSupp.CheckButton = false;
            this.btnSupp.Checked = false;
            this.btnSupp.CheckedBackground = System.Drawing.Color.Crimson;
            this.btnSupp.CheckedImageTint = System.Drawing.Color.White;
            this.btnSupp.CheckedOutline = System.Drawing.Color.Coral;
            this.btnSupp.Content = "Supprimer";
            this.btnSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSupp.ForeColor = System.Drawing.Color.White;
            this.btnSupp.HoverBackground = System.Drawing.Color.Red;
            this.btnSupp.HoveredImageTint = System.Drawing.Color.White;
            this.btnSupp.HoverOutline = System.Drawing.Color.Empty;
            this.btnSupp.Image = ((System.Drawing.Image)(resources.GetObject("btnSupp.Image")));
            this.btnSupp.ImageAutoCenter = true;
            this.btnSupp.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnSupp.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnSupp.ImageTint = System.Drawing.Color.White;
            this.btnSupp.Location = new System.Drawing.Point(386, 423);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.NormalBackground = System.Drawing.Color.Crimson;
            this.btnSupp.NormalOutline = System.Drawing.Color.Empty;
            this.btnSupp.OutlineThickness = 1.6F;
            this.btnSupp.PressedBackground = System.Drawing.Color.Crimson;
            this.btnSupp.PressedImageTint = System.Drawing.Color.White;
            this.btnSupp.PressedOutline = System.Drawing.Color.Empty;
            this.btnSupp.Rounding = new System.Windows.Forms.Padding(8);
            this.btnSupp.Size = new System.Drawing.Size(119, 35);
            this.btnSupp.TabIndex = 10;
            this.btnSupp.TextOffset = new System.Drawing.Point(5, 0);
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(333, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Supprimer ce categorie";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TransCategor
            // 
            this.TransCategor.BackColor = System.Drawing.Color.White;
            this.TransCategor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TransCategor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransCategor.FormattingEnabled = true;
            this.TransCategor.ItemHeight = 25;
            this.TransCategor.Location = new System.Drawing.Point(350, 341);
            this.TransCategor.Name = "TransCategor";
            this.TransCategor.Size = new System.Drawing.Size(185, 31);
            this.TransCategor.TabIndex = 5;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BorderRadius = 20;
            this.roundedPanel2.Controls.Add(this.btnAdd);
            this.roundedPanel2.Controls.Add(this.pNewName);
            this.roundedPanel2.Controls.Add(this.label1);
            this.roundedPanel2.FillColor = System.Drawing.Color.White;
            this.roundedPanel2.Location = new System.Drawing.Point(333, 13);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.RadiusBottomLeft = 0;
            this.roundedPanel2.RadiusBottomRight = 0;
            this.roundedPanel2.RadiusTopLeft = 0;
            this.roundedPanel2.RadiusTopRight = 0;
            this.roundedPanel2.Size = new System.Drawing.Size(220, 162);
            this.roundedPanel2.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.CheckButton = false;
            this.btnAdd.Checked = false;
            this.btnAdd.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAdd.CheckedImageTint = System.Drawing.Color.White;
            this.btnAdd.CheckedOutline = System.Drawing.Color.Coral;
            this.btnAdd.Content = "Ajouter";
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.HoveredImageTint = System.Drawing.Color.White;
            this.btnAdd.HoverOutline = System.Drawing.Color.Empty;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAutoCenter = true;
            this.btnAdd.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnAdd.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnAdd.ImageTint = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(17, 113);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAdd.NormalOutline = System.Drawing.Color.Empty;
            this.btnAdd.OutlineThickness = 1.6F;
            this.btnAdd.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAdd.PressedImageTint = System.Drawing.Color.White;
            this.btnAdd.PressedOutline = System.Drawing.Color.Empty;
            this.btnAdd.Rounding = new System.Windows.Forms.Padding(8);
            this.btnAdd.Size = new System.Drawing.Size(185, 35);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.TextOffset = new System.Drawing.Point(5, 0);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pNewName
            // 
            this.pNewName.BackColor = System.Drawing.Color.Transparent;
            this.pNewName.BorderColor = System.Drawing.Color.Black;
            this.pNewName.Content = "";
            this.pNewName.FillColor = System.Drawing.Color.White;
            this.pNewName.IsRounded = true;
            this.pNewName.Location = new System.Drawing.Point(17, 62);
            this.pNewName.MarginT = 10;
            this.pNewName.Name = "pNewName";
            this.pNewName.Padding = new System.Windows.Forms.Padding(10);
            this.pNewName.Placeholder = "Nom du categorie";
            this.pNewName.Size = new System.Drawing.Size(185, 40);
            this.pNewName.TabIndex = 0;
            this.pNewName.ContentChanged += new System.EventHandler(this.NameChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Créer un nouveaux catégorie";
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
            this.roundedPanel1.Location = new System.Drawing.Point(17, 13);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.RadiusBottomLeft = 0;
            this.roundedPanel1.RadiusBottomRight = 0;
            this.roundedPanel1.RadiusTopLeft = 50;
            this.roundedPanel1.RadiusTopRight = 50;
            this.roundedPanel1.Size = new System.Drawing.Size(308, 496);
            this.roundedPanel1.TabIndex = 7;
            // 
            // CategorBox
            // 
            this.CategorBox.BackColor = System.Drawing.Color.White;
            this.CategorBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CategorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategorBox.FormattingEnabled = true;
            this.CategorBox.ItemHeight = 25;
            this.CategorBox.Location = new System.Drawing.Point(26, 18);
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
            this.btnSearch.Location = new System.Drawing.Point(247, 55);
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
            this.SearchBar.Location = new System.Drawing.Point(26, 55);
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
            // CategorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TransCategor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTrans);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.Name = "CategorUC";
            this.Size = new System.Drawing.Size(569, 509);
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private JUtility.CustomTextBox pNewName;
        private System.Windows.Forms.Label label1;
        private JUtility.RoundedPanel roundedPanel1;
        private JUtility.CustomComboBox CategorBox;
        private CuoreUI.Controls.cuiButton btnSearch;
        private JUtility.CustomTextBox SearchBar;
        private System.Windows.Forms.FlowLayoutPanel panelContainer;
        private JUtility.RoundedPanel roundedPanel2;
        private CuoreUI.Controls.cuiButton btnAdd;
        private CuoreUI.Controls.cuiButton btnTrans;
        private System.Windows.Forms.Label label2;
        private JUtility.CustomComboBox TransCategor;
        private System.Windows.Forms.Label label3;
        private CuoreUI.Controls.cuiButton btnSupp;
        private System.Windows.Forms.Label label4;
    }
}
