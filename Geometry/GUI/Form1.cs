using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace GUI
{
    public partial class Form1 : Form
    {
        int Ex, Ey, w, h, Cx, Cy;
        Graphics gmc;
        Pen pen = Pens.Aqua;
        Pen pen2 = Pens.Red;
        public Form1()
        {
            InitializeComponent();
            gmc = Graphics.FromHwnd(panel1.Handle);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Ex = Convert.ToInt32(EPoint.Text.Split(',')[0]);rrrrr
                Ey = Convert.ToInt32(EPoint.Text.Split(',')[1]);
                w = Convert.ToInt32(width.Text);
                h = Convert.ToInt32(heigth.Text);
                Cx = Convert.ToInt32(CPoint.Text.Split(',')[0]);
                Cy = Convert.ToInt32(CPoint.Text.Split(',')[1]);
                this.panel1_Paint(this, null);
            }
            catch
            {
                CPoint.Clear();
                width.Clear();
                heigth.Clear();
                EPoint.Clear();
                Log.Clear();
                Log.AppendText("Please enter points");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Geometry.Geometry geom =
                    new Geometry.Geometry(Ex, Ey, w, h, Cx, Cy);
                if (geom.CheckDot())
                {
                    Log.Clear();
                    Log.AppendText("True");
                }
                else
                {
                    Log.Clear();
                    Log.AppendText("False");
                }
            }
            catch
            {
                CPoint.Clear();
                CPoint.AppendText("Please enter points");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            CPoint.Clear();
            EPoint.Clear();
            width.Clear();
            heigth.Clear();
            int x = r.Next(panel1.Width - 100);
            int y = r.Next(panel1.Height - 100);
            EPoint.AppendText(x.ToString());
            EPoint.AppendText(",");
            EPoint.AppendText(y.ToString());
            width.AppendText(r.Next(panel1.Width - x).ToString());
            heigth.AppendText(r.Next(panel1.Height - y).ToString());
            CPoint.AppendText(r.Next(panel1.Width).ToString());
            CPoint.AppendText(",");
            CPoint.AppendText(r.Next(panel1.Height).ToString());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            gmc.Clear(Color.White);
            gmc.DrawEllipse(pen, Ex, panel1.Height - Ey - h, w, h);
            gmc.DrawEllipse(pen2, (Cx - 1), panel1.Height - (Cy + 1), 2, 2);
        }
    }
}
