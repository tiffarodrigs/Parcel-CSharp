using Microsoft.AspNetCore.Mvc;
using Parcel.Models;
using System.Collections.Generic;

namespace Parcel.Controllers
{
  public class ParcelsController : Controller
  {

    [HttpGet("/parcel")]
    public ActionResult Index()
    {
      
     // int Vol= Parcel.Volume();
      return View();
    }
    [HttpGet("/parcels/new")]
    public ActionResult Parcel()
    {

      return View();
    }
    [HttpPost("/parcel")]
    public ActionResult ParcelCreate(int length, int height, int depth, int weight)
    {
      Dimension parcelObj = new Dimension(length,height,depth,weight);
      int vol= parcelObj.Volume();
      return RedirectToAction("Index");
    }
  }
}