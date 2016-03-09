using System;
using System.Collections.Generic;

namespace Version_1_C
{
    class ClsPriceComparer : IComparer<ClsWork>
    {
        public int Compare(ClsWork prValueX, ClsWork prValueY)
        {
            ClsWork lcValueX = (ClsWork)prValueX;
            ClsWork lcValueY = (ClsWork)prValueY;

            return prValueX.Value.CompareTo(prValueY.Value);
        }
    }
}