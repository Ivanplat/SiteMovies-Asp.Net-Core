namespace SiteMovies.Models
{
    public class Movie
    {
        public string Title { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public string VideoFormat { get; set; } = string.Empty;  
        public string AudioFormat { get; set; } = string.Empty;
        public int Duration { get; set; }
    }
}
