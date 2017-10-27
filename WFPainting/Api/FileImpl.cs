using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFPainting
{
    class FileImpl
    {
        public static IFileFormat GetInstance(string type)
        {
            IFileFormat ff = null;
            string[] str = type.Split('.');
            switch (str[str.Length - 1])
            {
                case "psd":
                    ff = new FilePsd(type);
                    break;
                case "raw":
                    ff = new FileRaw(type);
                    break;
                case "gif":
                    ff = new FileAll(type);
                    break;
                case "tiff":
                    ff = new FileAll(type);
                    break;
                case "png":
                    ff = new FileAll(type);
                    break;
                case "emf":
                    ff = new FileAll(type);
                    break;
                case "icon":
                    ff = new FileAll(type);
                    break;
                case "wmf":
                    ff = new FileAll(type);
                    break;
                case "bmp":
                    ff = new FileAll(type);
                    break;
                case "jpeg":
                    ff = new FileAll(type);
                    break;
            }
            return ff;
        }
    }
}
