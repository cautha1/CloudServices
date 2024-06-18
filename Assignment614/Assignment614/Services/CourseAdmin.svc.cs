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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CourseAdmin" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CourseAdmin.svc or CourseAdmin.svc.cs at the Solution Explorer and start debugging.
    public class CourseAdmin : ICourseAdmin
    {
        private TafesaDataSetTableAdapters.CourseTableAdapter courseTA;

        public CourseAdmin()
        {
            courseTA = new TafesaDataSetTableAdapters.CourseTableAdapter();
        }
        public void AddCourse( int courseID ,string courseName, decimal cost)
        {
            //courseTA.Insert (courseName, cost);
            //courseTA.Insert(courseID ,courseName, cost);
            return;
        }

        public List<Course> GetAllCourses()
        {
            TafesaDataSet.CourseDataTable courseTable = courseTA.GetData();
            List<Course> courseList = new List<Course>();

            foreach (DataRow row in courseTable.Rows)
            {
                Course course = new Course();
                course.CourseID = (int)row["courseID"];
                course.CourseName = row["CourseName"].ToString();
                course.Cost = (decimal)row["Cost"];
                courseList.Add(course);
            }
            return courseList;
        }
    }
}
