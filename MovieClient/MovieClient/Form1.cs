using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieClient.MovieServiceReference;
namespace MovieClient
{
    public partial class Form1 : Form
    {
        private MovieAdminClient client = new MovieAdminClient();
        private void displayButton_Click(object sender, EventArgs e)
        {
            foreach (Movies movie in client.GetMovies())
            {
                    movieListBox.Items.Add(movie.Title + " " + movie.Director + " " + movie.Date);
            }

            
            
           


    }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_click(object sender, EventArgs e)
        {
            string title = titleTextBox.Text;
            Movies movie = client.GetAMovie(title);
            //movieListBox.Items.Add(movie.Title + " " + movie.Director + " " + movie.Date);
            movieLabel.Text = movie.Title + " " + movie.Director + " " + movie.Date.ToString();

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string title = movieTitletextBox.Text;
            string director = directorTextBox.Text;
            DateTime date = DateTime.Parse(dateTextBox.Text);
            client.addMovie(title, director, date);
            messageLabel.Text = "Record Added";
        }
    }
}
