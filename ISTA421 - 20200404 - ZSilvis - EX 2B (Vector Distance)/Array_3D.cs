using System;
using System.Collections.Generic;
using System.Text;

namespace ISTA421___20200404___ZSilvis___EX_2B__Vector_Distance_
{
    public class Array_3D
    {
        public Point_3D[] Array3D = new Point_3D[100];

        public Array_3D()
        {
            for (int i = 0; i < 1000; i++)
            {

                Array3D[i] = new Point_3D();
            }
        }
    }
}
