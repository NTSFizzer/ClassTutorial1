using System;
//using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Version_1_C
{
    public partial class FrmArtist : Form
    {
        public FrmArtist()
        {
            InitializeComponent();
        }

        private ClsWorksList _WorksList;

        private byte _SortOrder; // 0 = Name, 1 = Date

        protected ClsArtist _Artist; //private member variable from clsArtist --> page 3 of notes 8.c

        private void UpdateDisplay()
        {
            txtName.Enabled = txtName.Text == "";
            if (_SortOrder == 0)
            {
                _WorksList.SortByName();
                rbByName.Checked = true;
            }
            else
            {
                _WorksList.SortByDate();
                rbByDate.Checked = true;
            }

            lstWorks.DataSource = null;
            lstWorks.DataSource = _WorksList;
            lblTotal.Text = Convert.ToString(_WorksList.GetTotalValue());
        }

        public void SetDetails(ClsArtist prArtist)
        {
            _Artist = prArtist;
            UpdateForm();
            UpdateDisplay();
            ShowDialog();
        }


        //no longer needed as refactored out
        //public void GetDetails(ref string prName, ref string prSpeciality, ref string prPhone)
        //{
        //    prName = txtName.Text;
        //    prSpeciality = txtSpeciality.Text;
        //    prPhone = txtPhone.Text;
        //    _SortOrder = _WorksList.SortOrder;
        //}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _WorksList.DeleteWork(lstWorks.SelectedIndex);
            UpdateDisplay();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _WorksList.AddWork();
            UpdateDisplay();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                pushData();                     //added just prior to closing the form to push the data back to the form
                DialogResult = DialogResult.OK;
            }
        }

        public virtual Boolean isValid()
        {
            if (txtName.Enabled && txtName.Text != "")
                if (_Artist.IsDuplicate(txtName.Text))
                {
                    MessageBox.Show("Artist with that name already exists!");
                    return false;
                }
                else
                    return true;
            else
                return true;
        }

        private void lstWorks_DoubleClick(object sender, EventArgs e)
        {
            int lcIndex = lstWorks.SelectedIndex;
            if (lcIndex >= 0)
            {
                _WorksList.EditWork(lcIndex);
                UpdateDisplay();
            }
        }

        private void rbByDate_CheckedChanged(object sender, EventArgs e)
        {
            _SortOrder = Convert.ToByte(rbByDate.Checked);
            UpdateDisplay();
        }

        private void UpdateForm()
        {
            txtName.Text = _Artist.Name;
            txtPhone.Text = _Artist.Phone;
            txtSpeciality.Text = _Artist.Speciality;
        }

        private void pushData()
        {
            _Artist.Name = txtName.Text;
            _Artist.Phone = txtPhone.Text;
            _Artist.Speciality = txtSpeciality.Text;

        }

    }
}