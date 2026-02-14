using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GradientPanel : Panel
{
    private int borderRadius = 3;
    public Color Color1 { get; set; } = Color.Blue;
    public Color Color2 { get; set; } = Color.Red;
    public float GradientAngle { get; set; } = 45f;
    public int Radius
    {
        get => borderRadius;
        set
        {
            borderRadius = value < 3 ? 3 : value;
            this.Invalidate();
        }
    }

    public int RadiusTL { get; set; } = 0;
    public int RadiusTR { get; set; } = 0;
    public int RadiusBL { get; set; } = 0;
    public int RadiusBR { get; set; } = 0;

    public GradientPanel()
    {
        this.DoubleBuffered = true; // Optimisation pour un affichage fluide
        this.Resize += ResizePanel;

        // Optimisation
        this.DoubleBuffered = true;
        this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        this.UpdateStyles();
    }

    private void ResizePanel(object sender, EventArgs e)
    {
        this.Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

        int radius = borderRadius;
        GraphicsPath path = new GraphicsPath();
        if (RadiusTL != 0) radius = RadiusTL;
        path.AddArc(rect.Left, rect.Top, radius, radius, 180, 90);
        radius = (RadiusTR != 0) ? RadiusTR : borderRadius;
        path.AddArc(rect.Right - radius, rect.Top, radius, radius, 270, 90);
        radius = (RadiusBR != 0) ? RadiusBR : borderRadius;
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
        radius = (RadiusBL != 0) ? RadiusBL : borderRadius;
        path.AddArc(rect.Left, rect.Bottom - radius, radius, radius, 90, 90);
        path.CloseFigure();

        using (LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, Color1, Color2, GradientAngle))
        {
            g.FillPath(brush, path);
        }


    }
}