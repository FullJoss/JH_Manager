using System.Drawing;
using System.Windows.Forms;

namespace JH_Manager.JUtility
{
    public class RoundedPanel : Panel
    {
        private int borderRadius = 20;
        private int radiusTopLeft = 0, radiusTopRight = 0, radiusBottomLeft = 0, radiusBottomRight = 0;
        private Color fillColor = Color.White;

        public RoundedPanel()
        {
            // Optimisation
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }

        public Color FillColor
        {
            get => fillColor;
            set
            {
                fillColor = value;
                this.Invalidate();
            }
        }

        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        public int RadiusTopLeft
        {
            get => radiusTopLeft;
            set
            {
                radiusTopLeft = value; this.Invalidate();
            }
        }
        public int RadiusTopRight
        {
            get => radiusTopRight;
            set
            {
                radiusTopRight = value; this.Invalidate();
            }
        }
        public int RadiusBottomLeft
        {
            get => radiusBottomLeft;
            set
            {
                radiusBottomLeft = value; this.Invalidate();
            }
        }
        public int RadiusBottomRight
        {
            get => radiusBottomRight;
            set
            {
                radiusBottomRight = value; this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radius = borderRadius; // Change this to adjust the roundness
                if (radiusTopLeft != 0) radius = radiusTopLeft;
                path.AddArc(0, 0, radius, radius, 180, 90);
                radius = (radiusTopRight != 0) ? radiusTopRight : borderRadius;
                path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
                radius = (radiusBottomLeft != 0) ? radiusBottomLeft : borderRadius;
                path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
                radius = (radiusBottomRight != 0) ? radiusBottomRight : borderRadius;
                path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();

                SolidBrush brush = new SolidBrush(fillColor);

                e.Graphics.FillPath(brush, path);
                e.Graphics.DrawPath(Pens.Transparent, path); // Change the brush and pen colors to your preferences
            }
        }
    }
}
