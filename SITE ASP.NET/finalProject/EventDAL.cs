using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace finalProject
{
    class EventDAL
    {
        public string conString= "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\GitHub\\My-little-business\\SITE ASP.NET\\MLBDB.mdf;Integrated Security=True;Connect Timeout=30";
        public SqlConnection con;

        public EventDAL()
        {
            con = new SqlConnection(conString);
        }

        public Boolean chackUser(string userN)
        {//get user name and return true if exist
            con.Open();
            string sqlString = "Select * from UsersTable where UserName='" + userN + "';";
            SqlCommand com = new SqlCommand(sqlString, con);
            SqlDataReader rdr = com.ExecuteReader();

            if (rdr.Read())
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }

        public Users getPassword(string userN)
        {//get user name and return user deatel for someone that forgot the password
            con.Open();
            string sqlString = "Select * from UsersTable where UserName='" + userN + "';";
            SqlCommand com = new SqlCommand(sqlString, con);
            SqlDataReader rdr = com.ExecuteReader();
            if (rdr.Read())
            {
                Users user = new Users((string)rdr[0], (string)rdr[1], (string)rdr[2], (string)rdr[3], (string)rdr[4], (DateTime)rdr[5]);
                con.Close();
                return user;
            }
            else
            {
                con.Close();
                return null;
            }
        }
       public int getIDEvent(string str)
        {//get the name of event and returns the id of event
            con.Open();
            string sqlString = "Select EventID from EventsTable where EventName='" + str + "';";
            SqlCommand com = new SqlCommand(sqlString, con);
            SqlDataReader rdr = com.ExecuteReader();
            int num = -1;
            if (rdr.Read())
            {
                num = (int)rdr[0];
            }
            con.Close();
            return num;
        }


        public string getTypeEvent(int num)
        {//get event id and return event name
            con.Open();
            string sqlString = "Select EventName from EventsTable where EventID=" + num + ";";
            SqlCommand com = new SqlCommand(sqlString, con);
            SqlDataReader rdr = com.ExecuteReader();
            string str="";
            if (rdr.Read())
            {
                str=(string)rdr[0];
            }
            con.Close();
            return str;
        }


        public Users signIn(string pass, string userN)
        {//get user name name and password and returns the user if not exist return null
            con.Open();
            string sqlString = "Select * from UsersTable where UserName='"+userN+"' AND Password='"+pass+"';";
            SqlCommand com = new SqlCommand(sqlString, con);
            SqlDataReader rdr = com.ExecuteReader();

            if(rdr.Read())
            {
                Users user = new Users((string)rdr[0],(string)rdr[1],(string)rdr[2],(string)rdr[3],(string)rdr[4],(DateTime)rdr[5]);
                con.Close();
                return user;
            }
            else
            {
                con.Close();
                return null;
            }
          
        }


         public LinkedList<string> getAllEventType()
        {
            con.Open();
            string sqlString = "Select EventName from EventsTable ;";
            SqlCommand com = new SqlCommand(sqlString, con);
            SqlDataReader rdr = com.ExecuteReader();

            LinkedList<string> eventName = new LinkedList<string>();

            while (rdr.Read())
            {
                string name = (string)rdr[0];
                eventName.AddLast(name);
            }
            con.Close();
            return eventName;
        }



         public LinkedList<UsersEvents> getUsersEvents(string name)
         {//get user name and returns events of user name
             con = new SqlConnection(conString);
             con.Open();
             string sqlString = "Select t.UserName,t.EventID,t.Date,t.Place  from UsersEventsTable t where t.UserName='" + name + "';"; 
             SqlCommand com = new SqlCommand(sqlString, con);
             SqlDataReader rdr = com.ExecuteReader();

             LinkedList<UsersEvents> usersEvents = new LinkedList<UsersEvents>();
             UsersEvents temp;
             while (rdr.Read())
             {
                 temp = new UsersEvents((string)rdr[0], (int)rdr[1], (DateTime)rdr[2], (string)rdr[3]);

                 usersEvents.AddLast(temp);
             }
             con.Close();
             return usersEvents;
         }
        
         public void createUserEvent(UsersEvents e)
         {//get user event and insert the event to the event table
             con = new SqlConnection(conString);
             con.Open();
             string sqlString = "INSERT INTO UsersEventsTable (UserName,Date,EventID,Place)" + "VALUES ('" + e.UserName + "',CONVERT(datetime,'" + e.Date_time + "',103)," + e.EventID + ",'" + e.Place + "');";
             SqlCommand com = new SqlCommand(sqlString, con);

                 com.ExecuteReader();

                 con.Close();

         }

         public void createUser(Users u)
         {
             con = new SqlConnection(conString);
             con.Open();
             string sqlString = "INSERT INTO UsersTable (UserName,Password,Email,FirstName,LastName,BirthDate)" + "VALUES ('" + u.UserName + "','" + u.Pass + "','" + u.EMail + "','" + u.FirstName + "','" + u.LastName + "',CONVERT(datetime,'" + u.Birth_date + "',103));";
             SqlCommand com = new SqlCommand(sqlString, con);
             try
             {
                 com.ExecuteReader();
             }
             catch
             {
                 con.Close();
             }
         }




         public void deleteUserEvent(UsersEvents e)
         {//get user event and delete this event
             con = new SqlConnection(conString);
             con.Open();
             string sqlString = "DELETE FROM UsersEventsTable WHERE UserName='" + e.UserName + "' AND Date=CONVERT(datetime,'" + e.Date_time + "',103);";
             SqlCommand com = new SqlCommand(sqlString, con);
             try
             {
                 com.ExecuteReader();
                 con.Close();

             }
             catch
             {
                 con.Close();
             }
         }




        
        }

    
        
        
        }
       
    

