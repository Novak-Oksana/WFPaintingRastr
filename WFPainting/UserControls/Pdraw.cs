using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WFPainting
{
    public partial class Pdraw : UserControl
    {
        public XData data = null;
        // public FPath fpath = null;
        int x = 0;
        int y = 0;

        public Pdraw()
        {
            InitializeComponent();
            SelfRef = this;
        }

        public static Pdraw SelfRef
        {
            get; set;
        }

        public PictureBox getPictureBox()
        {
            return this.pbox;
        }

        private void pbox_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            //if (e.Button == MouseButtons.Left && data.figure == 1)
            //{
            //    fpath = new FPath();
           // }
        }

        private void pbox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && data.figure == 1)
            {
                Graphics g = Graphics.FromImage(data.image);
                Pen pen = new Pen(data.color, data.width);
                g.DrawLine(pen, x, y, e.X, e.Y);
                x = e.X;
                y = e.Y;
                // fpath.addPoint(x, y);
            }
            pbox.Invalidate();
        }

        private void pbox_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics g = Graphics.FromImage(data.image);

            int startX = x;
            int startY = y;
            int x2 = e.X;
            int y2 = e.Y;
            int width = Math.Abs(x2 - x);
            int height = Math.Abs(y2 -y);

            if (x2 < startX)
                startX = x2;
            if (y2 < startY)
                startY = y2;


            Pen pen = new Pen(data.color, data.width);
            switch (data.figure)
            {
                //case 1:
                // figures.add(fpath);
                // fpath = null;
                //    break;
                case 2:
                    g.DrawRectangle(pen, startX, startY, width, height);
                    break;
                case 3:
                    g.DrawPath(pen, RoundRect(startX, startY, width, height, 10));
                    break;
                case 4:
                    g.DrawEllipse(pen, startX, startY, width, height);
                    break;
                case 5:
                    g.DrawLine(pen, x, y, x2, y2);
                    break;
            }
            pbox.Invalidate();
        }
        private GraphicsPath RoundRect(int x, int y, int width, int height, int diameter)
        {
            GraphicsPath path = new GraphicsPath();

            Rectangle bounds = new Rectangle(x, y, width, height);
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            path.AddArc(arc, 180, 90);
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);
            arc.Y = bounds.Top;
            path.CloseFigure();
            return path;
        }
        private void Pdraw_Load(object sender, EventArgs e)
        {

        }

        public void pbox_Paint(object sender, PaintEventArgs e)
        {
            if (data.image == null)
               data.image = new Bitmap(pbox.Width, pbox.Height);

            base.OnPaint(e);

            //Graphics g = Graphics.FromImage(data.image);
           // foreach (IFigure figure in figures)
           //     figure.draw(g);

            //if (fpath != null)
            //    figure.draw(g);


            pbox.Image = data.image;
        }
    }
}


