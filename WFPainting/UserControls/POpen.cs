using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFPainting
{
    public partial class POpen : UserControl
    {
        public POpen()
        {
            InitializeComponent();
        }

        public XData data = null;
        private void btnopen_Click(object sender, EventArgs e)
        {/*
            if (dgOpen.ShowDialog() == DialogResult.OK)
            {
                data.image = Image.FromFile(dgOpen.FileName);
            }*/
            string[] ext = {"PNG (*.png)|*.png","JPEG(*.jpeg) | *.jpeg","GIF (*.gif)|*.gif","BMP (*.bmp)|*.bmp","RAW (*.raw)|*.raw",
                "TIFF (*.tiff)|*.tiff","WMF (*.wmf)|*.wmf","PSD (*.psd)|*.psd","ICON (*.icon)|*.icon","EMF (*.emf)|*.emf" };

            dgOpen.Filter = String.Join("|", ext);
            if (dgOpen.ShowDialog() == DialogResult.OK)
            {
                data.image = FileImpl.GetInstance(dgOpen.FileName).Load();
            }
        }
    }
}
