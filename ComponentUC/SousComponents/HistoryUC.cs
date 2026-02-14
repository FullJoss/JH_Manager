using System;
using System.Windows.Forms;

namespace JH_Manager.ComponentUC.SousComponents
{
    public partial class HistoryUC : UserControl
    {
        private ToolTip tooltip;
        private string note;
        public HistoryUC(History h)
        {
            InitializeComponent();

            // Optimisation
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            tooltip = new ToolTip();

            type.Text = $"Type : {h.type}";
            dateTime.Text = $"{h.date:dd/MM/yyyy} à {h.date:HH:mm}";
            weight.Text = $"{h.weight}";

            note = h.note;

            MouseHover += MouseHoverV;
            foreach (Control c in Controls)
            {
                c.MouseHover += MouseHoverV;
            }
        }

        private void MouseHoverV(object sender, EventArgs e)
        {
            tooltip.SetToolTip((Control)sender, note);
        }
    }
}
