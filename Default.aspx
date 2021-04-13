<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StudentsAndProfessors._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
        <p>
            <asp:DropDownList ID="ddlUniversities" runat="server">
            </asp:DropDownList>
        </p>
        <p>
            Create University</p>
        <p>
            Name</p>
        <p>
            <asp:TextBox ID="tbCreateUniversityName" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnCreateUniversity" runat="server" OnClick="btnCreateUniversity_Click" Text="CreateUniversity" />
        </p>
        <p>
            Create Student</p>
        <p>
            Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LastName&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Address</p>
        <p>
            <asp:TextBox ID="tbCStudentName" runat="server"></asp:TextBox>
            <asp:TextBox ID="tbCStudentLastName" runat="server"></asp:TextBox>
            <asp:TextBox ID="tbCStudentAddress" runat="server"></asp:TextBox>
        </p>
        <p>
            Birthdate</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="CreateStudent" />
        </p>
        <p>
            Create Course</p>
        <p>
            Name</p>
        <p>
            <asp:TextBox ID="tbCourseInfoName" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnCreateCourseInfo" runat="server" OnClick="btnCreateCourseInfo_Click" Text="Button" />
        </p>
        <p>
            Link Professor to course</p>
        <p>
            Id course&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; id Professor</p>
        <p>
            <asp:TextBox ID="tbCIdCourse" runat="server"></asp:TextBox>
            <asp:TextBox ID="tbCIdProfessor" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnAddCourseProf" runat="server" OnClick="btnAddCourseProf_Click" Text="Link" />
        </p>
        <p>
            Link Student to Class</p>
        <p>
            IdStudent&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; IdClass</p>
        <p>
            <asp:TextBox ID="tbLTCStudent" runat="server"></asp:TextBox>
            <asp:TextBox ID="tbLTClassid" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnLinkToClass" runat="server" OnClick="btnLinkToClass_Click" Text="Link" />
        </p>
        <p>
            Add grade</p>
        <p>
            Course id&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; StudentId&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; grade</p>
        <p>
            <asp:TextBox ID="tbCourseIdGrade" runat="server"></asp:TextBox>
            <asp:TextBox ID="tbStudentIdGrade" runat="server"></asp:TextBox>
            <asp:TextBox ID="tbGradeIdGrade" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Create" runat="server" OnClick="Create_Click" Text="Create" />
        </p>
        <div>
            <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            </asp:GridView>
            <asp:Calendar ID="dtCStudentBirthdate" runat="server"></asp:Calendar>
            <asp:GridView ID="dgProfessors" runat="server">
            </asp:GridView>
            <asp:GridView ID="dgStudents" runat="server">
            </asp:GridView>
            <asp:GridView ID="dgCourses" runat="server">
            </asp:GridView>
            <asp:GridView ID="dgClasses" runat="server">
            </asp:GridView>
            <asp:GridView ID="dgCoursesInfo" runat="server">
            </asp:GridView>
        </div>
    </div>

    </asp:Content>
