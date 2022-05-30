using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace prueba3.Tools
{
    public class GenQR
    {

            public static byte[] GenerarQR(string pTexto)
            {

                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(pTexto, QRCodeGenerator.ECCLevel.Q);

                QRCode qrCodePNG = new QRCode(qrCodeData);
                Bitmap qrCodeImageBmp = qrCodePNG.GetGraphic(20, Color.Black, Color.White, (Bitmap)Bitmap.FromFile("C:\\logo4.jpg"));
                ImageConverter converter = new ImageConverter();
                return (byte[])converter.ConvertTo(qrCodeImageBmp, typeof(byte[]));

            }
    }
}
