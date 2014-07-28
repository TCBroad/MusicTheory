namespace TheoryWeb.Controllers
{
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Chord Identification";
            return this.View();
        }
    }
}