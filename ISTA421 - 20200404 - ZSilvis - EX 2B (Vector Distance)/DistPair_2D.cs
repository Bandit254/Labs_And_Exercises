using System;
using System.Collections.Generic;
using System.Text;

namespace ISTA421___20200404___ZSilvis___EX_2B__Vector_Distance_
{
    public class DistPair_2D
    {
        public Pair_2D pair2D;
        public  double distanceBetween;
        public DistPair_2D(Pair_2D pair2D)
        {
            this.pair2D = pair2D;
            double distanceBetween = EuclidianDist2D(pair2D);
        }

        public double EuclidianDist2D(Pair_2D pair_2D)
        {
            double X_dist = pair2D.pointOne.X - pair2D.pointTwo.X;
            double Y_dist = pair2D.pointOne.Y - pair2D.pointTwo.Y;
            double distanceBetween = Math.Sqrt((Math.Pow(X_dist, 2) + Math.Pow(Y_dist, 2)));
            return distanceBetween;
        }
    }
}
