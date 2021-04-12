using System;

namespace StudentsAndProfessors.models
{
    public class Grade
    {
        public string StudentId { get; set; }
        public string CourseId { get; set; }
        public double Note { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Grade()
        {

        }

        public Grade(string StudentId, string CourseId, double Note)
        {
            this.StudentId = StudentId;
            this.CourseId = CourseId;
            this.Note = Note;
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
        }
    }
}