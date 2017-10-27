using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageMagick;

namespace WFPainting
{
    class FileRaw : IFileFormat
    {
        string name = "";
        public FileRaw(string name)
        {
            this.name = name;
        }
        public Bitmap Load()
        {
            using (MagickImage image = new MagickImage(name))
            {
                return image.ToBitmap();
            }
        }

        public void Save(PictureBox pbox)
        {
            Bitmap bm = new Bitmap(pbox.Size.Width, pbox.Size.Height);
            pbox.DrawToBitmap(bm, new Rectangle(0, 0, pbox.Size.Width, pbox.Size.Height));
            MagickImage image = new MagickImage(bm);
            image.Format = MagickFormat.Raw;
            image.Write(name);
        }
    }

    
}
