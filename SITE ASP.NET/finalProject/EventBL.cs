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

        public Users getPassword(string userN)
        {
            return eventD.getPassword(userN);
        }
        public LinkedList<string> getAllEventType()
        {
            return eventD.getAllEventType();
        }

        public int getIDEvent(string str)
        {
            return eventD.getIDEvent(str);
        }
        public void deleteUserEvent(int eID,DateTime date,string user,string place)
        {
            Events e = new Events(user, eID, date, place);
            eventD.deleteUserEvent(e);
        }

        public string getTypeEvent(int num)
        {
            return eventD.getTypeEvent(num);
        }

        public LinkedList<Events> getUsersEvents(string name)
        {
            return eventD.getUsersEvents(name);
        }
        public void addNewUser(string userN, string pass, string email, string first, string last)
        {
            Users u = new Users(userN, pass, email, first, last);
            eventD.createUser(u);
        }

        public Boolean chackUser(string userN)
        {
            return eventD.chackUser(userN);
        }

        public Users signIn(string pass, string userN)
        {
            return eventD.signIn(pass,userN);
        }

        public void createUserEvent(string userName, int eventID, DateTime date_time, string place)
        {
            Events e =new Events(userName,eventID,date_time, place);
            eventD.createUserEvent(e);
        }


    }
}
