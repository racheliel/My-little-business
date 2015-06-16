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

        public Boolean chackBusinessName(string busN)
        {//get bussines name and return true if exist
            con.Open();
            string sqlString = "Select * from BusinessTable where BusName='" + busN + "';";
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
                Users user = new Users((string)rdr[0], (string)rdr[1], (string)rdr[2], (string)rdr[3], (string)rdr[4]);
                con.Close();
                return user;
            }
            else
            {
                con.Close();
                return null;
            }
        }


        public Business getBusiness(string str)
        {
            con.Open();
            string sqlString = "Select * from BusinessTable where BusName='" + str + "';";
            SqlCommand com = new SqlCommand(sqlString, con);
            SqlDataReader rdr = com.ExecuteReader();
            Business b=null;
            if (rdr.Read())
            {
                b = new Business((string)rdr[0], (string)rdr[1], (string)rdr[2], (string)rdr[3]);
            }
            con.Close();
            return b;
        }

        public Business getBusinessForUser(string str)
        {
            con.Open();
            string sqlString = "Select * from BusinessTable where UserName='" + str + "';";
            SqlCommand com = new SqlCommand(sqlString, con);
            SqlDataReader rdr = com.ExecuteReader();
            Business b = null;
            if (rdr.Read())
            {
                b = new Business((string)rdr[0], (string)rdr[1], (string)rdr[2], (string)rdr[3]);
            }
            con.Close();
            return b;
        }


       
        public LinkedList<Business> getAllBusiness()
        {
            con.Open();
            string sqlString = "Select BusName,UserName,Detailes,Place from BusinessTable ;";
            SqlCommand com = new SqlCommand(sqlString, con);
            SqlDataReader rdr = com.ExecuteReader();
            LinkedList<Business> buss = new LinkedList<Business>();
            Business b;
            
            if (rdr.Read())
            {
                b = new Business((string)rdr[0], (string)rdr[1], (string)rdr[2], (string)rdr[3]);
                buss.AddFirst(b);
            }
            con.Close();
            return buss;
        }


        public LinkedList<Favorit> getFavorit(string user)
        {
            con.Open();
            string sqlString = "Select * from FavoritTable where UserName='" + user + "';";
            SqlCommand com = new SqlCommand(sqlString, con);
            SqlDataReader rdr = com.ExecuteReader();
            LinkedList<Favorit> favorits = new LinkedList<Favorit>();
            Favorit f;
            if (rdr.Read())
            {
                f = new Favorit((string)rdr[0], (string)rdr[1]);
                favorits.AddFirst(f);
            }
            con.Close();
            return favorits;
        }

        public LinkedList<Feedback> getFeedback(string buss)
        {
            con.Open();
            string sqlString = "Select * from FeedbacksTable where BusName='" + buss + "';";
            SqlCommand com = new SqlCommand(sqlString, con);
            SqlDataReader rdr = com.ExecuteReader();
            LinkedList<Feedback> feedbacks = new LinkedList<Feedback>();
            Feedback f;
            if (rdr.Read())
            {
                f = new Feedback((string)rdr[2],(string)rdr[0],(string)rdr[1]);
                feedbacks.AddFirst(f);
            }
            con.Close();
            return feedbacks;
        }

        public Users signIn(string pass, string userN)
        {//get user name name and password and returns the user if not exist return null
            con.Open();
            string sqlString = "Select * from UsersTable where UserName='"+userN+"' AND Password='"+pass+"';";
            SqlCommand com = new SqlCommand(sqlString, con);
            SqlDataReader rdr = com.ExecuteReader();

            if(rdr.Read())
            {
                Users user = new Users((string)rdr[0],(string)rdr[1],(string)rdr[2],(string)rdr[3],(string)rdr[4]);
                con.Close();
                return user;
            }
            else
            {
                con.Close();
                return null;
            }
          
        }

        public string getMail(string user)
        {
            con.Open();
            string sqlString = "Select Email from UsersTable where UserName='" + user + "';";
            SqlCommand com = new SqlCommand(sqlString, con);
            SqlDataReader rdr = com.ExecuteReader();
            string e = "";
            if (rdr.Read())
            {
                e = (string)rdr[0];

            }
            con.Close();
            return e;
        }


         public LinkedList<Events> getEvents(string userName)
         {//get user name and returns events of user name
             con = new SqlConnection(conString);
             con.Open();
             string sqlString = "Select *  from EventsTable t where t.UserName='" + userName + "';"; 
             SqlCommand com = new SqlCommand(sqlString, con);
             SqlDataReader rdr = com.ExecuteReader();

             LinkedList<Events> events = new LinkedList<Events>();
             Events temp;
             while (rdr.Read())
             {
                 temp = new Events((string)rdr[0],(DateTime)rdr[1] , (string)rdr[2], (string)rdr[3], (string)rdr[4]);

                 events.AddLast(temp);
             }
             con.Close();
             return events;
         }

         public string getImageLogo(string BusName)
         {//get user name and returns events of user name
             con = new SqlConnection(conString);
             con.Open();
             string sqlString = "Select logo  from logos l where l.busName='" + BusName + "';";
             SqlCommand com = new SqlCommand(sqlString, con);
             SqlDataReader rdr = com.ExecuteReader();
             string str = "";
             while (rdr.Read())
             {
                 str= (string)rdr[0];
             }
             con.Close();
             return str;
         }


         public LinkedList<Events> getAllEvents()
         {//get user name and returns events of user name
             con = new SqlConnection(conString);
             con.Open();
             string sqlString = "Select *  from EventsTable t ;";
             SqlCommand com = new SqlCommand(sqlString, con);
             SqlDataReader rdr = com.ExecuteReader();

             LinkedList<Events> events = new LinkedList<Events>();
             Events temp;
             while (rdr.Read())
             {
                 temp = new Events((string)rdr[0], (DateTime)rdr[2], (string)rdr[1], (string)rdr[3], (string)rdr[4]);

                 events.AddLast(temp);
             }
             con.Close();
             return events;
         }
         public void createEvent(Events e)
         {//get user event and insert the event to the event table
             con = new SqlConnection(conString);
             con.Open();
             string sqlString = "INSERT INTO EventsTable (UserName,Date,Place,Name,Catgory)" + "VALUES ('" + e.UserName + "',CONVERT(datetime,'" + e.Date_time + "',103),'" + e.Place + "','" + e.Name + "','" + e.Catgory + "');";
             SqlCommand com = new SqlCommand(sqlString, con);

                 com.ExecuteReader();

                 con.Close();

         }

         public void addFavorit(Favorit f)
         {//get user event and insert the event to the event table
             con = new SqlConnection(conString);
             con.Open();
             string sqlString = "INSERT INTO FavoritTable (UserName,BusName)" + "VALUES ('" + f.UserName +  "','" + f.BusName + "');";
             SqlCommand com = new SqlCommand(sqlString, con);

             com.ExecuteReader();

             con.Close();

         }

         public void createUser(Users u)
         {
             con = new SqlConnection(conString);
             con.Open();
             string sqlString = "INSERT INTO UsersTable (UserName,Password,Email,FirstName,LastName)" + "VALUES ('" + u.UserName + "','" + u.Pass + "','" + u.EMail + "','" + u.FirstName + "','" + u.LastName +"');";
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

         public void addFeedback(Feedback f)
         {
             con = new SqlConnection(conString);
             con.Open();
             string sqlString = "INSERT INTO FeedbacksTable (BusName,Feedback,UserName)" + "VALUES ('" + f.BusName + "','" + f.Strfeedback + "','" + f.UserName + ");";
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

         public void addBusiness(Business b)
         {
             con = new SqlConnection(conString);
             con.Open();
             string sqlString = "INSERT INTO BusinessTable (BusName,UserName,Detailes,Place)" + " VALUES ('" + b.BusName + "','" + b.UserName +"','"+b.Detailes+"','"+b.Place+ "');";
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


         public void deleteEvent(Events e)
         {//get user event and delete this event
             con = new SqlConnection(conString);
             con.Open();
             string sqlString = "DELETE FROM EventsTable WHERE UserName='" + e.UserName + "' AND Date=CONVERT(datetime,'" + e.Date_time + "',103) AND Name= '"+ e.Name +"';";
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

         public void deleteImage(string p)
         {//get user event and delete this event
             con = new SqlConnection(conString);
             con.Open();
             string sqlString = "DELETE FROM uplodes WHERE image='" + p + "';";
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
         public void deleteFavorit(Favorit f)
         {//get user event and delete this event
             con = new SqlConnection(conString);
             con.Open();
             string sqlString = "DELETE FROM FavoritTable WHERE UserName='" + f.UserName + "' AND BusName= '" + f.BusName + "';";
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
         public void deleteBusiness(string b)
         {//get  business and deleted
             con = new SqlConnection(conString);
             con.Open();
             string sqlString = "delete from BusinessTable where BusName = '" + b + "';";
             SqlCommand com = new SqlCommand(sqlString, con);
     //        try
             {
                 com.ExecuteReader();
                 con.Close();

             }
        /*     catch
             {
                 con.Close();
             }*/
         }




        
        }

    
        
        
        }
       
    

