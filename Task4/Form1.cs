using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Task4
{
    public partial class MainForm : Form
    {
        Graphics g;
        Bitmap bmp;
        int ws, hs;

        Decorator decorator;


        public MainForm()
        {
            InitializeComponent();
            ws = MainPB.Width;
            hs = MainPB.Height;
            bmp = new Bitmap(ws, hs);
            decorator = new Decorator(ws, hs, bmp, g);
            decorator.Setup();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bmp = new Bitmap(ws, hs);
            decorator.Setup(ws, hs, bmp, g);
            MainPB.Image = bmp;
        }
    }
}
