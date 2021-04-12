using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsAndProfessors.models
{
	public class Classes
	{
        public string CourseId { get; set; }
        public string StudentId { get; set; }
        public List<Grade> Grades { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Classes()
        {

        }
        public Classes(string CourseId, string StudentId)
        {
            this.CourseId = CourseId;
            this.StudentId = StudentId;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        public void AddGrade(string StudentId, string CourseId, double note)
        {
            this.Grades.Add(
                new Grade(
                    StudentId,
                    CourseId,
                    note
                    )
                );
            this.UpdatedAt = DateTime.Now;
        }
    }
}