using System.Collections.Generic;

namespace Version_1_C
{
    class ClsDateComparer : IComparer<ClsWork>
    {
        public int Compare(ClsWork x, ClsWork y)
        {
            ClsWork lcDateX = (ClsWork)x;
            ClsWork lcDateY = (ClsWork)y;

            return x.Date.CompareTo(y.Date);
        }
    }
}