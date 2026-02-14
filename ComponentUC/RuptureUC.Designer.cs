namespace JH_Manager.ComponentUC
{
    partial class RuptureUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RuptureUC));
            this.Remake = new CuoreUI.Controls.cuiButton();
            this.label2 = new System.Windows.Forms.Label();
            this.modBtn = new CuoreUI.Controls.cuiButton();
            this.btnSupp = new CuoreUI.Controls.cuiButton();
            this.roundedPanel2 = new JH_Manager.JUtility.RoundedPanel();
            this.panelContainProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.roundedPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Remake
            // 
            this.Remake.CheckButton = false;
            this.Remake.Checked = false;
            this.Remake.CheckedBackground = System.Drawing.Color.White;
            this.Remake.CheckedImageTint = System.Drawing.Color.White;
            this.Remake.CheckedOutline = System.Drawing.Color.Coral;
            this.Remake.Content = "Reapprovisioner";
            this.Remake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Remake.ForeColor = System.Drawing.Color.Black;
            this.Remake.HoverBackground = System.Drawing.Color.Azure;
            this.Remake.HoveredImageTint = System.Drawing.Color.White;
            this.Remake.HoverOutline = System.Drawing.Color.Empty;
            this.Remake.Image = ((System.Drawing.Image)(resources.GetObject("Remake.Image")));
            this.Remake.ImageAutoCenter = true;
            this.Remake.ImageExpand = new System.Drawing.Point(0, 0);
            this.Remake.ImageOffset = new System.Drawing.Point(-5, 0);
            this.Remake.ImageTint = System.Drawing.Color.White;
            this.Remake.Location = new System.Drawing.Point(28, 130);
            this.Remake.Name = "Remake";
            this.Remake.NormalBackground = System.Drawing.Color.White;
            this.Remake.NormalOutline = System.Drawing.Color.Empty;
            this.Remake.OutlineThickness = 1.6F;
            this.Remake.PressedBackground = System.Drawing.Color.White;
            this.Remake.PressedImageTint = System.Drawing.Color.White;
            this.Remake.PressedOutline = System.Drawing.Color.Empty;
            this.Remake.Rounding = new System.Windows.Forms.Padding(8);
            this.Remake.Size = new System.Drawing.Size(166, 45);
            this.Remake.TabIndex = 4;
            this.Remake.TextOffset = new System.Drawing.Point(5, 0);
            this.Remake.Click += new System.EventHandler(this.Remake_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label2.Location = new System.Drawing.Point(25, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prise en main";
            // 
            // modBtn
            // 
            this.modBtn.CheckButton = false;
            this.modBtn.Checked = false;
            this.modBtn.CheckedBackground = System.Drawing.Color.RoyalBlue;
            this.modBtn.CheckedImageTint = System.Drawing.Color.White;
            this.modBtn.CheckedOutline = System.Drawing.Color.Coral;
            this.modBtn.Content = "Modifier";
            this.modBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.modBtn.ForeColor = System.Drawing.Color.White;
            this.modBtn.HoverBackground = System.Drawing.Color.CornflowerBlue;
            this.modBtn.HoveredImageTint = System.Drawing.Color.White;
            this.modBtn.HoverOutline = System.Drawing.Color.Empty;
            this.modBtn.Image = ((System.Drawing.Image)(resources.GetObject("modBtn.Image")));
            this.modBtn.ImageAutoCenter = true;
            this.modBtn.ImageExpand = new System.Drawing.Point(0, 0);
            this.modBtn.ImageOffset = new System.Drawing.Point(-30, 0);
            this.modBtn.ImageTint = System.Drawing.Color.White;
            this.modBtn.Location = new System.Drawing.Point(28, 186);
            this.modBtn.Name = "modBtn";
            this.modBtn.NormalBackground = System.Drawing.Color.RoyalBlue;
            this.modBtn.NormalOutline = System.Drawing.Color.Empty;
            this.modBtn.OutlineThickness = 1.6F;
            this.modBtn.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.modBtn.PressedImageTint = System.Drawing.Color.White;
            this.modBtn.PressedOutline = System.Drawing.Color.Empty;
            this.modBtn.Rounding = new System.Windows.Forms.Padding(8);
            this.modBtn.Size = new System.Drawing.Size(166, 45);
            this.modBtn.TabIndex = 6;
            this.modBtn.TextOffset = new System.Drawing.Point(-20, 0);
            this.modBtn.Click += new System.EventHandler(this.ModBtn_Click);
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
            this.btnSupp.ImageOffset = new System.Drawing.Point(-25, 0);
            this.btnSupp.ImageTint = System.Drawing.Color.White;
            this.btnSupp.Location = new System.Drawing.Point(28, 240);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.NormalBackground = System.Drawing.Color.Crimson;
            this.btnSupp.NormalOutline = System.Drawing.Color.Empty;
            this.btnSupp.OutlineThickness = 1.6F;
            this.btnSupp.PressedBackground = System.Drawing.Color.Crimson;
            this.btnSupp.PressedImageTint = System.Drawing.Color.White;
            this.btnSupp.PressedOutline = System.Drawing.Color.Empty;
            this.btnSupp.Rounding = new System.Windows.Forms.Padding(8);
            this.btnSupp.Size = new System.Drawing.Size(166, 45);
            this.btnSupp.TabIndex = 7;
            this.btnSupp.TextOffset = new System.Drawing.Point(-15, 0);
            this.btnSupp.Click += new System.EventHandler(this.BtnSupp_Click);
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BorderRadius = 3;
            this.roundedPanel2.Controls.Add(this.panelContainProduct);
            this.roundedPanel2.FillColor = System.Drawing.Color.White;
            this.roundedPanel2.Location = new System.Drawing.Point(222, 39);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.RadiusBottomLeft = 0;
            this.roundedPanel2.RadiusBottomRight = 0;
            this.roundedPanel2.RadiusTopLeft = 50;
            this.roundedPanel2.RadiusTopRight = 50;
            this.roundedPanel2.Size = new System.Drawing.Size(322, 470);
            this.roundedPanel2.TabIndex = 3;
            // 
            // panelContainProduct
            // 
            this.panelContainProduct.AutoScroll = true;
            this.panelContainProduct.BackColor = System.Drawing.Color.White;
            this.panelContainProduct.Location = new System.Drawing.Point(12, 18);
            this.panelContainProduct.Name = "panelContainProduct";
            this.panelContainProduct.Size = new System.Drawing.Size(299, 452);
            this.panelContainProduct.TabIndex = 1;
            // 
            // RuptureUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.modBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Remake);
            this.Controls.Add(this.roundedPanel2);
            this.Name = "RuptureUC";
            this.Size = new System.Drawing.Size(569, 509);
            this.roundedPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JUtility.RoundedPanel roundedPanel2;
        private System.Windows.Forms.FlowLayoutPanel panelContainProduct;
        private CuoreUI.Controls.cuiButton Remake;
        private System.Windows.Forms.Label label2;
        private CuoreUI.Controls.cuiButton modBtn;
        private CuoreUI.Controls.cuiButton btnSupp;
    }
}
