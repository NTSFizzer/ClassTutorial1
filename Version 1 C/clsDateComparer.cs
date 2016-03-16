using System.Collections.Generic;

namespace Version_1_C
{
    class ClsDateComparer : IComparer<ClsWork>
    {
        public int Compare(ClsWork prDateX, ClsWork prDateY)
        {
            ClsWork lcDateX = (ClsWork)prDateX;
            ClsWork lcDateY = (ClsWork)prDateY;

            return prDateX.Date.CompareTo(prDateY.Date);
        }
    }
}