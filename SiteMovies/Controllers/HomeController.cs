using Microsoft.AspNetCore.Mvc;
using SiteMovies.Models;
using SiteMovies.ViewModels;

namespace SiteMovies.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Movie movie = new Movie()
            {
                Title = "Теория большого взрыва",
                Genre = "Ситком",
                Duration = 20
            };
            return View(movie);
        }
        public IActionResult Movies()
        {
            Movie movie1 = new Movie()
            {
                Title = "Теория большого взрыва",
                Genre = "Ситком",
                Duration = 20
            };
            Movie movie2 = new Movie()
            {
                Title = "Доктор кто",
                Genre = "Фантастика",
                Duration = 25
            };
            Movie movie3 = new Movie()
            {
                Title = "Игра престолов",
                Genre = "Фэнтези",
                Duration = 63
            };
            List<Movie> list = new List<Movie>()
            { movie1, movie2, movie3 };
            return View(list);
        }
        public IActionResult GroupMovies()
        {
            Comedy comedy1 = new Comedy()
            {
                Title = "Теория большого взрыва",
                VideoFormat = "1080i (HDTV)",
                AudioFormat = "Dolby Digital",
                Duration = 40
            };
            Comedy comedy2 = new Comedy()
            {
                Title = "Один дома",
                VideoFormat = "1080i (HDTV)",
                AudioFormat = "Dolby Digital",
                Duration = 50
            };
            List<Comedy> comedies = new List<Comedy>
            { comedy1, comedy2 };

            Drama drama1 = new Drama()
            {
                Title = "Зеленая миля",
                VideoFormat = "1080i (HDTV)",
                AudioFormat = "Dolby Digital",
                Duration = 72
            };
            Drama drama2 = new Drama()
            {
                Title = "Джокер",
                VideoFormat = "1080i (HDTV)",
                AudioFormat = "Dolby Digital",
                Duration = 67
            };
            List<Drama> dramas = new List<Drama>()
            { drama1, drama2 };
            MoviesViewModel viewModel = new MoviesViewModel()
            {
                ListComedy = comedies,
                ListDrama = dramas
            };
            return View(viewModel);
        }
    }
}
