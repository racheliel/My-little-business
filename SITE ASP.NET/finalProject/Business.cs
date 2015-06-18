using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace finalProject
{
    public class Business
    {
        private string busName, userName, detailes, place;

        public Business(string busName, string userName, string detailes, string place)
        {
           this.busName = busName; 
            this.userName = userName;
            this.detailes = detailes;
            this.place = place;
         
        }

        public string BusName
        {
            get { return busName; }
            set { busName = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Detailes
        {
            get { return detailes; }
            set { detailes = value; }
        }

        public string Place
        {
            get { return place; }
            set { place = value; }
        }


    }
}