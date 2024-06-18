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
using TafesaClient.StudentServiceReference;

namespace TafesaClient
{
    public partial class course1 : Form
    { 
        private CourseAdminClient client2 = new CourseAdminClient();
        public course1()
        {
            InitializeComponent();
        }

        private void displayCourse_click(object sender, EventArgs e)
        {
            foreach (Course course in client2.GetAllCourses())
            {
                courseListBox.Items.Add(course.CourseID + " " + course.CourseName + " " + course.Cost);
            }


        }

        private void addCourse_click(object sender, EventArgs e)
        {
            string courseName = courseNameTextBox.Text;
            decimal cost = decimal.Parse(costTextBox.Text);

            client2.AddCourse(courseName, cost);
            messageLabel2.Text = courseName + " " + cost+ "  " + " Course Added !";

        }
    }
}
