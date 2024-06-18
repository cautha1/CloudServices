using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Assignment614.Classes
{
    [DataContract]
    public class Enrolment
    {
        [DataMember]
        public int StudentID { get; set; }

        [DataMember]
        public int CourseID { get; set; }

        [DataMember]
        public DateTime DateEnrolled { get; set; }

        
    }
}