using Assignment614.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Assessment01.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentEnrolment" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select StudentEnrolment.svc or StudentEnrolment.svc.cs at the Solution Explorer and start debugging.
    public class StudentEnrolment : IStudentEnrolment
    {
        private TafesaDataSetTableAdapters.EnrollmentsTableAdapter enrollmentTA;

        public StudentEnrolment()
        {
            enrollmentTA = new TafesaDataSetTableAdapters.EnrollmentsTableAdapter();
        }

        public void AddEnrolment(int studentID, int courseID, DateTime dateEnrolled)
        {
            enrollmentTA.Insert(studentID, courseID, dateEnrolled);
        }
        public List<Enrolment> GetAllEnrollments()
        {
            TafesaDataSet.EnrollmentsDataTable enrollmentTable = enrollmentTA.GetData();
            List<Enrolment> enrollmentList = new List<Enrolment>();

            foreach (DataRow row in enrollmentTable.Rows)
            {
                Enrolment enrollment = new Enrolment();
                enrollment.StudentID = (int)row["studentID"];
                enrollment.CourseID = (int)row["courseID"];
                enrollment.DateEnrolled = (DateTime)row["DateEnrolled"];
                enrollmentList.Add(enrollment);
            }
            return enrollmentList;
        }
    }
}
