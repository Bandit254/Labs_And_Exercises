using System;
using System.Collections.Generic;
using System.Text;

namespace ISTA421___20200404___ZSilvis___EX_2B__Vector_Distance_
{
    public class DistPairArray_2D
    {
        public DistPair_2D[] distPairArray2D;
        public DistPairArray_2D(PairArray_2D pair2DArray)
        {
            this.distPairArray2D = new DistPair_2D[4950];
            for (int i = 0; i < 4950; i++)
            {
                distPairArray2D[i] = new DistPair_2D(pair2DArray[i]);
            }
        }
        public DistPair_2D this[int index]
        {
            get { return FindDistPair(index);}
            set 
            {
                if (FindDistPair(index)==null)
                {
                    AddDistPair(index, value);
                }
                else
                {
                    UpdateDistPair(index, value);
                }
            }
        }
        public DistPair_2D FindDistPair(int index)
        {
            DistPair_2D desiredDistPair = null;
            for (int i = 0; i < distPairArray2D.Length; i++)
            {
                if (i==index)
                {
                    desiredDistPair = distPairArray2D[i];
                }
            }
            return desiredDistPair;
        }

        public void AddDistPair(int index, DistPair_2D distPair_2D)
        {
            distPairArray2D[index] = distPair_2D;
        }
        public void UpdateDistPair(int index, DistPair_2D distPair_2D)
        {
            for (int i = 0; i < distPairArray2D.Length; i++)
            {
                if (i==index)
                {
                    distPairArray2D[i] = distPair_2D;
                    break;
                }
            }
        }
        /*
        
        */
    }
}
