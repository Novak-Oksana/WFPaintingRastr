using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFPainting
{
    public partial class Form1 : Form
    {
        XData data = new XData();

        public Form1()
        {
            InitializeComponent();
            pColor1.data = data;
            pWidth1.data = data;
            pFigure1.data = data;
            pSave1.data = data;
            pOpen1.data = data;
            pdraw2.data = data;

            pColor1.select_color.SelectedIndex = 0;
            pWidth1.comboBox1.SelectedIndex = 0;
            pFigure1.box_figure.SelectedIndex = 0;
        }

        private void pgfile1_Load(object sender, EventArgs e)
        {

        }

        private void pdraw2_Load(object sender, EventArgs e)
        {

        }
    }
}
