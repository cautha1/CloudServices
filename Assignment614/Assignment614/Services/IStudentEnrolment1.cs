using Assignment614.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Assignment614.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStudentEnrolment1" in both code and config file together.
    [ServiceContract]
    public interface IStudentEnrolment1
    {
        [OperationContract]
        List<Enrolment> GetAllEnrollments();
    }
}
