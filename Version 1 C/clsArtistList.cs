using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace Version_1_C
{
    [Serializable()]
    public class ClsArtistList : SortedList<string, ClsArtist> //this now inherits from clsArtist as a sorted list
    {
        private const string _FileName = "GallerySaveFile1.xml"; //moved from frmMain

        //private ClsArtistList _ArtistList;

        public void EditArtist(string prKey)
        {
            ClsArtist lcArtist = new ClsArtist(this);
           // lcArtist = (ClsArtist)this[prKey];   //no longer required
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
                //System.IO.FileStream lcFileStream = new System.IO.FileStream(_FileName, System.IO.FileMode.Create);

                //System.Runtime.Serialization.Formatters.Binary.BinaryFormatter lcFormatter =
                //    new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                FileStream lcFileStream = new FileStream(_FileName, System.IO.FileMode.Create);

                BinaryFormatter lcFormatter =
                    new BinaryFormatter();      //note the simplification of this method - is accessed via the Using System.Runtime.Serializaition... at the top

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
                FileStream lcFileStream = new FileStream(_FileName, FileMode.Open);
                BinaryFormatter lcFormatter =
                    new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();  //not all code is required. left for learning exercise

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
