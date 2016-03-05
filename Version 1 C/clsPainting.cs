using System;
using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()] 
    public class ClsPainting : ClsWork
    {
        private float _Width;
        private float _Height;
        private string _Type;

        [NonSerialized()]
        private static FrmPainting paintDialog;

        public float Width
        {
            get
            {
                return _Width;
            }

            set
            {
                _Width = value;
            }
        }

        public float Height
        {
            get
            {
                return _Height;
            }

            set
            {
                _Height = value;
            }
        }

        public string Type
        {
            get
            {
                return _Type;
            }

            set
            {
                _Type = value;
            }
        }

        public override void EditDetails()
        {
            //if (paintDialog == null)
            //{
            //    paintDialog = new FrmPainting();
            //}
            //paintDialog.SetDetails(_Name, theDate, theValue, theWidth, theHeight, theType);
            //if (paintDialog.ShowDialog() == DialogResult.OK)
            //{
            //    paintDialog.GetDetails(ref _Name, ref theDate, ref theValue, ref theWidth, ref theHeight, ref theType);
            //}
        }
    }
}
