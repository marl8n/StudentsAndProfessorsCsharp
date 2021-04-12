using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsAndProfessors.models
{
    public class Course
    {
        string CourseId;
        string ProfessorId;
        DateTime CreatedAt;
        DateTime ModifiedAt;

        public Course()
        {

        }

        public Course(string CourseId, string ProfessorId)
        {
            this.CourseId = CourseId;
            this.ProfessorId = ProfessorId;
            this.CreatedAt = DateTime.Now;
            this.ModifiedAt = DateTime.Now;
        }
    }
}