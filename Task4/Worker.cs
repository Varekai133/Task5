using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task4
{
    public class Worker : IDraw
    {
        public int x;
        public int speed;

        public Worker(int x, int speed)
        {
            this.x = x;
            this.speed = speed;
        }

        public void Setup(int ws, int hs, Bitmap bmp, Graphics g)
        {
            Draw(ws, hs, bmp, g);
            Update(ws);
        }

        public void Draw(int ws, int hs, Bitmap bmp, Graphics g)
        {
            using (g = Graphics.FromImage(bmp))
            {
                g.FillEllipse(Brushes.Coral, x, hs - 70, 20, 40);
                g.FillEllipse(Brushes.Coral, x, hs - 85, 20, 20);
            }
        }

        public void Update(int ws)
        {
            if (x < ws)
                x += speed;
            else x = 0;
        }
    }
}
