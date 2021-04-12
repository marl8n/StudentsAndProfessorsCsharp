using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsAndProfessors.models
{
    public class Student : User
    {
        public string Id { get; set; }

        public Student()
        {

        }

        public Student(string Name, string LastName, string Address, DateTime Birhtdate)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.Birthdate = Birthdate;
            this.Id = Guid.NewGuid().ToString();
        }
    }
}