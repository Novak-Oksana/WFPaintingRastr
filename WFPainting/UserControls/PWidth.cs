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
    public partial class PWidth : UserControl
    {
        public XData data = null;

        public PWidth()
        {
            InitializeComponent();
        }
               
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            switch (comboBox.SelectedIndex)
            {
                case 1:
                    data.width = 2;
                    break;
                case 2:
                    data.width = 3;
                    break;
                default:
                    data.width = 1;
                    break;
            }
        }
    }
}
