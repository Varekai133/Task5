using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task4
{
    public class BlastFurnace : IDraw
    {
        public int x;
        public int height;
        public int width;

        bool vis = true;

        public int xheap;
        Smoke[] smoke = new Smoke[5];

        public BlastFurnace(int x, int height, int width, int xheap)
        {
            this.x = x;
            this.xheap = xheap;
            this.height = height;
            this.width = width;
        }

        public void SetupSmoke(Smoke[] smoke)
        {
            smoke[0] = new Smoke(200, 130);
            smoke[1] = new Smoke(170, 160);
            smoke[2] = new Smoke(180, 130);
            smoke[3] = new Smoke(190, 140);
            smoke[4] = new Smoke(185, 150);
        }

        public void UpdateSmoke(int ws, int hs, Bitmap bmp, Graphics g)
        {
            for (int i = 0; i < 5; i++)
            {
                if (smoke[i].y > 0)
                    smoke[i].y -=2;
                else smoke[i].y = 130;
            }
        }

        public void DrawSmoke(int ws, int hs, Bitmap bmp, Graphics g)
        {
            using (g = Graphics.FromImage(bmp))
            {
                for (int i = 0; i < 5; i++)
                {
                    g.FillEllipse(Brushes.Gray, smoke[i].x, smoke[i].y, 10, 10);
                }
            }
        }

        public void Setup(int ws, int hs, Bitmap bmp, Graphics g)
        {
            UpdateHeap(ws, hs, bmp, g);
            DrawHeap(ws, hs, bmp, g);
            if (vis)
                SetupSmoke(smoke);
            vis = false;
            UpdateSmoke(ws, hs, bmp, g);
            DrawSmoke(ws, hs, bmp, g);
            DrawFurnace(ws, hs, bmp, g);
        }

        public void UpdateHeap(int ws, int hs, Bitmap bmp, Graphics g)
        {
            if (xheap < 180)
            {
                xheap += 4;
            }
            else if (xheap < ws)
            {
                xheap += 4;
            }
            else xheap = 0;
        }

        public void DrawHeap(int ws, int hs, Bitmap bmp, Graphics g)
        {
            using (g = Graphics.FromImage(bmp))
                g.FillRectangle(Brushes.YellowGreen, xheap, hs / 2 + 30, 10, 10);
        }

        public void DrawFurnace(int ws, int hs, Bitmap bmp, Graphics g)
        {
            using (g = Graphics.FromImage(bmp))
            {
                g.FillRectangle(Brushes.DarkBlue, 0, hs / 2 + 40, ws, 10);
                g.FillRectangle(Brushes.DarkRed, x, hs / 2, width, height);
            }
        }
    }
}
