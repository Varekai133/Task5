using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task4
{
    public class BlastFurnace
    {
        public int x;
        public int height;
        public int width;

        public int xheap;

        public BlastFurnace(int x, int height, int width, int xheap)
        {
            this.x = x;
            this.xheap = xheap;
            this.height = height;
            this.width = width;
        }

        public void DrawAll(int ws, int hs, Bitmap bmp, Graphics g)
        {
            DrawHeap(ws, hs, bmp, g);
            Draw(ws, hs, bmp, g);
        }

        public void Draw(int ws, int hs, Bitmap bmp, Graphics g)
        {
            using (g = Graphics.FromImage(bmp))
            {
                g.FillRectangle(Brushes.DarkBlue, 0, hs / 2 + 40, ws, 10);
                g.FillRectangle(Brushes.DarkRed, x, hs / 2, width, height);
            }
        }

        public void DrawHeap(int ws, int hs, Bitmap bmp, Graphics g)
        {
            if (xheap < 180)
            {
                using (g = Graphics.FromImage(bmp))
                {
                    g.FillRectangle(Brushes.YellowGreen, xheap, hs / 2 + 30, 10, 10);
                }
                xheap += 4;
            }
            else if (xheap < ws)
            {
                using (g = Graphics.FromImage(bmp))
                {
                    g.FillEllipse(Brushes.YellowGreen, xheap, hs / 2 + 30, 10, 10);
                }
                xheap += 4;
            }
            else xheap = 0;
        }
    }
}
