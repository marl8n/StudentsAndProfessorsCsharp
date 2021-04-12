using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsAndProfessors.models
{
    public class University
    {
        public string Name { get; set; }
        public List<Professor>  Professors { get; set; }
        public List<Student>    Students { get; set; }
        public List<CourseInfo> CoursesInfo { get; set; }
        public List<Course>     Courses { get; set; }
        public List<Classes>    ClassesEn { get; set; }

        public University()
        {

        }

        public University(string name)
        {
            this.Name = name;
        }

        // Professor Create
        public Professor AddProfessor(
            string Name, string LastName, string Address, DateTime Birhtdate, string Title
            )
        {
            Professor professor = new Professor(Name, LastName, Address, Birhtdate, Title);
            this.Professors.Add( professor );

            return professor;
        }
        
        // Student Create
        public Student AddStudent (string Name, string LastName, string Address, DateTime Birhtdate)
        {
            Student student = new Student(Name, LastName, Address, Birhtdate);
            this.Students.Add(student);
            return student;
        }

        // CourseInfo Create
        public CourseInfo AddCourseInfo(string Name)
        {
            CourseInfo courseInfo = new CourseInfo(Name);
            this.CoursesInfo.Add(courseInfo);
            return courseInfo;
        }

        // Course Create
        public Course AddCourse(string CourseId, string ProfessorId)
        {
            Course course = new Course(CourseId, ProfessorId);
            this.Courses.Add(course);
            return course;
        }

        // Classes Entity create
        public Classes AddClasses(string courseId, string studentId)
        {
            Classes classes = new Classes(courseId, studentId);
            this.ClassesEn.Add(classes);
            return classes;
        }
    }
}