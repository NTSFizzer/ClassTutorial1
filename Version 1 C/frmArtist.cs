using System;
using System.Collections.Generic;
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

        //private ClsWorksList _WorksList;    // link from this form to ClsWorksList via _WorksList
        // private ClsArtistList _ArtistList;  // link from the Form FrmArtist to ClsArtistList
        //removed to reduce Inappropriate Intimacy. Refactored via Hiding Delegate (aka Hide Delegate)

        private ClsArtist _Artist; //private member variable from ClsArtist --> page 3 of notes 8.c -- this links to ClsArtist
        
        private string[] _ArtistWorksType = {"Painting", "Sculpture", "Photograph"};

        //private ClsWorksList _SortOrder;
        private byte _SortOrder; // 0 = Name, 1 = Date, 2 = Price;

        private void UpdateDisplay()
        {
            txtName.Enabled = txtName.Text == "";
            if (_SortOrder == 0)
            {
                _Artist.WorksList.SortByName();
                rbByName.Checked = true;
            }
            else
            {
                _Artist.WorksList.SortByDate();
                rbByDate.Checked = true;
            }

            //else if (_SortOrder ==2)
            //{
            //    _Artist.WorksList.SortByPrice();
            //    rbPrice.Checked = true;
            //}

            lstWorks.DataSource = null;
            lstWorks.DataSource = _Artist.WorksList;
        }


        public void SetDetails(ClsArtist prArtist)
        //this is now the effect from removing all of the previous parameters.
        {
            //parameters removed, and object preserved whole
            //direction changed form Unidirectional to Bidirectional Association

            _Artist = prArtist;
            UpdateForm();
            UpdateDisplay();
            ShowDialog();  
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _Artist.WorksList.DeleteWork(lstWorks.SelectedIndex);
            UpdateDisplay();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //  Matthias: this one is screwing things up.  You're creating a new artwork here,
            // then calling AddWork() which creates another one.
            // ClsWork lcWork = ClsWork.NewWork();
            _Artist.WorksList.AddWork();
            UpdateDisplay();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                pushData();   //added just prior to closing the form to push the data back to the form
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
                _Artist.WorksList.EditWork(lcIndex);
                UpdateDisplay();
            }
        }

        private void rbByDate_CheckedChanged(object sender, EventArgs e)
        {
            _SortOrder = Convert.ToByte(rbByDate.Checked);
            UpdateDisplay();
        }

        //responsible for populating the form
        private void UpdateForm()
        {
            txtName.Text = _Artist.Name;
            txtPhone.Text = _Artist.Phone;
            txtSpeciality.Text = _Artist.Speciality;
            //cboSpeciality.SelectedItem = _Artist.Speciality;
        }

        //responsible for pushing the details back to the class when the user closes the form
        private void pushData()
        {
            _Artist.Name = txtName.Text;
            _Artist.Phone = txtPhone.Text;
            _Artist.Speciality = txtSpeciality.Text;
            //_Artist.Speciality = Convert.ToString(cboSpeciality.SelectedItem);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*This will validate all type of numbers*/
            if ((!char.IsDigit(e.KeyChar)) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.')) // && (e.KeyChar != '-') 
            {
                e.Handled = true;
            }
            /* This will allow only allow one decimal point*/
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            //limits the number of decimal places to 2
            if (char.IsNumber(e.KeyChar) || ((e.KeyChar == '.') && (txtPhone.Text.IndexOf('.') == -1)))
            {
                if (txtPhone.Text.IndexOf('.') > 0)
                {
                    if (txtPhone.Text.IndexOf('.') < txtPhone.Text.Length - 2)
                        e.Handled = true;
                }
            }
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            //if (txtAnswer.Text.Length > 0 && txtAnswer.Text.Length < 2)
            //{
            //    answer = txtAnswer.Text;
            //    DialogResult = DialogResult.OK;
            //    this.Close();
            //}
            //else
            //{
            //    lblError.Text = "Please enter only one character into the text box.";
            //}
        }
    }
}