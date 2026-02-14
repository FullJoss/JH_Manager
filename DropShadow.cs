using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace JH_Manager
{
    internal class DropShadow : Form
    {
        public Form TargetForm { get; private set; }

        public DropShadow(Form targetForm)
        {
            this.TargetForm = targetForm;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.Manual;
            this.BackColor = Color.Black;
            this.Opacity = 0.5;
            this.Location = new Point(targetForm.Left - 10, targetForm.Top - 10);
            this.Size = new Size(targetForm.Width + 20, targetForm.Height + 20);
            this.TargetForm.LocationChanged += TargetForm_LocationChanged;
            this.TargetForm.SizeChanged += TargetForm_SizeChanged;
        }

        private void TargetForm_LocationChanged(object sender, EventArgs e)
        {
            this.Location = new Point(TargetForm.Left - 10, TargetForm.Top - 10);
        }

        private void TargetForm_SizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(TargetForm.Width + 20, TargetForm.Height + 20);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int radius = 30;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius - 1, this.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius - 1, radius, radius, 90, 90);
            path.CloseFigure();

            g.FillPath(new SolidBrush(Color.Black), path);
        }
    }
}
