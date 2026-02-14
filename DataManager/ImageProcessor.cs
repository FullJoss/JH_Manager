using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace JH_Manager.DataManager
{
    public class ImageProcessor
    {
        public static Image ByteToImage(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        public static byte[] ImageToByte(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public static Bitmap LoadImage(PictureBox imagePath)
        {
            return new Bitmap(imagePath.Image);
        }

        private static Color GetBackgroundColor(Bitmap image)
        {
            return image.GetPixel(0, 0);
        }

        private static bool IsColorClose(Color a, Color b, int tolerance)
        {
            int rDiff = Math.Abs(a.R - b.R);
            int gDiff = Math.Abs(a.G - b.G);
            int bDiff = Math.Abs(a.B - b.B);

            return rDiff <= tolerance && gDiff <= tolerance && bDiff <= tolerance;
        }

        public static Bitmap RemoveBackground(Bitmap image, int tolerance)
        {
            Color backgroundColor = GetBackgroundColor(image);
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    if (IsColorClose(pixelColor, backgroundColor, tolerance))
                    {
                        image.SetPixel(x, y, Color.Transparent);
                    }
                }
            }

            MessageBox.Show("Adaptation de l'image terminer");

            return image;
        }
    }
}
