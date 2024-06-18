using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Microsoft.VisualBasic;
namespace MortgageCalculatorWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MortgageCalculator" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MortgageCalculator.svc or MortgageCalculator.svc.cs at the Solution Explorer and start debugging.
    public class MortgageCalculator : IMortgageCalculator
    {
        public double getMonthlyPayment(Loan loan)
        {
            return Math.Abs(Financial.Pmt(loan.InterestRate / 1200, loan.Term * 12, loan.LoanAmount, 0, 0));
        }
        
      
    }
}
