using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalProject
{
    public class Favorit
    {

        private string busName,userName;


        public Favorit(string userName, string busName)
        {
            this.userName = userName;
            this.busName = busName;
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }



        public string BusName
        {
            get { return busName; }
            set { busName = value; }
        }

    }
}