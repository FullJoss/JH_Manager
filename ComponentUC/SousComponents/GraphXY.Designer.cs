namespace JH_Manager.ComponentUC.SousComponents
{
    partial class GraphXY
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
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelX
            // 
            this.labelX.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelX.Location = new System.Drawing.Point(9, 98);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(63, 18);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "X";
            this.labelX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelY
            // 
            this.labelY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelY.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelY.Location = new System.Drawing.Point(559, 349);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(79, 18);
            this.labelY.TabIndex = 1;
            this.labelY.Text = "Y";
            this.labelY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelName.Location = new System.Drawing.Point(13, 367);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(625, 23);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Nom du graphique";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelX2
            // 
            this.labelX2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelX2.Location = new System.Drawing.Point(9, 64);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(63, 18);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "X2";
            this.labelX2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GraphXY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Name = "GraphXY";
            this.Size = new System.Drawing.Size(652, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelX2;
    }
}
