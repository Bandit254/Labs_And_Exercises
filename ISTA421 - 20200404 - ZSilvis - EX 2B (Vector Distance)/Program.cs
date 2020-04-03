using System;
using System.Collections.Generic;

namespace ISTA421___20200404___ZSilvis___EX_2B__Vector_Distance_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vector Distance Calculations.\n");
            //I wrote this algorithm for the 3D points after Chris and Danny explained why my original algorithm was getting bogged down.
            //The primary reason the original algorithm wouldn't run more than 200 3D points was because I was creating and holding
            //multiple collections that contained all 990,000 possible pairs of points and holding them in memory as I tried to sort the
            //collection to find the smallest distance apart. Once Chris and Danny explained that I only needed to save the distance and index
            //of each calculation that resulted in a smaller distance than the current smallest distance, then I understood how to write the 
            //algorithm much more efficiently.
            List<Point3> pointList3dStruct = new List<Point3>();
            for (int i = 0; i < 1000; i++)
            {
                Random xR = new Random();
                int x3 = xR.Next(1, 1001);
                Random yR = new Random();
                int y3 = yR.Next(1, 1001);
                Random zR = new Random();
                int z3 = zR.Next(1, 1001);
                pointList3dStruct.Add(new Point3(x3, y3, z3));
            }
            double minDist3 = 200;
            int indexPoint1 = 0;
            int indexPoint2 = 0;
            for (int i = 0; i < pointList3dStruct.Count; i++)
            {
                for (int j = 0; j < pointList3dStruct.Count; j++)
                {
                    if (i!=j)
                    {
                        double currDist = StructDist3DPoints(pointList3dStruct[i], pointList3dStruct[j]);
                        if (currDist<minDist3)
                        {
                            minDist3 = currDist;
                            indexPoint1 = i;
                            indexPoint2 = j;
                        }
                    }
                }
            }
            Console.WriteLine($"The closest two 3D points are at index {indexPoint1}: ({pointList3dStruct[indexPoint1].x3}, {pointList3dStruct[indexPoint1].y3}, {pointList3dStruct[indexPoint1].z3}) and index {indexPoint2}: ({pointList3dStruct[indexPoint2].x3}, {pointList3dStruct[indexPoint2].y3}, {pointList3dStruct[indexPoint2].z3}) with a distance apart of {minDist3}.");
            //I left my 2D algorithm in its original form, to show how my approach to this problem evolved over time.
            //I was originally focused too much on creating the object of a collection of points, so my first approach was to 
            //make classes of all points, pairs, distance-pairs, etc. Although this is highly inefficient, it works for the small
            //number of 2D points required by the exercise.
            List<Point> pointList = new List<Point>();
            for (int i = 0; i < 100; i++)
            {
                pointList.Add(new Point());
            }
            List<Pair> pairList = new List<Pair>();
            for (int i = 0; i < pointList.Count; i++)
            {
                for (int j = 0; j < pointList.Count; j++)
                {
                    if (i!=j)
                    {
                        pairList.Add(new Pair(pointList[i], pointList[j]));
                    }
                }
            }
            DistPair[] arrayDistPair = new DistPair[pairList.Count];
            for (int i = 0; i < pairList.Count; i++)
            {
                double dist = DistanceBetweenPoints(pairList[i]);
                arrayDistPair[i] = new DistPair(dist, pairList[i]);
            }
            for (int i = 0; i < arrayDistPair.Length; i++)
            {
                for (int j = i+1; j < arrayDistPair.Length; j++)
                {
                    if (arrayDistPair[i].dist>arrayDistPair[j].dist)
                    {
                        DistPair temp = arrayDistPair[j];
                        arrayDistPair[j] = arrayDistPair[i];
                        arrayDistPair[i] = temp;
                    }
                }
            }
            Console.WriteLine($"The closest 2D points are ({arrayDistPair[0].pair.pointOne.X},{arrayDistPair[0].pair.pointOne.Y}) and ({arrayDistPair[0].pair.pointTwo.X},{arrayDistPair[0].pair.pointTwo.Y}) with a distance of {arrayDistPair[0].dist}.\n");
            Console.WriteLine($"The farthest 2D points are ({arrayDistPair[arrayDistPair.Length-1].pair.pointOne.X}, {arrayDistPair[arrayDistPair.Length - 1].pair.pointOne.Y}) and ({arrayDistPair[arrayDistPair.Length - 1].pair.pointTwo.X}, {arrayDistPair[arrayDistPair.Length - 1].pair.pointTwo.Y}) with a distance of {arrayDistPair[arrayDistPair.Length - 1].dist}.\n");

            Console.WriteLine("\nThis is the end of the code that should be considered for a grade. All following code is presented simply to show how many iterations I went through to get to a correct solution, and because I can't bear to delete it all after having spent so much time on it.\n");

            //Here is my first attempt at the 3D points, using classes as with the 2D approach (kept it to a small number so it would run):
            List<Point3D> pointList3d = new List<Point3D>();
            for (int i = 0; i < 100; i++)
            {
                pointList3d.Add(new Point3D());
            }
            List<Pair3D> pairList3d = new List<Pair3D>();
            for (int i = 0; i < pointList3d.Count; i++)
            {
                for (int j = 0; j < pointList3d.Count; j++)
                {
                    if (i!=j)
                    {
                        pairList3d.Add(new Pair3D(pointList3d[i], pointList3d[j]));
                    }
                }
            }
            DistPair3D[] arrayDistPair3d = new DistPair3D[pairList3d.Count];
            for (int i = 0; i < pairList3d.Count; i++)
            {
                double dist3d = DistanceBetweenPoints3D(pairList3d[i]);
                arrayDistPair3d[i] = new DistPair3D(dist3d, pairList3d[i]);
            }
            for (int i = 0; i < arrayDistPair3d.Length; i++)
            {
                for (int j = i+1; j < arrayDistPair3d.Length; j++)
                {
                    if (arrayDistPair3d[i].dist3d > arrayDistPair3d[j].dist3d)
                    {
                        DistPair3D temp = arrayDistPair3d[j];
                        arrayDistPair3d[j] = arrayDistPair3d[i];
                        arrayDistPair3d[i] = temp;
                    }
                }
            }
            Console.WriteLine($"The closest 3D points are ({arrayDistPair3d[0].pair3d.pointOne3d.X3D}, {arrayDistPair3d[0].pair3d.pointOne3d.Y3D}, {arrayDistPair3d[0].pair3d.pointOne3d.Z3D}) and ({arrayDistPair3d[0].pair3d.pointTwo3d.X3D}, {arrayDistPair3d[0].pair3d.pointTwo3d.Y3D}, {arrayDistPair3d[0].pair3d.pointTwo3d.Z3D}) with a distance of {arrayDistPair3d[0].dist3d}.");
            Console.WriteLine($"The farthest 3D points are ({arrayDistPair3d[arrayDistPair3d.Length - 1].pair3d.pointOne3d.X3D}, {arrayDistPair3d[arrayDistPair3d.Length - 1].pair3d.pointOne3d.Y3D}, {arrayDistPair3d[arrayDistPair3d.Length - 1].pair3d.pointOne3d.Z3D}) and ({arrayDistPair3d[arrayDistPair3d.Length - 1].pair3d.pointTwo3d.X3D}, {arrayDistPair3d[arrayDistPair3d.Length - 1].pair3d.pointTwo3d.Y3D}, {arrayDistPair3d[arrayDistPair3d.Length - 1].pair3d.pointTwo3d.Z3D}) with a distance of {arrayDistPair3d[arrayDistPair3d.Length - 1].dist3d}.");
            //Using a struct instead of a class to model the points/pairs to see if that would enable my computer to iterate through all 1000 3D point (it didn't improve performance):
            /*
            List<Point3> pointList3dStruct = new List<Point3>();
            for (int i = 0; i < 1000; i++)
            {
                Random xR = new Random();
                int x3 = xR.Next(1, 1001);
                Random yR = new Random();
                int y3 = yR.Next(1, 1001);
                Random zR = new Random();
                int z3 = zR.Next(1, 1001);
                pointList3dStruct.Add(new Point3(x3, y3, z3));
            }
            List<Pair3> pairList3DStruct = new List<Pair3>();
            for (int i = 0; i < pointList3dStruct.Count; i++)
            {
                for (int j = 0; j < pointList3dStruct.Count; j++)
                {
                    if (i!=j)
                    {
                        pairList3DStruct.Add(new Pair3(pointList3dStruct[i], pointList3dStruct[j]));
                    }
                }
            }
            DistPair3[] distPairArray3DStruct = new DistPair3[pairList3DStruct.Count];
            for (int i = 0; i < pairList3DStruct.Count; i++)
            {
                double dist3 = StructDist3D(pairList3DStruct[i]);
                distPairArray3DStruct[i] = new DistPair3(pairList3DStruct[i], dist3);
            }
            for (int i = 0; i < distPairArray3DStruct.Length; i++)
            {
                for (int j = i+1; j < distPairArray3DStruct.Length; j++)
                {
                    if (distPairArray3DStruct[i].dist3> distPairArray3DStruct[j].dist3)
                    {
                        DistPair3 temp = distPairArray3DStruct[j];
                        distPairArray3DStruct[j] = distPairArray3DStruct[i];
                        distPairArray3DStruct[i] = temp;
                    }
                }
            }
            Console.WriteLine($"The closest 3D pair of points is ({distPairArray3DStruct[0].pair3.point1.x3}, {distPairArray3DStruct[0].pair3.point1.y3}, {distPairArray3DStruct[0].pair3.point1.z3}) and " +
                $"({distPairArray3DStruct[0].pair3.point2.x3}, {distPairArray3DStruct[0].pair3.point2.y3}, {distPairArray3DStruct[0].pair3.point2.z3}) with a distance apart of {distPairArray3DStruct[0].dist3}.\n");
            Console.WriteLine($"The farthest 3D pair of points is ({distPairArray3DStruct[distPairArray3DStruct.Length-1].pair3.point1.x3}, {distPairArray3DStruct[distPairArray3DStruct.Length-1].pair3.point1.y3}, {distPairArray3DStruct[distPairArray3DStruct.Length-1].pair3.point1.z3}) and " +
                $"({distPairArray3DStruct[distPairArray3DStruct.Length-1].pair3.point2.x3}, {distPairArray3DStruct[distPairArray3DStruct.Length-1].pair3.point2.y3}, {distPairArray3DStruct[distPairArray3DStruct.Length-1].pair3.point2.z3}) with a distance apart of {distPairArray3DStruct[distPairArray3DStruct.Length-1].dist3}.\n");
            */
        }
        //2D Point Class:
        public class Point
        {
            private int _x;
            private int _y;
            public int X
            {
                get { return this._x; }
                set { this._x = value; }
            }
            public int Y
            {
                get { return this._y; }
                set { this._y = value; }
            }
            public Point()
            {
                Random xR = new Random();
                this._x = xR.Next(1, 101);
                Random yR = new Random();
                this._y = yR.Next(1, 101);
            }
        }
        //2D pair of points class:
        public class Pair
        {
            public Point pointOne;
            public Point pointTwo;
            public Pair()
            {
                this.pointOne = new Point();
                this.pointTwo = new Point();
            }
            public Pair(Point pointOne, Point pointTwo)
            {
                this.pointOne = pointOne;
                this.pointTwo = pointTwo;
            }
        }
        //Distance Method using a pair of 2D points object (class):
        public static double DistanceBetweenPoints(Pair pair)
        {
            double distance = Math.Sqrt((Math.Pow((pair.pointOne.X - pair.pointTwo.X), 2) + Math.Pow((pair.pointOne.Y - pair.pointTwo.Y), 2)));
            return distance;
        }
        //2D object that represents a pair of points and the distance between them as a single entity:
        public class DistPair
        {
            public double dist;
            public Pair pair;
            public DistPair(double dist, Pair pair)
            {
                this.dist = dist;
                this.pair = pair;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////    
        //3D Point object (class):
        public class Point3D
        {
            private int _x3d;
            private int _y3d;
            private int _z3d;
            public int X3D
            {
                get { return this._x3d; }
                set { this._x3d = value; }
            }
            public int Y3D
            {
                get { return this._y3d; }
                set { this._y3d = value; }
            }
            public int Z3D
            {
                get { return this._z3d; }
                set { this._z3d = value; }
            }
            public Point3D()
            {
                Random xR3D = new Random();
                this._x3d = xR3D.Next(1, 1001);
                Random yR3D = new Random();
                this._y3d = yR3D.Next(1, 1001);
                Random zR3D = new Random();
                this._z3d = zR3D.Next(1, 1001);
            }
        }
        //Pair of 3D points:
        public class Pair3D
        {
            public Point3D pointOne3d;
            public Point3D pointTwo3d;
            
            public Pair3D()
            {
                this.pointOne3d = new Point3D();
                this.pointTwo3d = new Point3D();
                
            }
            public Pair3D(Point3D pointOne3d, Point3D pointTwo3d)
            {
                this.pointOne3d = pointOne3d;
                this.pointTwo3d = pointTwo3d;
            }
        }
        //Distance method that accepts a pair of 3D points object:
        public static double DistanceBetweenPoints3D(Pair3D pair3d)
        {
            double dist3d = Math.Sqrt((Math.Pow((pair3d.pointOne3d.X3D - pair3d.pointTwo3d.X3D), 2) + Math.Pow((pair3d.pointOne3d.Y3D - pair3d.pointTwo3d.Y3D), 2)) + Math.Pow((pair3d.pointOne3d.Z3D - pair3d.pointTwo3d.Z3D), 2));
            return dist3d;
        }
        //Object representing the pair of 3D points and the distance between them:
        public class DistPair3D
        {
            public double dist3d;
            public Pair3D pair3d;
            public DistPair3D(double dist3d, Pair3D pair3d)
            {
                this.dist3d = dist3d;
                this.pair3d = pair3d;
            }
        }
        //Using a struct to model a 3D point after realizing that using classes was way more memory than I needed:
        public struct Point3
        {
            public int x3;
            public int y3;
            public int z3;
            public Point3(int x, int y, int z)
            {
                this.x3 = x;
                this.y3 = y;
                this.z3 = z;
            }
        }
        //Using a struct to model a pair of 3D points (which even this is overkill, I realize that now):
        public struct Pair3
        {
            public Point3 point1;
            public Point3 point2;
            public Pair3(Point3 point1, Point3 point2)
            {
                this.point1 = point1;
                this.point2 = point2;
            }
        }
        //Struct of 3D pairs and the distance between them:
        public struct DistPair3
        {
            public Pair3 pair3;
            public double dist3;
            public DistPair3(Pair3 pair3, double dist3)
            {
                this.pair3 = pair3;
                this.dist3 = dist3;
            }
        }
        //Re-writing the distance method to handle structs instead of classes:
        public static double StructDist3D(Pair3 pair3)
        {
            double dist3 = Math.Sqrt((
                                     Math.Pow((pair3.point1.x3 - pair3.point2.x3), 2) +
                                     Math.Pow((pair3.point1.y3 - pair3.point2.y3), 2) +
                                     Math.Pow((pair3.point1.z3 - pair3.point2.z3), 2)
                                     ));
            return dist3;
        }
        public static double StructDist3DPoints(Point3 point1, Point3 point2)
        {
            double dist3 = Math.Sqrt((
                                     Math.Pow((point1.x3 - point2.x3), 2) +
                                     Math.Pow((point1.y3 - point2.y3), 2) +
                                     Math.Pow((point1.z3 - point2.z3), 2)
                                     ));
            return dist3;
        }
    }
}
