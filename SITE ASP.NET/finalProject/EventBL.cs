using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public Boolean ifEventNameExsist(LinkedList<Events> getEvents,string name)
        {
            foreach(Events i in getEvents)
            {
                if (i.Name == name)
                {
                    return true;
                }

            }
            return false;
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

        public bool checkMail(string mail)
        {

            bool success = Regex.IsMatch(mail, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)
                                              |(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            return success;
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

        public void deleteFavoritByBuss(string name)
        {
            eventD.deleteFavoritByBuss(name);
        }

        public void deleteFeedbackByBuss(string name)
        {
            eventD.deleteFeedbackByBuss(name);
        }

        public void deleteLogosByBuss(string name)
        {
            eventD.deleteLogosByBuss(name);
        }

        public void deleteUpdateByBuss(string name)
        {
            eventD.deleteUpdateByBuss(name);
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

        public void updateUser(string user, string pass, string first, string last, string mail)
        {
            eventD.updateUser(user, pass, first, last, mail);
        }

        public void deleteEventByUser(string user)
        {
            eventD.deleteEventByUser(user);
        }

        public void deleteFavoritByUser(string name)
        {
            eventD.deleteFavoritByUser(name);
        }

        public void deleteUser(string name) {
            eventD.deleteUser(name);
        }

        public string getNameBusinessForUser(string str)
        {
            return eventD.getNameBusinessForUser(str);
        }
    }
}
