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

        public int xheap;

        public BlastFurnace(int x, int height, int width, int xheap)
        {
            this.x = x;
            this.xheap = xheap;
            this.height = height;
            this.width = width;
        }

        public void Setup(int ws, int hs, Bitmap bmp, Graphics g)
        {
            UpdateHeap(ws, hs, bmp, g);
            DrawHeap(ws, hs, bmp, g);
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
