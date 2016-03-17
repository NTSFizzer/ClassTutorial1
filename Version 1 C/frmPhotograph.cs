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
            //txtName.Text = lcWork.Name.ToString();
            //txtCreation.Text = lcWork.Date.ToShortDateString();
            //txtValue.Text = lcWork.Value.ToString();
            txtWidth.Text = lcWork.Width.ToString();
            txtHeight.Text = lcWork.Height.ToString();
            txtType.Text = lcWork.Type;
        }

        protected override void PushData()
        //this handles the Photograph specific data
        {
            base.PushData();
            ClsPhotograph lcWork = (ClsPhotograph)_Work;
            //lcWork.Name = txtName.Text;
            //lcWork.Date = DateTime.Parse(txtCreation.Text);
            //lcWork.Value = Decimal.Parse(txtValue.Text);
            lcWork.Width = Single.Parse(txtWidth.Text);
            lcWork.Height = Single.Parse(txtHeight.Text);
            lcWork.Type = txtType.Text;
        }
    }
}

