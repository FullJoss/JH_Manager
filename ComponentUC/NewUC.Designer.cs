namespace JH_Manager.ComponentUC
{
    partial class NewUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUC));
            this.roundedPanel3 = new JH_Manager.JUtility.RoundedPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.Categor = new JH_Manager.JUtility.CustomComboBox();
            this.pRef = new JH_Manager.JUtility.CustomTextBox();
            this.pPU = new JH_Manager.JUtility.CustomTextBox();
            this.pMin = new JH_Manager.JUtility.CustomTextBox();
            this.pMax = new JH_Manager.JUtility.CustomTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.cuiButton4 = new CuoreUI.Controls.cuiButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cuiButton3 = new CuoreUI.Controls.cuiButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.roundedPanel2 = new JH_Manager.JUtility.RoundedPanel();
            this.INtol = new JH_Manager.JUtility.CustomTextBox();
            this.pStock = new JH_Manager.JUtility.CustomTextBox();
            this.btnAdapter = new CuoreUI.Controls.cuiButton();
            this.pID = new JH_Manager.JUtility.CustomTextBox();
            this.pNom = new JH_Manager.JUtility.CustomTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cuiButton2 = new CuoreUI.Controls.cuiButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pPrd = new System.Windows.Forms.PictureBox();
            this.roundedPanel1 = new JH_Manager.JUtility.RoundedPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPrd)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BorderRadius = 3;
            this.roundedPanel3.Controls.Add(this.label11);
            this.roundedPanel3.Controls.Add(this.Categor);
            this.roundedPanel3.Controls.Add(this.pRef);
            this.roundedPanel3.Controls.Add(this.pPU);
            this.roundedPanel3.Controls.Add(this.pMin);
            this.roundedPanel3.Controls.Add(this.pMax);
            this.roundedPanel3.Controls.Add(this.label10);
            this.roundedPanel3.Controls.Add(this.label9);
            this.roundedPanel3.Controls.Add(this.label7);
            this.roundedPanel3.Controls.Add(this.pictureBox4);
            this.roundedPanel3.Controls.Add(this.cuiButton4);
            this.roundedPanel3.Controls.Add(this.label6);
            this.roundedPanel3.Controls.Add(this.cuiButton3);
            this.roundedPanel3.Controls.Add(this.label8);
            this.roundedPanel3.Controls.Add(this.label5);
            this.roundedPanel3.Controls.Add(this.pictureBox3);
            this.roundedPanel3.FillColor = System.Drawing.Color.White;
            this.roundedPanel3.Location = new System.Drawing.Point(297, 63);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.RadiusBottomLeft = 0;
            this.roundedPanel3.RadiusBottomRight = 150;
            this.roundedPanel3.RadiusTopLeft = 30;
            this.roundedPanel3.RadiusTopRight = 0;
            this.roundedPanel3.Size = new System.Drawing.Size(264, 446);
            this.roundedPanel3.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(24, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Categorie du produit";
            // 
            // Categor
            // 
            this.Categor.BackColor = System.Drawing.Color.White;
            this.Categor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Categor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Categor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Categor.FormattingEnabled = true;
            this.Categor.ItemHeight = 30;
            this.Categor.Location = new System.Drawing.Point(22, 352);
            this.Categor.Name = "Categor";
            this.Categor.Size = new System.Drawing.Size(214, 36);
            this.Categor.TabIndex = 25;
            // 
            // pRef
            // 
            this.pRef.BackColor = System.Drawing.Color.Transparent;
            this.pRef.BorderColor = System.Drawing.Color.Black;
            this.pRef.Content = "";
            this.pRef.FillColor = System.Drawing.Color.White;
            this.pRef.IsRounded = true;
            this.pRef.Location = new System.Drawing.Point(128, 107);
            this.pRef.MarginT = 10;
            this.pRef.Name = "pRef";
            this.pRef.Padding = new System.Windows.Forms.Padding(10);
            this.pRef.Placeholder = "Kg, metre, unité";
            this.pRef.Size = new System.Drawing.Size(108, 35);
            this.pRef.TabIndex = 24;
            // 
            // pPU
            // 
            this.pPU.BackColor = System.Drawing.Color.Transparent;
            this.pPU.BorderColor = System.Drawing.Color.Black;
            this.pPU.Content = "";
            this.pPU.FillColor = System.Drawing.Color.White;
            this.pPU.IsRounded = false;
            this.pPU.Location = new System.Drawing.Point(22, 215);
            this.pPU.MarginT = 10;
            this.pPU.Name = "pPU";
            this.pPU.Padding = new System.Windows.Forms.Padding(10);
            this.pPU.Placeholder = "Prix unitaire";
            this.pPU.Size = new System.Drawing.Size(209, 35);
            this.pPU.TabIndex = 23;
            // 
            // pMin
            // 
            this.pMin.BackColor = System.Drawing.Color.Transparent;
            this.pMin.BorderColor = System.Drawing.Color.Black;
            this.pMin.Content = "";
            this.pMin.FillColor = System.Drawing.Color.White;
            this.pMin.IsRounded = false;
            this.pMin.Location = new System.Drawing.Point(27, 62);
            this.pMin.MarginT = 10;
            this.pMin.Name = "pMin";
            this.pMin.Padding = new System.Windows.Forms.Padding(10);
            this.pMin.Placeholder = "Minimum";
            this.pMin.Size = new System.Drawing.Size(209, 33);
            this.pMin.TabIndex = 22;
            // 
            // pMax
            // 
            this.pMax.BackColor = System.Drawing.Color.Transparent;
            this.pMax.BorderColor = System.Drawing.Color.Black;
            this.pMax.Content = "";
            this.pMax.FillColor = System.Drawing.Color.White;
            this.pMax.IsRounded = false;
            this.pMax.Location = new System.Drawing.Point(22, 286);
            this.pMax.MarginT = 10;
            this.pMax.Name = "pMax";
            this.pMax.Padding = new System.Windows.Forms.Padding(10);
            this.pMax.Placeholder = "Prix initiale";
            this.pMax.Size = new System.Drawing.Size(209, 33);
            this.pMax.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(24, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 34);
            this.label10.TabIndex = 20;
            this.label10.Text = "La reference de l\'unité de mesure";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(88, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 36);
            this.label9.TabIndex = 19;
            this.label9.Text = "Entrer le prix de vente de ce produit par unité";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(88, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Parametre du prix";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(22, 156);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(58, 49);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // cuiButton4
            // 
            this.cuiButton4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cuiButton4.CheckButton = false;
            this.cuiButton4.Checked = false;
            this.cuiButton4.CheckedBackground = System.Drawing.Color.Coral;
            this.cuiButton4.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton4.CheckedOutline = System.Drawing.Color.Coral;
            this.cuiButton4.Content = "Annuler";
            this.cuiButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton4.ForeColor = System.Drawing.Color.White;
            this.cuiButton4.HoverBackground = System.Drawing.Color.Red;
            this.cuiButton4.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton4.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton4.Image = null;
            this.cuiButton4.ImageAutoCenter = true;
            this.cuiButton4.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton4.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton4.ImageTint = System.Drawing.Color.White;
            this.cuiButton4.Location = new System.Drawing.Point(54, 403);
            this.cuiButton4.Name = "cuiButton4";
            this.cuiButton4.NormalBackground = System.Drawing.Color.Crimson;
            this.cuiButton4.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton4.OutlineThickness = 1.6F;
            this.cuiButton4.PressedBackground = System.Drawing.Color.Crimson;
            this.cuiButton4.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton4.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton4.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton4.Size = new System.Drawing.Size(88, 35);
            this.cuiButton4.TabIndex = 15;
            this.cuiButton4.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton4.Click += new System.EventHandler(this.cuiButton4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(24, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Entrer le coût de production ou le prix initiale";
            // 
            // cuiButton3
            // 
            this.cuiButton3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cuiButton3.CheckButton = false;
            this.cuiButton3.Checked = false;
            this.cuiButton3.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton3.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton3.CheckedOutline = System.Drawing.Color.Coral;
            this.cuiButton3.Content = "Ajouter";
            this.cuiButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton3.ForeColor = System.Drawing.Color.White;
            this.cuiButton3.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton3.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton3.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton3.Image = null;
            this.cuiButton3.ImageAutoCenter = true;
            this.cuiButton3.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton3.ImageTint = System.Drawing.Color.White;
            this.cuiButton3.Location = new System.Drawing.Point(148, 403);
            this.cuiButton3.Name = "cuiButton3";
            this.cuiButton3.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton3.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton3.OutlineThickness = 1.6F;
            this.cuiButton3.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton3.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton3.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton3.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton3.Size = new System.Drawing.Size(88, 35);
            this.cuiButton3.TabIndex = 14;
            this.cuiButton3.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton3.Click += new System.EventHandler(this.cuiButton3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(24, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "le min ermet d\'alerter une eventuelle rupture";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(59, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Option de stock";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(27, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BorderRadius = 30;
            this.roundedPanel2.Controls.Add(this.INtol);
            this.roundedPanel2.Controls.Add(this.pStock);
            this.roundedPanel2.Controls.Add(this.btnAdapter);
            this.roundedPanel2.Controls.Add(this.pID);
            this.roundedPanel2.Controls.Add(this.pNom);
            this.roundedPanel2.Controls.Add(this.label4);
            this.roundedPanel2.Controls.Add(this.label3);
            this.roundedPanel2.Controls.Add(this.cuiButton2);
            this.roundedPanel2.Controls.Add(this.label2);
            this.roundedPanel2.Controls.Add(this.pPrd);
            this.roundedPanel2.FillColor = System.Drawing.Color.White;
            this.roundedPanel2.Location = new System.Drawing.Point(33, 7);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.RadiusBottomLeft = 0;
            this.roundedPanel2.RadiusBottomRight = 0;
            this.roundedPanel2.RadiusTopLeft = 0;
            this.roundedPanel2.RadiusTopRight = 0;
            this.roundedPanel2.Size = new System.Drawing.Size(226, 495);
            this.roundedPanel2.TabIndex = 1;
            // 
            // INtol
            // 
            this.INtol.BackColor = System.Drawing.Color.Transparent;
            this.INtol.BorderColor = System.Drawing.Color.Black;
            this.INtol.Content = "";
            this.INtol.FillColor = System.Drawing.Color.White;
            this.INtol.IsRounded = true;
            this.INtol.Location = new System.Drawing.Point(132, 16);
            this.INtol.MarginT = 10;
            this.INtol.Name = "INtol";
            this.INtol.Padding = new System.Windows.Forms.Padding(10);
            this.INtol.Placeholder = "Tolerance";
            this.INtol.Size = new System.Drawing.Size(79, 35);
            this.INtol.TabIndex = 25;
            // 
            // pStock
            // 
            this.pStock.BackColor = System.Drawing.Color.Transparent;
            this.pStock.BorderColor = System.Drawing.Color.Black;
            this.pStock.Content = "";
            this.pStock.FillColor = System.Drawing.Color.White;
            this.pStock.IsRounded = false;
            this.pStock.Location = new System.Drawing.Point(13, 444);
            this.pStock.MarginT = 10;
            this.pStock.Name = "pStock";
            this.pStock.Padding = new System.Windows.Forms.Padding(10);
            this.pStock.Placeholder = "Stock initiale";
            this.pStock.Size = new System.Drawing.Size(196, 31);
            this.pStock.TabIndex = 21;
            // 
            // btnAdapter
            // 
            this.btnAdapter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdapter.CheckButton = false;
            this.btnAdapter.Checked = false;
            this.btnAdapter.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAdapter.CheckedImageTint = System.Drawing.Color.White;
            this.btnAdapter.CheckedOutline = System.Drawing.Color.Coral;
            this.btnAdapter.Content = "Adapter";
            this.btnAdapter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAdapter.ForeColor = System.Drawing.Color.White;
            this.btnAdapter.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAdapter.HoveredImageTint = System.Drawing.Color.White;
            this.btnAdapter.HoverOutline = System.Drawing.Color.Empty;
            this.btnAdapter.Image = null;
            this.btnAdapter.ImageAutoCenter = true;
            this.btnAdapter.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnAdapter.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAdapter.ImageTint = System.Drawing.Color.White;
            this.btnAdapter.Location = new System.Drawing.Point(11, 16);
            this.btnAdapter.Name = "btnAdapter";
            this.btnAdapter.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAdapter.NormalOutline = System.Drawing.Color.Empty;
            this.btnAdapter.OutlineThickness = 1.6F;
            this.btnAdapter.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAdapter.PressedImageTint = System.Drawing.Color.White;
            this.btnAdapter.PressedOutline = System.Drawing.Color.Empty;
            this.btnAdapter.Rounding = new System.Windows.Forms.Padding(8);
            this.btnAdapter.Size = new System.Drawing.Size(115, 35);
            this.btnAdapter.TabIndex = 25;
            this.btnAdapter.TextOffset = new System.Drawing.Point(0, 0);
            this.btnAdapter.Click += new System.EventHandler(this.btnAdapter_Click);
            // 
            // pID
            // 
            this.pID.BackColor = System.Drawing.Color.Transparent;
            this.pID.BorderColor = System.Drawing.Color.Black;
            this.pID.Content = "";
            this.pID.FillColor = System.Drawing.Color.White;
            this.pID.IsRounded = false;
            this.pID.Location = new System.Drawing.Point(15, 377);
            this.pID.MarginT = 10;
            this.pID.Name = "pID";
            this.pID.Padding = new System.Windows.Forms.Padding(10);
            this.pID.Placeholder = "ID produit";
            this.pID.Size = new System.Drawing.Size(196, 31);
            this.pID.TabIndex = 21;
            // 
            // pNom
            // 
            this.pNom.BackColor = System.Drawing.Color.Transparent;
            this.pNom.BorderColor = System.Drawing.Color.Black;
            this.pNom.Content = "";
            this.pNom.FillColor = System.Drawing.Color.White;
            this.pNom.IsRounded = false;
            this.pNom.Location = new System.Drawing.Point(15, 310);
            this.pNom.MarginT = 10;
            this.pNom.Name = "pNom";
            this.pNom.Padding = new System.Windows.Forms.Padding(10);
            this.pNom.Placeholder = "Nom produit";
            this.pNom.Size = new System.Drawing.Size(196, 31);
            this.pNom.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID";
            // 
            // cuiButton2
            // 
            this.cuiButton2.BackColor = System.Drawing.Color.White;
            this.cuiButton2.CheckButton = false;
            this.cuiButton2.Checked = false;
            this.cuiButton2.CheckedBackground = System.Drawing.Color.Coral;
            this.cuiButton2.CheckedImageTint = System.Drawing.Color.Silver;
            this.cuiButton2.CheckedOutline = System.Drawing.Color.Coral;
            this.cuiButton2.Content = "choisir une image";
            this.cuiButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton2.ForeColor = System.Drawing.Color.Black;
            this.cuiButton2.HoverBackground = System.Drawing.Color.Silver;
            this.cuiButton2.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton2.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton2.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton2.Image")));
            this.cuiButton2.ImageAutoCenter = true;
            this.cuiButton2.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton2.ImageOffset = new System.Drawing.Point(-5, 0);
            this.cuiButton2.ImageTint = System.Drawing.Color.White;
            this.cuiButton2.Location = new System.Drawing.Point(13, 245);
            this.cuiButton2.Name = "cuiButton2";
            this.cuiButton2.NormalBackground = System.Drawing.Color.Gainsboro;
            this.cuiButton2.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton2.OutlineThickness = 1.6F;
            this.cuiButton2.PressedBackground = System.Drawing.Color.Silver;
            this.cuiButton2.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton2.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton2.Size = new System.Drawing.Size(198, 34);
            this.cuiButton2.TabIndex = 3;
            this.cuiButton2.TextOffset = new System.Drawing.Point(5, 0);
            this.cuiButton2.Click += new System.EventHandler(this.cuiButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom";
            // 
            // pPrd
            // 
            this.pPrd.BackColor = System.Drawing.Color.White;
            this.pPrd.Image = global::JH_Manager.Properties.Resources.coca;
            this.pPrd.Location = new System.Drawing.Point(13, 61);
            this.pPrd.Name = "pPrd";
            this.pPrd.Size = new System.Drawing.Size(198, 176);
            this.pPrd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pPrd.TabIndex = 2;
            this.pPrd.TabStop = false;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BorderRadius = 3;
            this.roundedPanel1.Controls.Add(this.pictureBox1);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.FillColor = System.Drawing.Color.White;
            this.roundedPanel1.Location = new System.Drawing.Point(297, 14);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.RadiusBottomLeft = 0;
            this.roundedPanel1.RadiusBottomRight = 40;
            this.roundedPanel1.RadiusTopLeft = 40;
            this.roundedPanel1.RadiusTopRight = 0;
            this.roundedPanel1.Size = new System.Drawing.Size(264, 43);
            this.roundedPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(59, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrer un noveaux produit";
            // 
            // NewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.roundedPanel3);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.Name = "NewUC";
            this.Size = new System.Drawing.Size(561, 509);
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPrd)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private JUtility.RoundedPanel roundedPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private JUtility.RoundedPanel roundedPanel2;
        private System.Windows.Forms.PictureBox pPrd;
        private System.Windows.Forms.Label label2;
        private CuoreUI.Controls.cuiButton cuiButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private JUtility.RoundedPanel roundedPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private CuoreUI.Controls.cuiButton cuiButton4;
        private CuoreUI.Controls.cuiButton cuiButton3;
        private JUtility.CustomTextBox pNom;
        private JUtility.CustomTextBox pID;
        private JUtility.CustomTextBox pStock;
        private JUtility.CustomTextBox pMax;
        private JUtility.CustomTextBox pMin;
        private JUtility.CustomTextBox pPU;
        private JUtility.CustomTextBox pRef;
        private CuoreUI.Controls.cuiButton btnAdapter;
        private JUtility.CustomTextBox INtol;
        private JUtility.CustomComboBox Categor;
        private System.Windows.Forms.Label label11;
    }
}
