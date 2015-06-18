
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    class Events
    {

        private DateTime date_time;
        private string place;
        private string userName,catgory,name;


        public Events(string userName, DateTime date_time, string place,string name, string cat)
        {
            this.date_time = date_time;
            this.place = place;
            this.userName = userName;
            this.name = name;
            this.catgory = cat;

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Catgory
        {
            get { return catgory; }
            set { catgory = value; }
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
