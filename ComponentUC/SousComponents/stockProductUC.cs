using System;
using System.Drawing;
using System.Windows.Forms;

namespace JH_Manager.ComponentUC.SousComponents
{
    public partial class stockProductUC : UserControl
    {
        private bool isChecked = false;

        public event EventHandler Clique;

        public bool IsChecked
        {
            get => isChecked;
            set
            {
                isChecked = value;
                if (value)
                {
                    labelPrice.ForeColor = nameProduit.ForeColor = LabelStok.ForeColor = Color.White;
                    BackColor = Color.FromArgb(32, 32, 32);
                }
                else
                {
                    labelPrice.ForeColor = nameProduit.ForeColor = LabelStok.ForeColor = Color.Black;
                    BackColor = Color.Transparent;
                }
                this.Invalidate();
            }
        }
        public stockProductUC()
        {
            InitializeComponent();

            // Optimisation
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            // Attache les cliques
            foreach (Control c in Controls)
            {
                c.Click += OnClick;
            }
            Click += OnClick;
        }

        public virtual void OnClick(object sender, EventArgs e)
        {
            Clique?.Invoke(this, e);
        }

        private void handleHoverEnter(object sender, EventArgs e)
        {
            if (!isChecked)
                this.BackColor = Color.WhiteSmoke;
        }

        private void handleHeave(object sender, EventArgs e)
        {
            if (!isChecked)
                this.BackColor = Color.Transparent;
        }
    }
}
