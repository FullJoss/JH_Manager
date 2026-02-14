using System.Drawing;
using System.Windows.Forms;

namespace JH_Manager.JUtility
{
    public class CustomPanel : Panel
    {
        public Color BorderColor { get; set; } = Color.Black;
        public float BorderRadius { get; set; } = 3f;

        public Color FillColor { get; set; } = Color.White;

        public int BorderSize { get; set; } = 1;
        public CustomPanel()
        {
            // Optimisation
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dessiner le fond avec des bords arrondis
            using (Brush brush = new SolidBrush(this.FillColor))
            {
                FillRoundedRectangle(g, brush, 0f, 0f, (float)this.Width, (float)this.Height, BorderRadius);
            }

            // Dessiner la bordure
            using (Pen pen = new Pen(BorderColor))
            {
                pen.Width = BorderSize;
                DrawRoundedRectangle(g, pen, 0f, 0f, (float)(this.Width - BorderSize / 4) - 1, (float)(this.Height - BorderSize / 4) - 1, BorderRadius + BorderSize);
            }
        }

        private void FillRoundedRectangle(Graphics g, Brush brush, float x, float y, float width, float height, float radius)
        {
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(x, y, radius, radius, 180f, 90f);
                path.AddArc(x + width - radius, y, radius, radius, 270f, 90f);
                path.AddArc(x + width - radius, y + height - radius, radius, radius, 0f, 90f);
                path.AddArc(x, y + height - radius, radius, radius, 90f, 90f);
                path.CloseFigure();
                g.FillPath(brush, path);
            }
        }

        private void DrawRoundedRectangle(Graphics g, Pen pen, float x, float y, float width, float height, float radius)
        {
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(x, y, radius, radius, 180, 90);
                path.AddArc(x + width - radius, y, radius, radius, 270, 90);
                path.AddArc(x + width - radius, y + height - radius, radius, radius, 0, 90);
                path.AddArc(x, y + height - radius, radius, radius, 90, 90);
                path.CloseFigure();
                g.DrawPath(pen, path);
            }
        }

    }

}
