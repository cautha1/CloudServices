using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string nameString = "";
            string emailString = "";
            string messageString = "";

            nameString = nameTextBox.Text;
            emailString = emailTextBox.Text;

            messageString = "Message: " + nameString +" "+ emailString;

            MessageBox.Show(messageString);
        }
    }
}
