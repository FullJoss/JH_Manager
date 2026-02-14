namespace JH_Manager.ComponentUC
{
    partial class ReviewUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewUC));
            this.panelRef = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRetour = new CuoreUI.Controls.cuiButton();
            this.customPanel2 = new JH_Manager.JUtility.CustomPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BudgetLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StockLabel = new System.Windows.Forms.Label();
            this.customPanel1 = new JH_Manager.JUtility.CustomPanel();
            this.labelNIn = new System.Windows.Forms.Label();
            this.labelNOut = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRef
            // 
            this.panelRef.Location = new System.Drawing.Point(20, 58);
            this.panelRef.Name = "panelRef";
            this.panelRef.Size = new System.Drawing.Size(541, 294);
            this.panelRef.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(16, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Revu globale des stocks";
            // 
            // btnRetour
            // 
            this.btnRetour.CheckButton = false;
            this.btnRetour.Checked = false;
            this.btnRetour.CheckedBackground = System.Drawing.Color.Crimson;
            this.btnRetour.CheckedImageTint = System.Drawing.Color.White;
            this.btnRetour.CheckedOutline = System.Drawing.Color.Coral;
            this.btnRetour.Content = "Retour";
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnRetour.ForeColor = System.Drawing.Color.White;
            this.btnRetour.HoverBackground = System.Drawing.Color.Red;
            this.btnRetour.HoveredImageTint = System.Drawing.Color.White;
            this.btnRetour.HoverOutline = System.Drawing.Color.Empty;
            this.btnRetour.Image = null;
            this.btnRetour.ImageAutoCenter = true;
            this.btnRetour.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnRetour.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnRetour.ImageTint = System.Drawing.Color.White;
            this.btnRetour.Location = new System.Drawing.Point(446, 8);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.NormalBackground = System.Drawing.Color.Crimson;
            this.btnRetour.NormalOutline = System.Drawing.Color.Empty;
            this.btnRetour.OutlineThickness = 1.6F;
            this.btnRetour.PressedBackground = System.Drawing.Color.Crimson;
            this.btnRetour.PressedImageTint = System.Drawing.Color.White;
            this.btnRetour.PressedOutline = System.Drawing.Color.Empty;
            this.btnRetour.Rounding = new System.Windows.Forms.Padding(8);
            this.btnRetour.Size = new System.Drawing.Size(115, 39);
            this.btnRetour.TabIndex = 8;
            this.btnRetour.TextOffset = new System.Drawing.Point(0, 0);
            this.btnRetour.Click += new System.EventHandler(this.BtnRetour_Click);
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.Transparent;
            this.customPanel2.BorderColor = System.Drawing.Color.GreenYellow;
            this.customPanel2.BorderRadius = 40F;
            this.customPanel2.BorderSize = 3;
            this.customPanel2.Controls.Add(this.label4);
            this.customPanel2.Controls.Add(this.label3);
            this.customPanel2.Controls.Add(this.BudgetLabel);
            this.customPanel2.Controls.Add(this.pictureBox2);
            this.customPanel2.Controls.Add(this.pictureBox1);
            this.customPanel2.Controls.Add(this.StockLabel);
            this.customPanel2.FillColor = System.Drawing.Color.White;
            this.customPanel2.Location = new System.Drawing.Point(290, 367);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(256, 130);
            this.customPanel2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(13, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Stock actuelle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Budget investi ";
            // 
            // BudgetLabel
            // 
            this.BudgetLabel.AutoSize = true;
            this.BudgetLabel.BackColor = System.Drawing.Color.Transparent;
            this.BudgetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BudgetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BudgetLabel.Location = new System.Drawing.Point(61, 96);
            this.BudgetLabel.Name = "BudgetLabel";
            this.BudgetLabel.Size = new System.Drawing.Size(38, 20);
            this.BudgetLabel.TabIndex = 10;
            this.BudgetLabel.Text = "Ar 0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // StockLabel
            // 
            this.StockLabel.AutoSize = true;
            this.StockLabel.BackColor = System.Drawing.Color.Transparent;
            this.StockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StockLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.StockLabel.Location = new System.Drawing.Point(61, 34);
            this.StockLabel.Name = "StockLabel";
            this.StockLabel.Size = new System.Drawing.Size(38, 20);
            this.StockLabel.TabIndex = 5;
            this.StockLabel.Text = "Ar 0";
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.Transparent;
            this.customPanel1.BorderColor = System.Drawing.Color.Yellow;
            this.customPanel1.BorderRadius = 40F;
            this.customPanel1.BorderSize = 3;
            this.customPanel1.Controls.Add(this.labelNIn);
            this.customPanel1.Controls.Add(this.labelNOut);
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.FillColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(20, 367);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(256, 130);
            this.customPanel1.TabIndex = 3;
            // 
            // labelNIn
            // 
            this.labelNIn.AutoSize = true;
            this.labelNIn.BackColor = System.Drawing.Color.Transparent;
            this.labelNIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNIn.Location = new System.Drawing.Point(21, 93);
            this.labelNIn.Name = "labelNIn";
            this.labelNIn.Size = new System.Drawing.Size(119, 17);
            this.labelNIn.TabIndex = 6;
            this.labelNIn.Text = "Nombre d\'entrer :";
            // 
            // labelNOut
            // 
            this.labelNOut.AutoSize = true;
            this.labelNOut.BackColor = System.Drawing.Color.Transparent;
            this.labelNOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNOut.Location = new System.Drawing.Point(21, 59);
            this.labelNOut.Name = "labelNOut";
            this.labelNOut.Size = new System.Drawing.Size(125, 17);
            this.labelNOut.TabIndex = 5;
            this.labelNOut.Text = "Nombre de sortie :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(0, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Statistique";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReviewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelRef);
            this.Name = "ReviewUC";
            this.Size = new System.Drawing.Size(569, 509);
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelRef;
        private System.Windows.Forms.Label label2;
        private JUtility.CustomPanel customPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNIn;
        private System.Windows.Forms.Label labelNOut;
        private JUtility.CustomPanel customPanel2;
        private System.Windows.Forms.Label StockLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label BudgetLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CuoreUI.Controls.cuiButton btnRetour;
    }
}
