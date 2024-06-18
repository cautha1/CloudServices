using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace MovieAdminService
{
    [DataContract]
    public class Movies
    {
        [DataMember]
        public string Title;
        [DataMember]
        public string Director;
        [DataMember]
        public DateTime Date;

    }
}