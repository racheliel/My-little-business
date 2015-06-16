using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    class EventBL
    {
        EventDAL eventD = new EventDAL();

        public EventBL()
        {
           


        }

        public Boolean chackBusinessName(string busN)
        {
            return eventD.chackBusinessName(busN);
        }


        public Users getPassword(string userN)
        {
            return eventD.getPassword(userN);
        }


        public void deleteEvent(DateTime date, string user, string place, string name, string cat)
        {
            Events e = new Events(user, date, place,name,cat);
            eventD.deleteEvent(e);
        }


        public LinkedList<Events> getEvents(string username)
        {
            return eventD.getEvents(username);
        }


        public LinkedList<Events> getAllEvents()
        {
            return eventD.getAllEvents();
        }

        public Boolean chackUser(string userN)
        {
            return eventD.chackUser(userN);
        }

        public Business getBusinessForUser(string str)
        {
            return eventD.getBusinessForUser(str);

        }
        public string getMail(string user)
        {
            return eventD.getMail(user);
        }

        public Users signIn(string pass, string userN)
        {
            return eventD.signIn(pass,userN);
        }


        public Business getBusiness(string str)
        {
            return eventD.getBusiness(str);
        }

        public LinkedList<Business> getAllBusiness()
        {
            return eventD.getAllBusiness();
        }

        public LinkedList<Favorit> getFavorit(string user)
        {
            return eventD.getFavorit(user);
        }

        public LinkedList<Feedback> getFeedback(string buss)
        {
            return eventD.getFeedback(buss);
        }

        public void addFavorit(Favorit f)
        {
            eventD.addFavorit(f);
        }

        public void addUser(string userN, string pass, string email, string first, string last)
        {
            Users u = new Users(userN, pass, email, first, last);
            eventD.createUser(u);
        }

        public void addFeedback(Feedback f)
        {
            eventD.addFeedback(f);
        }

        public void deleteFavorit(Favorit f)
        {
            eventD.deleteFavorit(f);
        }

        public void deleteBusiness(string b)
        {
            eventD.deleteBusiness(b);

        }

        public void createEvent(string userName, DateTime date_time, string place,string name,string cat)
        {
            Events e = new Events(userName, date_time, place,name,cat);
            eventD.createEvent(e);
        }

        public string getImageLogo(string BusName)
        {
            return eventD.getImageLogo(BusName);
        }

        public void addBusiness(Business b)
        {
            eventD.addBusiness(b);
        }

        public void deleteImage(string p)
        {
            eventD.deleteImage(p);

        }

    }
}
