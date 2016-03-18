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
        private static FrmPainting _PaintDialog;

        public float Width
        {
            get { return _Width; }
            set { _Width = value; }
        }

        public float Height
        {
            get { return _Height; }
            set { _Height = value; }
        }

        public string Type
        {
            get { return _Type;}
            set { _Type = value; }
        }

        public override void EditDetails()
        {
            /* Matthias: Check your original code here.  You were calling SetDetails(), and thereby starting the dialog,
                only if the dialog is null, which is the exception.  See #10l (Task List Stage1)

            if (_PaintDialog == null)
            {
                _PaintDialog = new FrmPainting();
                _PaintDialog.SetDetails(this); //SetDetails is found in frmWork.cs --> a business rule as part of the Work form as its a type of work. The others being photographs, sculptures
            }
              Matthias: like this (below).  Fix this for photo and sculpture also.
            */

            if (_PaintDialog == null)
                _PaintDialog = new FrmPainting();

            _PaintDialog.SetDetails(this); //SetDetails is found in frmWork.cs --> a business rule as part of the Work form as its a type of work. The others being photographs, sculptures
         
        }
    }
}
