using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    class Users
    {
        private string userName,pass;
        private string firstName, lastName,eMail;


        public Users(string userName, string pass, string eMail, string firstName, string lastName)
        {
            this.userName = userName;
            this.pass = pass;
            this.firstName = firstName; 
            this.lastName=lastName;
            this.eMail = eMail;
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string EMail
        {
            get { return eMail; }
            set { eMail = value; }
        }



    }
}
