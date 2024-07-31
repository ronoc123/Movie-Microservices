namespace Inventory_Management.Services.MovieService
{
    public interface IMovieService
    {
        public List<Movie> GetMovies();

        public Movie GetMovieById(int id);
    }
}
