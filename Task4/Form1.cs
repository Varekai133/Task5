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

        Worker worker = new Worker(0, 5);
        BlastFurnace blastfurnace = new BlastFurnace(170, 100, 40, 0);
        LoarderForFurnace loarder = new LoarderForFurnace(0, true, 7, 0.1);

        public MainForm()
        {
            InitializeComponent();
            ws = MainPB.Width;
            hs = MainPB.Height;
            bmp = new Bitmap(ws, hs);
            Thread thrl = new Thread(DrawLoarder);
            thrl.Start();
            Thread thrw = new Thread(DrawWorker);
            thrw.Start();
            Thread thrf = new Thread(DrawFurnace);
            thrf.Start();

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bmp = new Bitmap(ws, hs);
            DrawFurnace();
            DrawLoarder();
            DrawWorker();
            MainPB.Image = bmp;
        }

        private void DrawWorker()
        {
            worker.DrawAll(ws, hs, bmp, g);
        }

        private void DrawFurnace()
        {
            blastfurnace.DrawAll(ws, hs, bmp, g);
        }

        private void DrawLoarder()
        {
            loarder.DrawAll(ws, hs, bmp, g);
        }
    }
}
