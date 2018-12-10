using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task4
{
    public interface IDraw
    {
        void Setup(int ws, int hs, Bitmap bmp, Graphics g);
    }
}
