using System;

namespace Version_1_C
{
    [Serializable()] 
    public class ClsArtist
    {
        private string _Name;
        private string _Speciality;
        private string _Phone;

        private decimal _TotalValue;

        private ClsWorksList _WorksList = new ClsWorksList();
        private ClsArtistList _ArtistList;
        
        private static FrmArtist ArtistDialog = new FrmArtist();

        //declares a Name property of type string
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        //Declares a Speciality property of type string
        public string Speciality
        {
            get { return _Speciality;}
            set { _Speciality = value; }
        }

        //Declares a Phone property of type string
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        //Declares a TotalValue property of type decimal
        public decimal TotalValue
        {
            get { return _TotalValue; }
            //set { TotalValue = value; }
        }

        public ClsWorksList WorksList
        {
            get { return _WorksList; }
            //set { _WorksList = value; }
        }

        public ClsArtistList ArtistList
        {
            get { return _ArtistList; }
            ////set { _ArtistList = value; }
        }

        public ClsArtist(ClsArtistList prArtistList)
        {
         //   WorksList = new ClsWorksList();
        //    ArtistList = prArtistList;
            EditDetails();
        }

        //most of the editing of the form is done by the form.
        public void EditDetails()
        {
            ArtistDialog.SetDetails(this); //this passes a reference to itself now
            if (ArtistDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _TotalValue = _WorksList.GetTotalValue(); //this keeps a copy of the total work's value.
            }
        }

        public bool IsDuplicate(string prArtistName)
        {
            return ArtistList.ContainsKey(prArtistName);
        }
    }
}
