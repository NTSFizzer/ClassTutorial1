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

        protected ClsWork _Work;

        protected virtual void UpdateForm()
        {
            txtName.Text = _Work.Name;
            txtCreation.Text = _Work.Date.ToShortDateString();
            txtValue.Text = _Work.Value.ToString();
        }

        protected virtual void PushData()
        {
            _Work.Name = txtName.Text;
            _Work.Date = DateTime.Parse(txtCreation.Text);
            _Work.Value = decimal.Parse(txtValue.Text);
        }

        public void SetDetails(ClsWork prWork)
        {
            _Work = prWork;
            UpdateForm();
            ShowDialog();
       
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                PushData();
                Close();
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