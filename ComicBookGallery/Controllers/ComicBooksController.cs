using System;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {

            if (DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
            {
                return new RedirectResult("/");
            }

            return new ContentResult()
            {

                Content = "Hello from the ComicBooksController"
            };

        }

    }
}