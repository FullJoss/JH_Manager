using System.Drawing;
using System.Windows.Forms;

namespace JH_Manager.JUtility
{
    public class CustomComboBox : ComboBox
    {
        private Color arrowColor = Color.White;

        public CustomComboBox()
        {
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.FlatStyle = FlatStyle.Standard;
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.BackColor = Color.White;
            this.ItemHeight = 30; // Hauteur personnalisée des items
            this.Height = 30;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);
            if (e.Index < 0) return;

            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            if (isSelected && e.Index == this.SelectedIndex)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.GreenYellow), e.Bounds);
            }
            else
            {
                e.DrawBackground();
            }

            // Ajouter du padding
            Rectangle paddedBounds = new Rectangle(e.Bounds.Left + 10, e.Bounds.Top + (e.Bounds.Height - e.Font.Height) / 2, e.Bounds.Width - 20, e.Bounds.Height - 10);

            // Dessiner le texte de l'élément avec padding=

            using (Brush br = new SolidBrush(Color.Black))
            {
                e.Graphics.DrawString(this.Items[e.Index].ToString(), e.Font, br, paddedBounds);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Rectangle rect = this.ClientRectangle;
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dessiner la flèche de drop-down
            int arrowX = rect.Right - 15;
            int arrowY = rect.Height / 2 - 1;
            Point[] arrowPoints = {
            new Point(arrowX, arrowY),
            new Point(arrowX + 5, arrowY),
            new Point(arrowX + 2, arrowY + 4)
        };
            using (Brush b = new SolidBrush(Color.Red))
            {
                g.FillPolygon(b, arrowPoints);
            }
        }
    }
    public static class GraphicsExtensions
    {
        public static void DrawRoundedRectangle(this Graphics graphics, Pen pen, int x, int y, int width, int height, int radius)
        {
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(x, y, radius, radius, 180, 90);
                path.AddArc(x + width - radius, y, radius, radius, 270, 90);
                path.AddArc(x + width - radius, y + height - radius, radius, radius, 0, 90);
                path.AddArc(x, y + height - radius, radius, radius, 90, 90);
                path.CloseFigure();
                graphics.DrawPath(pen, path);
            }
        }
    }
}
