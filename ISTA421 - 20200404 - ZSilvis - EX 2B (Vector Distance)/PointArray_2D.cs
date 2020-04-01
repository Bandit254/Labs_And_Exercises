using System;
using System.Collections.Generic;
using System.Text;

namespace ISTA421___20200404___ZSilvis___EX_2B__Vector_Distance_
{
    public class PointArray_2D
    {
        public Point_2D[] Array2D;

        public PointArray_2D()
        {
            this.Array2D = new Point_2D[100];
            for (int i = 0; i < 100; i++)
            {
                Point_2D point = new Point_2D();
                Array2D[i] = point;
            }
        }

        public Point_2D this [int index]
        {
            get { return FindPoint(index); }
            set
            {
                if (FindPoint(index)==null)
                {
                    AddPoint(index, value);
                }
                else
                {
                    UpdatePoint(index, value);
                }
            }
        }

        public Point_2D FindPoint(int index)
        {
            Point_2D desiredPoint=null;
            for (int i = 0; i < 100; i++)
            {
                if (i==index)
                {
                    desiredPoint = Array2D[index];
                }
                else
                {
                    desiredPoint = null;
                }
            }
            return desiredPoint;
        }
        public void AddPoint(int index, Point_2D point_2D)
        {
            Array2D[index] = point_2D;
        }
        public void UpdatePoint(int index, Point_2D point_2D)
        {
            for (int i = 0; i < 100; i++)
            {
                if (i==index)
                {
                    Array2D[index] = point_2D;
                    break;
                }
            }
        }
    }
}
