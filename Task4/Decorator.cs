using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using static Task4.MainForm;


namespace Task4
{
    public class Decorator : IDraw
    {
        Graphics g;
        Bitmap bmp;
        Thread thrl, thrw, thrf, thrs, thrb;

        int ws, hs;

        private MainForm form;

        Worker worker = new Worker(0, 5);
        BlastFurnace blastfurnace = new BlastFurnace(170, 100, 40, 0);
        LoarderForFurnace loarder = new LoarderForFurnace(0, true, 7, 0.1);
        Smoke smoke = new Smoke();
        
        public Decorator(int ws, int hs, Bitmap bmp, Graphics g, MainForm form)
        {
            this.form = form;
            this.ws = ws;
            this.hs = hs;
            this.g = g;
            this.bmp = bmp;
        }

        public void Setup()
        {
            thrl = new Thread(LoarderThr);
            thrl.Start();
            thrf = new Thread(FurnaceThr);
            thrf.Start();
            thrw = new Thread(WorkerThr);
            thrw.Start();
            thrs = new Thread(SmoteThr);
            thrs.Start();
            thrb = new Thread(BrokeThr);
            thrb.Start();
        }

        public void Setup(int ws, int hs, Bitmap bmp, Graphics g)
        {
            smoke.Setup(ws, hs, bmp, g);
            smoke.color = Color.Gray;
            blastfurnace.Setup(ws, hs, bmp, g);
            loarder.Setup(ws, hs, bmp, g);
            worker.Setup(ws, hs, bmp, g);
        }

        private void BrokeThr()
        {
            if (loarder.broke && Monitor.TryEnter(loarder))
            {
                lock (smoke)
                {
                    Thread.Sleep(100);
                    form.BeginInvoke(new MyDelegate(form.Refresh));
                    loarder.broke = false;
                }
            }
        }

        private void SmoteThr()
        {
            smoke.Setup(ws, hs, bmp, g);
        }

        private void WorkerThr()
        {
            worker.Setup(ws, hs, bmp, g);
        }

        private void FurnaceThr()
        {
            blastfurnace.Setup(ws, hs, bmp, g);
        }

        private void LoarderThr()
        {
            loarder.Setup(ws, hs, bmp, g);
        }
    }
}
