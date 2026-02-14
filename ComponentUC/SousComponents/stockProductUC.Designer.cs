using System.Windows.Forms;

namespace JH_Manager.ComponentUC.SousComponents
{
    partial class stockProductUC
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
                this.MouseEnter -= handleHoverEnter;
                this.MouseLeave -= handleHeave;
                this.Click -= OnClick;

                foreach (Control c in Controls)
                {
                    c.Click -= OnClick;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stockProductUC));
            this.LabelStok = new System.Windows.Forms.Label();
            this.nameProduit = new System.Windows.Forms.Label();
            this.pictureProduit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelStok
            // 
            this.LabelStok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LabelStok.ForeColor = System.Drawing.Color.Black;
            this.LabelStok.Location = new System.Drawing.Point(192, 28);
            this.LabelStok.Name = "LabelStok";
            this.LabelStok.Size = new System.Drawing.Size(73, 20);
            this.LabelStok.TabIndex = 13;
            this.LabelStok.Text = "03/20";
            this.LabelStok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelStok.MouseEnter += new System.EventHandler(this.handleHoverEnter);
            this.LabelStok.MouseLeave += new System.EventHandler(this.handleHeave);
            // 
            // nameProduit
            // 
            this.nameProduit.AutoSize = true;
            this.nameProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameProduit.ForeColor = System.Drawing.Color.Black;
            this.nameProduit.Location = new System.Drawing.Point(66, 7);
            this.nameProduit.Name = "nameProduit";
            this.nameProduit.Size = new System.Drawing.Size(105, 17);
            this.nameProduit.TabIndex = 12;
            this.nameProduit.Text = "Nom du produit";
            this.nameProduit.MouseEnter += new System.EventHandler(this.handleHoverEnter);
            this.nameProduit.MouseLeave += new System.EventHandler(this.handleHeave);
            // 
            // pictureProduit
            // 
            this.pictureProduit.Image = ((System.Drawing.Image)(resources.GetObject("pictureProduit.Image")));
            this.pictureProduit.Location = new System.Drawing.Point(6, 3);
            this.pictureProduit.Name = "pictureProduit";
            this.pictureProduit.Size = new System.Drawing.Size(54, 40);
            this.pictureProduit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureProduit.TabIndex = 14;
            this.pictureProduit.TabStop = false;
            this.pictureProduit.MouseEnter += new System.EventHandler(this.handleHoverEnter);
            this.pictureProduit.MouseLeave += new System.EventHandler(this.handleHeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(163, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(69, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPrice.ForeColor = System.Drawing.Color.Black;
            this.labelPrice.Location = new System.Drawing.Point(97, 28);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(60, 20);
            this.labelPrice.TabIndex = 17;
            this.labelPrice.Text = "1.0k Ar";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stockProductUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureProduit);
            this.Controls.Add(this.LabelStok);
            this.Controls.Add(this.nameProduit);
            this.Name = "stockProductUC";
            this.Size = new System.Drawing.Size(273, 50);
            this.MouseEnter += new System.EventHandler(this.handleHoverEnter);
            this.MouseLeave += new System.EventHandler(this.handleHeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label LabelStok;
        public System.Windows.Forms.Label nameProduit;
        public System.Windows.Forms.PictureBox pictureProduit;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        public Label labelPrice;
    }
}
