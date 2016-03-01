using System;
using System.Collections;

namespace Version_1_C
{
    class ClsNameComparer : IComparer
    {
        public int Compare(Object x, Object y)
        {
            ClsWork workClassX = (ClsWork)x;
            ClsWork workClassY = (ClsWork)y;
            string lcNameX = workClassX.GetName();
            string lcNameY = workClassY.GetName();

            return lcNameX.CompareTo(lcNameY);
        }
    }
}
