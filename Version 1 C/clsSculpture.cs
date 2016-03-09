using System;
using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()] 
    public class ClsSculpture : ClsWork
    {
        private float _Weight;
        private string _Material;

        [NonSerialized()]
        private static FrmSculpture _SculptureDiaglog;

        public float Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }

        public string Material
        {
            get { return _Material; }
            set { _Material = value; }
        }

        public override void EditDetails()
        {
            if (_SculptureDiaglog == null)
            {
                _SculptureDiaglog = new FrmSculpture();
                _SculptureDiaglog.SetDetails(this); //SetDetails is found in frmWork.cs --> a business rule as part of the Work form as its a type of work. The others being photographs, sculptures
            }
        }
    }
}
