using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Text;

namespace buithanhthang_2121110129.Functions
{
    internal static class Converter
    {
        public static byte[] ImageToByteArray(Image image)
        {
            if (image == null)
                return null;

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public static Image ByteArrayToImage(byte[] data)
        {
            if (data == null)
                return null;

            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
