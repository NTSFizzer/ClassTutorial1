using System;
using System.Collections.Generic;

namespace Version_1_C
{
    class ClsNameComparer : IComparer<ClsWork>
    {
        public int Compare(ClsWork prNameX, ClsWork prNameY)
        {
            ClsWork lcNameX = (ClsWork)prNameX;
            ClsWork lcNameY = (ClsWork)prNameY;

            return prNameX.Name.CompareTo(prNameY.Name);
        }
    }
}
