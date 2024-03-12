using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic.Library
{
    public class UploadImage
    {
        private OpenFileDialog fd = new OpenFileDialog();

        public void UploadImages(PictureBox pictureBox)
        {
            pictureBox.WaitOnLoad = true;
            fd.Filter = "Imagenes | *.jpg;*.gif;*.png;*.bmp";
            fd.ShowDialog();

            if (fd.FileName != string.Empty)
            {
                pictureBox.ImageLocation = fd.FileName;
            }

        }

        public byte[] ImageToByte(Image img)
        {
            var convert = new ImageConverter();
            return (byte[])convert.ConvertTo(img, typeof(byte[]));
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            return Image.FromStream(new MemoryStream(byteArrayIn));
        }

    }
}
