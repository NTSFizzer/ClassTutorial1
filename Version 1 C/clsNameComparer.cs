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
            string lcNameX = workClassX.Name();
            string lcNameY = workClassY.Name();

            return lcNameX.CompareTo(lcNameY);
        }
    }
}
