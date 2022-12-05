using Lab2ViewcomponentPartialView.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab2ViewcomponentPartialView.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            PostViewModel model = new PostViewModel()
            {
                Id = 1,
                Title = "What is Asp.Net Core",
                Author = "JD",
                Body = "Asp.net openc source framework"
            };

            return View(model);
        }
    }
}
