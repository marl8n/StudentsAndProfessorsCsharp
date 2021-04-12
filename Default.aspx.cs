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
        string ProfessorsFile = "";
        string StudentsFile = "";
        string CoursesInfoFile = "";
        string CoursesFile = "";
        string ClassesEnFile = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            universitiesFile = Server.MapPath("Universities.json");
            ProfessorsFile = Server.MapPath("Professors.json");
            StudentsFile = Server.MapPath("Students.json");
            CoursesInfoFile = Server.MapPath("CoursesInfo.json");
            CoursesFile = Server.MapPath("Courses.json");
            ClassesEnFile = Server.MapPath("Classes.json");

            if (ValidateFiles())
            {
                Universities = JsonConvert.DeserializeObject<List<University>>(universitiesFile);
                if (Universities == null)
                {
                    Universities = new List<University>();
                }
                foreach ( var university in Universities)
                {
                    university.Professors = JsonConvert.DeserializeObject<List<Professor>>(ProfessorsFile);
                    if ( university.Professors == null )
                    {
                        university.Professors = new List<Professor>();
                    }
                    university.Students = JsonConvert.DeserializeObject<List<Student>>(StudentsFile);
                    if (university.Students == null)
                    {
                        university.Students = new List<Student>();
                    }
                    university.CoursesInfo = JsonConvert.DeserializeObject<List<CourseInfo>>(CoursesInfoFile);
                    if ( university.CoursesInfo == null)
                    {
                        university.CoursesInfo = new List<CourseInfo>();
                    }
                    university.Courses = JsonConvert.DeserializeObject<List<Course>>(CoursesFile);
                    if (university.Courses == null)
                    {
                        university.Courses = new List<Course>();
                    }
                    university.ClassesEn = JsonConvert.DeserializeObject<List<Classes>>(ClassesEnFile);
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
            SetDataSources(ddlUniversities.SelectedValue.);
        }

        private void SetDataSources(string selectedValue)
        {
            //TODO
            //University u = Universities.Find(selectedValue);
        }

        private bool ValidateFiles()
        {
            return File.Exists(universitiesFile) &&
                File.Exists(StudentsFile) &&
                File.Exists(CoursesInfoFile) &&
                File.Exists(CoursesFile) &&
                File.Exists(ClassesEnFile);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}