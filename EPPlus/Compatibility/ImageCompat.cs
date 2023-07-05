using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using IronSoftware.Drawing;
using static IronSoftware.Drawing.AnyBitmap;

namespace OfficeOpenXml.Compatibility
{
    internal class ImageCompat
    {
        internal static byte[] GetImageAsByteArray(AnyBitmap image)
        {
            var ms = new MemoryStream();
            if (image.GetImageFormat() == ImageFormat.Gif)
            {
                image.ExportStream(ms, ImageFormat.Gif);
            }
            else if (image.GetImageFormat() == ImageFormat.Bmp)
            {
                image.ExportStream(ms, ImageFormat.Bmp);
            }
            else if (image.GetImageFormat() == ImageFormat.Png)
            {
                image.ExportStream(ms, ImageFormat.Png);
            }
            else if (image.GetImageFormat() == ImageFormat.Tiff)
            {
                image.ExportStream(ms, ImageFormat.Tiff);
            }
            else
            {
                image.ExportStream(ms, ImageFormat.Jpeg);
            }

            return ms.ToArray();
        }
    }
}