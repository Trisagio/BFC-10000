using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

using Accord.Imaging;
using Accord.Imaging.Filters;


namespace BFC_10000
{
    static class ImageProcessing
    {
        //private Bitmap _image;
        //public Bitmap Image { get => _image; }

        //public ImageProcessing(Bitmap image)
        //    => _image = image;

        public static Bitmap Extract(string text)
        {
            Bitmap bitmap = new Bitmap(32, 32, PixelFormat.Format32bppRgb);
            string[] lines = text.Split(new String[] {"\n"}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < 32; i++)
            {
                for (int j = 0; j < 32; j++)
                {
                    if (lines[i][j] == '0')
                        bitmap.SetPixel(j, i, Color.White);
                    else bitmap.SetPixel(j, i, Color.Black);
                }
            }
            return bitmap;
        }

        public static double[] Extract(Bitmap bmp)
        {
            double[] features = new double[32 * 32];
            for (int i = 0; i < 32; i++)
                for (int j = 0; j < 32; j++)
                    features[i * 32 + j] = (bmp.GetPixel(j, i).R == 255) ? 0 : 1;

            return features;
        }

        public static Bitmap Export(double[] features)
        {
            Bitmap bitmap = new Bitmap(32, 32, PixelFormat.Format32bppRgb);

            for (int i = 0; i < 32; i++)
                for (int j = 0; j < 32; j++)
                {
                    double v = features[i * 32 + j];
                    v = 255 - Math.Max(0, Math.Min(255, Math.Abs(v) * 255));
                    bitmap.SetPixel(j, i, Color.FromArgb((int)v, (int)v, (int)v));
                }

            return bitmap;
        }
    }
}
