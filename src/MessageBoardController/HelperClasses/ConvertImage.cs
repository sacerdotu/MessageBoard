using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoardController.HelperClasses
{
    public static class ConvertImage
    {
        public static byte[] ImageToByteArray(System.Drawing.Image image)
        {
            return (Byte[])new ImageConverter().ConvertTo(image, typeof(Byte[]));
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}
