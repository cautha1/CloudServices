using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace MortgageCalculatorWCFService
{
    [DataContract]
    public class Loan
    {
        [DataMember]
        public double LoanAmount;
        [DataMember]
        public double InterestRate;
        [DataMember]
        public double Term;
    }
}