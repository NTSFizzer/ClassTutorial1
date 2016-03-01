using System;
using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()] 
    public class ClsPainting : ClsWork
    {
        private float theWidth;
        private float theHeight;
        private string theType;

        [NonSerialized()]
        private static FrmPainting paintDialog;

        public override void EditDetails()
        {
            if (paintDialog == null)
            {
                paintDialog = new FrmPainting();
            }
            paintDialog.SetDetails(_Name, theDate, theValue, theWidth, theHeight, theType);
            if(paintDialog.ShowDialog() == DialogResult.OK)
            {
               paintDialog.GetDetails(ref _Name, ref theDate, ref theValue, ref theWidth, ref theHeight, ref theType);
            }
        }
    }
}
