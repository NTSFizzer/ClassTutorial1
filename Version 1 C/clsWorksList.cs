using System;
using System.Collections;
using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()] 
    public class ClsWorksList : ArrayList
    {
        private static ClsNameComparer theNameComparer = new ClsNameComparer();
        private static ClsDateComparer theDateComparer = new ClsDateComparer();

        private byte _SortOrder;

        public byte SortOrder
        {
            get
            {
                return _SortOrder;
            }

            set
            {
                _SortOrder = value;
            }
        }

        public void AddWork()
        {
            ClsWork lcWork = ClsWork.NewWork();
            if (lcWork != null)
            {
                Add(lcWork);
            }
        }
       
        public void DeleteWork(int prIndex)
        {
            if (prIndex >= 0 && prIndex < this.Count)
            {
                if (MessageBox.Show("Are you sure?", "Deleting work", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.RemoveAt(prIndex);
                }
            }
        }
        
        public void EditWork(int prIndex)
        {
            if (prIndex >= 0 && prIndex < this.Count)
            {
                ClsWork lcWork = (ClsWork)this[prIndex];
                lcWork.EditDetails();
            }
            else
            {
                MessageBox.Show("Sorry no work selected #" + Convert.ToString(prIndex));
            }
        }

        public decimal GetTotalValue()
        {
            decimal lcTotal = 0;
            foreach (ClsWork lcWork in this)
            {
                lcTotal += lcWork.GetValue();
            }
            return lcTotal;
        }

         public void SortByName()
         {
             Sort(theNameComparer);
         }
    
        public void SortByDate()
        {
            Sort(theDateComparer);
        }
    }
}
