using System;
using System.Collections.Generic;
using System.Text;

namespace ISTA421___20200404___ZSilvis___EX_2B__Vector_Distance_
{
    public class Point_3D
    {
        private int _x;
        private int _y;
        private int _z;
        public int X
        {
            get { return this._x; }
        }
        public int Y
        {
            get { return this._y; }
        }
        public int Z
        {
            get { return this._z; }
        }

        public Point_3D()
        {
            Random xR = new Random();
            this._x = xR.Next(1, 1001);
            Random yR = new Random();
            this._y = yR.Next(1, 1001);
            Random zR = new Random();
            this._z = zR.Next(1, 1001);
        }
    }
}
