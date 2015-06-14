
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    class UsersEvents
    {

        private int eventID;
        private DateTime date_time;
        private string place;
        private string userName;


        public UsersEvents(string userName,int eventID, DateTime date_time, string place)
        {
            this.eventID = eventID;
            this.date_time = date_time;
            this.place = place;
            this.userName = userName;

        }

        public int EventID
        {
            get { return eventID; }
            set { eventID = value; }
        }

        public DateTime Date_time
        {
            get { return date_time; }
            set { date_time = value; }
        }

        public string Place
        {
            get { return place; }
            set { place = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

    }
}
