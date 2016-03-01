using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Version_1_C
{
    public partial class FrmMain : Form
    {
        /// <summary>
        /// Matthias Otto, NMIT, 2010-2016
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
            //there is a second Private Void below with the same constructor name
            // private void InitializeComponent ????? renamed
        }

        private ClsArtistList _ArtistList = new ClsArtistList(); //no longer required


        //        private const string _FileName = "gallery.xml";

        private void UpdateDisplay()
        {
            string[] lcDisplayList = new string[_ArtistList.Count];

            lstArtists.DataSource = null;
            _ArtistList.Keys.CopyTo(lcDisplayList, 0);
            lstArtists.DataSource = lcDisplayList;
            lblValue.Text = Convert.ToString(_ArtistList.GetTotalValue());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _ArtistList.NewArtist();
            UpdateDisplay();
        }

        private void lstArtists_DoubleClick(object sender, EventArgs e)
        {
            string lcKey;

            lcKey = Convert.ToString(lstArtists.SelectedItem);
            if (lcKey != null)
            {
                _ArtistList.EditArtist(lcKey);
                UpdateDisplay();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            try
            {
                _ArtistList.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
      
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string lcKey;

            lcKey = Convert.ToString(lstArtists.SelectedItem);
            if (lcKey != null)
            {
                lstArtists.ClearSelected();
                _ArtistList.Remove(lcKey);
                UpdateDisplay();
            }
        }

        //private void Save()
        //{
        //    try
        //    {
        //        System.IO.FileStream lcFileStream = new System.IO.FileStream(fileName, System.IO.FileMode.Create);
        //        System.Runtime.Serialization.Formatters.Soap.SoapFormatter lcFormatter =
        //            new System.Runtime.Serialization.Formatters.Soap.SoapFormatter();

        //        lcFormatter.Serialize(lcFileStream, theArtistList);
        //        lcFileStream.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message, "File Save Error");
        //    }
        //}


        private ClsArtistList lcArtistList;


        private void FrmMain_Load(object sender, EventArgs e)
        {
            _ArtistList.Retrieve();
            UpdateDisplay();
        }

        private void LoadForm()
            //renamed from private void InitializeComponent
        {
            this.SuspendLayout();
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load_1);
            this.ResumeLayout(false);

        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {

        }
    }
}