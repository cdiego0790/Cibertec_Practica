using System.Web.Mvc;
using WebDeveloper.Model;
using WebDeveloper.DataAccess;


namespace WebDeveloper.Controllers
{
    public class CategoriesController : Controller
    {
 
        // GET: Categories
        public ActionResult Index()
        {
            return View();
        }
    }
}