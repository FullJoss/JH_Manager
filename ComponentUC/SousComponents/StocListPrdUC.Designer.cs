using System.Windows.Forms;

namespace JH_Manager.ComponentUC.SousComponents
{
    partial class StocListPrdUC
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
                btnDelete.Click -= btnDelete_Click;
                foreach (Control c in Controls)
                {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StocListPrdUC));
            this.btnDelete = new CuoreUI.Controls.cuiButton();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.CheckButton = false;
            this.btnDelete.Checked = false;
            this.btnDelete.CheckedBackground = System.Drawing.Color.Coral;
            this.btnDelete.CheckedImageTint = System.Drawing.Color.White;
            this.btnDelete.CheckedOutline = System.Drawing.Color.Coral;
            this.btnDelete.Content = "";
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(80)))));
            this.btnDelete.HoveredImageTint = System.Drawing.Color.White;
            this.btnDelete.HoverOutline = System.Drawing.Color.Empty;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAutoCenter = true;
            this.btnDelete.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnDelete.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnDelete.ImageTint = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(464, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.NormalOutline = System.Drawing.Color.Empty;
            this.btnDelete.OutlineThickness = 1.5F;
            this.btnDelete.PressedBackground = System.Drawing.Color.Coral;
            this.btnDelete.PressedImageTint = System.Drawing.Color.White;
            this.btnDelete.PressedOutline = System.Drawing.Color.Empty;
            this.btnDelete.Rounding = new System.Windows.Forms.Padding(8);
            this.btnDelete.Size = new System.Drawing.Size(38, 35);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.TextOffset = new System.Drawing.Point(0, 0);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPrice.Location = new System.Drawing.Point(344, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(107, 48);
            this.labelPrice.TabIndex = 16;
            this.labelPrice.Text = "10000 Ar";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStock
            // 
            this.labelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelStock.Location = new System.Drawing.Point(251, 0);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(72, 48);
            this.labelStock.TabIndex = 15;
            this.labelStock.Text = "100";
            this.labelStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::JH_Manager.Properties.Resources.coca;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(48, 48);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelName.Location = new System.Drawing.Point(75, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(157, 48);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Coca cola";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StocListPrdUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelName);
            this.Name = "StocListPrdUC";
            this.Size = new System.Drawing.Size(515, 48);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiButton btnDelete;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelName;
    }
}
