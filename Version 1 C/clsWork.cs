using System;

namespace Version_1_C
{
    [Serializable()] 
    public abstract class ClsWork
    {
        private string _Name;
        private DateTime _Date = DateTime.Now;
        private decimal _Value;
        

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public decimal Value
        {
            get { return _Value; }
            set { this._Value = value; }
        }

        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        public ClsWork()
        {
            EditDetails();
        }

        public abstract void EditDetails();

         public static ClsWork NewWork()
         {
             char lcReply;
             InputBox inputBox = new InputBox("Enter P for Painting, S for Sculpture and H for Photograph");
             //inputBox.ShowDialog();
             //if (inputBox.getAction() == true)
             if (inputBox.ShowDialog() == System.Windows.Forms.DialogResult.OK)
             {
                 lcReply = Convert.ToChar(inputBox.getAnswer());

                 switch (char.ToUpper(lcReply))  //converts the characters entered to Uppercase - p = P, s = S, h = H.
                 {
                     case 'P': return new ClsPainting();
                     case 'S': return new ClsSculpture();
                     case 'H': return new ClsPhotograph();
                     default: return null;
                 }
             }
             else
             {
                 inputBox.Close();
                 return null;
             }
         }


        //public string GetName()
        //{
        //    return _Name;
        //}

        //public DateTime GetDate()
        //{
        //    return Date;
        //}

        //public decimal GetValue()
        //{
        //    return Value;
        //}



        public override string ToString()
        {
            return Name + "\t" + Date.ToShortDateString() + " ooh yeah! 2016!";  
        }
    }
}
