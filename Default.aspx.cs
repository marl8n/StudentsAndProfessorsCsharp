using Newtonsoft.Json;
using StudentsAndProfessors.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentsAndProfessors
{
    public partial class _Default : Page
    {
        List<University> Universities = new List<University>();
        string universitiesFile = "";
        /* string ProfessorsFile = "";
        string StudentsFile = "";
        string CoursesInfoFile = "";
        string CoursesFile = "";
        string ClassesEnFile = "";
        */
        protected void Page_Load(object sender, EventArgs e)
        {
            universitiesFile = Server.MapPath("Universities.json");
            /*ProfessorsFile = Server.MapPath("Professors.json");
            StudentsFile = Server.MapPath("Students.json");
            CoursesInfoFile = Server.MapPath("CoursesInfo.json");
            CoursesFile = Server.MapPath("Courses.json");
            ClassesEnFile = Server.MapPath("Classes.json");
            */

            if (ValidateFiles())
            {
                Universities = JsonConvert.DeserializeObject<List<University>>(universitiesFile);
                if (Universities == null)
                {
                    Universities = new List<University>();
                }
                foreach ( var university in Universities)
                {
                    if ( university.Professors == null )
                    {
                        university.Professors = new List<Professor>();
                    }
                    if (university.Students == null)
                    {
                        university.Students = new List<Student>();
                    }
                    if ( university.CoursesInfo == null)
                    {
                        university.CoursesInfo = new List<CourseInfo>();
                    }
                    if (university.Courses == null)
                    {
                        university.Courses = new List<Course>();
                    }
                    if ( university.ClassesEn == null)
                    {
                        university.ClassesEn = new List<Classes>();
                    }
                } 
            }
            else
            {
                Universities = new List<University>();
                foreach (var university in Universities)
                {
                    if (university.Professors == null)
                    {
                        university.Professors = new List<Professor>();
                    }
                    if (university.Students == null)
                    {
                        university.Students = new List<Student>();
                    }
                    if (university.CoursesInfo == null)
                    {
                        university.CoursesInfo = new List<CourseInfo>();
                    }
                    if (university.Courses == null)
                    {
                        university.Courses = new List<Course>();
                    }
                    if (university.ClassesEn == null)
                    {
                        university.ClassesEn = new List<Classes>();
                    }
                }
            }
            GridView1.DataSource = Universities;
            ddlUniversities.DataSource = Universities;
            SetDataSources(ddlUniversities.SelectedValue);
        }

        private void SetDataSources(string selectedValue)
        {
            University u = Universities.Find(university => university.Name.Equals(selectedValue));
            GridView1.DataSource = Universities;
            GridView1.DataBind();
            //Professors
            dgProfessors.DataSource = u.Professors;
            dgProfessors.DataBind();
            //Students
            dgStudents.DataSource = u.Students;
            dgStudents.DataBind();
            //Courses
            dgCourses.DataSource = u.Courses;
            dgCourses.DataBind();
            // Courses Info
            dgCourses.DataSource = u.CoursesInfo;
            dgCourses.DataBind();
            // Classes
            dgClasses.DataSource = u.ClassesEn;
            dgClasses.DataSource = u.ClassesEn;
        }

        private bool ValidateFiles()
        {
            return File.Exists(universitiesFile);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            University u = Universities.Find(un => un.Name.ToLower().Equals(ddlUniversities.SelectedValue));
            u
        }

        protected void btnCreateUniversity_Click(object sender, EventArgs e)
        {
            if (Universities.Find(u => u.Name.ToLower().Equals(tbCreateUniversityName.Text)) != null)
            {
                Universities.Add(
                    new University(
                        tbCreateUniversityName.Text
                        )
                    ) ;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            University u = Universities.Find(un => un.Name.ToLower().Equals(ddlUniversities.SelectedValue));
            u.Students.Add(
                new Student(
                    tbCStudentName.Text,
                    tbCStudentLastName.Text,
                    tbCStudentAddress.Text,
                    dtCStudentBirthdate.SelectedDate
                    )
                );
        }

        protected void btnCreateCourseInfo_Click(object sender, EventArgs e)
        {
            University u = Universities.Find(un => un.Name.ToLower().Equals(ddlUniversities.SelectedValue));
            u.CoursesInfo.Add(
                new CourseInfo(tbCourseInfoName.Text)
                );
        }

        protected void btnAddCourseProf_Click(object sender, EventArgs e)
        {
            University u = Universities.Find(un => un.Name.ToLower().Equals(ddlUniversities.SelectedValue));
            u.Courses.Add(new Course(tbCIdCourse.Text, tbCIdProfessor.Text));
        }

        protected void btnLinkToClass_Click(object sender, EventArgs e)
        {
            University u = Universities.Find(un => un.Name.ToLower().Equals(ddlUniversities.SelectedValue));
            u.AddCourse(tbLTClassid.Text, tbLTCStudent.Text);
        }

        protected void Create_Click(object sender, EventArgs e)
        {
            University u = Universities.Find(un => un.Name.ToLower().Equals(ddlUniversities.SelectedValue));
            u.Grades.Add(new Grade(tbCourseIdGrade.Text, tbStudentIdGrade.Text, Double.Parse( tbGradeIdGrade.Text )));
        }
    }
}