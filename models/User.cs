using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsAndProfessors.models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public string Address { get; set; }
        public DateTime Birthdate { get; set; }

        public int CalculateAge() => DateTime.MinValue.AddDays((DateTime.Now - Birthdate).Days).Year;

        public User()
        {

        }

    }
}