using System;
using System.Collections;

namespace Version_1_C
{
    class ClsDateComparer : IComparer
    {
        public int Compare(Object x, Object y)
        {
            ClsWork lcWorkX = (ClsWork)x;
            ClsWork lcWorkY = (ClsWork)y;
            DateTime lcDateX = lcWorkX.GetDate();
            DateTime lcDateY = lcWorkY.GetDate();

            return lcDateX.CompareTo(lcDateY);
        }
    }
}
