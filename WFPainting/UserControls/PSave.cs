using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;


namespace WFPainting
{
    public partial class PSave : UserControl
    {
        public PSave()
        {
            InitializeComponent();
        }

        public XData data = null;

        private void btnsave_Click(object sender, EventArgs e)
        {
            string[] ext = {"PNG (*.png)|*.png","JPEG(*.jpeg) | *.jpeg","GIF (*.gif)|*.gif","BMP (*.bmp)|*.bmp","RAW (*.raw)|*.raw",
                "TIFF (*.tiff)|*.tiff","WMF (*.wmf)|*.wmf","PSD (*.psd)|*.psd","ICON (*.icon)|*.icon","EMF (*.emf)|*.emf" };

            dgSave.Filter = String.Join("|", ext);
            if (dgSave.ShowDialog() == DialogResult.OK)
            {
                FileImpl.GetInstance(dgSave.FileName).Save(Pdraw.SelfRef.getPictureBox());
            }
        }

    }
}
