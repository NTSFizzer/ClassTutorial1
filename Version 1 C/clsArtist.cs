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
       

        public ClsArtist(ClsArtistList prArtistList)
        {
            _WorksList = new ClsWorksList();
            _ArtistList = prArtistList;
            EditDetails();
        }
        
        public void EditDetails()
        {
            ArtistDialog.SetDetails(_Name, _Speciality, _Phone, _WorksList, _ArtistList);
            if (ArtistDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ArtistDialog.GetDetails(ref _Name, ref _Speciality, ref _Phone);
                _TotalValue = _WorksList.GetTotalValue();
            }
        }

        public string GetKey()
        {
            return _Name;
        }

        public decimal GetWorksValue()
        {
            return _TotalValue;
        }
    }
}
