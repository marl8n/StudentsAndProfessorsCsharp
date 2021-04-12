using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsAndProfessors.models
{
    public class Professor : User
    {
        public string Title { get; set; }

        public Professor()
        {

        }


        public Professor(string Name, string LastName, string Address, DateTime Birhtdate, string Title)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.Birthdate = Birthdate;
            this.Title = Title;
        }
    }
}