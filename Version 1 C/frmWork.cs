using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Version_1_C
{
    public partial class FrmWork : Form
    {

        public FrmWork()
        {
            InitializeComponent();
        }

        protected ClsWork _Work; //protected variable of type ClsWork == _Work


        protected virtual void UpdateForm()                     //this fills in the textboxes with data from clsWork
            //protected so that the derived forms (frmPainting, frmSculputure, etc can use them).
            //Virtual so the form can be overriden by the other derived forms
        {
            txtName.Text = _Work.Name;
            txtCreation.Text = _Work.Date.ToShortDateString();
            txtValue.Text = _Work.Value.ToString();
        }

        protected virtual void PushData()                       // sends the contents of the textboxes back to clsWork
        {
            _Work.Name = txtName.Text;
            _Work.Date = DateTime.Parse(txtCreation.Text);
            _Work.Value = decimal.Parse(txtValue.Text);
        }

        public void SetDetails(ClsWork prWork)
            //this has been modified to Remove Parameters, Preserve Whole Object and Change Unidirectional to Bidirectional Association
        {
            _Work = prWork;
            UpdateForm();
            ShowDialog();
        }

        //Get details has been removed.

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                PushData();
                Close();
                //note the OK button now only pushes the data and closes the form
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        
        public virtual bool isValid()
        {
            return true;
        }
    }
}