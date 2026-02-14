using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;

namespace JH_Manager.generatePDF
{
    internal class JParagrah
    {
        private int width, height;
        private List<PdfPTable> tables;
        private Font font;
        private int initW, initH;
        private int padding = 3;
        private BaseColor backColor;

        public Font SetFont { set => font = value; }

        private bool IsLeft = true;
        public JParagrah(int width, int height, Font font, BaseColor backColor)
        {
            this.width = width; this.height = height;
            initW = initH = 0;
            tables = new List<PdfPTable>();
            for (int i = 0; i < height; i++)
            {
                tables.Add(new PdfPTable(width)
                {
                    WidthPercentage = 100
                });
            }
            this.font = font;
            this.backColor = backColor;
        }

        public void AddText(string text)
        {
            int pad = padding;
            if (height - 1 == initH) pad *= 2;
            AddToCell(text, tables[initH], pad);
            initW++;
            if (initW >= width && initH < height - 1)
            {
                initW = 0;
                initH++;
            }
        }

        private void AddToCell(string str, PdfPTable table, int paddingBtm)
        {
            PdfPCell cell = new PdfPCell(new Phrase(str, font))
            {
                PaddingBottom = paddingBtm,
                BackgroundColor = backColor,
                BorderWidth = 0,
            };

            cell.HorizontalAlignment = (IsLeft) ? Element.ALIGN_LEFT : Element.ALIGN_RIGHT;

            table.AddCell(cell);

            IsLeft = !IsLeft;
        }

        public void ImplementAllTab(Document doc)
        {
            while (initW < width)
            {
                AddText("");
                initW++;
            }

            foreach (PdfPTable table in tables)
            {
                doc.Add(table);
            }
        }

    }
}
