using System;

namespace StudentsAndProfessors.models
{
    public class CourseInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public CourseInfo()
        {

        }

        public CourseInfo(string Name)
        {
            this.Name = Name;
            this.Id = Guid.NewGuid().ToString();
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
        }
    }
}