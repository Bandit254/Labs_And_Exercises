using System;

namespace ISTA421___20200404___ZSilvis___EX_2B__Vector_Distance_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vector Distance Calculations.\n");
            PointArray_2D Array2D = new PointArray_2D();
            PairArray_2D pair2DArray = new PairArray_2D(Array2D);
            DistPairArray_2D distPairArray2D = new DistPairArray_2D(pair2DArray);
           
            Sort2DPairsByDistance(distPairArray2D);
        }



        public static double EuclidianDist3D(Point_3D first3DPoint, Point_3D second3DPoint)
        {
            double eucDist3D = 0;
            double X_dist = first3DPoint.X - second3DPoint.X;
            double Y_dist = first3DPoint.Y - second3DPoint.Y;
            double Z_dist = first3DPoint.Z - second3DPoint.Z;
            eucDist3D = Math.Sqrt((Math.Pow(X_dist, 2) + Math.Pow(Y_dist, 2)+Math.Pow(Z_dist, 2)));
            return eucDist3D;
        }
        public static void Sort2DPairsByDistance(DistPairArray_2D distPairArray2D)
        {
            for (int i = 0; i < 4950; i++)
            {
                for (int j = 0; j < 4950; j++)
                {
                    if (distPairArray2D[i].distanceBetween > distPairArray2D[j].distanceBetween)
                    {
                        DistPair_2D tempDistPair = distPairArray2D[j];
                        distPairArray2D[j] = distPairArray2D[i];
                        distPairArray2D[i] = tempDistPair;
                    }
                }
            }
            int xPointOne = distPairArray2D[0].pair2D.pointOne.X;
            int yPointOne = distPairArray2D[0].pair2D.pointOne.Y;
            int xPointTwo = distPairArray2D[0].pair2D.pointTwo.X;
            int yPointTwo = distPairArray2D[0].pair2D.pointTwo.Y;
            double distanceBetween = distPairArray2D[0].distanceBetween;
            Console.WriteLine($"(The pair that is closest together is ({xPointOne}, {yPointOne}) and ({xPointTwo}, {yPointTwo}) and the distance between them is {distanceBetween}.");
        
        }           
        
    }
}
