using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task4
{
    public interface Loarder
    {
        double Probability();
        void Dangerous(int ws, int hs, Bitmap bmp, Graphics g);
    }
}
