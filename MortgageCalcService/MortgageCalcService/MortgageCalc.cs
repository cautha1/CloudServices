using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Microsoft.VisualBasic;

namespace MortgageCalcService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MortgageCalc" in both code and config file together.
    public class MortgageCalc : IMortgageCalc
    {
        public double getMonthyPayment(Loan loan)
        {
            return Math.Abs(Financial.Pmt(loan.InterestRate / 1200, loan.Term * 12, loan.LoanAmount, 0, 0));

        }
    }
}
