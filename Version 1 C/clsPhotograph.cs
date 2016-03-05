using System;
using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()]
    public class ClsPhotograph : ClsWork
    {
        private float _Width;
        private float _Height;
        private string _Type;

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
  
        }
    }
}
