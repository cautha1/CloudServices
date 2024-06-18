using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TafesaClient
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           // add student form
           new Form1().Show();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new course1().Show();
        }

        private void addEnrolmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new enrolment().Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
