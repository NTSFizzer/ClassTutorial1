using System;
using System.Collections.Generic;

namespace Version_1_C
{
    class ClsNameComparer : IComparer<ClsWork>
    {
        public int Compare(ClsWork x, ClsWork y)
        {
            ClsWork lcNameX = (ClsWork)x;
            ClsWork lcNameY = (ClsWork)y;

            return x.Name.CompareTo(y.Name);
        }
    }
}
