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
        public delegate void MyDelegate();

        public MainForm()
        {
            InitializeComponent();
            ws = MainPB.Width;
            hs = MainPB.Height;
            bmp = new Bitmap(ws, hs);
            decorator = new Decorator(ws, hs, bmp, g, this);
            decorator.Setup();
        }

        private void MainPB_Paint(object sender, PaintEventArgs e)
        {
            bmp = new Bitmap(ws, hs);
            decorator.Setup(ws, hs, bmp, g);
            MainPB.Image = bmp;
            Thread.Sleep(100);
        }
    }
}
