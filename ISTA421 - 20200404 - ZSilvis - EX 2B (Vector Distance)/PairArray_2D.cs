using System;
using System.Collections.Generic;
using System.Text;

namespace ISTA421___20200404___ZSilvis___EX_2B__Vector_Distance_
{
    public class PairArray_2D
    {
        public Pair_2D[] pair2DArray;
        public PairArray_2D(PointArray_2D Array2D)
        {
            this.pair2DArray = new Pair_2D[4950];
            for (int i = 0; i < 4950; i++)
            {
                for (int j = 0; j < 4950; j++)
                {
                  pair2DArray[i] = new Pair_2D(Array2D[i], Array2D[j]);
                }
            }
        }

        public Pair_2D this[int index]
        {
            get { return FindPair(index); }
            set
            {
                if (FindPair(index) == null)
                {
                    AddPair(index, value);
                }
                else
                {
                    UpdatePair(index, value);
                }
            }
        }

        public Pair_2D FindPair(int index)
        {
            Pair_2D desiredPair = null;
            for (int i = 0; i < 4950; i++)
            {
                if (i == index)
                {
                    desiredPair = pair2DArray[index];
                }
            }
            return desiredPair;
        }
        public void AddPair(int index, Pair_2D pair2D)
        {
            pair2DArray[index] = pair2D;
        }
        public void UpdatePair(int index, Pair_2D pair2D)
        {
            for (int i = 0; i < 4950; i++)
            {
                if (i == index)
                {
                    pair2DArray[index] = pair2D;
                }
            }
        }
    }
}
