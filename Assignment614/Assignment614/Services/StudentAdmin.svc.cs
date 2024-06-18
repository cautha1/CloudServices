using Assignment614.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Assignment614.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentAdmin" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select StudentAdmin.svc or StudentAdmin.svc.cs at the Solution Explorer and start debugging.
    public class StudentAdmin : IStudentAdmin
    {
        private TafesaDataSetTableAdapters.StudentsTableAdapter studentTA;

        public StudentAdmin()
        {
            studentTA = new TafesaDataSetTableAdapters.StudentsTableAdapter();
        }
        public void AddStudent(string studentName, DateTime dateEnrolled)
        {
            studentTA.Insert(studentName, dateEnrolled);
        }
        public List<Student> GetAllStudents()
        {
            TafesaDataSet.StudentsDataTable studentTable = studentTA.GetData();
            List<Student> studentList = new List<Student>();

            foreach (DataRow row in studentTable.Rows)
            {
                Student student = new Student();
                student.StudentID = (int)row["studentID"];
                student.StudentName = row["StudentName"].ToString();
                student.DateEnrolled = (DateTime)row["DateEnrolled"];
                studentList.Add(student);
            }
            return studentList;
        }
    }
}
