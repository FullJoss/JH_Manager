namespace JH_Manager.ComponentUC
{
    partial class ManagerUserUC
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
            this.chgMdp = new CuoreUI.Controls.cuiButton();
            this.panelContainerTime = new JH_Manager.JUtility.CustomPanel();
            this.modN = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BarProg = new CuoreUI.Controls.cuiCircleProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.timeBegin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customPanel1 = new JH_Manager.JUtility.CustomPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.panelChange = new JH_Manager.JUtility.CustomPanel();
            this.btnAnnul = new CuoreUI.Controls.cuiButton();
            this.btnLetsChange = new CuoreUI.Controls.cuiButton();
            this.inputMdp = new JH_Manager.JUtility.CustomTextBox();
            this.inputName = new JH_Manager.JUtility.CustomTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panelContainerTime.SuspendLayout();
            this.customPanel1.SuspendLayout();
            this.panelChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // chgMdp
            // 
            this.chgMdp.CheckButton = false;
            this.chgMdp.Checked = false;
            this.chgMdp.CheckedBackground = System.Drawing.Color.Coral;
            this.chgMdp.CheckedImageTint = System.Drawing.Color.GreenYellow;
            this.chgMdp.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.chgMdp.Content = "Changer de mot de passe";
            this.chgMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chgMdp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.chgMdp.HoverBackground = System.Drawing.Color.Chartreuse;
            this.chgMdp.HoveredImageTint = System.Drawing.Color.White;
            this.chgMdp.HoverOutline = System.Drawing.Color.Empty;
            this.chgMdp.Image = null;
            this.chgMdp.ImageAutoCenter = true;
            this.chgMdp.ImageExpand = new System.Drawing.Point(0, 0);
            this.chgMdp.ImageOffset = new System.Drawing.Point(0, 0);
            this.chgMdp.ImageTint = System.Drawing.Color.White;
            this.chgMdp.Location = new System.Drawing.Point(321, 169);
            this.chgMdp.Name = "chgMdp";
            this.chgMdp.NormalBackground = System.Drawing.Color.GreenYellow;
            this.chgMdp.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.chgMdp.OutlineThickness = 1.5F;
            this.chgMdp.PressedBackground = System.Drawing.Color.Coral;
            this.chgMdp.PressedImageTint = System.Drawing.Color.White;
            this.chgMdp.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.chgMdp.Rounding = new System.Windows.Forms.Padding(8);
            this.chgMdp.Size = new System.Drawing.Size(203, 44);
            this.chgMdp.TabIndex = 3;
            this.chgMdp.TextOffset = new System.Drawing.Point(0, 0);
            this.chgMdp.Click += new System.EventHandler(this.chgMdp_Click);
            // 
            // panelContainerTime
            // 
            this.panelContainerTime.BackColor = System.Drawing.Color.Transparent;
            this.panelContainerTime.BorderColor = System.Drawing.Color.GreenYellow;
            this.panelContainerTime.BorderRadius = 20F;
            this.panelContainerTime.BorderSize = 3;
            this.panelContainerTime.Controls.Add(this.modN);
            this.panelContainerTime.Controls.Add(this.label8);
            this.panelContainerTime.Controls.Add(this.BarProg);
            this.panelContainerTime.Controls.Add(this.label7);
            this.panelContainerTime.Controls.Add(this.time);
            this.panelContainerTime.Controls.Add(this.timeBegin);
            this.panelContainerTime.Controls.Add(this.label1);
            this.panelContainerTime.Controls.Add(this.label3);
            this.panelContainerTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelContainerTime.Location = new System.Drawing.Point(35, 262);
            this.panelContainerTime.Name = "panelContainerTime";
            this.panelContainerTime.Size = new System.Drawing.Size(489, 220);
            this.panelContainerTime.TabIndex = 3;
            // 
            // modN
            // 
            this.modN.BackColor = System.Drawing.Color.Transparent;
            this.modN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.modN.ForeColor = System.Drawing.Color.White;
            this.modN.Location = new System.Drawing.Point(49, 171);
            this.modN.Name = "modN";
            this.modN.Size = new System.Drawing.Size(191, 35);
            this.modN.TabIndex = 8;
            this.modN.Text = "1";
            this.modN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(354, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Evaluation";
            // 
            // BarProg
            // 
            this.BarProg.BackColor = System.Drawing.Color.Transparent;
            this.BarProg.BorderWidth = 12;
            this.BarProg.Location = new System.Drawing.Point(329, 70);
            this.BarProg.MaximumValue = 100;
            this.BarProg.MinimumSize = new System.Drawing.Size(24, 24);
            this.BarProg.MinimumValue = 0;
            this.BarProg.Name = "BarProg";
            this.BarProg.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BarProg.ProgressColor = System.Drawing.Color.GreenYellow;
            this.BarProg.ProgressValue = 50;
            this.BarProg.RoundedEnds = true;
            this.BarProg.Size = new System.Drawing.Size(123, 123);
            this.BarProg.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.GreenYellow;
            this.label7.Location = new System.Drawing.Point(63, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Totale de modification";
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(39, 58);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(188, 35);
            this.time.TabIndex = 4;
            this.time.Text = "1";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeBegin
            // 
            this.timeBegin.BackColor = System.Drawing.Color.Transparent;
            this.timeBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.timeBegin.ForeColor = System.Drawing.Color.White;
            this.timeBegin.Location = new System.Drawing.Point(184, 105);
            this.timeBegin.Name = "timeBegin";
            this.timeBegin.Size = new System.Drawing.Size(72, 17);
            this.timeBegin.TabIndex = 3;
            this.timeBegin.Text = "0";
            this.timeBegin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Debut de connexion :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.GreenYellow;
            this.label3.Location = new System.Drawing.Point(35, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Temps de travail";
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.Transparent;
            this.customPanel1.BorderColor = System.Drawing.Color.GreenYellow;
            this.customPanel1.BorderRadius = 20F;
            this.customPanel1.BorderSize = 3;
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.Controls.Add(this.name);
            this.customPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.customPanel1.Location = new System.Drawing.Point(35, 41);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(489, 122);
            this.customPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(43, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Utilisateurs actuelle";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(46, 74);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(50, 20);
            this.name.TabIndex = 0;
            this.name.Text = "Nom :";
            // 
            // panelChange
            // 
            this.panelChange.BackColor = System.Drawing.Color.Transparent;
            this.panelChange.BorderColor = System.Drawing.Color.GreenYellow;
            this.panelChange.BorderRadius = 20F;
            this.panelChange.BorderSize = 3;
            this.panelChange.Controls.Add(this.btnAnnul);
            this.panelChange.Controls.Add(this.btnLetsChange);
            this.panelChange.Controls.Add(this.inputMdp);
            this.panelChange.Controls.Add(this.inputName);
            this.panelChange.Controls.Add(this.label4);
            this.panelChange.Controls.Add(this.label12);
            this.panelChange.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelChange.Location = new System.Drawing.Point(35, 262);
            this.panelChange.Name = "panelChange";
            this.panelChange.Size = new System.Drawing.Size(489, 220);
            this.panelChange.TabIndex = 9;
            this.panelChange.Visible = false;
            // 
            // btnAnnul
            // 
            this.btnAnnul.CheckButton = false;
            this.btnAnnul.Checked = false;
            this.btnAnnul.CheckedBackground = System.Drawing.Color.White;
            this.btnAnnul.CheckedImageTint = System.Drawing.Color.White;
            this.btnAnnul.CheckedOutline = System.Drawing.Color.Crimson;
            this.btnAnnul.Content = "Annuler";
            this.btnAnnul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAnnul.ForeColor = System.Drawing.Color.Crimson;
            this.btnAnnul.HoverBackground = System.Drawing.Color.WhiteSmoke;
            this.btnAnnul.HoveredImageTint = System.Drawing.Color.White;
            this.btnAnnul.HoverOutline = System.Drawing.Color.Crimson;
            this.btnAnnul.Image = null;
            this.btnAnnul.ImageAutoCenter = true;
            this.btnAnnul.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnAnnul.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAnnul.ImageTint = System.Drawing.Color.White;
            this.btnAnnul.Location = new System.Drawing.Point(344, 106);
            this.btnAnnul.Name = "btnAnnul";
            this.btnAnnul.NormalBackground = System.Drawing.Color.White;
            this.btnAnnul.NormalOutline = System.Drawing.Color.Crimson;
            this.btnAnnul.OutlineThickness = 1.5F;
            this.btnAnnul.PressedBackground = System.Drawing.Color.White;
            this.btnAnnul.PressedImageTint = System.Drawing.Color.White;
            this.btnAnnul.PressedOutline = System.Drawing.Color.Crimson;
            this.btnAnnul.Rounding = new System.Windows.Forms.Padding(8);
            this.btnAnnul.Size = new System.Drawing.Size(128, 45);
            this.btnAnnul.TabIndex = 10;
            this.btnAnnul.TextOffset = new System.Drawing.Point(0, 0);
            this.btnAnnul.Click += new System.EventHandler(this.btnAnnul_Click);
            // 
            // btnLetsChange
            // 
            this.btnLetsChange.CheckButton = false;
            this.btnLetsChange.Checked = false;
            this.btnLetsChange.CheckedBackground = System.Drawing.Color.Coral;
            this.btnLetsChange.CheckedImageTint = System.Drawing.Color.GreenYellow;
            this.btnLetsChange.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnLetsChange.Content = "Changer";
            this.btnLetsChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnLetsChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnLetsChange.HoverBackground = System.Drawing.Color.Chartreuse;
            this.btnLetsChange.HoveredImageTint = System.Drawing.Color.White;
            this.btnLetsChange.HoverOutline = System.Drawing.Color.Empty;
            this.btnLetsChange.Image = null;
            this.btnLetsChange.ImageAutoCenter = true;
            this.btnLetsChange.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnLetsChange.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnLetsChange.ImageTint = System.Drawing.Color.White;
            this.btnLetsChange.Location = new System.Drawing.Point(344, 157);
            this.btnLetsChange.Name = "btnLetsChange";
            this.btnLetsChange.NormalBackground = System.Drawing.Color.GreenYellow;
            this.btnLetsChange.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnLetsChange.OutlineThickness = 1.5F;
            this.btnLetsChange.PressedBackground = System.Drawing.Color.Coral;
            this.btnLetsChange.PressedImageTint = System.Drawing.Color.White;
            this.btnLetsChange.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnLetsChange.Rounding = new System.Windows.Forms.Padding(8);
            this.btnLetsChange.Size = new System.Drawing.Size(128, 39);
            this.btnLetsChange.TabIndex = 10;
            this.btnLetsChange.TextOffset = new System.Drawing.Point(0, 0);
            this.btnLetsChange.Click += new System.EventHandler(this.btnLetsChange_Click);
            // 
            // inputMdp
            // 
            this.inputMdp.BackColor = System.Drawing.Color.Transparent;
            this.inputMdp.BorderColor = System.Drawing.Color.Black;
            this.inputMdp.Content = "";
            this.inputMdp.FillColor = System.Drawing.Color.White;
            this.inputMdp.IsRounded = true;
            this.inputMdp.Location = new System.Drawing.Point(36, 157);
            this.inputMdp.MarginT = 10;
            this.inputMdp.Name = "inputMdp";
            this.inputMdp.Padding = new System.Windows.Forms.Padding(10);
            this.inputMdp.Placeholder = "Admin";
            this.inputMdp.Size = new System.Drawing.Size(243, 39);
            this.inputMdp.TabIndex = 4;
            // 
            // inputName
            // 
            this.inputName.BackColor = System.Drawing.Color.Transparent;
            this.inputName.BorderColor = System.Drawing.Color.Black;
            this.inputName.Content = "";
            this.inputName.FillColor = System.Drawing.Color.White;
            this.inputName.IsRounded = true;
            this.inputName.Location = new System.Drawing.Point(36, 57);
            this.inputName.MarginT = 10;
            this.inputName.Name = "inputName";
            this.inputName.Padding = new System.Windows.Forms.Padding(10);
            this.inputName.Placeholder = "Admin";
            this.inputName.Size = new System.Drawing.Size(243, 39);
            this.inputName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.GreenYellow;
            this.label4.Location = new System.Drawing.Point(32, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nom d\'utilisateurs";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.ForeColor = System.Drawing.Color.GreenYellow;
            this.label12.Location = new System.Drawing.Point(32, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Nouvelle mot de passe";
            // 
            // ManagerUserUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelChange);
            this.Controls.Add(this.panelContainerTime);
            this.Controls.Add(this.chgMdp);
            this.Controls.Add(this.customPanel1);
            this.Name = "ManagerUserUC";
            this.Size = new System.Drawing.Size(569, 509);
            this.panelContainerTime.ResumeLayout(false);
            this.panelContainerTime.PerformLayout();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.panelChange.ResumeLayout(false);
            this.panelChange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label name;
        private JUtility.CustomPanel customPanel1;
        private CuoreUI.Controls.cuiButton chgMdp;
        private JUtility.CustomPanel panelContainerTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timeBegin;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label7;
        private CuoreUI.Controls.cuiCircleProgressBar BarProg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label modN;
        private JUtility.CustomPanel panelChange;
        private JUtility.CustomTextBox inputMdp;
        private JUtility.CustomTextBox inputName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private CuoreUI.Controls.cuiButton btnLetsChange;
        private CuoreUI.Controls.cuiButton btnAnnul;
    }
}
