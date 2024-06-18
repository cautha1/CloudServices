using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using Assignment614.Classes;

namespace Assignment614.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentEnrolment1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select StudentEnrolment1.svc or StudentEnrolment1.svc.cs at the Solution Explorer and start debugging.
    public class StudentEnrolment1 : IStudentEnrolment1
    {
        private TafesaDataSetTableAdapters.EnrollmentsTableAdapter enrollmentTA;

        public StudentEnrolment1()
        {
            enrollmentTA = new TafesaDataSetTableAdapters.EnrollmentsTableAdapter();
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
