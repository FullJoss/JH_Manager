using JH_Manager.JUtility;
using JH_Manager.Produits;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace JH_Manager.ComponentUC.SousComponents
{
    public partial class GraphXY : UserControl
    {

        internal class Data
        {
            public DateTime Date { get; set; }
            public long Value { get; set; }

            public Data(DateTime date, long value)
            {
                Date = date;
                Value = value;
            }
        }

        private Panel pan;
        // Data
        private List<Data> data;
        private string reff = "Unit";

        private List<PointF> points2D;
        private Point CursorPos;

        private int selectedSegment;

        private Color lineColor, gradientColor;

        private bool isFirst = true; // Optimisation des calculs

        // Variables pour le dessin
        private Pen pen;
        private Pen PenCoord;

        public GraphXY(string name, Color backColor, Color lineColor, Color gradientColor)
        {
            InitializeComponent();
            selectedSegment = -1;

            this.lineColor = lineColor;
            this.BackColor = backColor;
            this.gradientColor = gradientColor;

            labelName.Text = name;

            CursorPos = new Point(0);

            // Initialisation des donner a afficher
            data = new List<Data>();

            // Afficher les graphiques

            labelX.ForeColor = labelX2.ForeColor = labelY.ForeColor = lineColor;

            pan = new GraphiquePanel();
            pan.BackColor = backColor;
            pan.Location = new Point(78, 18);
            pan.Size = new Size(560, 328);
            pan.BorderStyle = BorderStyle.None;
            pan.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;

            Controls.Add(pan);

            // Pour de dessin
            pen = new Pen(Color.FromArgb(51, lineColor), 2);
            PenCoord = new Pen(lineColor, 1);

            // Ajout d'evenement
            pan.MouseMove += MouseMoveInPan;
            pan.Paint += PaintPanelGraph;
        }

        private long MAX_Value()
        {
            long max = 0;
            foreach (Data d in data)
            {
                if (max < d.Value) max = d.Value;
            }
            return max;
        }
        private long MIN_Value()
        {
            long min = data[0].Value;
            foreach (Data d in data)
            {
                if (min > d.Value) min = d.Value;
            }
            return min;
        }

        private List<PointF> CreatePoint2D()
        {
            float panelWidth = pan.Width;
            float panelHeight = pan.Height;
            long maxSalary = MAX_Value();
            long minSalary = MIN_Value();
            float topMargin = 10;
            float bottomMargin = 10;
            float leftMargin = 0;
            float rightMargin = 0;

            List<PointF> points = new List<PointF>() { };
            float stepX = (panelWidth - leftMargin - rightMargin) / (data.Count - 1);

            for (int i = 0; i < data.Count; i++)
            {
                float normalizedY = (Convert.ToSingle(data[i].Value - minSalary)) / (maxSalary - minSalary);
                float yPosition = topMargin + (panelHeight - topMargin - bottomMargin) * (1 - normalizedY);
                float xPosition = leftMargin + i * stepX;

                points.Add(new PointF(xPosition, yPosition));
            }

            return points;
        }

        public void GetAllPriceList()
        {
            data.Clear();
            // Si aucun produit a afficher
            if (!Bigdata.produits.Any())
            {
                pan.MouseMove -= MouseMoveInPan;
                pan.Paint -= PaintPanelGraph;
                pan.Dispose();
                labelX.Dispose();
                labelX2.Dispose();
                labelY.Dispose();

                labelName.Text = "Aucun produit";
                labelName.ForeColor = Color.Red;
                return;
            }

            foreach (Produit p in Bigdata.produits.Values)
            {
                foreach (History h in p.historic)
                {
                    if (h.type == "Entrer") continue;
                    // Determine si c'est un nouvea date
                    int i = -1;
                    for (i = 0; i < data.Count; i++)
                    {
                        if (data[i].Date.ToString("dd/MM/yyyy") == h.date.ToString("dd/MM/yyyy"))
                        {
                            break;
                        }
                    }
                    // Creer un nouveau bloc
                    if (i >= data.Count || data.Count <= 0)
                    {
                        Data d = new Data(h.date, p.Price * h.weight);
                        data.Add(d);
                    }
                    // Ajouter sur un bloc
                    else
                    {
                        data[i].Value += p.Price * h.weight;
                    }
                }
            }

            if (data.Count <= 1)
            {
                pan.MouseMove -= MouseMoveInPan;
                pan.Paint -= PaintPanelGraph;
                pan.Dispose();
                labelX.Dispose();
                labelX2.Dispose();
                labelY.Dispose();

                labelName.Text = "Votre donner doit depasser les 2 Jours";
                labelName.ForeColor = Color.Red;
                return;
            }

            reff = "Ar";

            // Trier les date
            data.Sort((l, y) => l.Date.CompareTo(y.Date));

            points2D = CreatePoint2D();

            pan.Invalidate();
        }
        public void GetListInProduct(Produit p)
        {
            data.Clear();
            long x = p.Stock;

            Data d = new Data(DateTime.Now, x);
            data.Add(d);

            for (int i = p.historic.Count - 1; i >= 0; i--)
            {
                History h = p.historic[i];
                int coef = h.type == "Entrer" ? -1 : 1;
                x += h.weight * coef;
                data.Add(new Data(h.date, x));
            }
            reff = p.Unit;

            data.Reverse();

            points2D = CreatePoint2D();

            pan.Invalidate();
        }

        private void PaintPanelGraph(object sender, PaintEventArgs e)
        {
            if (data.Count <= 1) return;
            Graphics g = e.Graphics;

            using (LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, -pan.Height / 3, pan.Width, 4 * pan.Height / 3),
                        gradientColor, Color.Transparent, LinearGradientMode.Vertical))
            using (var path = new GraphicsPath())
            {
                for (int i = 0; i < points2D.Count - 1; i++)
                {
                    PointF p1 = points2D[i];
                    PointF p2 = points2D[i + 1];
                    PointF controlP1 = new PointF((p1.X + p2.X) / 2, p1.Y);
                    PointF controlP2 = new PointF((p1.X + p2.X) / 2, p2.Y);

                    if (i == 0)
                    {
                        path.StartFigure();
                        path.AddBezier(p1, controlP1, controlP2, p2);

                    }
                    else
                    {
                        path.AddBezier(p1, controlP1, controlP2, p2);
                    }
                    g.DrawBezier(pen, p1, controlP1, controlP2, p2);
                }

                // Ligne fermé
                path.AddLine(points2D[points2D.Count - 1], new PointF(points2D[points2D.Count - 1].X, pan.Height));
                path.AddLine(new PointF(points2D[points2D.Count - 1].X, pan.Height), new PointF(points2D[0].X, pan.Height));
                path.CloseFigure();

                // Remplir la forme avec le gradient

                {
                    g.FillPath(brush, path);
                }

                // Dessiner des courbes
                g.DrawPath(pen, path);
            }



            // Dessine les points
            foreach (var point in points2D)
            {
                using (Brush brus = new SolidBrush(lineColor))
                {
                    e.Graphics.FillEllipse(brus, point.X - 4, point.Y - 4, 8, 8);
                }
            }

            if (selectedSegment != -1)
            {
                PointF p1 = points2D[selectedSegment];
                PointF p2 = points2D[selectedSegment + 1];
                PointF controlPoint1 = new PointF((p1.X + p2.X) / 2, p1.Y);
                PointF controlPoint2 = new PointF((p1.X + p2.X) / 2, p2.Y);


                using (var selectedPath = new GraphicsPath())
                using (LinearGradientBrush selectedBrush = new LinearGradientBrush(new RectangleF(p1.X, 0, p2.X - p1.X, pan.Height),
                                                                    Color.FromArgb(128, lineColor), Color.Transparent, LinearGradientMode.Vertical))
                {
                    selectedPath.StartFigure();
                    selectedPath.AddBezier(p1, controlPoint1, controlPoint2, p2);
                    selectedPath.AddLine(p2, new PointF(p2.X, pan.Height));
                    selectedPath.AddLine(new PointF(p2.X, pan.Height), new PointF(p1.X, pan.Height));
                    selectedPath.CloseFigure();

                    g.FillPath(selectedBrush, selectedPath);

                }
                // point coordinate
                PointF coord2 = new PointF(0, points2D[selectedSegment].Y);
                g.DrawLine(PenCoord, points2D[selectedSegment], coord2);

                coord2 = new PointF(0, points2D[selectedSegment + 1].Y);
                g.DrawLine(PenCoord, points2D[selectedSegment + 1], coord2);
            }
        }

        private void MouseMoveInPan(object sender, MouseEventArgs e)
        {
            if (data.Count <= 1) return;
            CursorPos = new Point(e.X, e.Y);

            if (isFirst == true)
            {
                isFirst = false;
                points2D = CreatePoint2D();
            }

            selectedSegment = -1;

            float stepX = 1;
            float calc = 0;
            if (data.Count > 1)
            {
                stepX = pan.Width / (data.Count - 1);
                calc = e.X / stepX;
            }
            int index = (int)calc;

            if (index >= 0 && index < data.Count - 1)
            {

                selectedSegment = index;
            }
            else
            {
                for (int i = 0; i < points2D.Count - 1; i++)
                {
                    PointF p1 = points2D[i];
                    PointF p2 = points2D[i + 1];
                    if (IsCursorBetweenPoints(CursorPos, p1, p2))
                    {
                        selectedSegment = i;
                        break;
                    }
                }
            }

            if (selectedSegment <= -1 || selectedSegment >= data.Count) return;

            labelX.Location = new Point(labelX.Location.X, (int)points2D[selectedSegment].Y);
            labelY.Location = new Point(e.X + labelY.Width / 2, labelY.Location.Y);

            labelX.Text = $"{data[selectedSegment].Value} {reff}";
            if (data.Count > 1)
            {
                labelX2.Location = new Point(labelX.Location.X, (int)points2D[selectedSegment + 1].Y);
                labelX2.Text = $"{data[selectedSegment + 1].Value} {reff}";
            }
            labelY.Text = data[selectedSegment].Date.ToString("dd/MM/yyyy");

            pan.Invalidate();
        }
        private bool IsCursorBetweenPoints(PointF cursor, PointF p1, PointF p2)
        {
            float minX = Math.Min(p1.X, p2.X);
            float maxX = Math.Max(p1.X, p2.X);
            return cursor.X > minX && cursor.X < maxX;
        }
    }
}
