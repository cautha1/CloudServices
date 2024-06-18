using Assignment614.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Assignment614.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICourseAdmin" in both code and config file together.
    [ServiceContract]
    public interface ICourseAdmin
    {
        [OperationContract]
        void AddCourse(int CourseID, string courseName, decimal cost);
        List<Course> GetAllCourses();
    }
}
