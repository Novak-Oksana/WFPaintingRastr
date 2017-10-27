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
    public partial class PColor : UserControl
    {
        public XData data = null;

        public PColor()
        {
            InitializeComponent();
        }

       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            switch (comboBox.SelectedIndex)
            {
                case 1:
                    data.color = Color.Blue;
                    break;
                case 2:
                    data.color = Color.Green;
                    break;
                default:
                    data.color = Color.Red;
                    break;
            }
        }
    }
}
