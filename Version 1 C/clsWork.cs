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

        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        public decimal Value
        {
            get { return _Value; }
            set { this._Value = value; }
        }

        public ClsWork()
        {
            EditDetails();
        }

        public abstract void EditDetails();

         public static ClsWork NewWork() //this returns a thing of its own kind
         {
             char lcReply;
             InputBox inputBox = new InputBox("Enter P for Painting, S for Sculpture and F for Photograph");
            //inputBox.ShowDialog();
            //if (inputBox.getAction() == true)
            inputBox.Text = "Enter the Artists Work Here"; 
            inputBox.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent; //this centres the input box on the screen

            if (inputBox.ShowDialog() == System.Windows.Forms.DialogResult.OK)
             {
                 lcReply = Convert.ToChar(inputBox.getAnswer());

                 switch (char.ToUpper(lcReply))  //converts the characters entered to Uppercase - p = P, s = S, etc.
                 {
                     case 'P': return new ClsPainting();
                     case 'S': return new ClsSculpture();
                     case 'F': return new ClsPhotograph();
                     default: throw new Exception("You chose the wrong option. Please Try Again."); ;
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
            return Name + "\t" + Date.ToShortDateString() + "\t" + Value.ToString();  
        }
    }
}
