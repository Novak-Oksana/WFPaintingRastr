using ImageMagick;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace WFPainting
{
    class FileAll : IFileFormat
    {
        string name = "";

        public FileAll(string name)
        {
            this.name = name;
        }

        public Bitmap Load()
        {
            return new Bitmap(name);
        }

        public void Save(PictureBox pbox)
        {
            Bitmap bm = new Bitmap(pbox.Size.Width, pbox.Size.Height);
            pbox.DrawToBitmap(bm, new Rectangle(0, 0, pbox.Size.Width, pbox.Size.Height));
            string[] str = name.Split('.');
            switch (str[str.Length - 1])
            {
                case "bmp":
                    bm.Save(name, ImageFormat.Bmp);
                    break;
                case "gif":
                    bm.Save(name, ImageFormat.Gif);
                    break;
                case "png":
                    bm.Save(name, ImageFormat.Png);
                    break;
                case "emf":
                    bm.Save(name, ImageFormat.Emf);
                    break;
                case "tiff":
                    bm.Save(name, ImageFormat.Tiff);
                    break;
                case "wmf":
                    bm.Save(name, ImageFormat.Wmf);
                    break;
                case "icon":
                    bm.Save(name, ImageFormat.Icon);
                    break;
                case "jpeg":
                    bm.Save(name, ImageFormat.Jpeg);
                    break;
            }

        }

    }
}
