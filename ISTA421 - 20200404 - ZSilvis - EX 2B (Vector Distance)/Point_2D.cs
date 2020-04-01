using System;
using System.Collections.Generic;
using System.Text;

namespace ISTA421___20200404___ZSilvis___EX_2B__Vector_Distance_
{
    public class Point_2D
    {
        private int _x;
        private int _y;
        public int X
        {
            get { return this._x; }
        }
        public int Y
        {
            get { return this._y; }
        }

        public Point_2D()
        {
            Random xR = new Random();
            this._x = xR.Next(1, 101);
            Random yR = new Random();
            this._y = yR.Next(1, 101);
        }
    }
}
