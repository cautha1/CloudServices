﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TemperatureService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITemperatureCalc" in both code and config file together.
    [ServiceContract]
    public interface ITemperatureCalc
    {
        [OperationContract]
      
        double GetCelsius(Temperature temp);
        [OperationContract]
        double GetFahrenheit(Temperature temp);

    }
}
