using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Assignment614.Classes
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public int StudentID { get; set; }
        [DataMember]
        public string StudentName { get; set; }
        [DataMember]
        public DateTime DateEnrolled { get; set; }


    }
}