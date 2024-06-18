using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Assignment614.Classes
{
    [DataContract]
    public class Course
    {
        [DataMember]
        public int CourseID { get; set; }
        [DataMember]
        public string CourseName { get; set; }
        [DataMember]
        public decimal Cost { get; set; }

    }
}