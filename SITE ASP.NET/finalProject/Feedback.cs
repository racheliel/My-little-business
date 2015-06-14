using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    class Feedback
    {
        private string userName;
        private string busName,feedback;


        public Feedback(string userName, string busName, string feedback)
        {
            this.userName = userName;
            this.busName = busName;
            this.feedback = feedback; 
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Feedback
        {
            get { return feedback; }
            set { feedback = value; }
        }

        public string BusName
        {
            get { return busName; }
            set { busName = value; }
        }

    }
}
