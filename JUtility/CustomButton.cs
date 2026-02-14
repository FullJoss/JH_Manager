using System.Drawing;
using System.Windows.Forms;

public class CustomButton : Button
{
    public int CornerRadius { get; set; } = 3;
    private Bitmap resizedImage;

    public CustomButton()
    {
        this.DoubleBuffered = true;

        this.Text = "josie";

        this.Size = new Size(150, 50);
        this.ImageAlign = ContentAlignment.MiddleLeft;
        this.TextAlign = ContentAlignment.MiddleRight;

        // Redimensionner l'image une seule fois
        ResizeImage();
        this.Paint += new PaintEventHandler(DrawButton);
    }

    private void ResizeImage()
    {
        if (Image == default) return;
        Size textSize = TextRenderer.MeasureText(this.Text, this.Font);
        int imageHeight = this.Height - 20;
        int imageWidth = (Image.Width * imageHeight) / Image.Height;
        resizedImage = new Bitmap(Image, new Size(imageWidth, imageHeight));
        this.Image = resizedImage;
    }

    private void DrawButton(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        // Dessiner le bouton avec des coins arrondis
        Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
        System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
        path.AddArc(rect.X, rect.Y, CornerRadius, CornerRadius, 180, 90);
        path.AddArc(rect.X + rect.Width - CornerRadius, rect.Y, CornerRadius, CornerRadius, 270, 90);
        path.AddArc(rect.X + rect.Width - CornerRadius, rect.Y + rect.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
        path.AddArc(rect.X, rect.Y + rect.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
        path.CloseAllFigures();

        this.Region = new Region(path);
    }
}
