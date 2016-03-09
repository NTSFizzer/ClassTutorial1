using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Version_1_C
{
    public partial class FrmSculpture : Version_1_C.FrmWork
    {        
        public FrmSculpture()
        {
            InitializeComponent();
        }

        protected override void UpdateForm()
        //this handles the Sculpture specific data
        {
            base.UpdateForm();
            ClsSculpture lcWork = (ClsSculpture)_Work;
            txtWeight.Text = lcWork.Weight.ToString();
            txtMaterial.Text = lcWork.Material;
        }

        protected override void PushData()
        //this handles the Scuplture specific data
        {
            base.PushData();
            ClsSculpture lcWork = (ClsSculpture)_Work;
            lcWork.Weight = Single.Parse(txtWeight.Text);
            lcWork.Material = txtMaterial.Text;
        }
    }
}

