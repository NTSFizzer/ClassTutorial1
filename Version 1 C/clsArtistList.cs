using System;
using System.Collections;
using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()]
    public class ClsArtistList : SortedList
    {
        private const string _FileName = "GallerySaveFile.xml"; //moved from frmMain
        private ClsArtistList _ArtistList;

        public void EditArtist(string prKey)
        {
            ClsArtist lcArtist;
            lcArtist = (ClsArtist)this[prKey];
            if (lcArtist != null)
                lcArtist.EditDetails();
            else
                MessageBox.Show("Sorry no artist by this name");
        }
       
        public void NewArtist()
        {
            ClsArtist lcArtist = new ClsArtist(this);
            try
            {
                if (lcArtist.Name != "")
                {
                    Add(lcArtist.Name, lcArtist);
                    MessageBox.Show("Artist added!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Duplicate Key!");
            }
        }
        
        public decimal GetTotalValue()
        {
            decimal lcTotal = 0;
            foreach (ClsArtist lcArtist in Values)
            {
                lcTotal += lcArtist.TotalValue;
            }
            return lcTotal;
        }

        //Moved from frmMain.cs
        public void Save()
        {
            try
            {
                System.IO.FileStream lcFileStream = new System.IO.FileStream(_FileName, System.IO.FileMode.Create);
                System.Runtime.Serialization.Formatters.Soap.SoapFormatter lcFormatter =
                    new System.Runtime.Serialization.Formatters.Soap.SoapFormatter();

                lcFormatter.Serialize(lcFileStream, this);
                lcFileStream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "File Save Error");
            }
        }

        //moved from frmMain.cs
        //this is now a static method. 
        public static ClsArtistList Retrieve()
        {
            ClsArtistList lcArtistList; //local variable for this method

            try
            {
                System.IO.FileStream lcFileStream = new System.IO.FileStream(_FileName, System.IO.FileMode.Open);
                System.Runtime.Serialization.Formatters.Soap.SoapFormatter lcFormatter =
                    new System.Runtime.Serialization.Formatters.Soap.SoapFormatter();

                lcArtistList = (ClsArtistList)lcFormatter.Deserialize(lcFileStream);

                lcFileStream.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "File Retrieve Error");
                lcArtistList = new ClsArtistList();
            }
            return lcArtistList;
        }
    }
}
