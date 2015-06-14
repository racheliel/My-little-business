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
        private string busName,strfeedback;


        public Feedback(string userName, string busName, string feedback)
        {
            this.userName = userName;
            this.busName = busName;
            this.strfeedback = feedback; 
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Strfeedback
        {
            get { return strfeedback; }
            set { strfeedback = value; }
        }

        public string BusName
        {
            get { return busName; }
            set { busName = value; }
        }

    }
}
