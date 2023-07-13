using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkWeek4
{
    public class Student
    {
        public Student (string firstName, string lastName, int studentId, double gpa)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentId = studentId;
            this.gpa = gpa;
        }

        public string firstName;
        public string lastName;
        public int studentId;
        public double gpa;

        public string fullName;
        public string GetFullName()
        {
            
            fullName = this.firstName+ " " +this.lastName;
            return fullName;

        }
        public bool HasHonors()
        {
            return (this.gpa > 3.5) ? true : false; 
            
        }
    }

    public class Faculty
    {
        public Faculty(string firstName, string lastName, int employeeId,string[] subjectsTaught)
        {
            this.firstName=firstName;
            this.lastName=lastName;
            this.employeeId = employeeId;
            this.subjectsTaught = subjectsTaught;
        }
        
        
        public string firstName;
        public string lastName;
        public int employeeId;
        public string[] subjectsTaught;

        public string GetFullName()
        { 
            return this.firstName + " " + this.lastName;
        }

        public string[] GetSubjectsTaught()
        {
            return this.subjectsTaught;
        }

    }

    public class University
    {
        
        public University(string name)
        {
            this.name = name;
        }
        
        public string name;
        public List<Student> students;
        public List<Faculty> faculties;

        public void AddStudent(Student student)
        {
            if (students == null)
                students = new List<Student>();
            students.Add(student);
        }

        public void AddFaculty(Faculty faculty)
        {
            if (faculties == null)
                faculties = new List<Faculty>();
            faculties.Add(faculty);
        }

        public int GetStudentCount()
        {
            return students.Count;
        }

        public int GetFacultyCount()
        { 
            return faculties.Count; 
        }
    }
}
