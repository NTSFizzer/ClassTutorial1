using System;

namespace Version_1_C
{
    [Serializable()] 
    public class ClsArtist
    {
        private string _Name;
        private string _Speciality;
        private string _Phone;

  //      private byte _SortOrder;

        private decimal _TotalValue;

        private ClsWorksList _WorksList;
        private ClsArtistList _ArtistList;
        
        private static FrmArtist ArtistDialog = new FrmArtist();

        //declares a Name property of type string
        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
            }
        }

        //Declares a Speciality property of type string
        public string Speciality
        {
            get
            {
                return _Speciality;
            }

            set
            {
                _Speciality = value;
            }
        }

        //Declares a Phone property of type string
        public string Phone
        {
            get
            {
                return _Phone;
            }

            set
            {
                _Phone = value;
            }
        }

        //Declares a TotalValue property of type decimal
        public decimal TotalValue
        {
            get
            {
                return TotalValue;
            }

            //set
            //{
            //    _TotalValue = value;
            //}
        }

        public ClsArtist(ClsArtistList prArtistList)
        {
            _WorksList = new ClsWorksList();
            _ArtistList = prArtistList;
            EditDetails();
        }
        
        public void EditDetails() 
        {
            //ArtistDialog.SetDetails(Name, Speciality, Phone, _WorksList, _ArtistList);
            //simplified as frmArtist now handles the getting and setting of the Artist details. above code no longer needed.
            ArtistDialog.SetDetails(this);
            if (ArtistDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               // ArtistDialog.GetDetails(ref _Name, ref _Speciality, ref _Phone);
                _TotalValue = _WorksList.GetTotalValue();
            }
        }

        //public string GetKey()
        //{
        //    return Name;
        //}

        //public decimal GetWorksValue()
        //{
        //    return TotalValue;
        //}
    }
}
