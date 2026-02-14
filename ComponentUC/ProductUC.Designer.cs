using System.Windows.Forms;

namespace JH_Manager.ComponentUC
{
    partial class ProductUC
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
                btnUp.Click -= btnUp_Click;
                btnDown.Click -= btnDown_Click;
                pweight.ContentChanged -= ContentChangedTxt;
                btnSave.Click -= btnSave_Click;
                BtnSwitch.CheckedChanged -= CheckedChanged;

                foreach (Control c in Controls)
                {
                    foreach (Control c2 in c.Controls)
                    {
                        foreach (Control c3 in c2.Controls)
                        {
                            c3.Dispose();
                        }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductUC));
            this.historyContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.roundedPanel3 = new JH_Manager.JUtility.RoundedPanel();
            this.roundedPanelType = new JH_Manager.JUtility.RoundedPanel();
            this.TextType = new System.Windows.Forms.Label();
            this.pFournisseur = new cuiTextBox();
            this.pDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roundedPanel2 = new JH_Manager.JUtility.RoundedPanel();
            this.pweight = new cuiTextBox();
            this.pNote = new cuiTextBox();
            this.pName = new System.Windows.Forms.Label();
            this.btnReset = new CuoreUI.Controls.cuiButton();
            this.btnDown = new CuoreUI.Controls.cuiButton();
            this.btnUp = new CuoreUI.Controls.cuiButton();
            this.btnSave = new CuoreUI.Controls.cuiButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pPU = new System.Windows.Forms.Label();
            this.pStock = new System.Windows.Forms.Label();
            this.pPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pBenef = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.roundedPanel1 = new JH_Manager.JUtility.RoundedPanel();
            this.BtnSwitch = new CuoreUI.Controls.cuiSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedPanel4 = new JH_Manager.JUtility.RoundedPanel();
            this.btnMoreInfo = new CuoreUI.Controls.cuiButton();
            this.btnBack = new CuoreUI.Controls.cuiButton();
            this.roundedPanel3.SuspendLayout();
            this.roundedPanelType.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // historyContainer
            // 
            this.historyContainer.AutoScroll = true;
            this.historyContainer.BackColor = System.Drawing.Color.Transparent;
            this.historyContainer.Location = new System.Drawing.Point(8, 378);
            this.historyContainer.Name = "historyContainer";
            this.historyContainer.Size = new System.Drawing.Size(543, 128);
            this.historyContainer.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.Location = new System.Drawing.Point(13, 6);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label9.Size = new System.Drawing.Size(128, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "Historique";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BorderRadius = 3;
            this.roundedPanel3.Controls.Add(this.roundedPanelType);
            this.roundedPanel3.Controls.Add(this.pFournisseur);
            this.roundedPanel3.Controls.Add(this.pDate);
            this.roundedPanel3.Controls.Add(this.label3);
            this.roundedPanel3.FillColor = System.Drawing.Color.White;
            this.roundedPanel3.Location = new System.Drawing.Point(75, 12);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.RadiusBottomLeft = 40;
            this.roundedPanel3.RadiusBottomRight = 40;
            this.roundedPanel3.RadiusTopLeft = 50;
            this.roundedPanel3.RadiusTopRight = 50;
            this.roundedPanel3.Size = new System.Drawing.Size(311, 88);
            this.roundedPanel3.TabIndex = 22;
            // 
            // roundedPanelType
            // 
            this.roundedPanelType.BorderRadius = 3;
            this.roundedPanelType.Controls.Add(this.TextType);
            this.roundedPanelType.FillColor = System.Drawing.Color.Crimson;
            this.roundedPanelType.Location = new System.Drawing.Point(228, 0);
            this.roundedPanelType.Name = "roundedPanelType";
            this.roundedPanelType.RadiusBottomLeft = 0;
            this.roundedPanelType.RadiusBottomRight = 50;
            this.roundedPanelType.RadiusTopLeft = 0;
            this.roundedPanelType.RadiusTopRight = 50;
            this.roundedPanelType.Size = new System.Drawing.Size(83, 42);
            this.roundedPanelType.TabIndex = 28;
            // 
            // TextType
            // 
            this.TextType.AutoSize = true;
            this.TextType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.TextType.ForeColor = System.Drawing.Color.White;
            this.TextType.Location = new System.Drawing.Point(25, 13);
            this.TextType.Name = "TextType";
            this.TextType.Size = new System.Drawing.Size(42, 16);
            this.TextType.TabIndex = 27;
            this.TextType.Text = "Sortie";
            // 
            // pFournisseur
            // 
            this.pFournisseur.BackColor = System.Drawing.Color.White;
            this.pFournisseur.Background = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pFournisseur.Border = System.Drawing.Color.DarkGray;
            this.pFournisseur.BorderRadius = new System.Windows.Forms.Padding(1);
            this.pFournisseur.BorderSize = 1.6F;
            this.pFournisseur.Content = "";
            this.pFournisseur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pFournisseur.DesignStyle = cuiTextBox.Styles.Partial;
            this.pFournisseur.FocusedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pFournisseur.FocusedBorder = System.Drawing.Color.RoyalBlue;
            this.pFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.pFournisseur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pFournisseur.Location = new System.Drawing.Point(20, 41);
            this.pFournisseur.Name = "pFournisseur";
            this.pFournisseur.PartialThickness = 1F;
            this.pFournisseur.Placeholder = "Fournisseur";
            this.pFournisseur.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.pFournisseur.Size = new System.Drawing.Size(202, 31);
            this.pFournisseur.TabIndex = 26;
            // 
            // pDate
            // 
            this.pDate.AutoSize = true;
            this.pDate.BackColor = System.Drawing.Color.White;
            this.pDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.pDate.Location = new System.Drawing.Point(53, 14);
            this.pDate.Name = "pDate";
            this.pDate.Size = new System.Drawing.Size(69, 15);
            this.pDate.TabIndex = 24;
            this.pDate.Text = "08/10/2024";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Date :";
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BorderRadius = 3;
            this.roundedPanel2.Controls.Add(this.pweight);
            this.roundedPanel2.Controls.Add(this.pNote);
            this.roundedPanel2.Controls.Add(this.pName);
            this.roundedPanel2.Controls.Add(this.btnReset);
            this.roundedPanel2.Controls.Add(this.btnDown);
            this.roundedPanel2.Controls.Add(this.btnUp);
            this.roundedPanel2.Controls.Add(this.btnSave);
            this.roundedPanel2.Controls.Add(this.label2);
            this.roundedPanel2.Controls.Add(this.pPU);
            this.roundedPanel2.Controls.Add(this.pStock);
            this.roundedPanel2.Controls.Add(this.pPicture);
            this.roundedPanel2.Controls.Add(this.pictureBox4);
            this.roundedPanel2.Controls.Add(this.pBenef);
            this.roundedPanel2.Controls.Add(this.pictureBox3);
            this.roundedPanel2.Controls.Add(this.pictureBox2);
            this.roundedPanel2.FillColor = System.Drawing.Color.White;
            this.roundedPanel2.Location = new System.Drawing.Point(11, 109);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.RadiusBottomLeft = 0;
            this.roundedPanel2.RadiusBottomRight = 50;
            this.roundedPanel2.RadiusTopLeft = 0;
            this.roundedPanel2.RadiusTopRight = 50;
            this.roundedPanel2.Size = new System.Drawing.Size(537, 219);
            this.roundedPanel2.TabIndex = 21;
            // 
            // pweight
            // 
            this.pweight.Background = System.Drawing.Color.White;
            this.pweight.Border = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pweight.BorderRadius = new System.Windows.Forms.Padding(6);
            this.pweight.BorderSize = 1F;
            this.pweight.Content = "";
            this.pweight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pweight.DesignStyle = cuiTextBox.Styles.Full;
            this.pweight.FocusedBackground = System.Drawing.Color.Transparent;
            this.pweight.FocusedBorder = System.Drawing.Color.Coral;
            this.pweight.ForeColor = System.Drawing.Color.Black;
            this.pweight.Location = new System.Drawing.Point(228, 125);
            this.pweight.Name = "pweight";
            this.pweight.PartialThickness = 2F;
            this.pweight.Placeholder = "Quantité";
            this.pweight.PlaceholderColor = System.Drawing.Color.Gray;
            this.pweight.Size = new System.Drawing.Size(101, 34);
            this.pweight.TabIndex = 31;
            // 
            // pNote
            // 
            this.pNote.Background = System.Drawing.Color.Transparent;
            this.pNote.Border = System.Drawing.Color.DarkGray;
            this.pNote.BorderRadius = new System.Windows.Forms.Padding(3);
            this.pNote.BorderSize = 1F;
            this.pNote.Content = "";
            this.pNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pNote.DesignStyle = cuiTextBox.Styles.Full;
            this.pNote.FocusedBackground = System.Drawing.Color.Transparent;
            this.pNote.FocusedBorder = System.Drawing.Color.Coral;
            this.pNote.ForeColor = System.Drawing.Color.Black;
            this.pNote.Location = new System.Drawing.Point(189, 174);
            this.pNote.Name = "pNote";
            this.pNote.PartialThickness = 2F;
            this.pNote.Placeholder = "Note";
            this.pNote.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pNote.Size = new System.Drawing.Size(336, 34);
            this.pNote.TabIndex = 29;
            // 
            // pName
            // 
            this.pName.BackColor = System.Drawing.Color.White;
            this.pName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pName.Location = new System.Drawing.Point(16, 159);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(164, 49);
            this.pName.TabIndex = 26;
            this.pName.Text = "Carton marron";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.CheckButton = false;
            this.btnReset.Checked = false;
            this.btnReset.CheckedBackground = System.Drawing.Color.Crimson;
            this.btnReset.CheckedImageTint = System.Drawing.Color.White;
            this.btnReset.CheckedOutline = System.Drawing.Color.Coral;
            this.btnReset.Content = "";
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.HoverBackground = System.Drawing.Color.Red;
            this.btnReset.HoveredImageTint = System.Drawing.Color.White;
            this.btnReset.HoverOutline = System.Drawing.Color.Empty;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAutoCenter = true;
            this.btnReset.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnReset.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnReset.ImageTint = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(477, 14);
            this.btnReset.Name = "btnReset";
            this.btnReset.NormalBackground = System.Drawing.Color.Crimson;
            this.btnReset.NormalOutline = System.Drawing.Color.Empty;
            this.btnReset.OutlineThickness = 1.6F;
            this.btnReset.PressedBackground = System.Drawing.Color.Crimson;
            this.btnReset.PressedImageTint = System.Drawing.Color.White;
            this.btnReset.PressedOutline = System.Drawing.Color.Empty;
            this.btnReset.Rounding = new System.Windows.Forms.Padding(20);
            this.btnReset.Size = new System.Drawing.Size(40, 40);
            this.btnReset.TabIndex = 25;
            this.btnReset.TextOffset = new System.Drawing.Point(5, 0);
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.White;
            this.btnDown.CheckButton = false;
            this.btnDown.Checked = false;
            this.btnDown.CheckedBackground = System.Drawing.Color.Crimson;
            this.btnDown.CheckedImageTint = System.Drawing.Color.White;
            this.btnDown.CheckedOutline = System.Drawing.Color.Coral;
            this.btnDown.Content = "-";
            this.btnDown.Font = new System.Drawing.Font("Malgun Gothic Semilight", 20F);
            this.btnDown.ForeColor = System.Drawing.Color.White;
            this.btnDown.HoverBackground = System.Drawing.Color.Red;
            this.btnDown.HoveredImageTint = System.Drawing.Color.White;
            this.btnDown.HoverOutline = System.Drawing.Color.Empty;
            this.btnDown.Image = null;
            this.btnDown.ImageAutoCenter = true;
            this.btnDown.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnDown.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnDown.ImageTint = System.Drawing.Color.White;
            this.btnDown.Location = new System.Drawing.Point(186, 124);
            this.btnDown.Name = "btnDown";
            this.btnDown.NormalBackground = System.Drawing.Color.Crimson;
            this.btnDown.NormalOutline = System.Drawing.Color.Empty;
            this.btnDown.OutlineThickness = 1.6F;
            this.btnDown.PressedBackground = System.Drawing.Color.Crimson;
            this.btnDown.PressedImageTint = System.Drawing.Color.White;
            this.btnDown.PressedOutline = System.Drawing.Color.Empty;
            this.btnDown.Rounding = new System.Windows.Forms.Padding(5);
            this.btnDown.Size = new System.Drawing.Size(36, 35);
            this.btnDown.TabIndex = 24;
            this.btnDown.TextOffset = new System.Drawing.Point(1, -1);
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.White;
            this.btnUp.CheckButton = false;
            this.btnUp.Checked = false;
            this.btnUp.CheckedBackground = System.Drawing.Color.LimeGreen;
            this.btnUp.CheckedImageTint = System.Drawing.Color.White;
            this.btnUp.CheckedOutline = System.Drawing.Color.Coral;
            this.btnUp.Content = "+";
            this.btnUp.Font = new System.Drawing.Font("Malgun Gothic Semilight", 20F);
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.HoverBackground = System.Drawing.Color.LimeGreen;
            this.btnUp.HoveredImageTint = System.Drawing.Color.White;
            this.btnUp.HoverOutline = System.Drawing.Color.Empty;
            this.btnUp.Image = null;
            this.btnUp.ImageAutoCenter = true;
            this.btnUp.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnUp.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnUp.ImageTint = System.Drawing.Color.White;
            this.btnUp.Location = new System.Drawing.Point(335, 124);
            this.btnUp.Name = "btnUp";
            this.btnUp.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUp.NormalOutline = System.Drawing.Color.Empty;
            this.btnUp.OutlineThickness = 1.6F;
            this.btnUp.PressedBackground = System.Drawing.Color.LimeGreen;
            this.btnUp.PressedImageTint = System.Drawing.Color.White;
            this.btnUp.PressedOutline = System.Drawing.Color.Empty;
            this.btnUp.Rounding = new System.Windows.Forms.Padding(5);
            this.btnUp.Size = new System.Drawing.Size(36, 35);
            this.btnUp.TabIndex = 23;
            this.btnUp.TextOffset = new System.Drawing.Point(1, -1);
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.CheckButton = false;
            this.btnSave.Checked = false;
            this.btnSave.CheckedBackground = System.Drawing.Color.RoyalBlue;
            this.btnSave.CheckedImageTint = System.Drawing.Color.White;
            this.btnSave.CheckedOutline = System.Drawing.Color.Coral;
            this.btnSave.Content = "Enregistrer";
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverBackground = System.Drawing.Color.CornflowerBlue;
            this.btnSave.HoveredImageTint = System.Drawing.Color.White;
            this.btnSave.HoverOutline = System.Drawing.Color.Empty;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAutoCenter = true;
            this.btnSave.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnSave.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnSave.ImageTint = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(402, 124);
            this.btnSave.Name = "btnSave";
            this.btnSave.NormalBackground = System.Drawing.Color.RoyalBlue;
            this.btnSave.NormalOutline = System.Drawing.Color.Empty;
            this.btnSave.OutlineThickness = 1.6F;
            this.btnSave.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.btnSave.PressedImageTint = System.Drawing.Color.White;
            this.btnSave.PressedOutline = System.Drawing.Color.Empty;
            this.btnSave.Rounding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(123, 35);
            this.btnSave.TabIndex = 21;
            this.btnSave.TextOffset = new System.Drawing.Point(5, 0);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(183, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Information";
            // 
            // pPU
            // 
            this.pPU.AutoSize = true;
            this.pPU.BackColor = System.Drawing.Color.Transparent;
            this.pPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pPU.Location = new System.Drawing.Point(215, 68);
            this.pPU.Name = "pPU";
            this.pPU.Size = new System.Drawing.Size(39, 17);
            this.pPU.TabIndex = 16;
            this.pPU.Text = "PU  :";
            // 
            // pStock
            // 
            this.pStock.AutoSize = true;
            this.pStock.BackColor = System.Drawing.Color.Transparent;
            this.pStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pStock.Location = new System.Drawing.Point(215, 40);
            this.pStock.Name = "pStock";
            this.pStock.Size = new System.Drawing.Size(51, 17);
            this.pStock.TabIndex = 8;
            this.pStock.Text = "Stock :";
            // 
            // pPicture
            // 
            this.pPicture.BackColor = System.Drawing.Color.Transparent;
            this.pPicture.Location = new System.Drawing.Point(25, 21);
            this.pPicture.Name = "pPicture";
            this.pPicture.Size = new System.Drawing.Size(135, 135);
            this.pPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pPicture.TabIndex = 0;
            this.pPicture.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(187, 38);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pBenef
            // 
            this.pBenef.AutoSize = true;
            this.pBenef.BackColor = System.Drawing.Color.Transparent;
            this.pBenef.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pBenef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pBenef.Location = new System.Drawing.Point(215, 95);
            this.pBenef.Name = "pBenef";
            this.pBenef.Size = new System.Drawing.Size(75, 17);
            this.pBenef.TabIndex = 15;
            this.pBenef.Text = "Benefice  :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(187, 92);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(187, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.Controls.Add(this.BtnSwitch);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.FillColor = System.Drawing.Color.White;
            this.roundedPanel1.Location = new System.Drawing.Point(410, 0);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.RadiusBottomLeft = 3;
            this.roundedPanel1.RadiusBottomRight = 80;
            this.roundedPanel1.RadiusTopLeft = 3;
            this.roundedPanel1.RadiusTopRight = 3;
            this.roundedPanel1.Size = new System.Drawing.Size(151, 76);
            this.roundedPanel1.TabIndex = 20;
            // 
            // BtnSwitch
            // 
            this.BtnSwitch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSwitch.Background = System.Drawing.Color.White;
            this.BtnSwitch.Checked = false;
            this.BtnSwitch.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnSwitch.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnSwitch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnSwitch.Location = new System.Drawing.Point(53, 41);
            this.BtnSwitch.Name = "BtnSwitch";
            this.BtnSwitch.OutlineColor = System.Drawing.Color.Crimson;
            this.BtnSwitch.OutlineStyle = true;
            this.BtnSwitch.OutlineThickness = 1.6F;
            this.BtnSwitch.ShowSymbols = true;
            this.BtnSwitch.Size = new System.Drawing.Size(50, 24);
            this.BtnSwitch.TabIndex = 5;
            this.BtnSwitch.UncheckedForeground = System.Drawing.Color.Crimson;
            this.BtnSwitch.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type de transaction";
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.BorderRadius = 20;
            this.roundedPanel4.Controls.Add(this.btnMoreInfo);
            this.roundedPanel4.Controls.Add(this.label9);
            this.roundedPanel4.FillColor = System.Drawing.Color.White;
            this.roundedPanel4.Location = new System.Drawing.Point(8, 334);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.RadiusBottomLeft = 0;
            this.roundedPanel4.RadiusBottomRight = 0;
            this.roundedPanel4.RadiusTopLeft = 0;
            this.roundedPanel4.RadiusTopRight = 0;
            this.roundedPanel4.Size = new System.Drawing.Size(540, 38);
            this.roundedPanel4.TabIndex = 0;
            // 
            // btnMoreInfo
            // 
            this.btnMoreInfo.BackColor = System.Drawing.Color.White;
            this.btnMoreInfo.CheckButton = false;
            this.btnMoreInfo.Checked = false;
            this.btnMoreInfo.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnMoreInfo.CheckedImageTint = System.Drawing.Color.White;
            this.btnMoreInfo.CheckedOutline = System.Drawing.Color.Coral;
            this.btnMoreInfo.Content = "En savoir plus";
            this.btnMoreInfo.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F);
            this.btnMoreInfo.ForeColor = System.Drawing.Color.White;
            this.btnMoreInfo.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMoreInfo.HoveredImageTint = System.Drawing.Color.White;
            this.btnMoreInfo.HoverOutline = System.Drawing.Color.Empty;
            this.btnMoreInfo.Image = null;
            this.btnMoreInfo.ImageAutoCenter = true;
            this.btnMoreInfo.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnMoreInfo.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMoreInfo.ImageTint = System.Drawing.Color.White;
            this.btnMoreInfo.Location = new System.Drawing.Point(402, 3);
            this.btnMoreInfo.Name = "btnMoreInfo";
            this.btnMoreInfo.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnMoreInfo.NormalOutline = System.Drawing.Color.Empty;
            this.btnMoreInfo.OutlineThickness = 1.6F;
            this.btnMoreInfo.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnMoreInfo.PressedImageTint = System.Drawing.Color.White;
            this.btnMoreInfo.PressedOutline = System.Drawing.Color.Empty;
            this.btnMoreInfo.Rounding = new System.Windows.Forms.Padding(5);
            this.btnMoreInfo.Size = new System.Drawing.Size(126, 32);
            this.btnMoreInfo.TabIndex = 32;
            this.btnMoreInfo.TextOffset = new System.Drawing.Point(1, -1);
            this.btnMoreInfo.Click += new System.EventHandler(this.btnMoreInfo_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.CheckButton = false;
            this.btnBack.Checked = false;
            this.btnBack.CheckedBackground = System.Drawing.Color.RoyalBlue;
            this.btnBack.CheckedImageTint = System.Drawing.Color.White;
            this.btnBack.CheckedOutline = System.Drawing.Color.Coral;
            this.btnBack.Content = "";
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.HoverBackground = System.Drawing.Color.DeepSkyBlue;
            this.btnBack.HoveredImageTint = System.Drawing.Color.White;
            this.btnBack.HoverOutline = System.Drawing.Color.Empty;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAutoCenter = true;
            this.btnBack.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnBack.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnBack.ImageTint = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(10, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.NormalBackground = System.Drawing.Color.RoyalBlue;
            this.btnBack.NormalOutline = System.Drawing.Color.Empty;
            this.btnBack.OutlineThickness = 1.6F;
            this.btnBack.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.btnBack.PressedImageTint = System.Drawing.Color.White;
            this.btnBack.PressedOutline = System.Drawing.Color.Empty;
            this.btnBack.Rounding = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.btnBack.Size = new System.Drawing.Size(43, 98);
            this.btnBack.TabIndex = 30;
            this.btnBack.TextOffset = new System.Drawing.Point(5, 0);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ProductUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.roundedPanel4);
            this.Controls.Add(this.roundedPanel3);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.historyContainer);
            this.Name = "ProductUC";
            this.Size = new System.Drawing.Size(561, 509);
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel3.PerformLayout();
            this.roundedPanelType.ResumeLayout(false);
            this.roundedPanelType.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.roundedPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel historyContainer;
        private System.Windows.Forms.Label pStock;
        private System.Windows.Forms.Label pBenef;
        private System.Windows.Forms.Label pPU;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private JUtility.RoundedPanel roundedPanel1;
        private JUtility.RoundedPanel roundedPanel2;
        private System.Windows.Forms.Label label2;
        private CuoreUI.Controls.cuiButton btnSave;
        private CuoreUI.Controls.cuiButton btnUp;
        private CuoreUI.Controls.cuiButton btnDown;
        private CuoreUI.Controls.cuiButton btnReset;
        private JUtility.RoundedPanel roundedPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pDate;
        private cuiTextBox pFournisseur;
        private System.Windows.Forms.Label pName;
        private System.Windows.Forms.Label label9;
        private cuiTextBox pNote;
        private JUtility.RoundedPanel roundedPanelType;
        public Label TextType;
        public CuoreUI.Controls.cuiSwitch BtnSwitch;
        private JUtility.RoundedPanel roundedPanel4;
        private CuoreUI.Controls.cuiButton btnBack;
        private cuiTextBox pweight;
        private CuoreUI.Controls.cuiButton btnMoreInfo;
    }
}
