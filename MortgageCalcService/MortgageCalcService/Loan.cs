using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace MortgageCalcService
{
    [DataContract]
    public class Loan
    {
        private double loanAmount;
        private double interestRate;
        private double term;

        [DataMember]
        public double LoanAmount
        {
            get { return loanAmount; }
            set { loanAmount = value; }
        }

        [DataMember]
        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }
        [DataMember]
        public double Term
        {
            get { return term; }
            set { term = value; }
        }


    }
}
