using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinClient.ServiceReference1;
namespace WinClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void calculate_Click(object sender, EventArgs e)
        {
            MortgageCalcClient client = new MortgageCalcClient();
            
            double loanAmt = double.Parse(amtTextBox.Text);
            
            double intRate = double.Parse(rateTextBox.Text);
            
            int term = int.Parse(termTextBox.Text);
            double monthPayment = 0;
            Loan loan = new Loan();
            loan.InterestRate = intRate;
            loan.LoanAmount = loanAmt;
            loan.Term = term;


            monthPayment = client.getMonthyPayment(loan);
           monthPaymentTextBox.Text = monthPayment.ToString("c");
        }
    }
}
