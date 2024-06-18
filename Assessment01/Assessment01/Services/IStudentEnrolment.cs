using Assignment614.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Assessment01.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStudentEnrolment" in both code and config file together.
    [ServiceContract]
    public interface IStudentEnrolment

    {
        [OperationContract]
        void AddEnrolment(int studentID, int courseID, DateTime dateEnrolled);
        [OperationContract]
        List<Enrolment> GetAllEnrollments();
    }
}
