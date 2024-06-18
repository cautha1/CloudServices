using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MortgageCalculatorWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMortgageCalculator" in both code and config file together.
    [ServiceContract]
    public interface IMortgageCalculator
    {
        [OperationContract]
        double getMonthlyPayment(Loan loan);
    }
}
