using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TafesaClient.StudentServiceReference;
namespace TafesaClient
{
    public partial class Form1 : Form
    {
       // private TafesaAdminClient client = new TafesaClient();
       private StudentAdminClient client = new StudentAdminClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void addStudent_clicked(object sender, EventArgs e)
        {
            string studentName = studentNameTextBox.Text;
            DateTime date = dateTimePicker.Value;
            client.AddStudent(studentName, dateTimePicker.Value);
            messageLabel.Text = "Student Added!";

        }


        


    private void displayStudent_clicked(object sender, EventArgs e)
        {
            foreach (Student student in client.GetAllStudents())
            {
                studentListBox.Items.Add(student.StudentID + " " + student.StudentName + " "+ student.DateEnrolled);
            }

        }
    }
}
