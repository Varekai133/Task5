using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Task4
{
    public class Decorator : IDraw
    {
        Graphics g;
        Bitmap bmp;
        Thread thrl, thrw, thrf;

        int ws, hs;

        Worker worker = new Worker(0, 5);
        BlastFurnace blastfurnace = new BlastFurnace(170, 100, 40, 0);
        LoarderForFurnace loarder = new LoarderForFurnace(0, true, 7, 0.1);
        
        public Decorator(int ws, int hs, Bitmap bmp, Graphics g)
        {
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
        }

        public void Setup(int ws, int hs, Bitmap bmp, Graphics g)
        {
            worker.Setup(ws, hs, bmp, g);
            blastfurnace.Setup(ws, hs, bmp, g);
            loarder.Setup(ws, hs, bmp, g);
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
