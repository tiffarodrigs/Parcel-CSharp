using Microsoft.AspNetCore.Mvc;

namespace Parcel.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}