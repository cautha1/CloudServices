using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Web.UI.WebControls;

namespace MovieAdminService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MovieAdmin" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MovieAdmin.svc or MovieAdmin.svc.cs at the Solution Explorer and start debugging.
    public class MovieAdmin : IMovieAdmin
    {
        private MovieDataSetTableAdapters.MoviesTableAdapter movieTA;

        public List<Movies> GetMovies()
        {
            movieTA = new MovieDataSetTableAdapters.MoviesTableAdapter();
            MovieDataSet.MoviesDataTable movieTable = movieTA.GetData();
            List<Movies> movieList = new List<Movies>();

            foreach (DataRow row in movieTable)
            {
                Movies movie = new Movies();
                movie.Title = row["Title"].ToString();
                movie.Director = row["Director"].ToString();
                movie.Date = (DateTime)row["Date Released"];

                movieList.Add(movie); 

            }
            return movieList;
            
        }
        public Movies GetAMovie(string title)
        {
            MovieDataSet.MoviesDataTable movieTable = movieTA.GetDataByTitle();
            Movies movie = new Movies();
            movie.Title = movieTable.Rows[0]["Title"].ToString();
            movie.Director = movieTable.Rows[0]["Director"].ToString();
            movie.Date = (DateTime)movieTable.Rows[0]["Date released"];
            return movie;

        }

        public void addMovie(string title, string Director, DateTime date)
        {
            movieTA.Insert(title, Director, date);
            return;
        }
    }
}
