using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleClient.ServiceReference1;
namespace ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MortgageCalcClient client = new MortgageCalcClient();
            Console.WriteLine("Enter amount :");
            double loanAmt = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter rate:");
            double intRate = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter years:");
            int term = int.Parse(Console.ReadLine());
            double monthPayment = 0;
            Loan loan = new Loan();
            loan.InterestRate = intRate;
            loan.LoanAmount = loanAmt;
            loan.Term = term;
            

            monthPayment= client.getMonthyPayment(loan);
            Console.WriteLine("Monthly payment is {0:F2}", monthPayment);
            Console.ReadLine();
               
        }
    }
}
