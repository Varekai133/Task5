using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task4
{
    public class Smoke
    {
        public int x;
        public int y;
        public Color color;

        bool vis = true;
        
        Smoke[] smoke = new Smoke[5];

        public Smoke(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Smoke()
        {

        }

        public void Setup(int ws, int hs, Bitmap bmp, Graphics g)
        {
            if (vis)
                SetupSmoke(smoke);
            vis = false;
            UpdateSmoke(ws, hs, bmp, g);
            DrawSmoke(ws, hs, bmp, g);
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
                    smoke[i].y -= 2;
                else smoke[i].y = 130;
            }
        }

        public void DrawSmoke(int ws, int hs, Bitmap bmp, Graphics g)
        {
            using (g = Graphics.FromImage(bmp))
            {
                for (int i = 0; i < 5; i++)
                {
                    g.FillEllipse(new SolidBrush(color), smoke[i].x, smoke[i].y, 10, 10);
                }
            }
        }
    }
}
