using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Version_1_C
{
    public partial class FrmPhotograph : Version_1_C.FrmWork
    {

        public FrmPhotograph()
        {
            InitializeComponent();
        }

        protected override void UpdateForm()
        {
            base.UpdateForm();
            ClsPhotograph lcWork = (ClsPhotograph)_Work;
            txtName.Text = lcWork.Name.ToString();
           

        }


        //protected override void UpdateForm()
        //{
        //    base.UpdateForm();
        //    ClsPainting lcWork = (ClsPainting)_Work;
        //    txtWidth.Text = lcWork.Width.ToString();
        //    txtHeight.Text = lcWork.Height.ToString();
        //    txtType.Text = lcWork.Type;
        //}

    }
}

