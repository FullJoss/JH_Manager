using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuoreUI;
using JH_Manager.Produits;

namespace JH_Manager.ComponentUC.SousComponents
{
    class ListPanel : Panel
    {
        private List<Produit> produits;
        private const int HauteurItem = 80;
        private const int LargeurImage = 64;
        private const int Marge = 10;
        private Rectangle rectHover;
        private Point? offsetMouse;
        public int IndexSelected { get; set; } = -1;

        public ListPanel()
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
            this.AutoScroll = true;

            produits = new List<Produit>();
            rectHover = new Rectangle(0, -HauteurItem, 0, HauteurItem - Marge);
            offsetMouse = null;
        }

        public void SetProduit(List<Produit> value)
        {
            produits = value;
            this.Invalidate();
        }

        private void DesignImageProduit(Graphics g, int indexImageData, Rectangle rectImage)
        {
            Image img = Bigdata.ImageData[indexImageData];
            
            Rectangle drawRectImg = new Rectangle();

            double ratioImg = (double)img.Width / img.Height;
            double ratioRectImg = (double)rectImage.Width / rectImage.Height;

            if (ratioImg > ratioRectImg)
            {
                drawRectImg.Width = rectImage.Width;
                drawRectImg.Height = (int)(rectImage.Width / ratioImg);
            }
            else
            {
                drawRectImg.Height = rectImage.Height;
                drawRectImg.Width = (int)(rectImage.Height * ratioImg);
     
            }
            drawRectImg.X = rectImage.X + (rectImage.Width - drawRectImg.Width) / 2;
            drawRectImg.Y = rectImage.Y + (rectImage.Height - drawRectImg.Height) / 2;

            // Dessiner l'image
            g.DrawImage(img, drawRectImg);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(Color.White);
            int y = this.AutoScrollPosition.Y;

            using (Font fontNom = new Font("Segoe UI", 12, FontStyle.Bold))
            using (Font fontStock = new Font("Segoe UI", 10, FontStyle.Regular))
            using (Brush bNom = new SolidBrush(Color.Black))
            using (Brush bStock = new SolidBrush(Color.Gray))
            {
                for (int i = 0; i < produits.Count; i++)
                {
                    var produit = produits[i];

                    Rectangle rectImage = new Rectangle(Marge, y + Marge, LargeurImage, HauteurItem - 2 * Marge);
                    Rectangle rectTexte = new Rectangle(rectImage.Right + Marge, y + Marge, this.Width - rectImage.Right - 2 * Marge, HauteurItem - 2 * Marge);

                    // Hover
                    if (offsetMouse != null)
                    {
                        rectHover.Y = y + Marge/2;
                        if (rectHover.Contains((Point)offsetMouse) || i == produits.Count - 1)
                        {
                            e.Graphics.FillRectangle(Brushes.WhiteSmoke, rectHover);
                            IndexSelected = i;
                            offsetMouse = null;
                        }
                    }

                    //Dessiner l'image
                    DesignImageProduit(e.Graphics, produit.Index, rectImage);

                    // Dessiner le nom
                    e.Graphics.DrawString(produit.Name, fontNom, bNom, rectTexte.Location);

                    // Dessiner le stock en dessous du nom
                    PointF positionStock = new PointF(rectTexte.Left, rectTexte.Top + fontNom.Height + 5);
                    e.Graphics.DrawString($"Stock: {produit.Stock}", fontStock, bStock, positionStock);

                    y += HauteurItem;
                }
            }

            this.AutoScrollMinSize = new Size(0, produits.Count * HauteurItem);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (!rectHover.Contains(e.Location))
            {
                offsetMouse = e.Location;
                this.Invalidate();
                Console.WriteLine("Re Dessiner");
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            offsetMouse = null;
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            rectHover.Width = this.Width;
        }
    }
}
