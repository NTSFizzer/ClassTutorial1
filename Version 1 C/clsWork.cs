using System;

namespace Version_1_C
{
    [Serializable()] 
    public abstract class ClsWork
    {
        protected string _Name;
        protected DateTime theDate = DateTime.Now;
        protected decimal theValue;

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

                 switch (char.ToUpper(lcReply))
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

        public override string ToString()
        {
            return _Name + "\t" + theDate.ToShortDateString();  
        }
        
        public string GetName()
        {
            return _Name;
        }

        public DateTime GetDate()
        {
            return theDate;
        }

        public decimal GetValue()
        {
            return theValue;
        }
    }
}
