using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JH_Manager.DataManager
{
    public static class AnalyserGraph
    {
        public static Point offset;

        public static void DrawGraph(List<long> DataGraph, Panel panelGraph, PaintEventArgs e)
        {
            if (DataGraph.Count <= 0) return;
            // Calculer les ajustements
            float panelHeight = panelGraph.Height;
            float panelWidth = panelGraph.Width;
            double max = DataGraph.Max();
            double min = DataGraph.Min();

            List<PointF> points2D = new List<PointF>() { new Point(0, (int)panelHeight) };
            double stepX = panelWidth / DataGraph.Count;

            for (int i = 0; i < DataGraph.Count; i++)
            {
                double norm = (DataGraph[i] - min) / (max - min);
                double y = (panelHeight - 10) * (1 - norm);
                double x = i * stepX;
                points2D.Add(new PointF((float)x, (float)y));
            }
            using (Pen pen = new Pen(Color.LightBlue, 2))
            {
                for (int i = 0; i < points2D.Count - 1; i++)
                {
                    e.Graphics.DrawLine(pen, points2D[i], points2D[i + 1]);
                }

                foreach (var point in points2D)
                {
                    e.Graphics.FillEllipse(Brushes.Red, point.X - 3, point.Y - 3, 6, 6);
                }
            };
        }

        public static void DrawModernGraph(List<long> listeData, Label heightLabel, Panel panelGraph, PaintEventArgs e)
        {
            // Calculer les ajustements pour l'affichage
            float panelWidth = panelGraph.Width;
            float panelHeight = panelGraph.Height;
            float maxSalary = listeData.Max(); // Valeur maximale dans les salaires
            float minSalary = listeData.Min(); // Valeur minimale dans les salaires
            float topMargin = 10; // 10px en dessous de la position 0
            float bottomMargin = 10; // Marge en bas

            List<PointF> points2D = new List<PointF>();
            float stepX = panelWidth / listeData.Count;

            // Afficher les nobmres
            float calc = offset.X / stepX;

            int index = (int)calc;
            if (index >= 0 && index < listeData.Count)
            {
                float salary = listeData[index];
                float normalizedY = (Convert.ToSingle(listeData[index] - minSalary)) / (maxSalary - minSalary);
                float yPosition = topMargin + (panelHeight - topMargin - bottomMargin) * (1 - normalizedY);
                heightLabel.Text = $"{salary}";
                heightLabel.Location = new Point(offset.X, (int)yPosition - heightLabel.Height - 10);
                e.Graphics.FillEllipse(Brushes.RoyalBlue, offset.X - 3, yPosition - 3, 6, 6);
            }
            else
            {
                heightLabel.Text = string.Empty;
            }

            using (Pen pen = new Pen(Color.Crimson, 2))
            {
                for (int i = 0; i < listeData.Count; i++)
                {
                    float normalizedY = (Convert.ToSingle(listeData[i] - minSalary)) / (maxSalary - minSalary);
                    float yPosition = topMargin + (panelHeight - topMargin - bottomMargin) * (1 - normalizedY);
                    float xPosition = i * stepX;

                    points2D.Add(new PointF(xPosition, yPosition));

                    // denier ligne
                    if (i == listeData.Count - 1)
                    {
                        float x = (i + 1) * stepX;
                        points2D.Add(new PointF(x, yPosition));
                    }

                    // Dessiner le segment horizontal
                    if (i > 0)
                    {
                        e.Graphics.DrawLine(pen, points2D[i - 1].X, points2D[i - 1].Y, xPosition, points2D[i - 1].Y);
                    }
                }

                // Dessiner les segments verticaux
                for (int i = 0; i < points2D.Count - 1; i++)
                {
                    e.Graphics.DrawLine(pen, points2D[i].X, points2D[i].Y, points2D[i + 1].X, points2D[i].Y);
                    e.Graphics.DrawLine(pen, points2D[i + 1].X, points2D[i].Y, points2D[i + 1].X, points2D[i + 1].Y);
                }
            }

        }

    }
}
