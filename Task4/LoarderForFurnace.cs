using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task4
{
    public class LoarderForFurnace : Loarder, IDraw
    {
        public int speed;
        public int x;
        public bool isReady;
        public double prob;
        public bool broke;

        public delegate void NoMaterials();
        public event NoMaterials NoMaterial;

        public LoarderForFurnace(int x, bool isReady, int speed, double prob)
        {
            this.x = x;
            this.speed = speed;
            this.isReady = isReady;
            this.prob = prob;
            NoMaterial = NoMater;
            broke = false;
        }

        public void NoMater()
        {
            isReady = false;
        }

        public void Setup(int ws, int hs, Bitmap bmp, Graphics g)
        {
            Dangerous(ws, hs, bmp, g);
        }

        public void Draw(int ws, int hs, Bitmap bmp, Graphics g)
        {
            using (g = Graphics.FromImage(bmp))
            {
                g.FillRectangle(Brushes.Green, x, hs / 2 + 70, 30, 30);
                g.FillRectangle(Brushes.Green, x + 30, hs / 2 + 90, 10, 10);
                g.FillEllipse(Brushes.Black, x, hs / 2 + 95, 10, 10);
                g.FillEllipse(Brushes.Black, x + 20, hs / 2 + 95, 10, 10);
            }
        }

        public void Move(int ws)
        {
            //if (broke)
            //    return;
            if (x < ws)
                x += speed;
            else
            {
                x = 0;
                isReady = true;
            }
        }

        public double Probability()
        {
            Random rnd = new Random();
            return rnd.NextDouble();
        }

        public void Dangerous(int ws, int hs, Bitmap bmp, Graphics g)
        {
            if (isReady)
                prob = Probability();
            if (prob > 0.9)
            {
                broke = true;
                NoMaterial();
                Move(ws);
                Draw(ws, hs, bmp, g);
            }
            
        }
    }
}
