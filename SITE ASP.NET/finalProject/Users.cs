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
        DateTime birth_date;

        public Users(string userName, string pass, string eMail, string firstName, string lastName, DateTime date)
        {
            this.userName = userName;
            this.pass = pass;
            this.firstName = firstName; 
            this.lastName=lastName;
            this.eMail = eMail;
            this.birth_date = date;

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

        public DateTime Birth_date
        {
            get { return birth_date; }
            set { birth_date = value; }
        }


    }
}
