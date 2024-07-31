namespace Inventory_Management.Model
{
    public class Movie
    {
        public string Poster { get; set; }

        public string MediaType { get; set; }

        public string ReleaseDate { get; set; }

        public string PersonalRating { get; set; }

        public bool IsWatched { get; set; } = false;

        public bool IsFavorited { get; set; } = false;

        public int DbId { get; set; }

        public int Rating { get; set; }

        public string Description { get; set; }

        public User user { get; set; }

    }
}
