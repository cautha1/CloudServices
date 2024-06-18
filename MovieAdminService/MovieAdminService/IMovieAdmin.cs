using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MovieAdminService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMovieAdmin" in both code and config file together.
    [ServiceContract]
    public interface IMovieAdmin
    {
        [OperationContract]
        List<Movies> GetMovies();

        [OperationContract]
        Movies GetAMovie(string title);

        [OperationContract]
        void addMovie(string title, string Director, DateTime date);

    }
}
