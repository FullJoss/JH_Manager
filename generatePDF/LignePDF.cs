using iTextSharp.text;
using iTextSharp.text.pdf;

namespace JH_Manager.generatePDF
{
    internal class LignePDF
    {
        private BaseColor backColor, foreColor;
        private Font font;
        private PdfPTable table;
        private int align;
        private int padding = 5;
        private float fontSize = 11;
        private BaseColor borderColor;
        // Les bordures
        private int borderTopSize = 0;
        private int borderLeftSize = 0;
        private int borderRightSize = 0;
        private int borderBottomSize = 0;
        public int SetBorderTopSize { set => borderTopSize = value; }
        public int SetBorderLeftSize { set => borderLeftSize = value; }
        public int SetBorderRightSize { set => borderRightSize = value; }
        public int SetBorderBottomSize { set => borderBottomSize = value; }

        public PdfPTable Table { get => table; }
        public int SetAlign { set => align = value; }
        public int SetPaddding { set => padding = value; }
        public BaseColor BorderColor { set => borderColor = value; }
        public void SetFont(Font font)
        {
            this.font = font;
        }
        public void SetBackColor(BaseColor color)
        {
            backColor = color;
        }
        public void SetForeColor(BaseColor color)
        {
            font.SetColor(color.R, color.G, color.B);
        }

        public LignePDF(int nContent, BaseColor backColor, BaseColor foreColor)
        {
            this.backColor = backColor;
            this.foreColor = foreColor;
            table = new PdfPTable(nContent);
            align = Element.ALIGN_LEFT;
            // font par defaut
            this.font = new Font(Font.FontFamily.HELVETICA, fontSize, Font.NORMAL, foreColor);
        }
        public LignePDF(int nContent, Font font, BaseColor backColor, int padding)
        {
            this.backColor = backColor;
            table = new PdfPTable(nContent)
            {
                WidthPercentage = 100
            };
            align = Element.ALIGN_LEFT; this.font = font;
            this.padding = padding;
        }

        public void WriteLine(string str)
        {
            PdfPCell cell = new PdfPCell(new Phrase(str, font))
            {
                Padding = padding,
                HorizontalAlignment = align,
                BackgroundColor = backColor,
                BorderColor = borderColor,

                // les bordures 
                BorderWidthRight = borderRightSize,
                BorderWidthLeft = borderLeftSize,
                BorderWidthTop = borderTopSize,
                BorderWidthBottom = borderBottomSize,
            };
            table.AddCell(cell);
        }
        public void WriteLine(Phrase phrase)
        {
            PdfPCell cell = new PdfPCell(phrase)
            {
                Padding = padding,
                HorizontalAlignment = align,
                BackgroundColor = backColor,
                BorderColor = borderColor,

                // les bordures 
                BorderWidthRight = borderRightSize,
                BorderWidthLeft = borderLeftSize,
                BorderWidthTop = borderTopSize,
                BorderWidthBottom = borderBottomSize,
            };
            table.AddCell(cell);
        }
        public void WriteLine(string str, int paddingBtm)
        {
            PdfPCell cell = new PdfPCell(new Phrase(str, font))
            {
                Padding = padding,
                PaddingBottom = paddingBtm,
                HorizontalAlignment = align,
                BackgroundColor = backColor,
                BorderColor = borderColor,

                // les bordures 
                BorderWidthRight = borderRightSize,
                BorderWidthLeft = borderLeftSize,
                BorderWidthTop = borderTopSize,
                BorderWidthBottom = borderBottomSize,
            };
            table.AddCell(cell);
        }
        public int[] SetDimension { set => table.SetWidths(value); }
        public float[] SetDimensionFloat { set => table.SetWidths(value); }
    }

}
