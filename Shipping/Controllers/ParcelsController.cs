using Microsoft.AspNetCore.Mvc;
using Shipping.Models;
using System.Collections.Generic;

namespace Shipping.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/parcel")]
    public ActionResult Index()
    {
      List<Parcel> allParcels = Parcel.GetAll();
      return View(allParcels);
    }

    [HttpPost("/parcel")]
    public ActionResult ParcelCreate(int length, int height, int depth, int weight)
    {
      Parcel parcelObj = new Parcel(length,height,depth,weight);
      return RedirectToAction("Index");
    }

    [HttpGet("/parcels/new")]
    public ActionResult ParcelReturn()
    {
      return View();
    }


  }
}