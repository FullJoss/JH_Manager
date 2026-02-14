namespace JH_Manager.ComponentUC
{
    partial class StockG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockG));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panDetails = new JH_Manager.JUtility.RoundedPanel();
            this.btnStockMode = new CuoreUI.Controls.cuiButton();
            this.btnBudgetMode = new CuoreUI.Controls.cuiButton();
            this.label8 = new System.Windows.Forms.Label();
            this.cuiButton1 = new CuoreUI.Controls.cuiButton();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panStock = new JH_Manager.JUtility.RoundedPanel();
            this.btnFact = new CuoreUI.Controls.cuiButton();
            this.btnPrev = new CuoreUI.Controls.cuiButton();
            this.btnNext = new CuoreUI.Controls.cuiButton();
            this.panelContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDetails = new CuoreUI.Controls.cuiButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBar = new JH_Manager.JUtility.CustomTextBox();
            this.cuiButton3 = new CuoreUI.Controls.cuiButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.panStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // panDetails
            // 
            this.panDetails.BorderRadius = 3;
            this.panDetails.Controls.Add(this.btnStockMode);
            this.panDetails.Controls.Add(this.btnBudgetMode);
            this.panDetails.Controls.Add(this.label8);
            this.panDetails.Controls.Add(this.cuiButton1);
            this.panDetails.Controls.Add(this.gridView);
            this.panDetails.FillColor = System.Drawing.Color.White;
            this.panDetails.Location = new System.Drawing.Point(11, 0);
            this.panDetails.Name = "panDetails";
            this.panDetails.RadiusBottomLeft = 0;
            this.panDetails.RadiusBottomRight = 80;
            this.panDetails.RadiusTopLeft = 80;
            this.panDetails.RadiusTopRight = 0;
            this.panDetails.Size = new System.Drawing.Size(555, 488);
            this.panDetails.TabIndex = 1;
            // 
            // btnStockMode
            // 
            this.btnStockMode.CheckButton = false;
            this.btnStockMode.Checked = false;
            this.btnStockMode.CheckedBackground = System.Drawing.Color.Silver;
            this.btnStockMode.CheckedImageTint = System.Drawing.Color.White;
            this.btnStockMode.CheckedOutline = System.Drawing.Color.Coral;
            this.btnStockMode.Content = "Stock";
            this.btnStockMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnStockMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStockMode.HoverBackground = System.Drawing.Color.LightGray;
            this.btnStockMode.HoveredImageTint = System.Drawing.Color.White;
            this.btnStockMode.HoverOutline = System.Drawing.Color.Empty;
            this.btnStockMode.Image = ((System.Drawing.Image)(resources.GetObject("btnStockMode.Image")));
            this.btnStockMode.ImageAutoCenter = true;
            this.btnStockMode.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnStockMode.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnStockMode.ImageTint = System.Drawing.Color.White;
            this.btnStockMode.Location = new System.Drawing.Point(169, 451);
            this.btnStockMode.Name = "btnStockMode";
            this.btnStockMode.NormalBackground = System.Drawing.Color.Silver;
            this.btnStockMode.NormalOutline = System.Drawing.Color.Empty;
            this.btnStockMode.OutlineThickness = 1.6F;
            this.btnStockMode.PressedBackground = System.Drawing.Color.Silver;
            this.btnStockMode.PressedImageTint = System.Drawing.Color.White;
            this.btnStockMode.PressedOutline = System.Drawing.Color.Empty;
            this.btnStockMode.Rounding = new System.Windows.Forms.Padding(8);
            this.btnStockMode.Size = new System.Drawing.Size(121, 33);
            this.btnStockMode.TabIndex = 7;
            this.btnStockMode.Tag = "checkedBtn";
            this.btnStockMode.TextOffset = new System.Drawing.Point(5, 1);
            this.btnStockMode.Click += new System.EventHandler(this.btnStockMode_Click);
            // 
            // btnBudgetMode
            // 
            this.btnBudgetMode.CheckButton = false;
            this.btnBudgetMode.Checked = false;
            this.btnBudgetMode.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBudgetMode.CheckedImageTint = System.Drawing.Color.White;
            this.btnBudgetMode.CheckedOutline = System.Drawing.Color.Coral;
            this.btnBudgetMode.Content = "Budget";
            this.btnBudgetMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnBudgetMode.ForeColor = System.Drawing.Color.White;
            this.btnBudgetMode.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBudgetMode.HoveredImageTint = System.Drawing.Color.White;
            this.btnBudgetMode.HoverOutline = System.Drawing.Color.Empty;
            this.btnBudgetMode.Image = ((System.Drawing.Image)(resources.GetObject("btnBudgetMode.Image")));
            this.btnBudgetMode.ImageAutoCenter = true;
            this.btnBudgetMode.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnBudgetMode.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnBudgetMode.ImageTint = System.Drawing.Color.White;
            this.btnBudgetMode.Location = new System.Drawing.Point(42, 451);
            this.btnBudgetMode.Name = "btnBudgetMode";
            this.btnBudgetMode.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBudgetMode.NormalOutline = System.Drawing.Color.Empty;
            this.btnBudgetMode.OutlineThickness = 1.6F;
            this.btnBudgetMode.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBudgetMode.PressedImageTint = System.Drawing.Color.White;
            this.btnBudgetMode.PressedOutline = System.Drawing.Color.Empty;
            this.btnBudgetMode.Rounding = new System.Windows.Forms.Padding(8);
            this.btnBudgetMode.Size = new System.Drawing.Size(121, 33);
            this.btnBudgetMode.TabIndex = 6;
            this.btnBudgetMode.Tag = "checkedBtn";
            this.btnBudgetMode.TextOffset = new System.Drawing.Point(5, 1);
            this.btnBudgetMode.Click += new System.EventHandler(this.btnBudgetMode_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(432, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Revu de tout les stock";
            // 
            // cuiButton1
            // 
            this.cuiButton1.CheckButton = false;
            this.cuiButton1.Checked = false;
            this.cuiButton1.CheckedBackground = System.Drawing.Color.Crimson;
            this.cuiButton1.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton1.CheckedOutline = System.Drawing.Color.Coral;
            this.cuiButton1.Content = "Retour";
            this.cuiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton1.ForeColor = System.Drawing.Color.White;
            this.cuiButton1.HoverBackground = System.Drawing.Color.Red;
            this.cuiButton1.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton1.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton1.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton1.Image")));
            this.cuiButton1.ImageAutoCenter = true;
            this.cuiButton1.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton1.ImageOffset = new System.Drawing.Point(-5, 0);
            this.cuiButton1.ImageTint = System.Drawing.Color.White;
            this.cuiButton1.Location = new System.Drawing.Point(423, 451);
            this.cuiButton1.Name = "cuiButton1";
            this.cuiButton1.NormalBackground = System.Drawing.Color.Crimson;
            this.cuiButton1.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton1.OutlineThickness = 1.6F;
            this.cuiButton1.PressedBackground = System.Drawing.Color.Crimson;
            this.cuiButton1.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton1.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton1.Size = new System.Drawing.Size(121, 33);
            this.cuiButton1.TabIndex = 3;
            this.cuiButton1.TextOffset = new System.Drawing.Point(5, 1);
            this.cuiButton1.Click += new System.EventHandler(this.cuiButton1_Click);
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.AllowUserToResizeColumns = false;
            this.gridView.AllowUserToResizeRows = false;
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.BackgroundColor = System.Drawing.Color.White;
            this.gridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridView.ColumnHeadersHeight = 30;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.id,
            this.Stock,
            this.IN,
            this.OUT});
            this.gridView.EnableHeadersVisualStyles = false;
            this.gridView.Location = new System.Drawing.Point(24, 36);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersVisible = false;
            this.gridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.gridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.gridView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 3);
            this.gridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.GreenYellow;
            this.gridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridView.RowTemplate.Height = 30;
            this.gridView.RowTemplate.ReadOnly = true;
            this.gridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(508, 394);
            this.gridView.TabIndex = 0;
            // 
            // name
            // 
            this.name.HeaderText = "Nom";
            this.name.Name = "name";
            // 
            // id
            // 
            this.id.FillWeight = 150F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            // 
            // IN
            // 
            this.IN.HeaderText = "Entrer";
            this.IN.Name = "IN";
            // 
            // OUT
            // 
            this.OUT.HeaderText = "Sortie";
            this.OUT.Name = "OUT";
            // 
            // panStock
            // 
            this.panStock.BorderRadius = 20;
            this.panStock.Controls.Add(this.btnFact);
            this.panStock.Controls.Add(this.btnPrev);
            this.panStock.Controls.Add(this.btnNext);
            this.panStock.Controls.Add(this.panelContainer);
            this.panStock.Controls.Add(this.btnDetails);
            this.panStock.Controls.Add(this.label6);
            this.panStock.Controls.Add(this.label5);
            this.panStock.Controls.Add(this.label4);
            this.panStock.Controls.Add(this.label1);
            this.panStock.Controls.Add(this.SearchBar);
            this.panStock.Controls.Add(this.cuiButton3);
            this.panStock.Controls.Add(this.label3);
            this.panStock.Controls.Add(this.label2);
            this.panStock.FillColor = System.Drawing.Color.White;
            this.panStock.Location = new System.Drawing.Point(11, 16);
            this.panStock.Name = "panStock";
            this.panStock.RadiusBottomLeft = 0;
            this.panStock.RadiusBottomRight = 0;
            this.panStock.RadiusTopLeft = 0;
            this.panStock.RadiusTopRight = 0;
            this.panStock.Size = new System.Drawing.Size(547, 475);
            this.panStock.TabIndex = 2;
            // 
            // btnFact
            // 
            this.btnFact.BackColor = System.Drawing.Color.White;
            this.btnFact.CheckButton = false;
            this.btnFact.Checked = false;
            this.btnFact.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFact.CheckedImageTint = System.Drawing.Color.White;
            this.btnFact.CheckedOutline = System.Drawing.Color.Coral;
            this.btnFact.Content = "Facturation";
            this.btnFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnFact.ForeColor = System.Drawing.Color.Black;
            this.btnFact.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFact.HoveredImageTint = System.Drawing.Color.White;
            this.btnFact.HoverOutline = System.Drawing.Color.Empty;
            this.btnFact.Image = ((System.Drawing.Image)(resources.GetObject("btnFact.Image")));
            this.btnFact.ImageAutoCenter = true;
            this.btnFact.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnFact.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnFact.ImageTint = System.Drawing.Color.White;
            this.btnFact.Location = new System.Drawing.Point(395, 60);
            this.btnFact.Name = "btnFact";
            this.btnFact.NormalBackground = System.Drawing.Color.White;
            this.btnFact.NormalOutline = System.Drawing.Color.Black;
            this.btnFact.OutlineThickness = 1F;
            this.btnFact.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFact.PressedImageTint = System.Drawing.Color.White;
            this.btnFact.PressedOutline = System.Drawing.Color.Empty;
            this.btnFact.Rounding = new System.Windows.Forms.Padding(8);
            this.btnFact.Size = new System.Drawing.Size(135, 34);
            this.btnFact.TabIndex = 14;
            this.btnFact.TextOffset = new System.Drawing.Point(5, 0);
            this.btnFact.Click += new System.EventHandler(this.btnFact_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.White;
            this.btnPrev.CheckButton = false;
            this.btnPrev.Checked = false;
            this.btnPrev.CheckedBackground = System.Drawing.Color.Crimson;
            this.btnPrev.CheckedImageTint = System.Drawing.Color.White;
            this.btnPrev.CheckedOutline = System.Drawing.Color.Coral;
            this.btnPrev.Content = "<";
            this.btnPrev.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.HoverBackground = System.Drawing.Color.Red;
            this.btnPrev.HoveredImageTint = System.Drawing.Color.White;
            this.btnPrev.HoverOutline = System.Drawing.Color.Empty;
            this.btnPrev.Image = null;
            this.btnPrev.ImageAutoCenter = true;
            this.btnPrev.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnPrev.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnPrev.ImageTint = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(231, 438);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.NormalBackground = System.Drawing.Color.Crimson;
            this.btnPrev.NormalOutline = System.Drawing.Color.Empty;
            this.btnPrev.OutlineThickness = 1.6F;
            this.btnPrev.PressedBackground = System.Drawing.Color.Crimson;
            this.btnPrev.PressedImageTint = System.Drawing.Color.White;
            this.btnPrev.PressedOutline = System.Drawing.Color.Empty;
            this.btnPrev.Rounding = new System.Windows.Forms.Padding(8);
            this.btnPrev.Size = new System.Drawing.Size(35, 34);
            this.btnPrev.TabIndex = 13;
            this.btnPrev.TextOffset = new System.Drawing.Point(0, 0);
            this.btnPrev.Click += new System.EventHandler(this.cuiButton6_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.CheckButton = false;
            this.btnNext.Checked = false;
            this.btnNext.CheckedBackground = System.Drawing.Color.RoyalBlue;
            this.btnNext.CheckedImageTint = System.Drawing.Color.White;
            this.btnNext.CheckedOutline = System.Drawing.Color.Coral;
            this.btnNext.Content = ">";
            this.btnNext.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverBackground = System.Drawing.Color.CornflowerBlue;
            this.btnNext.HoveredImageTint = System.Drawing.Color.White;
            this.btnNext.HoverOutline = System.Drawing.Color.Empty;
            this.btnNext.Image = null;
            this.btnNext.ImageAutoCenter = true;
            this.btnNext.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnNext.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnNext.ImageTint = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(269, 438);
            this.btnNext.Name = "btnNext";
            this.btnNext.NormalBackground = System.Drawing.Color.RoyalBlue;
            this.btnNext.NormalOutline = System.Drawing.Color.Empty;
            this.btnNext.OutlineThickness = 1.6F;
            this.btnNext.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.btnNext.PressedImageTint = System.Drawing.Color.White;
            this.btnNext.PressedOutline = System.Drawing.Color.Empty;
            this.btnNext.Rounding = new System.Windows.Forms.Padding(8);
            this.btnNext.Size = new System.Drawing.Size(35, 34);
            this.btnNext.TabIndex = 12;
            this.btnNext.TextOffset = new System.Drawing.Point(0, 0);
            this.btnNext.Click += new System.EventHandler(this.cuiButton5_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Location = new System.Drawing.Point(11, 131);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(519, 306);
            this.panelContainer.TabIndex = 11;
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.White;
            this.btnDetails.CheckButton = false;
            this.btnDetails.Checked = false;
            this.btnDetails.CheckedBackground = System.Drawing.Color.RoyalBlue;
            this.btnDetails.CheckedImageTint = System.Drawing.Color.White;
            this.btnDetails.CheckedOutline = System.Drawing.Color.Coral;
            this.btnDetails.Content = "Details";
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnDetails.ForeColor = System.Drawing.Color.White;
            this.btnDetails.HoverBackground = System.Drawing.Color.CornflowerBlue;
            this.btnDetails.HoveredImageTint = System.Drawing.Color.White;
            this.btnDetails.HoverOutline = System.Drawing.Color.Empty;
            this.btnDetails.Image = null;
            this.btnDetails.ImageAutoCenter = true;
            this.btnDetails.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnDetails.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnDetails.ImageTint = System.Drawing.Color.White;
            this.btnDetails.Location = new System.Drawing.Point(395, 20);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.NormalBackground = System.Drawing.Color.RoyalBlue;
            this.btnDetails.NormalOutline = System.Drawing.Color.Empty;
            this.btnDetails.OutlineThickness = 1.6F;
            this.btnDetails.PressedBackground = System.Drawing.Color.Coral;
            this.btnDetails.PressedImageTint = System.Drawing.Color.RoyalBlue;
            this.btnDetails.PressedOutline = System.Drawing.Color.Empty;
            this.btnDetails.Rounding = new System.Windows.Forms.Padding(8);
            this.btnDetails.Size = new System.Drawing.Size(135, 34);
            this.btnDetails.TabIndex = 10;
            this.btnDetails.TextOffset = new System.Drawing.Point(0, 0);
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(477, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Action";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(359, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(266, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(90, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom";
            // 
            // SearchBar
            // 
            this.SearchBar.BackColor = System.Drawing.Color.Transparent;
            this.SearchBar.BorderColor = System.Drawing.Color.Black;
            this.SearchBar.Content = "";
            this.SearchBar.FillColor = System.Drawing.Color.White;
            this.SearchBar.IsRounded = true;
            this.SearchBar.Location = new System.Drawing.Point(15, 54);
            this.SearchBar.MarginT = 10;
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Padding = new System.Windows.Forms.Padding(10);
            this.SearchBar.Placeholder = "Nom ou ID";
            this.SearchBar.Size = new System.Drawing.Size(200, 35);
            this.SearchBar.TabIndex = 5;
            this.SearchBar.EnterTouch += new System.EventHandler(this.SearchBarTouch);
            // 
            // cuiButton3
            // 
            this.cuiButton3.BackColor = System.Drawing.Color.Transparent;
            this.cuiButton3.CheckButton = false;
            this.cuiButton3.Checked = false;
            this.cuiButton3.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cuiButton3.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton3.CheckedOutline = System.Drawing.Color.Coral;
            this.cuiButton3.Content = "";
            this.cuiButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cuiButton3.ForeColor = System.Drawing.Color.White;
            this.cuiButton3.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cuiButton3.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton3.HoverOutline = System.Drawing.Color.Black;
            this.cuiButton3.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton3.Image")));
            this.cuiButton3.ImageAutoCenter = true;
            this.cuiButton3.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton3.ImageTint = System.Drawing.Color.White;
            this.cuiButton3.Location = new System.Drawing.Point(221, 54);
            this.cuiButton3.Name = "cuiButton3";
            this.cuiButton3.NormalBackground = System.Drawing.Color.White;
            this.cuiButton3.NormalOutline = System.Drawing.Color.Black;
            this.cuiButton3.OutlineThickness = 1.5F;
            this.cuiButton3.PressedBackground = System.Drawing.Color.Coral;
            this.cuiButton3.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cuiButton3.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton3.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton3.Size = new System.Drawing.Size(38, 35);
            this.cuiButton3.TabIndex = 4;
            this.cuiButton3.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton3.Click += new System.EventHandler(this.cuiButton3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(10, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tableau de produit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Image";
            // 
            // StockG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panDetails);
            this.Controls.Add(this.panStock);
            this.Name = "StockG";
            this.Size = new System.Drawing.Size(569, 509);
            this.panDetails.ResumeLayout(false);
            this.panDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.panStock.ResumeLayout(false);
            this.panStock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn IN;
        private System.Windows.Forms.DataGridViewTextBoxColumn OUT;
        private JUtility.RoundedPanel panDetails;
        private JUtility.RoundedPanel panStock;
        private CuoreUI.Controls.cuiButton cuiButton3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private JUtility.CustomTextBox SearchBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private CuoreUI.Controls.cuiButton btnDetails;
        private CuoreUI.Controls.cuiButton btnNext;
        private System.Windows.Forms.FlowLayoutPanel panelContainer;
        private CuoreUI.Controls.cuiButton btnPrev;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiButton btnFact;
        private System.Windows.Forms.Label label8;
        private CuoreUI.Controls.cuiButton btnBudgetMode;
        private CuoreUI.Controls.cuiButton btnStockMode;
    }
}
