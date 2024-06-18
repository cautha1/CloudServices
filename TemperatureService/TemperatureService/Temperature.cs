﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace TemperatureService
{
    [DataContract]
    public class Temperature
    {
        [DataMember]
        public double Fahrenheit;
        [DataMember]
        public double Celsius;
    }
}
