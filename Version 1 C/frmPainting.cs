using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Version_1_C
{
    public partial class FrmPainting : Version_1_C.FrmWork
    {

        public FrmPainting()
        {
            InitializeComponent();
        }

        protected override void UpdateForm()
            //this handles the painting specific data
        {
            base.UpdateForm();
            ClsPainting lcWork = (ClsPainting) _Work;
            txtWidth.Text = lcWork.Width.ToString();
            txtHeight.Text = lcWork.Height.ToString();
            txtType.Text = lcWork.Type;
        }

        protected override void PushData()
            //this handles the Painting specific data
        {
            base.PushData();
            ClsPainting lcWork = (ClsPainting)_Work;
            lcWork.Width = Single.Parse(txtWidth.Text);
            lcWork.Height = Single.Parse(txtHeight.Text);
            lcWork.Type = txtType.Text;
        }
    }
}

