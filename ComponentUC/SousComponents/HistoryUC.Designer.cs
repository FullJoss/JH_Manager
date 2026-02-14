using System.Windows.Forms;

namespace JH_Manager.ComponentUC.SousComponents
{
    partial class HistoryUC
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
                MouseHover -= MouseHoverV;
                tooltip.Dispose();
                foreach (Control c in Controls)
                {
                    c.MouseHover -= MouseHoverV;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryUC));
            this.roundedPanel5 = new JH_Manager.JUtility.RoundedPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.weight = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roundedPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPanel5
            // 
            this.roundedPanel5.BorderRadius = 25;
            this.roundedPanel5.Controls.Add(this.pictureBox3);
            this.roundedPanel5.Controls.Add(this.pictureBox2);
            this.roundedPanel5.Controls.Add(this.weight);
            this.roundedPanel5.Controls.Add(this.dateTime);
            this.roundedPanel5.Controls.Add(this.type);
            this.roundedPanel5.Controls.Add(this.pictureBox1);
            this.roundedPanel5.FillColor = System.Drawing.Color.White;
            this.roundedPanel5.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel5.Name = "roundedPanel5";
            this.roundedPanel5.RadiusBottomLeft = 0;
            this.roundedPanel5.RadiusBottomRight = 0;
            this.roundedPanel5.RadiusTopLeft = 0;
            this.roundedPanel5.RadiusTopRight = 0;
            this.roundedPanel5.Size = new System.Drawing.Size(514, 47);
            this.roundedPanel5.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(163, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(336, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // weight
            // 
            this.weight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.weight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.weight.Location = new System.Drawing.Point(367, 8);
            this.weight.Name = "weight";
            this.weight.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.weight.Size = new System.Drawing.Size(130, 32);
            this.weight.TabIndex = 4;
            this.weight.Text = "50";
            this.weight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTime
            // 
            this.dateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateTime.Location = new System.Drawing.Point(194, 8);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(136, 32);
            this.dateTime.TabIndex = 3;
            this.dateTime.Text = "05/10/2024 à 10:30";
            this.dateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.type.Location = new System.Drawing.Point(45, 14);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(112, 21);
            this.type.TabIndex = 1;
            this.type.Text = "Type : Entrer";
            this.type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HistoryUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.roundedPanel5);
            this.Name = "HistoryUC";
            this.Size = new System.Drawing.Size(514, 47);
            this.roundedPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private JUtility.RoundedPanel roundedPanel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label dateTime;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
