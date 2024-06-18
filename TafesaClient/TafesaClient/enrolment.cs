using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TafesaClient.CourseServiceReference;
using TafesaClient.EnrolmentServiceReference;

namespace TafesaClient
{
    
    public partial class enrolment : Form
    {
        private StudentEnrolmentClient client1 = new StudentEnrolmentClient();
        public enrolment()
        {
            InitializeComponent();
        }

        private void getEnrol_click(object sender, EventArgs e)
        {
            foreach (Enrolment enrolment in client1.GetAllEnrollments())
            {
                enrolListBox.Items.Add(enrolment.CourseID + " " + enrolment.StudentID + " " + enrolment.DateEnrolled);
            }
        }

        private void enrol_click(object sender, EventArgs e)
        {
            int studentId = 0;

            int courseId = 0;
            client1.GetAllEnrollments();
            messageLabel3.Text = "Student Enrolled";

            
        }
    }
}
