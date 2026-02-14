using iTextSharp.text;
using System;
using System.Drawing.Imaging;
using System.Globalization;
using System.Windows.Forms;

namespace JH_Manager.generatePDF
{
    internal class PDFCyber
    {
        private Document doc;
        // Plaette de couleurs
        private BaseColor blue = new BaseColor(0, 75, 155);
        private BaseColor gray = new BaseColor(178, 178, 178);
        private BaseColor white = new BaseColor(255, 255, 255);
        private BaseColor black = new BaseColor(21, 21, 21);
        private BaseColor transparentColor = new BaseColor(0, 0, 0, 0);
        // Les fonts utilisés
        private Font FLight, FBold, FBoldWhite, FfooterBold, FheaderLight, FBoldBlack, Farret;

        // donner
        private DataGridView grid;
        private Label lblArret, lblTotal;
        private string[] headerInfo;

        public PDFCyber(DataGridView grid, Label lblArret, Label lblTotal, string[] headerInfo)
        {
            Farret = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 11f, iTextSharp.text.Font.BOLD, black);
            FLight = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 11f, iTextSharp.text.Font.NORMAL, black);
            FBold = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 17f, iTextSharp.text.Font.BOLD, blue);
            FBoldWhite = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13f, iTextSharp.text.Font.BOLD, white);
            FfooterBold = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 11f, iTextSharp.text.Font.BOLD, blue);
            FheaderLight = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12f, iTextSharp.text.Font.NORMAL, black);
            FBoldBlack = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13f, iTextSharp.text.Font.BOLD, black);
            doc = new Document();

            this.grid = grid;
            this.lblArret = lblArret;
            this.lblTotal = lblTotal;

            this.headerInfo = headerInfo;
        }

        public Document GetDoc()
        {
            return doc;
        }

        public void WriteInTheDoc()
        {
            doc.Open();

            // L'en tête
            InsertHeader(doc);

            // petite espace
            doc.Add(new Phrase("\n", new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 4f, 1, white)));


            // Nouvelle ligne
            LignePDF ligne = new LignePDF(4, FBoldWhite, blue, 8)
            {
                SetAlign = Element.ALIGN_CENTER,
                SetDimension = new int[4] { 20, 40, 20, 20 },
                SetBorderRightSize = 1,
                SetBorderLeftSize = 1,
                SetBorderBottomSize = 2,
                BorderColor = blue
            };

            ligne.WriteLine("PRODUIT");
            ligne.WriteLine("SDFGÏ");
            ligne.WriteLine("PRIX");
            ligne.WriteLine("TOTAL");

            doc.Add(ligne.Table);

            // Lister les produits
            for (int i = 0; i < grid.RowCount - 1; i++)
            {
                ligne = new LignePDF(4, FLight, white, 8)
                {
                    SetDimension = new int[4] { 20, 40, 20, 20 },
                    SetBorderLeftSize = 1,
                    SetBorderBottomSize = 1,
                    SetBorderRightSize = 1,
                    BorderColor = gray,
                    SetAlign = Element.ALIGN_CENTER
                };

                ligne.WriteLine(grid["QTE", i].Value.ToString());
                ligne.SetBorderLeftSize = 0;
                ligne.WriteLine(grid["DESIGNATION", i].Value.ToString());
                ligne.WriteLine(grid["PU", i].Value.ToString());
                ligne.WriteLine(grid["MONTANT", i].Value.ToString());
                doc.Add(ligne.Table);
            }

            ligne = new LignePDF(3, FLight, white, 8)
            {
                SetDimensionFloat = new float[3] { 60, 19.8f, 20.2f },
            };
            // String (arret de somme)
            Chunk Chunkinchanger = new Chunk("Arrêtée à la somme de : ", FLight);
            Chunk Chunkchangeable = new Chunk($"{lblArret.Text}", Farret);
            Phrase phrase = new Phrase();
            phrase.Add(Chunkinchanger); phrase.Add(Chunkchangeable);

            ligne.WriteLine(phrase);
            ligne.SetFont(FBoldBlack);
            ligne.SetAlign = Element.ALIGN_CENTER;
            ligne.WriteLine("TOTAL :");

            ligne.SetBorderLeftSize = ligne.SetBorderRightSize = ligne.SetBorderBottomSize = 1;
            ligne.BorderColor = gray;
            ligne.WriteLine($"{lblTotal.Text}");

            doc.Add(ligne.Table);

            // petite espace
            doc.Add(new Phrase("\n", new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 4f, 1, white)));

            InsertFooter(doc);

            doc.Close();
        }

        void InsertFooter(Document doc)
        {
            JParagrah p = new JParagrah(2, 2, FfooterBold, white);
            p.AddText($"Paiement a l'ordre de {headerInfo[5]}");
            p.AddText("");

            p.SetFont = FLight;
            // Date
            DateTime now = DateTime.Now;
            p.AddText($"Paiement effectué à {now:HH:mm}");
            p.AddText("Signature du fournisseur");

            p.ImplementAllTab(doc);

            //Image sign = default(Image);
            //sign = Image.GetInstance(Properties.Resources.signature, ImageFormat.Png);
            //sign.ScalePercent(10f);
            //sign.SetAbsolutePosition(doc.PageSize.Width - 150f, sign.AbsoluteY);

            //doc.Add(sign);

            // Ligne Horizontale
            LignePDF ligne = new LignePDF(1, FBold, white, 0)
            {
                SetBorderBottomSize = 1,
                BorderColor = blue
            };
            ligne.WriteLine(" ");
            doc.Add(ligne.Table);

            // petite espace
            doc.Add(new Phrase("\n", new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 3f, 1, white)));


            // Ligne Horizontale
            ligne = new LignePDF(1, FBold, white, 0)
            {
                SetAlign = Element.ALIGN_CENTER,
                BorderColor = blue,
            };
            ligne.WriteLine("MERCI DE VOTRE CONFIANCE");
            doc.Add(ligne.Table);
        }

        void InsertHeader(Document doc)
        {

            Image logo = default(Image);
            logo = Image.GetInstance(Properties.Resources.sprite, ImageFormat.Png);
            logo.ScalePercent(10f);
            logo.SetAbsolutePosition(doc.PageSize.Width - 130f, doc.PageSize.Height - 110f);

            Paragraph paragraph = new Paragraph("FACTURE", new Font(Font.FontFamily.HELVETICA, 30f, Font.BOLD, blue));
            paragraph.SpacingAfter = 15;
            paragraph.SpacingBefore = -30f;

            doc.Add(paragraph);

            LignePDF ligne = new LignePDF(3, FLight, white, 7)
            {
                SetBorderBottomSize = 1,
                SetBorderLeftSize = 1,
                SetBorderRightSize = 1,
                SetBorderTopSize = 1,
                SetAlign = Element.ALIGN_CENTER,
            };

            ligne.SetDimension = new int[3] { 25, 35, 40 };

            ligne.WriteLine($"Facture n°{headerInfo[8]}");

            ligne.SetBorderLeftSize = 0;

            //Capitaliser le premier lettre
            TextInfo txtinf = new CultureInfo("fr-FR", false).TextInfo;

            ligne.WriteLine($"{txtinf.ToTitleCase(headerInfo[3])}");

            ligne.SetBorderRightSize = ligne.SetBorderTopSize = ligne.SetBorderBottomSize = 0;
            ligne.SetBackColor(transparentColor);
            ligne.WriteLine("");

            doc.Add(ligne.Table);
            doc.Add(logo);

            // Ligne Horizontale
            ligne = new LignePDF(1, FLight, white, 0)
            {
                SetBorderBottomSize = 1,
                BorderColor = blue
            };
            ligne.WriteLine(" ");
            doc.Add(ligne.Table);

            // petite espace
            doc.Add(new Phrase("\n", new Font(Font.FontFamily.HELVETICA, 2f, 1, white)));

            // Nouvelle ligne
            ligne = new LignePDF(2, FBold, white, 2);

            ligne.WriteLine("CYBER FAST");
            ligne.SetAlign = Element.ALIGN_RIGHT;
            ligne.WriteLine("A L'ATTENTION DE");

            doc.Add(ligne.Table);

            // petite espace
            doc.Add(new Phrase("\n", new Font(Font.FontFamily.HELVETICA, 3f, 1, white)));


            JParagrah p = new JParagrah(2, 4, FheaderLight, white);
            p.AddText($"NIF    : {headerInfo[0]}");
            p.AddText($"{headerInfo[5]}");
            p.AddText($"STAT : {headerInfo[1]}");
            p.AddText($"à {headerInfo[6]}");
            p.AddText($"MAIL  : {headerInfo[2]}");
            p.AddText($"{headerInfo[7]}");
            p.AddText($"TEL    : {headerInfo[4]}");

            p.ImplementAllTab(doc);
        }
    }
}
