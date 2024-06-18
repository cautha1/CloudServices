using Assignment614.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Assignment614.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStudentAdmin" in both code and config file together.
    [ServiceContract]
    public interface IStudentAdmin
    {
        [OperationContract]
        void AddStudent(string studentName, DateTime dateEnrolled);
        List<Student> GetAllStudents();
    }
}
