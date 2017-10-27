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
    public partial class select_figure : UserControl
    {
       /* public int x;
        public int y;
        public int w;
        public int h;
        public int w1;
        public int type;
        public Color col;*/


        public XData data = null;

        public select_figure()
        {
            InitializeComponent();
        }

        private void box_figure_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            switch (comboBox.SelectedIndex)
            {
                case 1:
                    data.figure = 2;
                    break;
                case 2:
                    data.figure = 3;
                    break;
                case 3:
                    data.figure = 4;
                    break;
                case 4:
                    data.figure = 5;
                    break;
                default:
                    data.figure = 1;
                    break;
            }
        }
    }
}
